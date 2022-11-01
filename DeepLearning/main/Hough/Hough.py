#!usr/bin/env python
# -*- coding:utf-8 _*-
"""
@author:eivision
@file: Hough.py
@time: 2022/10/29
"""

# method1;
# import numpy as np
# import cv2 as cv
# from matplotlib import pyplot as plt
#
# # WORK;
# # img1 = cv.imread("./gangguan.jpg")
#
# img1 = cv.imread("./GDRG/00000003_Error_00000003_07_.JPG")
#
# img = img1.copy()
# img = cv.cvtColor(img, cv.COLOR_BGR2GRAY)
#
# cv.imwrite("./image3.png", img)
#
# img = cv.medianBlur(img, 5)
# # cimg = cv.cvtColor(img, cv.COLOR_GRAY2BGR)
# circles = cv.HoughCircles(img, cv.HOUGH_GRADIENT, 1, 100,
#                           param1=42, param2=35,  minRadius=80, maxRadius=150)
#
#
# # circles = cv.HoughCircles(gray,cv.HOUGH_GRADIENT,1,300,param1=50,param2=30,minRadius=50,maxRadius=200) #default;
# # image：灰度图像；
# # method：一般为cv.HOUGH_GRADIENT
# # dp:累加器分辨率与图像分辨率的反比，一般为1
# # minDist：不同圆心之间的最小距离，太大会遗漏一些圆形，太小会产生许多无关的圆
# # param1：传递给 canny 边缘检测算子的高阀值，而低阀值为高阀值的一半
# # param2：是检测阶段圆心的累加阀值。越小可以检测到更多的假圆。越大能通过检测的圆就更加接近完美的圆形。
# # minRadius：最小半径
# # maxRadius：最大半径
#
# circles = np.uint16(np.around(circles))
# # count=0
# for i in circles[0, :]:
#     # 画圆：
#     cv.circle(img1, (i[0], i[1]), i[2], (0, 255, 0), 1) # 圆--绿色；
#     # 圆心：
#     cv.circle(img1, (i[0], i[1]), 2, (0, 0, 255), 5)    # 圆心--红色；
#     # count+=i
#
# # add;
# # count=0
# # for c in circles[0]:
# #     #print(c)
# #     x, y, r = c
# #     b = np.random.randint(0, 256)
# #     g = np.random.randint(0, 256)
# #     r = np.random.randint(0, 256)
# #     cv.circle(img1, (x, y), 16, (255, g, r), -1, 8, 0)  # default：30；
#
# # add-2022-1029;
# # cv2.rectangle(img, pt1, pt2, color, thickness=None, lineType=None, shift=None )
# # img：指定一张图片，在这张图片的基础上进行绘制；
# # pt1： 矩形的一个顶点；
# # pt2： 与pt1在对角线上相对的矩形的顶点；
# # color：指定边框的颜色，由（B,G,R）组成，当为（255,0，0）时为绿色，可以自由设定；
# # thinkness：线条的粗细值，为正值时代表线条的粗细（以像素为单位），为负值时边框实心;
# # lineType ：关于选择线条生成算法的。
# # shift ：
# # 作用（根据效果图的个人理解）：对点坐标进行左移的位运算，即对点坐标除以(2^shift)
# # 参数范围：shift>=0
# # 该参数示范代码（函数中最后一个参数为shift）：
# # 两个角点分别为（200，200），（0，0）
#
# # WORK;
# # cv.rectangle(img1, (600,450), (220,80), (0,0,255), 1, cv.LINE_8, 0)    #红
#
# # add--2022-1031;
# # img2 = cv.cvtColor(img1,cv.COLOR_BGR2GRAY)
#
# contours,hierarchy = cv.findContours(img,cv.RETR_EXTERNAL,cv.CHAIN_APPROX_NONE)
# # 绘制轮廓
# # cv.drawContours(图像,轮廓列表,轮廓索引-1则绘制所有,轮廓颜色,轮廓的宽度)
# # 绘制整幅图像大小-img1;
# img3 = cv.drawContours(img1,contours,-1,(0,0,255),2)
#
# # 不带旋转角度外接矩形 --TypeError: Expected Ptr<cv::UMat> for argument 'array'
# # rect2 = cv.boundingRect(contours)
#
# # 最小矩形框；
# # rect = cv.minAreaRect(contours)
#
# cv.imshow('Result', img3)
# # cv.imwrite("./hough_det3.png", img1)
#
# cv.waitKey(0)
# cv.destroyAllWindows()



