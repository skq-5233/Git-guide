#!usr/bin/env python
# -*- coding:utf-8 _*-
"""
@author:eivision
@file: Kera5fitting.py
@time: 2022/09/19
"""
# 降低过拟合的方法叫作正则化（regularization）。我们先介绍几种最常见的正则化方法， 然后将其应用于实践中，以改进上一节的电影分类模型。

from tensorflow.keras.datasets import imdb
import numpy as np

(train_data, train_labels), (test_data, test_labels) = imdb.load_data(num_words=10000)


def vectorize_sequences(sequences, dimension=10000):
    # Create an all-zero matrix of shape (len(sequences), dimension)（创建一个形状为 (len(sequences), dimension) 的零矩阵）
    results = np.zeros((len(sequences), dimension))
    for i, sequence in enumerate(sequences):
        results[i, sequence] = 1.  # set specific indices of results[i] to 1.（将 results[i] 的指定索引设为 1）
    return results


# Our vectorized training data（将训练数据向量化）
x_train = vectorize_sequences(train_data)
# Our vectorized test data（将测试数据向量化）
x_test = vectorize_sequences(test_data)
# Our vectorized labels（将标签向量化）
y_train = np.asarray(train_labels).astype('float32')
y_test = np.asarray(test_labels).astype('float32')

# 我们在电影评论分类的网络上试一下。原始网络如下所示。
from tensorflow.keras import models
from tensorflow.keras import layers

original_model = models.Sequential()
original_model.add(layers.Dense(16, activation='relu', input_shape=(10000,)))
original_model.add(layers.Dense(16, activation='relu'))
original_model.add(layers.Dense(1, activation='sigmoid'))

original_model.compile(optimizer='rmsprop',
                       loss='binary_crossentropy',
                       metrics=['acc'])

# 比较了原始网络与更小网络的验证损失。圆点是更小网络的验证损失值，十字是原 始网络的验证损失值（请记住，更小的验证损失对应更好的模型）。
original_hist = original_model.fit(x_train, y_train,
                                   epochs=20,
                                   batch_size=512,
                                   validation_data=(x_test, y_test))

# 现在我们尝试用下面这个更小的网络来替换它。
# from tensorflow.keras import models
# from tensorflow.keras import layers
#
# smaller_model = models.Sequential()
# smaller_model.add(layers.Dense(4, activation='relu', input_shape=(10000,)))
# smaller_model.add(layers.Dense(4, activation='relu'))
# smaller_model.add(layers.Dense(1, activation='sigmoid'))
#
# smaller_model.compile(optimizer='rmsprop',
#                       loss='binary_crossentropy',
#                       metrics=['acc'])
# #
# # # 比较了原始网络与更小网络的验证损失。圆点是更小网络的验证损失值，十字是原 始网络的验证损失值（请记住，更小的验证损失对应更好的模型）。
# smaller_model_hist = smaller_model.fit(x_train, y_train,
#                                        epochs=20,
#                                        batch_size=512,
#                                        validation_data=(x_test, y_test))
#
#
# # 绘制Epoch-Loss曲线；
# epochs = range(1, 21)
# original_val_loss = original_hist.history['val_loss']
# smaller_model_val_loss = smaller_model_hist.history['val_loss']
#
# import matplotlib.pyplot as plt
# # % matplotlib inline
# # b+ is for "blue cross"
# plt.plot(epochs, original_val_loss, 'b+', label='Original model')
# # "bo" is for "blue dot"
# plt.plot(epochs, smaller_model_val_loss, 'bo', label='Smaller model')
# plt.xlabel('Epochs')
# plt.ylabel('Validation loss')
# plt.legend(loc="best")
#
# plt.savefig("./TrainCurve/loss.png")
# plt.show()

# 现在，为了好玩，我们再向这个基准中添加一个容量更大的网络（容量远大于问题所需）。
# bigger_model = models.Sequential()
# bigger_model.add(layers.Dense(512, activation='relu', input_shape=(10000,)))
# bigger_model.add(layers.Dense(512, activation='relu'))
# bigger_model.add(layers.Dense(1, activation='sigmoid'))
#
# bigger_model.compile(optimizer='rmsprop',
#                      loss='binary_crossentropy',
#                      metrics=['acc'])
# bigger_model_hist = bigger_model.fit(x_train, y_train,
#                                      epochs=20,
#                                      batch_size=512,
#                                      validation_data=(x_test, y_test))

# import matplotlib.pyplot as plt
# # 绘制Epoch-Loss曲线；
# epochs = range(1, 21)
# original_val_loss = original_hist.history['val_loss']
# bigger_model_val_loss = bigger_model_hist.history['val_loss']
#
# plt.plot(epochs, original_val_loss, 'b+', label='Original model')
# plt.plot(epochs, bigger_model_val_loss, 'bo', label='Bigger model')
# plt.xlabel('Epochs')
# plt.ylabel('Validation loss')
# plt.legend(loc="best")
#
# plt.savefig("./TrainCurve/loss-512.png")
#
# plt.show()

