#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: Mnist.py 
@time: 2022/09/17 
"""
# Mnist手写数字体识别完整Code;
from tensorflow.keras.datasets import mnist
#这里下载要多试几次，不访问国外网站能下。train_images 和 train_labels 组成了训练集（training set），模型将从这些数据中进行学习。
#然后在测试集（test set，即 test_images 和 test_labels）上对模型进行测试。
(train_images, train_labels), (test_images, test_labels) = mnist.load_data()

from tensorflow.keras import models
from tensorflow.keras import layers
network = models.Sequential()
network.add(layers.Dense(512, activation='relu', input_shape=(28 * 28,)))
network.add(layers.Dense(10, activation='softmax'))

network.compile(optimizer='rmsprop',loss='categorical_crossentropy',metrics=['accuracy'])

train_images = train_images.reshape((60000, 28 * 28))
train_images = train_images.astype('float32') / 255
test_images = test_images.reshape((10000, 28 * 28))
test_images = test_images.astype('float32') / 255

from tensorflow.keras.utils import to_categorical
train_labels = to_categorical(train_labels)
test_labels = to_categorical(test_labels)

network.fit(train_images, train_labels, epochs=20, batch_size=16)