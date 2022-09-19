#!usr/bin/env python
# -*- coding:utf-8 _*-
"""
@author:eivision
@file: Imdbbinaryclassficy.py
@time: 2022/09/19
"""

# https://ai.stanford.edu/~amaas/data/sentiment/
# import keras
# from tensorflow.compat.v1 import keras
from tensorflow.keras.datasets import imdb
# 参数 num_words=10000 的意思是仅保留训练数据中前 10 000 个最常出现的单词。低频单词将被舍弃。这样得到的向量数据不会太大，便于处理。
(train_data, train_labels), (test_data, test_labels) = imdb.load_data(num_words=10000)

import numpy as np
def vectorize_sequences(sequences, dimension=10000):

    # （创建一个形状为 (len(sequences), dimension) 的零矩阵）
    results = np.zeros((len(sequences), dimension))
    for i, sequence in enumerate(sequences):
        results[i, sequence] = 1.  # （将 results[i] 的指定索引设为 1）

    return results

# Our vectorized training data（将训练数据向量化）
x_train = vectorize_sequences(train_data)

# Our vectorized test data（将测试数据向量化）
x_test = vectorize_sequences(test_data)

# 标签向量化;
y_train = np.asarray(train_labels).astype('float32')
y_test = np.asarray(test_labels).astype('float32')

# 构造激活函数及网络密集层数;
from tensorflow.keras import models

from tensorflow.keras import layers

model = models.Sequential()

# 中间层使用 relu 作为激活函数，最后一层使用 sigmoid 激活以输出一个 0~1 范围内的概率值（表示样本的目标值等于 1 的可能性，即评论为正面的可能性）。
# relu（rectified linear unit，整流线性单元）函数将所有负值归零，而 sigmoid 函数则将任意值“压缩”到 [0,1] 区间内，其输出值可以看作概率值。
model.add(layers.Dense(16, activation='relu', input_shape=(20,10000)))

model.add(layers.Dense(16, activation='relu'))

model.add(layers.Dense(1, activation='sigmoid'))    # 最后一层使用 sigmoid 激活以输出一个 0~1 范围内的概率值

# 下面的步骤是用 rmsprop 优化器和 binary_crossentropy 二分类损失函数来配置模型。注意，我们还在训练过程中监控精度。
# model.compile(optimizer='rmsprop',
#
#               loss='binary_crossentropy',
#
#               metrics=['accuracy'])

# 上述代码将优化器、损失函数和指标作为字符串传入，这是因为 rmsprop、binary_ crossentropy 和 accuracy 都是 Keras 内置的一部分。
# 有时你可能希望配置自定义优化器的 参数，或者传入自定义的损失函数或指标函数。前者可通过向 optimizer 参数传入一个优化器类实例来实现，如代码所示：
from tensorflow.keras import optimizers

model.compile(optimizer=optimizers.RMSprop(lr=0.001),

              loss='binary_crossentropy',

              metrics=['accuracy'])
# 为了在训练过程中监控模型在前所未见的数据上的精度，你需要将原始训练数据留出 10 000个样本作为验证集
x_val = x_train[:]

partial_x_train = x_train[:]

y_val = y_train[:]

partial_y_train = y_train[:]

# 现在使用 512 个样本组成的小批量，将模型训练 20 个轮次（即对 x_train 和 y_train 两 个张量中的所有样本进行 20 次迭代）。
# 与此同时，你还要监控在留出的 10 000 个样本上的损失和精度。你可以通过将验证数据传入 validation_data 参数来完成。
history = model.fit(partial_x_train,
                    partial_y_train,
                    epochs=20,
                    batch_size=512,
                    validation_data=(x_val, y_val))


