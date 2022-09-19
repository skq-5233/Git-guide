# #!usr/bin/env python
# # -*- coding:utf-8 _*-
# """
# @author:eivision
# @file: MultiClassification.py
# @time: 2022/09/19
# """
# # 多分类问题
# # 本节你会构建一个网络，将路透社新闻划分为 46 个互斥的主题。因为有多个类别，所以这是多分类（multiclass classification）问题的一个例子。
# # 因为每个数据点只能划分到一个类别，所以更具体地说，这是单标签、多分类（single-label, multiclass classification）问题的一个例子。
# # 如果每个数据点可以划分到多个类别（主题），那它就是一个多标签、多分类（multilabel, multiclass classification）问题。
#
# # 路透社数据集
# # 本节使用路透社数据集，它包含许多短新闻及其对应的主题，由路透社在 1986 年发布。它是一个简单的、广泛使用的文本分类数据集。它包括 46 个不同的主题：某些主题的样本更多，但训练集中每个主题都有至少 10 个样本。
# # 与 IMDB 和 MNIST 类似，路透社数据集也内置为 Keras 的一部分。我们来看一下。
#
# from tensorflow.keras.datasets import reuters
# (train_data, train_labels), (test_data, test_labels) = reuters.load_data(num_words=10000)
#
# # 与 IMDB 数据集一样，参数 num_words=10000 将数据限定为前 10 000 个最常出现的单词。我们有 8982 个训练样本和 2246 个测试样本。（这里下载可能会失败几次，不翻墙可以下的）
# import numpy as np
#
# def vectorize_sequences(sequences, dimension=10000):
#     results = np.zeros((len(sequences), dimension))
#     for i, sequence in enumerate(sequences):
#         results[i, sequence] = 1.
#     return results
#
# # Our vectorized training data（将训练数据向量化）
# x_train = vectorize_sequences(train_data)
# # Our vectorized test data（将测试数据向量化）
# x_test = vectorize_sequences(test_data)
#
# # 将标签向量化有两种方法：你可以将标签列表转换为整数张量，或者使用one - hot编码。one - hot编码是分类数据广泛使用的一种格式，也叫分类编码（categoricalencoding）。
# # 在这个例子中，标签的one - hot编码就是将每个标签表示为全零向量，只有标签索引对应的元素为1。其代码实现如下。
#
# def to_one_hot(labels, dimension=46):
#     results = np.zeros((len(labels), dimension))
#     for i, label in enumerate(labels):
#         results[i, label] = 1.
#     return results
#
#
# # Our vectorized training labels（将训练标签向量化）
# one_hot_train_labels = to_one_hot(train_labels)
# # Our vectorized test labels（将测试标签向量化）
# one_hot_test_labels = to_one_hot(test_labels)
#
# # Keras内置方法可以实现这个操作，你在MNIST例子中已经见过这种方法。
# # from tensorflow.keras.utils.np_utils import to_categorical
# from tensorflow.keras.utils import to_categorical
#
# one_hot_train_labels = to_categorical(train_labels)
# one_hot_test_labels = to_categorical(test_labels)
#
# from tensorflow.keras import models
# from tensorflow.keras import layers
#
# model = models.Sequential()
# model.add(layers.Dense(64, activation='relu', input_shape=(10000,)))
# model.add(layers.Dense(64, activation='relu'))
# model.add(layers.Dense(46, activation='softmax'))
#
# # 网络的最后一层是大小为 46 的 Dense 层。这意味着，对于每个输入样本，网络都会输出一个 46 维向量。这个向量的每个元素（即每个维度）代表不同的输出类别。
# # 最后一层使用了 softmax 激活。你在 MNIST 例子中见过这种用法。网络将输出在 46 个不同输出类别上的概率分布——对于每一个输入样本，
# # 网络都会输出一个 46 维向量，其中 output[i] 是样本属于第 i 个类别的概率。46 个概率的总和为 1。
#
# model.compile(optimizer='rmsprop',
#               loss='categorical_crossentropy',
#               metrics=['accuracy'])
#
# # 在训练数据中留出 1000 个样本作为验证集。
# x_val = x_train[:1000]
# partial_x_train = x_train[1000:]
#
# y_val = one_hot_train_labels[:1000]
# partial_y_train = one_hot_train_labels[1000:]
#
# # 现在开始训练网络，共 20 个轮次。
# history = model.fit(partial_x_train,
#                     partial_y_train,
#                     epochs=20,
#                     batch_size=512,
#                     validation_data=(x_val, y_val))
#
# # 绘制损失曲线：
# # import matplotlib.pyplot as plt
# #
# # loss = history.history['loss']
# # val_loss = history.history['val_loss']
# #
# # epochs = range(1, len(loss) + 1)
# #
# # plt.plot(epochs, loss, 'bo', label='Training loss')
# # plt.plot(epochs, val_loss, 'b', label='Validation loss')
# # plt.title('Training and validation loss')
# # plt.xlabel('Epochs')
# # plt.ylabel('Loss')
# # plt.legend(['train_loss', 'val_loss'],loc="best")
# # plt.savefig("./MultiClassification/TrainCurve/loss.png")
# # plt.show()
#
# # 绘制精度曲线：
# #!usr/bin/env python
# # -*- coding:utf-8 _*-
# """
# @author:eivision
# @file: MultiClassification.py
# @time: 2022/09/19
# """
# # 多分类问题
# # 本节你会构建一个网络，将路透社新闻划分为 46 个互斥的主题。因为有多个类别，所以这是多分类（multiclass classification）问题的一个例子。
# # 因为每个数据点只能划分到一个类别，所以更具体地说，这是单标签、多分类（single-label, multiclass classification）问题的一个例子。
# # 如果每个数据点可以划分到多个类别（主题），那它就是一个多标签、多分类（multilabel, multiclass classification）问题。
#
# # 路透社数据集
# # 本节使用路透社数据集，它包含许多短新闻及其对应的主题，由路透社在 1986 年发布。它是一个简单的、广泛使用的文本分类数据集。它包括 46 个不同的主题：某些主题的样本更多，但训练集中每个主题都有至少 10 个样本。
# # 与 IMDB 和 MNIST 类似，路透社数据集也内置为 Keras 的一部分。我们来看一下。
#
# from tensorflow.keras.datasets import reuters
# (train_data, train_labels), (test_data, test_labels) = reuters.load_data(num_words=10000)
#
# # 与 IMDB 数据集一样，参数 num_words=10000 将数据限定为前 10 000 个最常出现的单词。我们有 8982 个训练样本和 2246 个测试样本。（这里下载可能会失败几次，不翻墙可以下的）
# import numpy as np
#
# def vectorize_sequences(sequences, dimension=10000):
#     results = np.zeros((len(sequences), dimension))
#     for i, sequence in enumerate(sequences):
#         results[i, sequence] = 1.
#     return results
#
# # Our vectorized training data（将训练数据向量化）
# x_train = vectorize_sequences(train_data)
# # Our vectorized test data（将测试数据向量化）
# x_test = vectorize_sequences(test_data)
#
# # 将标签向量化有两种方法：你可以将标签列表转换为整数张量，或者使用one - hot编码。one - hot编码是分类数据广泛使用的一种格式，也叫分类编码（categoricalencoding）。
# # 在这个例子中，标签的one - hot编码就是将每个标签表示为全零向量，只有标签索引对应的元素为1。其代码实现如下。
#
# def to_one_hot(labels, dimension=46):
#     results = np.zeros((len(labels), dimension))
#     for i, label in enumerate(labels):
#         results[i, label] = 1.
#     return results
#
#
# # Our vectorized training labels（将训练标签向量化）
# one_hot_train_labels = to_one_hot(train_labels)
# # Our vectorized test labels（将测试标签向量化）
# one_hot_test_labels = to_one_hot(test_labels)
#
# # Keras内置方法可以实现这个操作，你在MNIST例子中已经见过这种方法。
# # from tensorflow.keras.utils.np_utils import to_categorical
# from tensorflow.keras.utils import to_categorical
#
# one_hot_train_labels = to_categorical(train_labels)
# one_hot_test_labels = to_categorical(test_labels)
#
# from tensorflow.keras import models
# from tensorflow.keras import layers
#
# model = models.Sequential()
# model.add(layers.Dense(64, activation='relu', input_shape=(10000,)))
# model.add(layers.Dense(64, activation='relu'))
# model.add(layers.Dense(46, activation='softmax'))
#
# # 网络的最后一层是大小为 46 的 Dense 层。这意味着，对于每个输入样本，网络都会输出一个 46 维向量。这个向量的每个元素（即每个维度）代表不同的输出类别。
# # 最后一层使用了 softmax 激活。你在 MNIST 例子中见过这种用法。网络将输出在 46 个不同输出类别上的概率分布——对于每一个输入样本，
# # 网络都会输出一个 46 维向量，其中 output[i] 是样本属于第 i 个类别的概率。46 个概率的总和为 1。
#
# model.compile(optimizer='rmsprop',
#               loss='categorical_crossentropy',
#               metrics=['accuracy'])
#
# # 在训练数据中留出 1000 个样本作为验证集。
# x_val = x_train[:1000]
# partial_x_train = x_train[1000:]
#
# y_val = one_hot_train_labels[:1000]
# partial_y_train = one_hot_train_labels[1000:]
#
# # 现在开始训练网络，共 20 个轮次。
# history = model.fit(partial_x_train,
#                     partial_y_train,
#                     epochs=20,
#                     batch_size=512,
#                     validation_data=(x_val, y_val))
#
# # 绘制损失曲线：
# # import matplotlib.pyplot as plt
# #
# # loss = history.history['loss']
# # val_loss = history.history['val_loss']
# #
# # epochs = range(1, len(loss) + 1)
# #
# # plt.plot(epochs, loss, 'bo', label='Training loss')
# # plt.plot(epochs, val_loss, 'b', label='Validation loss')
# # plt.title('Training and validation loss')
# # plt.xlabel('Epochs')
# # plt.ylabel('Loss')
# # plt.legend(['train_loss', 'val_loss'],loc="best")
# # plt.savefig("./MultiClassification/TrainCurve/loss.png")
# # plt.show()
#
# # 绘制精度曲线：
# import matplotlib.pyplot as plt
# loss = history.history['loss']
#
# plt.clf()  # clear figure(清空图像)
#
# acc = history.history['accuracy']
# val_acc = history.history['val_accuracy']
#
# epochs = range(1, len(loss) + 1)
#
# plt.plot(epochs, acc, 'bo', label='Training acc')
# plt.plot(epochs, val_acc, 'b', label='Validation acc')
# plt.title('Training and validation accuracy')
# plt.xlabel('Epochs')
# plt.ylabel('Loss')
#
# plt.legend(['train_accuracy', 'val_accuracy'],loc="best")
# plt.savefig("./MultiClassification/TrainCurve/accuracy.png")
# plt.show()
#

