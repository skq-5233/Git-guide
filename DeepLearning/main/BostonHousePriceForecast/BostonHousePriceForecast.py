#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: BostonHousePriceForecast.py 
@time: 2022/09/19 
"""
# 本节将要预测 20 世纪 70 年代中期波士顿郊区房屋价格的中位数，已知当时郊区的一些数据点，
# 比如犯罪率、当地房产税率等。本节用到的数据集与前面两个例子有一个有趣的区别。
# 它包含的数据点相对较少，只有 506 个，分为 404 个训练样本和 102 个测试样本。输入数据的每个特征（比如犯罪率）都有不同的取值范围。
# 例如，有些特性是比例，取值范围为 0~1；有的取值范围为 1~12；还有的取值范围为 0~100，等等。

# import keras
from tensorflow.keras.datasets import boston_housing

(train_data, train_targets), (test_data, test_targets) = boston_housing.load_data()  # 这里下载有时候会失败，多试几次，不需要访问国外网站

# # 输出(404, 13)
# print(train_data.shape)
#
# # 输出为：(102, 13)
# print(test_data.shape)

# 准备数据
mean = train_data.mean(axis=0)
train_data -= mean
std = train_data.std(axis=0)
train_data /= std

test_data -= mean
test_data /= std

# 构建网络
from tensorflow.keras import models
from tensorflow.keras import layers


def build_model():
    # Because we will need to instantiate the same model multiple times,（因为需要将同一个模型多次实例化，）
    # we use a function to construct it.（所以用一个函数来构建模型）
    model = models.Sequential()
    model.add(layers.Dense(64, activation='relu',
                           input_shape=(train_data.shape[1],)))
    model.add(layers.Dense(64, activation='relu'))
    # 网络的最后一层只有一个单元，没有激活，是一个线性层。这是标量回归（标量回归是预测单一连续值的回归）的典型设置。
    model.add(layers.Dense(1))
    model.compile(optimizer='rmsprop', loss='mse', metrics=['mae'])
    return model

# 利用 K 折验证来验证你的方法
# import numpy as np
#
# k = 4
# num_val_samples = len(train_data) // k
# num_epochs = 100
# all_scores = []
# for i in range(k):
#     print('processing fold #', i)
#     # Prepare the validation data: data from partition # k（准备验证数据：第 k 个分区的数据）
#     val_data = train_data[i * num_val_samples: (i + 1) * num_val_samples]
#     val_targets = train_targets[i * num_val_samples: (i + 1) * num_val_samples]
#
#     # Prepare the training data: data from all other partitions（准备训练数据：其他所有分区的数据）
#     partial_train_data = np.concatenate(
#         [train_data[:i * num_val_samples],
#          train_data[(i + 1) * num_val_samples:]],
#         axis=0)
#     partial_train_targets = np.concatenate(
#         [train_targets[:i * num_val_samples],
#          train_targets[(i + 1) * num_val_samples:]],
#         axis=0)
#
#     # Build the Keras model (already compiled)（构建 Keras 模型（已编译））
#     model = build_model()
#     # Train the model (in silent mode, verbose=0)（训练模型（静默模式，）
#     model.fit(partial_train_data, partial_train_targets,
#               epochs=num_epochs, batch_size=1, verbose=0)
#     # Evaluate the model on the validation data（在验证数据上评估模型）
#     val_mse, val_mae = model.evaluate(val_data, val_targets, verbose=0)
#     all_scores.append(val_mae)



# 我们让训练时间更长一点，达到 500 个轮次。为了记录模型在每轮的表现，我们需要修改训练循环，以保存每轮的验证分数记录。
from tensorflow.keras import backend as K
import numpy as np
k = 4
num_val_samples = len(train_data) // k
# Some memory clean-up
K.clear_session()
num_epochs = 20
all_mae_histories = []
for i in range(k):
    print('processing fold #', i)
    # Prepare the validation data: data from partition # k（准备验证数据：第 k 个分区的数据）
    val_data = train_data[i * num_val_samples: (i + 1) * num_val_samples]
    val_targets = train_targets[i * num_val_samples: (i + 1) * num_val_samples]

    # Prepare the training data: data from all other partitions（准备训练数据：其他所有分区的数据）
    partial_train_data = np.concatenate(
        [train_data[:i * num_val_samples],
         train_data[(i + 1) * num_val_samples:]],
        axis=0)
    partial_train_targets = np.concatenate(
        [train_targets[:i * num_val_samples],
         train_targets[(i + 1) * num_val_samples:]],
        axis=0)

    # Build the Keras model (already compiled)（构建 Keras 模型（已编译））
    model = build_model()
    # Train the model (in silent mode, verbose=0)（训练模型（静默模式，verbose=0））
    history = model.fit(partial_train_data, partial_train_targets,
                        validation_data=(val_data, val_targets),
                        epochs=num_epochs, batch_size=1, verbose=0)
    # mae_history = history.history['val_mean_absolute_error']
    mae_history = history.history['val_mae']
    all_mae_histories.append(mae_history)

average_mae_history = [
    np.mean([x[i] for x in all_mae_histories]) for i in range(num_epochs)]

import matplotlib.pyplot as plt

plt.plot(range(1, len(average_mae_history) + 1), average_mae_history)
plt.xlabel('Epochs')
plt.ylabel('Validation MAE')
plt.savefig("./TrainCurve/AvgMAE.png")
plt.show()

# 因为纵轴的范围较大，且数据方差相对较大，所以难以看清这张图的规律。我们来重新绘制一张图。
# 删除前 10 个数据点，因为它们的取值范围与曲线上的其他点不同。
# 将每个数据点替换为前面数据点的指数移动平均值，以得到光滑的曲线。

def smooth_curve(points, factor=0.9):
    smoothed_points = []
    for point in points:
        if smoothed_points:
            previous = smoothed_points[-1]
            smoothed_points.append(previous * factor + point * (1 - factor))
        else:
            smoothed_points.append(point)
    return smoothed_points


smooth_mae_history = smooth_curve(average_mae_history[10:])

plt.plot(range(1, len(smooth_mae_history) + 1), smooth_mae_history)
plt.xlabel('Epochs')
plt.ylabel('Validation MAE')
plt.savefig("./TrainCurve/SmoothAvgMAE.png")
plt.show()