## method2;
# import cv2
# import numpy as np
#
# original = cv2.imread('./GDRG/00000001_Error_00000001_07_.JPG')
#
# # 查找物体轮廓
# def findcontour(img):
#     gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)  # 图像灰度化
#     ret, binary = cv2.threshold(gray, 130, 255, cv2.THRESH_BINARY)  # 图像二值化
#     contours, hierarchy = cv2.findContours(binary, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)  # 查找物体轮廓
#     return contours, hierarchy
#
#
#
# contours, hierarchy = findcontour(original)
#
# nums = len(contours)
#
# for i in range(nums):
#     temp = np.zeros(original.shape, np.uint8)
#
#     # 绘制最小外接矩形框
#     rect = cv2.minAreaRect(contours[i])  # rect返回矩形的特征信息，其结构为【最小外接矩形的中心（x，y），（宽度，高度），旋转角度】
#     points = cv2.boxPoints(rect)  # 得到最小外接矩形的四个点坐标
#     points = np.int0(points)  # 坐标值取整
#     image = cv2.drawContours(original, [points], 0, (0, 0, 255), 2)  # 直接在原图上绘制矩形框
#
#     cv2.imshow("result", image)
#
#     # cv2.imwrite("./hough_det3.png", image)
#
# cv2.waitKey()


# method3;
import cv2
import numpy as np

original = cv2.imread('./GDRG/00000006_Error_00000006_07_.JPG')

# 查找物体轮廓
# def findcontour(img):
imgray = cv2.cvtColor(original, cv2.COLOR_BGR2GRAY)  # 图像灰度化
ret, binary = cv2.threshold(imgray, 100, 255, cv2.THRESH_BINARY)  # 图像二值化
circles = cv2.HoughCircles(binary, cv2.HOUGH_GRADIENT, 1, 200,
                           param1=100, param2=10,  minRadius=100, maxRadius=130)

# circles = np.uint16(np.around(circles))

# print(circles.shape)  # （1,1,3）;
# a,b,c=0
a_x=0
b_y=0
c_r=0

for i in circles[0, :]:
    # 画圆：
    a_x = int(i[0])
    b_y= int(i[1])
    c_r = int(i[2])
    # cv2.circle(original, (i[0], i[1]), i[2], (0, 255, 0), 1) # 圆--绿色；
    #
    # # 圆心：
    # cv2.circle(original, (i[0], i[1]), 2, (0, 0, 255), 5)    # 圆心--红色；

    # cropImg =original[i[0] - i[2] - 20:i[0] + i[2] + 20, i[1] - i[2] - 20:i[1] + i[2] + 20]

    # box =((i[0] - i[2] - 20), (i[1] - i[2] - 20), (i[0] + i[2] + 20), (i[1] + i[2] + 20))
    #
    # box = ((a_x - c_r - 20), (b_y - c_r - 20), (a_x + c_r + 20), (b_y + c_r + 20))
    # cropImg = original.crop(box)

# a_crop = original.crop(box)



# 如何取圆心及半径？
# cropImg = original[(circles[0,0] - circles[0,2] - 0): (circles[0,0] + circles[0,2] + 0), (circles[0,1] - circles[0,2] - 0):(circles[0,1] + circles[0,0] + 0)]  #裁剪图像

# 裁剪图像；


# cropImg =original[i[0] - i[2] - 20:i[0] + i[2] + 20, i[1] - i[2] - 20:i[1] + i[2] + 20]

# 应该是img[min_y:max_y,min_x:max_x]
cropImg = original[ b_y - c_r - 20 : b_y + c_r + 20,a_x - c_r - 20 : a_x + c_r + 20]

cv2.imshow("result", cropImg)
cv2.imwrite("./hough_det6.jpg", cropImg)

cv2.waitKey()

#
#
# # circles = cv.HoughCircles(gray,cv.HOUGH_GRADIENT,1,300,param1=50,param2=30,minRadius=50,maxRadius=200) #default;
# # image：灰度图像；
# # method：一般为cv.HOUGH_GRADIENT
# # dp:累加器分辨率与图像分辨率的反比，一般为1
# # minDist：不同圆心之间的最小距离，太大会遗漏一些圆形，太小会产生许多无关的圆
# # param1：传递给 canny 边缘检测算子的高阀值，而低阀值为高阀值的一半
# # param2：是检测阶段圆心的累加阀值。越小可以检测到更多的假圆。越大能通过检测的圆就更加接近完美的圆形。
# # minRadius：最小半径
# # maxRadius：最大半径


#     contours, hierarchy = cv2.findContours(binary, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)  # 查找物体轮廓
#     return contours, hierarchy
#
#
# contours, hierarchy = findcontour(original)
#
# nums = len(contours)
#
# for i in range(nums):
#     temp = np.zeros(original.shape, np.uint8)
#
#     # 绘制最小外接矩形框
#     rect = cv2.minAreaRect(contours[i])  # rect返回矩形的特征信息，其结构为【最小外接矩形的中心（x，y），（宽度，高度），旋转角度】
#     points = cv2.boxPoints(rect)  # 得到最小外接矩形的四个点坐标
#     points = np.int0(points)  # 坐标值取整
#     image = cv2.drawContours(original, [points], 0, (0, 0, 255), 2)  # 直接在原图上绘制矩形框

# cv2.imshow("result", cropImg)
#
#     # cv2.imwrite("./hough_det3.png", image)
#
# cv2.waitKey()
