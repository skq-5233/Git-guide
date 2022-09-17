#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: MnistTrain.py
@time: 2022/09/17 
"""
# Mnist手写数字体识别完整Code;
import matplotlib.pyplot as plt
from tensorflow.keras.datasets import mnist
#这里下载要多试几次，不访问国外网站能下。train_images 和 train_labels 组成了训练集（training set），模型将从这些数据中进行学习。
#然后在测试集（test set，即 test_images 和 test_labels）上对模型进行测试。
(train_images, train_labels), (test_images, test_labels) = mnist.load_data()

from tensorflow.keras import models
from tensorflow.keras import layers
network = models.Sequential()
network.add(layers.Dense(512, activation='relu', input_shape=(28 * 28,)))   # 512层FeatureMap;
network.add(layers.Dense(10, activation='softmax')) # 将512层FeatureMap打平，10:对应10个类别（0-9）；

network.compile(optimizer='rmsprop',loss='categorical_crossentropy',metrics=['accuracy'])

train_images = train_images.reshape((60000, 28 * 28))
train_images = train_images.astype('float32') / 255
test_images = test_images.reshape((10000, 28 * 28))
test_images = test_images.astype('float32') / 255

from tensorflow.keras.utils import to_categorical
train_labels = to_categorical(train_labels)
test_labels = to_categorical(test_labels)

network.fit(train_images, train_labels, epochs=20, batch_size=16)

# test
test_loss, test_acc = network.evaluate(test_images, test_labels)
print('test_acc:', test_acc)
print("Mnist process finished!")

# def plot_training(history):
#     acc = history.history['accuracy']
#     val_acc = history.history['val_accuracy']
#     loss = history.history['loss']
#     val_loss = history.history['val_loss']
#     epochs = range(len(acc))
#     plt.style.use("ggplot")
#     plt.plot(epochs, acc)
#     plt.plot(epochs, val_acc)
#     plt.title('Training and validation accuracy')
#     plt.xlabel('Epochs')
#     plt.ylabel('Acc')
#     plt.legend(['train_acc', 'val_acc'])
#     plt.savefig('acc.png')
#
#     plt.clf()
#
#     plt.plot(epochs, loss)
#     plt.plot(epochs, val_loss)
#     plt.title('Training and validation loss')
#     plt.xlabel('Epochs')
#     plt.ylabel('Loss')
#     plt.legend(['train_loss', 'val_loss'])
#     plt.savefig('loss.png')

# plot_training(hist)