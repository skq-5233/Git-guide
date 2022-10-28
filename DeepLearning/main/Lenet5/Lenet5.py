#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: Lenet5.py 
@time: 2022/10/28 
"""

import tensorflow.keras
import numpy as np

import os
os.environ['KERAS_BACKEND']='tensorflow'

from tensorflow.keras import optimizers
from tensorflow.keras.datasets import cifar10
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Conv2D, Dense, Flatten, MaxPooling2D
from tensorflow.keras.callbacks import LearningRateScheduler, TensorBoard
from tensorflow.keras.preprocessing.image import ImageDataGenerator
from tensorflow.keras.regularizers import l2

batch_size = 128
epochs = 200
iterations = 391
num_classes = 10
weight_decay = 0.0001
mean = [125.307, 122.95, 113.865]
std = [62.9932, 62.0887, 66.7048]


def build_model():
    model = Sequential()
    model.add(Conv2D(6, (5, 5), padding='valid', activation='relu', kernel_initializer='he_normal',
                     kernel_regularizer=l2(weight_decay), input_shape=(32, 32, 3)))
    model.add(MaxPooling2D((2, 2), strides=(2, 2)))
    model.add(Conv2D(16, (5, 5), padding='valid', activation='relu', kernel_initializer='he_normal',
                     kernel_regularizer=l2(weight_decay)))
    model.add(MaxPooling2D((2, 2), strides=(2, 2)))
    model.add(Flatten())
    model.add(Dense(120, activation='relu', kernel_initializer='he_normal', kernel_regularizer=l2(weight_decay)))
    model.add(Dense(84, activation='relu', kernel_initializer='he_normal', kernel_regularizer=l2(weight_decay)))
    model.add(Dense(10, activation='softmax', kernel_initializer='he_normal', kernel_regularizer=l2(weight_decay)))
    sgd = optimizers.SGD(lr=.1, momentum=0.9, nesterov=True)
    model.compile(loss='categorical_crossentropy', optimizer=sgd, metrics=['accuracy'])
    return model


def scheduler(epoch):
    if epoch < 100:
        return 0.01
    if epoch < 150:
        return 0.005
    return 0.001


if __name__ == '__main__':

    # load data
    (x_train, y_train), (x_test, y_test) = cifar10.load_data()
    y_train = tensorflow.keras.utils.to_categorical(y_train, num_classes)
    y_test = tensorflow.keras.utils.to_categorical(y_test, num_classes)
    x_train = x_train.astype('float32')
    x_test = x_test.astype('float32')

    # data preprocessing  [raw - mean / std]
    for i in range(3):
        x_train[:, :, :, i] = (x_train[:, :, :, i] - mean[i]) / std[i]
        x_test[:, :, :, i] = (x_test[:, :, :, i] - mean[i]) / std[i]

    # build network
    model = build_model()
    print(model.summary())

    # set callback
    tb_cb = TensorBoard(log_dir='./lenet_dp_da_wd', histogram_freq=0)
    change_lr = LearningRateScheduler(scheduler)
    cbks = [change_lr, tb_cb]

    # using real-time data augmentation
    print('Using real-time data augmentation.')
    datagen = ImageDataGenerator(horizontal_flip=True,
                                 width_shift_range=0.125, height_shift_range=0.125, fill_mode='constant', cval=0.)

    datagen.fit(x_train)

    # start train
    model.fit_generator(datagen.flow(x_train, y_train, batch_size=batch_size),
                        steps_per_epoch=iterations,
                        epochs=epochs,
                        callbacks=cbks,
                        validation_data=(x_test, y_test))
    # save model
    model.save('lenet_dp_da_wd.h5')