#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: BatchHough.py 
@time: 2022/10/31 
"""
"""
处理数据集和标签数据集的代码：（主要是对原始数据集裁剪）
  处理方式：分别处理
  注意修改输入输出目录 和 生成的文件名
  output_dir = "./label_temp"
  input_dir = "./label"
"""

# method1;
# import cv2
# import os
# import sys
# import time
#
# a_x=0
# b_y=0
# c_r=0
#
#
# def get_img(input_dir):
#     img_paths = []
#     for (path, dirname, filenames) in os.walk(input_dir):
#         for filename in filenames:
#             img_paths.append(path + '/' + filename)
#     print("img_paths:", img_paths)
#     return img_paths
#
#     readimg = cv2.imread(filename+'/'+filename)
#
#     imgray = cv2.cvtColor(readimg, cv2.COLOR_BGR2GRAY)  # 图像灰度化
#     ret, binary = cv2.threshold(imgray, 100, 255, cv2.THRESH_BINARY)  # 图像二值化
#     circles = cv2.HoughCircles(binary, cv2.HOUGH_GRADIENT, 1, 200,
#                                param1=100, param2=10,  minRadius=100, maxRadius=130)
#     # a_x=0
#     # b_y=0
#     # c_r=0
#
#     for i in circles[0, :]:
#         # 画圆：
#         a_x = int(i[0])
#         b_y= int(i[1])
#         c_r = int(i[2])
#     return img_paths
#
# def cut_img(img_paths, output_dir):
#     scale = len(img_paths)
#     for i, img_path in enumerate(img_paths):
#         a = "#" * int(i / 1000)
#         b = "." * (int(scale / 1000) - int(i / 1000))
#         c = (i / scale) * 100
#         time.sleep(0.2)
#         print('正在处理图像： %s' % img_path.split('/')[-1])
#         img = cv2.imread(img_path)
#         weight = img.shape[1]
#         if weight > 1600:  # 正常发票
#             cropImg = img_paths[b_y - c_r - 20: b_y + c_r + 20, a_x - c_r - 20: a_x + c_r + 20]
#             # cropImg = img[50:200, 700:1500]  # 裁剪【y1,y2：x1,x2】
#             # cropImg = cv2.resize(cropImg, None, fx=0.5, fy=0.5,
#             # interpolation=cv2.INTER_CUBIC) #缩小图像
#             cv2.imwrite(output_dir + '/' + img_path.split('/')[-1], cropImg)
#         else:  # 卷帘发票
#             cropImg_01 = img[30:150, 50:600]
#             cv2.imwrite(output_dir + '/' + img_path.split('/')[-1], cropImg_01)
#         print('{:^3.3f}%[{}>>{}]'.format(c, a, b))
#
#
# if __name__ == '__main__':
#     output_dir = "./GDRG_Crop"  # 保存截取的图像目录
#     input_dir = "./GDRG"  # 读取图片目录表
#     img_paths = get_img(input_dir)
#
#     # img_paths = read_path(input_dir)
#     print('图片获取完成 。。。！')
#     cut_img(img_paths, output_dir)
# print('图片获取完成 。。。！')


# # method2;
# import os
# from PIL import Image
# def crop(input_img_path, output_img_path, crop_w, crop_h):
#     image = Image.open(input_img_path)
#
#     x_max = image.size[0]
#     y_max = image.size[1]
#
#     mid_point_x = int(x_max / 2)
#     mid_point_y = int(y_max / 2)
#
#     right = mid_point_x + int(crop_w / 2)
#     left = mid_point_x - int(crop_w / 2)
#     down = mid_point_y + int(crop_h / 2)
#     up = mid_point_y - int(crop_h / 2)
#
#     BOX_LEFT, BOX_UP, BOX_RIGHT, BOX_DOWN = left, up, right, down
#     box = (BOX_LEFT, BOX_UP, BOX_RIGHT, BOX_DOWN)
#
#     crop_img = image.crop(box)
#     crop_img.save(output_img_path)
#
#
# if __name__ == '__main__':
#     dataset_dir = "./GDRG"  # 图片路径
#     output_dir = './GDRG_Crop'  # 输出路径
#     crop_w = 400  # 裁剪图片宽
#     crop_h = 400  # 裁剪图片高
#     # 获得需要转化的图片路径并生成目标路径
#     image_filenames = [(os.path.join(dataset_dir, x), os.path.join(output_dir, x))
#                        for x in os.listdir(dataset_dir)]
#     # 转化所有图片
#     for path in image_filenames:
#         crop(path[0], path[1], crop_w, crop_h)
# print("Finished!")


# method3;
import os
import cv2
from PIL import Image
import numpy as np

a_x = 0
b_y = 0
c_r = 0

def crop(dataset_dir, output_dir):
    image = Image.open(dataset_dir)
    image = np.ascontiguousarray(image)

    # 查找物体轮廓--add;
    # def findcontour(img):
    imgray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)  # 图像灰度化
    ret, binary = cv2.threshold(imgray, 100, 255, cv2.THRESH_BINARY)  # 图像二值化
    circles = cv2.HoughCircles(binary, cv2.HOUGH_GRADIENT, 1, 200,
                               param1=100, param2=10, minRadius=100, maxRadius=130)

    for i in circles[0, :]:
        # 画圆：
        a_x = int(i[0])
        b_y = int(i[1])
        c_r = int(i[2])

    # 应该是img[min_y:max_y,min_x:max_x]
    cropImg = image[b_y - c_r - 20: b_y + c_r + 20, a_x - c_r - 20: a_x + c_r + 20]

    cv2.imshow("result", cropImg)
    # cv2.waitKey()

    # x_max = image.size[0]
    # y_max = image.size[1]
    #
    # mid_point_x = int(x_max / 2)
    # mid_point_y = int(y_max / 2)
    #
    # right = mid_point_x + int(crop_w / 2)
    # left = mid_point_x - int(crop_w / 2)
    # down = mid_point_y + int(crop_h / 2)
    # up = mid_point_y - int(crop_h / 2)

    # BOX_LEFT, BOX_UP, BOX_RIGHT, BOX_DOWN = left, up, right, down
    # box = (BOX_LEFT, BOX_UP, BOX_RIGHT, BOX_DOWN)

    cv2.imwrite(output_dir, cropImg)  # 保存图片

    # crop_img = image.crop(cropImg)
    # crop_img.save(output_dir)


if __name__ == '__main__':
    dataset_dir = "./GDRG"  # 图片路径
    output_dir = './GDRG_Crop'  # 输出路径
    # crop_w = 400  # 裁剪图片宽
    # crop_h = 400  # 裁剪图片高
    # 获得需要转化的图片路径并生成目标路径
    image_filenames = [(os.path.join(dataset_dir, x), os.path.join(output_dir, x))
                       for x in os.listdir(dataset_dir)]
    # 转化所有图片
    for path in image_filenames:
        crop(path[0], path[1])
print("Finished!")