# 使用 Matplotlib 在同一张图上绘制训练损失和验证损失，以及训练精度和验证精度）。
import matplotlib.pyplot as plt
#
# # plot loss-curve
# # %matplotlib inline  # 使显示的图像在notebook可见
#
# # acc = history.history['binary_accuracy']
# # 需要使用accuracy，否则报错；
# # acc = history.history['accuracy']
# #
# # # val_acc = history.history['val_binary_acc']
# # 需要使用accuracy，否则报错；
# # val_acc = history.history['val_accuracy']
# #
# # loss = history.history['loss']
# #
# # val_loss = history.history['val_loss']
# #
# # epochs = range(1, len(acc) + 1)
# #
# # # "bo" is for "blue dot"（'bo' 表示蓝色圆点）
# #
# # plt.plot(epochs, loss, 'bo', label='Training loss')
# #
# # # b is for "solid blue line"（'b' 表示蓝色实线）
# #
# # plt.plot(epochs, val_loss, 'b', label='Validation loss')
# #
# # plt.title('Training and validation loss')
# #
# # plt.xlabel('Epochs')
# #
# # plt.ylabel('Loss')
# #
# # plt.legend(["train-loss","validation-loss"],loc="best")
# #
# # plt.savefig("./IMDB_BinaryClassficay/TrainCurve/loss.png")
# # plt.show()
#
#
# # plot accuracy curve
history_dict = history.history

history_dict.keys()

plt.clf()  # clear figure（清空图像）

acc = history.history['accuracy']

val_acc = history.history['val_accuracy']

epochs = range(1, len(acc) + 1)

# acc_values = history_dict['binary_accuracy']
acc_values = history_dict['accuracy']

# val_acc_values = history_dict['val_binary_accuracy']
val_acc_values = history_dict['val_accuracy']

plt.plot(epochs, acc, 'bo', label='Training acc')

plt.plot(epochs, val_acc, 'b', label='Validation acc')

plt.title('Training and validation accuracy')

plt.xlabel('Epochs')

plt.ylabel('Loss')

plt.legend(["train-accuracy","validation-accuracy"],loc="best")

plt.savefig("./IMDB_BinaryClassficay/TrainCurve/accuracy.png")
plt.show()


# 我们从头开始训练一个新的网络，训练10轮，然后在测试数据上评估模型。;
# from tensorflow.keras import models
#
# from tensorflow.keras import layers
#
# model = models.Sequential()
#
# from tensorflow.keras.datasets import imdb
# # 参数 num_words=10000 的意思是仅保留训练数据中前 10 000 个最常出现的单词。低频单词将被舍弃。这样得到的向量数据不会太大，便于处理。
# (train_data, train_labels), (test_data, test_labels) = imdb.load_data(num_words=10000)
#
# import numpy as np
# def vectorize_sequences(sequences, dimension=10000):
#
#     # （创建一个形状为 (len(sequences), dimension) 的零矩阵）
#     results = np.zeros((len(sequences), dimension))
#     for i, sequence in enumerate(sequences):
#         results[i, sequence] = 1.  # （将 results[i] 的指定索引设为 1）
#
#     return results
#
# # Our vectorized training data（将训练数据向量化）
# x_train = vectorize_sequences(train_data)
#
# # Our vectorized test data（将测试数据向量化）
# x_test = vectorize_sequences(test_data)
#
# # 标签向量化;
# y_train = np.asarray(train_labels).astype('float32')
# y_test = np.asarray(test_labels).astype('float32')
#
#
# model.add(layers.Dense(16, activation='relu', input_shape=(20,10000)))
#
# model.add(layers.Dense(16, activation='relu'))
#
# model.add(layers.Dense(1, activation='sigmoid'))
#
# model.compile(optimizer='rmsprop',
#
#               loss='binary_crossentropy',
#
#               metrics=['accuracy'])
#
# model.fit(x_train, y_train, epochs=10, batch_size=20)
#
# results = model.evaluate(x_test, y_test)
# # 打印验证结果；
# print("模型精度为：")
# print(results)
# # 打印预测结果
# print("预测评论为正面的可能性")
# print(model.predict(x_test))