# 网络在训练8 轮后开始过拟合。我们从头开始训练一个新网络，共8个轮次，然后在测试集上评估模型。
from tensorflow.keras import models
from tensorflow.keras import layers
import numpy as np

from tensorflow.keras.datasets import reuters
(train_data, train_labels), (test_data, test_labels) = reuters.load_data(num_words=10000)

model = models.Sequential()
model.add(layers.Dense(64, activation='relu', input_shape=(10000,)))
model.add(layers.Dense(64, activation='relu'))
model.add(layers.Dense(46, activation='softmax'))

model.compile(optimizer='rmsprop',
              loss='categorical_crossentropy',
              metrics=['accuracy'])

def vectorize_sequences(sequences, dimension=10000):
    results = np.zeros((len(sequences), dimension))
    for i, sequence in enumerate(sequences):
        results[i, sequence] = 1.
    return results

# Our vectorized training data（将训练数据向量化）
x_train = vectorize_sequences(train_data)
# Our vectorized test data（将测试数据向量化）
x_test = vectorize_sequences(test_data)

# Keras内置方法可以实现这个操作，你在MNIST例子中已经见过这种方法。
# from tensorflow.keras.utils.np_utils import to_categorical
from tensorflow.keras.utils import to_categorical

one_hot_train_labels = to_categorical(train_labels)
one_hot_test_labels = to_categorical(test_labels)

# 在训练数据中留出 1000 个样本作为验证集。
x_val = x_train[:1000]
partial_x_train = x_train[1000:]

y_val = one_hot_train_labels[:1000]
partial_y_train = one_hot_train_labels[1000:]


model.fit(partial_x_train,
          partial_y_train,
          epochs=8,
          batch_size=512,
          validation_data=(x_val, y_val))
results = model.evaluate(x_test, one_hot_test_labels)
