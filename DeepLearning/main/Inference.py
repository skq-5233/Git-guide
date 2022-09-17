#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: Inference.py 
@time: 2022/08/15 
"""
# Step1
# 第一步，引入相应库函数，配置推理计算设备，IR文件路径，媒体文件路径；
from openvino.inference_engine import IECore
import numpy as np
import cv2 as cv
model_xml = "models/YOLOv5s.xml"
model_bin = "models/YOLOv5***in"
src = cv.imread(r"images\image_06626_2.jpg")


# Step2 初始化Core对象
# 第二步，初始化Core对象，管理可用设备和读取网络对象；

ie = IECore()
for device in ie.available_devices:
   print(device)

#Step3 读取IR模型
# 第三步，使用读取IR模型(支持.xml格式)，将IR模型读入ie.read_network；

net = ie.read_network(model=model_xml,weight***odel_bin)

#Step4 配置模型输入和输出；
# 第四步，配置模型输入和输出，将模型载入内存后，使用net.outputs和net.inputs参数保存输入和输出；

input_blob = next(iter(net.inputs))
out_blob = next(iter(net.outputs))
n,c,h,w = net.inputs[input_blob].shape


#Step5 将模型加载到设备
# 第五步，使用ie.load_network()将模型加载到设备，载入的硬件由LoadNetwork()方法的DEVICE参数决定。

exec_net = ie.load_network(network=net, device_name="CPU")

# Step6 准备输入数据；
# 第六步，准备输入数据，并按模型要求对图像矩阵进行转置处理；

image = cv.resize(src,(w,h))
image = image.transpose(2,0,1)

#Step7 执行推理计算；
# 第七步，执行推理计算，使用此前加载到设备上的模型exec_net的infer()方法进行推理；

res = exec_net.infer(inputs={input_blob:[image]})

#Step8 处理推理计算结果；
# 第八步，处理推理计算结果，使用numpy的np.max()和np.argmax()方法对输出结果进行筛选，获得对应输入图像的推理得分以及标签索引，之后再利用Opencv的putText()与imshow()方法对结果进行显示；

res = res[out_blob]
print(res.shape)
print(np.max(res,1))
label_index = str(np.argmax(res, 1)[0]) #使用0将list转成数值类型
print(label_index)
label_index = 'classes_index: '+label_index
scores = ' scores: ' + str(np.max(res,1)[0])[:5]
cv.putText(src, label_index, (20,50), cv.FONT_HERSHEY_SIMPLEX, 1.0, (255,255,255), 2, 12)
cv.putText(src, scores, (5,85), cv.FONT_HERSHEY_SIMPLEX, 1.0, (255,255,255), 2, 12)
cv.imshow("flowers recognition",src)
cv.waitKey(0)

