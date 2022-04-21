## 一、Models_Format；

```python
HDF5格式文件保存的是 ： Model weights
H5 格式文件保存的是： Model structure 和 Model weights
JSON 和 YAML 格式文件保存的是： Model stucture
   
model.to_json() 以 JSON 字符串的形式返回模型的表示。请注意，该表示不包括权重，仅包含结构。
model.to_yaml() 以 YAML 字符串的形式返回模型的表示。请注意，该表示不包括权重，只包含结构。
```

## 二、Channels_last，Channels_first；

```python
channels_last 对应着尺寸为 (batch, ..., channels) 的输入，而 channels_first 对应着尺寸为(batch, channels, ...) 的输入。
channels_last (默认) 或 channels_first 之一，表示输入中维度的顺序。
channels_last 对应输入尺寸为 (batch, height, width, channels) ， channels_first 对应输入尺寸为(batch, channels, height, width) 。

如果 data_format='channels_first'， 输入 4D 张量，尺寸为 (samples, channels, rows, cols) 。
如果 data_format='channels_last'， 输入 4D 张量，尺寸为 (samples, rows, cols, channels) 。
   
通道最后（Channels Last）。 图像数据以三维阵列表示，其中最后一个通道代表颜色通道，例如[B,W,H,C]。
通道第一（Channels First）。 图像数据以三维阵列表示，其中第一通道代表颜色通道，例如彩色通道。 [B,C,W,H]。
```

##  三、Save/Load--Model；

```python
model.save_weights(filepath) 将模型权重存储为 HDF5 文件。
model.load_weights(filepath, by_name=False) : 从 HDF5 文件（由 save_weights 创建）中加载权重。默认情况下，
模型的结构应该是不变的。 如果想将权重载入不同的模型（部分层相同）,设置by_name=True 来载入那些名字相同的层的权重。
```

## 四、Parameters；

```python
verbose: 0, 1 或 2。日志显示模式。 0 = 安静模式, 1 = 进度条, 2 = 每轮一行；
workers: 整数。使用基于进程的多线程时启动的最大进程数。如果未指定，worker 将默认为 1。如果为 0，将在主线程上执行生成器。
如下：
hist = net_final.fit_generator(train_batches,
                               steps_per_epoch=train_batches.samples // BATCH_SIZE,
                               validation_data=valid_batches,
                               validation_steps=valid_batches.samples // BATCH_SIZE,
                               epochs=NUM_EPOCHS,
                               # shuffle=True,
                               # use_multiprocessing=True,
                               workers=20,
                               callbacks=callbacks_list)

shuffle: 布尔值。是否在每轮迭代之前打乱 batch 的顺序。只能与 Sequence ( keras.utils.Sequence )实例同用。
在 steps_per_epoch 不为 None 是无效果。

padding: "valid" , "causal" 或 "same" 之一 (大小写敏感) "valid" 表示「不填充」。 "same" 表示
填充输入以使输出具有与原始输入相同的尺寸大小。 "causal" 表示因果（膨胀）卷积。
```



