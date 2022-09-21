# coding=utf-8
import math

from keras.models import Model, load_model
from keras.layers import Flatten, Dense, Dropout
from keras.applications.mobilenet_v3 import MobileNetV3Large
from keras.optimizer_v2.adam import Adam
import matplotlib.pyplot as plt
from keras.preprocessing.image import ImageDataGenerator
from keras.saving.hdf5_format import save_model_to_hdf5
from keras.callbacks import ModelCheckpoint, LearningRateScheduler, ReduceLROnPlateau, EarlyStopping
from keras.callbacks import TensorBoard

# 图片路径
DATASET_PATH = 'train'  # 训练数据集文件夹
DATATEST_PATH = 'test'  # 测试数据集文件夹

# 图片大小
IMAGE_SIZE = (224, 224)

# 图片类别数
NUM_CLASSES = 1

# 若CPU/GPU性能不足，可降低batch size或冻结更多网络层
BATCH_SIZE = 32    # 16，32;

# 冻结网络层数
FREEZE_LAYERS = 0   # default:2;

# Epoch 数
NUM_EPOCHS = 150

TRAIN_TYPE = 0  # 0：重新训练，1:在预训练权重基础上继续训练

# origin
def my_lr_scheduler(epoch, lr):
    if epoch < 50:
        return 1e-4
    elif epoch < 100:
        return 1e-5
    else:
        return lr * 0.9 + 1e-5 * 0.1


# add-1;
# def my_lr_scheduler(epoch):
#     lr = 1e-4
# #     if 50 < epoch < 100:
# #         lr *= 0.2
# #         # return lr * math.exp(-0.1)
# #     elif 100 < epoch < 150:
# #         lr =  lr * 0.9 + 1e-5 * 0.1
# #         # return lr * math.exp(-0.1)
# #     # else:
# #     #     lr = lr * 0.9 + 1e-5 * 0.1
#     print('Learning Rate:',lr)
#     return lr




# add-2;
# Change_LR(0715);
# import keras.backend as K
# from keras.callbacks import LearningRateScheduler


# 将 model.optimizer_G 改成 model.module.optimizer_G

# def my_lr_scheduler(epoch):
#     # 每间隔50epoch,LR减小为原来的1/10；
#     if epoch%50==0 and epoch!=0:
#         lr=K.get_value(Model.optimizer.lr)
#         K.set_value(Model.optimizer.lr,lr*0.1)
#         print("lr changed to {}".format(lr*0.1))
#
#         print('Learning Rate:', lr) # Add;
#
#     return K.get_value(Model.optimizer.lr)


# reduce_lr = LearningRateScheduler(my_lr_scheduler)



# 模型输出文件名
WEIGHTS_FINAL = './models/models.hdf5'
# WEIGHTS_FINAL = './models/models.epoch{epoch}.hdf5'   # Output All Train_Models(0712);


# rescale=1. / 255,在训练过程中添加该项时，train_loss会一直增大，无法收敛；

# train_datagen = ImageDataGenerator(
#                                    rotation_range=5,
#                                    width_shift_range=0.05,
#                                    height_shift_range=0.05,
#                                    shear_range=0.05,
#                                    zoom_range=0.05,
#                                    channel_shift_range=1,
#                                    horizontal_flip=True,
#                                    fill_mode='nearest')


# ADD;
train_datagen = ImageDataGenerator(rotation_range=5,  # 随机旋转角度范围在（-20，20）；[5,10,20,30]
                                   width_shift_range=0.05,  # 水平位移（-0.1，0.1），提高数据鲁棒性，如大于1，表示像素值；[0.05,0.1,0.15,0.2]
                                   height_shift_range=0.05,  # 上下位移（-0.1，0.1），如大于1，表示像素值；[0.05,0.1,0.15,0.2]
                                   shear_range=0.05,  # 裁剪程度(default：0.1)--（可0.2）；[0.05,0.1,0.15,0.2]
                                   zoom_range=0.05,  # 缩放程度(default：0.1)--（可0.2）；[0.05,0.1,0.15,0.2]
                                   channel_shift_range=1,  # 通道随机偏移的最大幅度;[1,5,10,15];
                                   horizontal_flip=True,  # 随机做水平翻转;
                                   fill_mode='nearest')  # 填充像素，离他最近的真实像素点进行填充;



train_batches = train_datagen.flow_from_directory(DATASET_PATH,
                                                  target_size=IMAGE_SIZE,
                                                  interpolation='bicubic',
                                                  class_mode='binary',
                                                  shuffle=True,
                                                  batch_size=BATCH_SIZE)

valid_datagen = ImageDataGenerator()

valid_batches = valid_datagen.flow_from_directory(DATATEST_PATH,
                                                  target_size=IMAGE_SIZE,
                                                  interpolation='bicubic',
                                                  class_mode='binary',
                                                  shuffle=False,
                                                  batch_size=BATCH_SIZE)

