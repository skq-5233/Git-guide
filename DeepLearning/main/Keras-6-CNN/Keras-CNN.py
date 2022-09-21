#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: Keras-CNN.py 
@time: 2022/09/21 
"""
# 卷积神经网络接收形状为 (image_height, image_width, image_channels)的输入张量（不包括批量维度）。
# 本例中设置卷积神经网络处理大小为 (28, 28, 1) 的输入张量，这正是 MNIST 图像的格式。我们向第一层传入参数 input_shape=(28, 28, 1) 来完成此设置。

from tensorflow.keras import layers
from tensorflow.keras import models
model = models.Sequential()

model.add(layers.Conv2D(32, (3, 3), activation='relu', input_shape=(28, 28, 1)))
model.add(layers.MaxPooling2D((2, 2)))

model.add(layers.Conv2D(64, (3, 3), activation='relu'))
model.add(layers.MaxPooling2D((2, 2)))

model.add(layers.Conv2D(64, (3, 3), activation='relu'))

# 打印卷积神经网络的架构;
# model.summary()

# 下一步是将最后的输出张量［大小为 (3, 3, 64)］输入到一个密集连接分类器网络中， 即 Dense 层的堆叠，你已经很熟悉了。
# 这些分类器可以处理 1D 向量，而当前的输出是 3D 张量。首先，我们需要将 3D 输出展平为 1D，然后在上面添加几个 Dense 层。
model.add(layers.Flatten())

model.add(layers.Dense(64, activation='relu'))

model.add(layers.Dense(10, activation='softmax'))
# 打印卷积神经网络的架构;
model.summary()


# 下面我们在 MNIST 数字图像上训练这个卷积神经网络。我们将复用前面讲的 MNIST 示例中的很多代码。
from tensorflow.keras.datasets import mnist

from tensorflow.keras.utils import to_categorical

(train_images, train_labels), (test_images, test_labels) = mnist.load_data()

train_images = train_images.reshape((60000, 28, 28, 1))

train_images = train_images.astype('float32') / 255

test_images = test_images.reshape((10000, 28, 28, 1))

test_images = test_images.astype('float32') / 255

train_labels = to_categorical(train_labels)

test_labels = to_categorical(test_labels)

model.compile(optimizer='rmsprop',

              loss='categorical_crossentropy',

              metrics=['accuracy'])

model.fit(train_images, train_labels, epochs=5, batch_size=64)
