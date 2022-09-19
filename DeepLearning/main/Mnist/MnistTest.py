#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: MnistTest.py 
@time: 2022/09/17 
"""
from tensorflow.keras import models
from tensorflow.keras import layers
network = models.Sequential()

from tensorflow.keras.datasets import mnist

(test_images, test_labels) = mnist.load_data()

test_images = test_images.reshape((10000, 28 * 28))
test_images = test_images.astype('float32') / 255

from tensorflow.keras.utils import to_categorical
test_labels = to_categorical(test_labels)


test_loss, test_acc = network.evaluate(test_images, test_labels)
print('test_acc:', test_acc)