# 输出各类别的索引值
for cls, idx in train_batches.class_indices.items():
    print('Class #{} = {}'.format(idx, cls))

# 以训练好的的MobileNet为基础来建立模型，
# 拾取 MobileNet 顶层的 fully connected layers
net = MobileNetV3Large(alpha=1.0, include_top=False, weights=None,
                       input_tensor=None,
                       input_shape=(IMAGE_SIZE[0], IMAGE_SIZE[1], 3))

net.load_weights('weights_mobilenet_v3_large_224_1.0_float_no_top.h5', by_name=True) # load_model;

x = net.output
x = Flatten()(x)

x = Dense(64, activation='relu')(x) # 64;

# 增加 DropOut layer
x = Dropout(0.5)(x) # 0.5;

# 增加Dense layer，以 softmax 产生各类别的几率值
output_layer = Dense(NUM_CLASSES, activation='sigmoid', name='sigmoid')(x)

# 设定冻结与要进行训练的网络层
net_final = Model(inputs=net.input, outputs=output_layer)

for layer in net_final.layers[:FREEZE_LAYERS]:
    layer.trainable = False
for layer in net_final.layers[FREEZE_LAYERS:]:
    layer.trainable = True
# ======================================================================================================================

filepath = './models/weights.epoch{epoch}.hdf5' # Output All Enhancement_Models;

checkpoint = ModelCheckpoint(filepath,
                             # WEIGHTS_FINAL,   # Output All Train_Models(0712);
                             monitor='val_accuracy',
                             verbose=1,
                             save_best_only=False,
                             save_weights_only=False,
                             mode='max',
                             period=1)


# Change_LR(0715);
learning_rate_scheduler = LearningRateScheduler(my_lr_scheduler)


reduce_lr_on_plateau = ReduceLROnPlateau(monitor='val_accuracy',
                                         factor=0.1,
                                         patience=5,
                                         min_delta=1e-3)

early_stopping = EarlyStopping(monitor='val_accuracy',
                               patience=10,
                               mode='max',
                               min_delta=1e-2)

tensorboard = TensorBoard(log_dir='./logs',
                          update_freq=NUM_EPOCHS,
                          histogram_freq=1,
                          write_graph=False)

# callbacks_list = [checkpoint, learning_rate_scheduler, early_stopping, tensorboard]

callbacks_list = [tensorboard]  # 设置启用动态lr---learning_rate_scheduler及early_stopping;

# 使用 Adam optimizer，以较低的 learning rate 进行 fine-tuning

net_final.compile(loss='binary_crossentropy', metrics=['accuracy'], optimizer=Adam(lr=1e-4))    # default:lr=1e-4;
# ======================================================================================================================
# 输出整个网络结构
print(net_final.summary())

# 训练模型
if TRAIN_TYPE:  # 0：重新训练，1:在预训练权重基础上继续训练
    del net_final
    del callbacks_list
    net_final = load_model('./models/weights.epoch40.hdf5')
    # net_final = load_model('./models/models.hdf5')
    # net_final = load_model('./models/models.epoch60.hdf5')

    # callbacks_list = [checkpoint, learning_rate_scheduler, early_stopping, tensorboard]
    callbacks_list = [checkpoint]
    net_final.compile(loss='binary_crossentropy', metrics=['accuracy'], optimizer=Adam(lr=1e-4))


# Output All Train_Models(0712);
# callbacks_list = [checkpoint]

hist = net_final.fit_generator(train_batches,
                               steps_per_epoch=train_batches.samples // BATCH_SIZE,
                               validation_data=valid_batches,
                               validation_steps=valid_batches.samples // BATCH_SIZE,
                               epochs=NUM_EPOCHS,
                               workers=10,
                               callbacks=callbacks_list)


def plot_training(history):
    acc = history.history['accuracy']
    val_acc = history.history['val_accuracy']
    loss = history.history['loss']
    val_loss = history.history['val_loss']
    epochs = range(len(acc))
    plt.style.use("ggplot")
    plt.plot(epochs, acc)
    plt.plot(epochs, val_acc)
    plt.title('Training and validation accuracy')
    plt.xlabel('Epochs')
    plt.ylabel('Acc')
    plt.legend(['train_acc', 'val_acc'])
    plt.savefig('acc.png')

    plt.clf()

    plt.plot(epochs, loss)
    plt.plot(epochs, val_loss)
    plt.title('Training and validation loss')
    plt.xlabel('Epochs')
    plt.ylabel('Loss')
    plt.legend(['train_loss', 'val_loss'])
    plt.savefig('loss.png')


plot_training(hist)


# 保存训练好的模型
# net_final.save(WEIGHTS_FINAL)  # 此种保存方式转换为pb格式时报错
save_model_to_hdf5(net_final, WEIGHTS_FINAL, overwrite=True, include_optimizer=True)
