#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: OpenCvGuangguanCount.py 
@time: 2022/07/19 
"""

# 加载图像，实现形态学梯度;
# import cv2 as cv
# import numpy as np
#
# image = cv.imread("./gangguan.jpg")
# se = cv.getStructuringElement(cv.MORPH_RECT, (3, 3))
# image = cv.morphologyEx(image, cv.MORPH_GRADIENT, se)
# cv.imwrite("./image.png", image)
# gray = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
#
# img = image.copy()
# img = cv.cvtColor(img, cv.COLOR_BGR2GRAY)
#
# img = cv.medianBlur(img, 5)
# cimg = cv.cvtColor(img, cv.COLOR_GRAY2BGR)

# 使用霍夫变换，得到输出的圆数组，直接循环绘制颜色即可：

# circles= cv.HoughCircles(gray, cv.HOUGH_GRADIENT, d, min_dist, param1=hgrad, param2=lgrad, minRadius=min, maxRadius=max)

# circles= cv.HoughCircles(img, cv.HOUGH_GRADIENT, 1, 30, param1=50, param2=30, minRadius=50, maxRadius=200)

# add;
# circles = cv.HoughCircles(gray,cv.HOUGH_GRADIENT,1,300,param1=50,param2=30,minRadius=50,maxRadius=200)
#
# circles = cv.HoughCircles(image, method, dp, minDist[, param1[, param2[, minRadius[, maxRadius]]]]])


# image：灰度图像
# method：一般为cv.HOUGH_GRADIENT
# dp:累加器分辨率与图像分辨率的反比，一般为1
# minDist：不同圆心之间的最小距离，太大会遗漏一些圆形，太小会产生许多无关的圆
# param1：传递给 canny 边缘检测算子的高阀值，而低阀值为高阀值的一半
# param2：是检测阶段圆心的累加阀值。越小可以检测到更多的假圆。越大能通过检测的圆就更加接近完美的圆形。
# minRadius：最小半径
# maxRadius：最大半径


# circles = np.uint16(np.around(circles))
#
# for c in circles[0]:
#     #print(c)
#     x, y, r = c
#     b = np.random.randint(0, 256)
#     g = np.random.randint(0, 256)
#     r = np.random.randint(0, 256)
#     cv.circle(image, (x, y), 30, (255, g, r), -1, 8, 0)
#
# cv.imshow('detected circles', image)
# cv.imwrite("./hough_det.png", image)
# cv.waitKey(0)
# cv.destroyAllWindows()




# add1;
import cv2.cv2
import numpy as np
import cv2 as cv
from matplotlib import pyplot as plt

# img1 = cv.imread(r'XXXXX.jpg')

img1 = cv.imread("./gangguan.jpg")

img = img1.copy()
img = cv.cvtColor(img, cv.COLOR_BGR2GRAY)

cv.imwrite("./image.png", img)

img = cv.medianBlur(img, 5)
cimg = cv.cvtColor(img, cv.COLOR_GRAY2BGR)
circles = cv.HoughCircles(img, cv.HOUGH_GRADIENT, 1, 30,
                          param1=42, param2=35,  minRadius=5, maxRadius=30)


# circles = cv.HoughCircles(gray,cv.HOUGH_GRADIENT,1,300,param1=50,param2=30,minRadius=50,maxRadius=200) #default;
# image：灰度图像；
# method：一般为cv.HOUGH_GRADIENT
# dp:累加器分辨率与图像分辨率的反比，一般为1
# minDist：不同圆心之间的最小距离，太大会遗漏一些圆形，太小会产生许多无关的圆
# param1：传递给 canny 边缘检测算子的高阀值，而低阀值为高阀值的一半
# param2：是检测阶段圆心的累加阀值。越小可以检测到更多的假圆。越大能通过检测的圆就更加接近完美的圆形。
# minRadius：最小半径
# maxRadius：最大半径

circles = np.uint16(np.around(circles))
# count=0
for i in circles[0, :]:
    # 画圆：
    cv.circle(img1, (i[0], i[1]), i[2], (0, 255, 0), 5) # 圆--绿色；
    # 圆心：
    cv.circle(img1, (i[0], i[1]), 2, (0, 0, 255), 5)    # 圆心--红色；
    # count+=i

# add;
# count=0
# for c in circles[0]:
#     #print(c)
#     x, y, r = c
#     b = np.random.randint(0, 256)
#     g = np.random.randint(0, 256)
#     r = np.random.randint(0, 256)
#     cv.circle(img1, (x, y), 16, (255, g, r), -1, 8, 0)  # default：30；



# print(count)

cv.imshow('detected circles', img1)
cv.imwrite("./hough_det.png", img1)

cv.waitKey(0)
cv.destroyAllWindows()