# # 下图同时给出了这两个网络的训练损失。
# import matplotlib.pyplot as plt
# # 绘制Epoch-Loss曲线；
# epochs = range(1, 21)
#
# original_train_loss = original_hist.history['loss']
# bigger_model_train_loss = bigger_model_hist.history['loss']
#
# plt.plot(epochs, original_train_loss, 'b+', label='Original model')
# plt.plot(epochs, bigger_model_train_loss, 'bo', label='Bigger model')
# plt.xlabel('Epochs')
# plt.ylabel('Training loss')
# plt.legend()
# plt.savefig("./TrainCurve/train-loss.png")
# plt.show()

# 在 Keras 中，添加权重正则化的方法是向层传递 权重正则化项实例（weight regularizer instance）作为关键字参数。下列代码将向电影评论分类网络中添加 L2 权重正则化。
# from tensorflow.keras import regularizers
#
# l2_model = models.Sequential()
# l2_model.add(layers.Dense(16, kernel_regularizer=regularizers.l2(0.001),
#                           activation='relu', input_shape=(10000,)))
# l2_model.add(layers.Dense(16, kernel_regularizer=regularizers.l2(0.001),
#                           activation='relu'))
# l2_model.add(layers.Dense(1, activation='sigmoid'))
# l2_model.compile(optimizer='rmsprop',
#                  loss='binary_crossentropy',
#                  metrics=['acc'])
# # L2 正则化惩罚。
# l2_model_hist = l2_model.fit(x_train, y_train,
#                              epochs=20,
#                              batch_size=512,
#                              validation_data=(x_test, y_test))
# # 绘制Epoch-Loss曲线；
# import matplotlib.pyplot as plt
# epochs = range(1, 21)
#
# original_val_loss = original_hist.history['val_loss']
# l2_model_val_loss = l2_model_hist.history['val_loss']
#
# plt.plot(epochs, original_val_loss, 'b+', label='Original model')
# plt.plot(epochs, l2_model_val_loss, 'bo', label='L2-regularized model')
# plt.xlabel('Epochs')
# plt.ylabel('Validation loss')
# plt.legend()
# plt.savefig("./TrainCurve/L2-loss.png")
#
# plt.show()

# # 添加 dropout 正则化
# # 假设有一个包含某层输出的 Numpy 矩阵 layer_output，其形状为 (batch_size, features)。训练时，我们随机将矩阵中一部分值设为 0。
# # At training time: we drop out 50% of the units in the output(训练时候我们舍弃50%的输出单元)
# layer_output *= np.randint(0, high=2, size=layer_output.shape)
#
# # 测试时，我们将输出按 dropout 比率缩小。这里我们乘以 0.5（因为前面舍弃了一半的单元）。
# #At test time:（测试时）
# layer_output *= 0.5
#
# # 注意，为了实现这一过程，还可以让两个运算都在训练时进行，而测试时输出保持不变。这通常也是实践中的实现方式：
# # At training time:
# layer_output *= np.randint(0, high=2, size=layer_output.shape)
# # Note that we are scaling *up* rather scaling *down* in this case
# layer_output /= 0.5

# 在 Keras 中，你可以通过 Dropout 层向网络中引入 dropout，dropout 将被应用于前面一层的输出。
# model.add(layers.Dropout(0.5))

# 我们向 IMDB 网络中添加两个 Dropout 层，来看一下它们降低过拟合的效果。
dpt_model = models.Sequential()
dpt_model.add(layers.Dense(16, activation='relu', input_shape=(10000,)))
dpt_model.add(layers.Dropout(0.5))
dpt_model.add(layers.Dense(16, activation='relu'))
dpt_model.add(layers.Dropout(0.5))
dpt_model.add(layers.Dense(1, activation='sigmoid'))

dpt_model.compile(optimizer='rmsprop',
                  loss='binary_crossentropy',
                  metrics=['acc'])

dpt_model_hist = dpt_model.fit(x_train, y_train,
                               epochs=20,
                               batch_size=512,
                               validation_data=(x_test, y_test))

# 绘制损失曲线;
import matplotlib.pyplot as plt
epochs = range(1, 21)

original_val_loss = original_hist.history['val_loss']
dpt_model_val_loss = dpt_model_hist.history['val_loss']

plt.plot(epochs, original_val_loss, 'b+', label='Original model')
plt.plot(epochs, dpt_model_val_loss, 'bo', label='Dropout-regularized model')
plt.xlabel('Epochs')
plt.ylabel('Validation loss')
plt.legend()
plt.savefig("./TrainCurve/Dropout-loss.png")
plt.show()
