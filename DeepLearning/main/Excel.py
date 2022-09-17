#!usr/bin/env python  
# -*- coding:utf-8 _*-
""" 
@author:eivision 
@file: Excel.py 
@time: 2022/08/22 
"""
import matplotlib.pyplot as plt
import pandas as pd

df = pd.read_excel('图像信息2.xlsx')  # 默认读取sheet = 0的
li = df["像素值"].tolist() # 将excel表中像素值列中的数值进行转换成列表；
print(li)
print (len(li))

dic = {
    (4400, 4500): 0,
    (4500, 4750): 0
}
for v in li:
    # print(v)
    # if v == 'pixel:':
        # v = v.replace(v,'');
        # print(v)
        for k in dic:
            if k[0] <= int(v) < k[1]:
                dic[k] += 1
# 这两行代码解决 plt 中文显示的问题
plt.rcParams['font.sans-serif'] = ['SimHei']
plt.rcParams['axes.unicode_minus'] = False

waters = ('4400-4500', '4500-4750')
buy_number = list(dic.values())

plt.bar(waters, buy_number)
plt.title('像素值分布')

plt.savefig('./pixel-2.png')
plt.show()



# import xlrd
# import matplotlib.pyplot as plt
# # 调节字体
# plt.rcParams['font.sans-serif'] = ['SimHei']  # 用来正常显示中文标签
# plt.rcParams['axes.unicode_minus'] = False  # 用来正常显示负号
# # 导入excel文件，以及第几张表
# data = xlrd.open_workbook('图像信息1.xlsx')
# table = data.sheets()[0]
# # 第一个图的数据
# t1 = table.col_values(1)
# tt = t1[4000:5000]
# xAxis1 = range(1,1001)
# # #第二个图的数据
# # t2 = table.col_values(2)
# # tu = t2[27:90]
# # xAxis2 = range(1955,2018)
# # #第三个图的数据
# # t3 = table.col_values(3)
# # tv = t3[20:90]
# # xAxis3 = range(1948,2018)
# # #第四个图的数据
# # t4 = table.col_values(4)
# # tw = t4[42:90]
# # xAxis4 = range(1970,2018)
# # 作图
# plt.plot(xAxis1, tt, label='像素值分布')
# # plt.plot(xAxis2, tu, label='日本GDP')
# # plt.plot(xAxis3, tv, label='英国GDP')
# # plt.plot(xAxis4, tw, label='韩国GDP')
# plt.xlabel('顺序')
# plt.ylabel('像素值')
# plt.title("各像素值分布情况")
# plt.legend()
# plt.show()
