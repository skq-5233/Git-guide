## 一、python函数；

```python
## coding:utf-8
# from matplotlib import pyplot as plt
# x_data = ['2011','2012','2013','2014','2015','2016','2017']
# y_data = [58000,60200,63000,71000,84000,90500,107000]
# y_data2 = [52000,54200,51500,58300,56800,59500,62700]
#
# plt.plot(x_data,y_data,color='red',linewidth=2.0,linestyle='--',label='curve1')
# plt.plot(x_data,y_data2,color='blue',linewidth=3.0,linestyle='-.',label='curve_2')
# plt.title('curve')
# plt.legend(loc='best')  ## 添加这行代码后，才可以出现图标；
# plt.show()

# print("abcd"*4)
# print(11<<1) # （22）左移一位，相当于乘以2的1次方；
# print(11<<2) # （44）左移两位，相当于乘以2的2次方；
# print(11>>1) # （5）右移一位，相当于整除2的1次方；
# print(11>>2) # （2）右移一位，相当于整除2的2次方；

# if-else语句
# age = int(input('请输入年龄：'))
#
# if age >= 18:
#     print('已经成年')
# else:
#     print('还未成年')
#
# print('if-else后面的语句')


# if -elif- else
# score = int(input("请输入你的考试成绩："))
# if score>=90:
#     print("该生成绩优秀！！！")
# elif score >=80:
#     print("该生成绩优良")
# elif score>=60:
#     print("该生成绩合格")
# else:
#     print("你需要加油了！！！")

# if嵌套语句
# age = int(input('请输入年龄：'))
# score = int(input('请输入成绩：'))
#
# if age >= 18:
#     print('年龄合格，准许参军。')
#     if score >= 90:
#         print('身体素质优秀！==>去当飞行员！')
#     else:
#         print('达不到飞行员素质。==>当个普通士兵。')
# else:
#     print('还不够参军年龄，过几年再来。')

# 缩进决定了语句块的范围
# num = 5
# if num > 10:
#     print('num大于10')
#     # 有缩进时，此print语句是if语句块的一部分
#     print('测试语句')
# print('if后续第一条执行语句')

# while循环(2022-0104)；
# sum =0
# i=1
# while i<101:
#     sum += i
#     i+=1
# print(sum)

# for循环（2022-0104）；
# sum =0
# for i in range(1,11):
#     sum+=i
# print(f'sum = {sum}')
#
# for x in 'adcde':
#     print(f'x = {x}')
#     print('==========')
# print('finished')

# # 一行打印；
# for x in range(1,10,2):
#     print(x,end='')
# print()
# # 一行打印；
# for x in range(1,10):
#     print(x,end='')# 一行打印；
# print()

# 水仙花数；
# for num in range(100,1000):
#     b = num // 100 % 10
#     s = num //10 %10
#     g = num %10
#     if b**3 + s**3 +g**3 == num:
#         print(num)


# 打印*形矩形(嵌套循环)；
# h = int(input("请输入高："))
# b = int(input("请输入宽："))
# for i in range(h):
#     for j in range(b):
#         print('*',end='')
#     print()

# # break
# my_sum = 0
# for i in range(1,101):
#     my_sum+=i
#     if my_sum>3000:
#         break
# print(f'i={i}')
# print(f'sum={my_sum}')

# if -else
# use_name = "skq"
# use_key = "123"
#
# s = input("请输入登录名：")
# k = input("请输入密码：")
#
# b = (s == use_name) and (k == use_key)
# if (b):
#     print("登录成功！！!")
# else:
#     print("请重新输入密码和用户名")

# break,结束所有循环；(2022-0106)
# use_name = "skq"
# use_key = "123"
# while True:
#     s = input("请输入登录名：")
#     k = input("请输入密码：")
#
#     b = (s == use_name) and (k == use_key)
#     if (b):
#         print("登录成功！！!")
#         break
#     else:
#         print("密码或用户名错误！请重新输入密码和用户名！")
# print("**************欢迎进入系统界面，开始你的表演！！!*************\n"
#       "*******************8848，纯纯牛马手机**************")

# continue，结束当前循环；(20220106)
# for x in 'abcde':
#     print(f'x={x}')
#     if x == 'c':
#         continue
#     print('打印=======打印')
# print('Finished')

# continue,偶数相加；(20220106)
# my_sum = 0
# for i in range(1, 101):
#     if i % 2 == 0:
#         my_sum += i
#         continue
# print(f'my_sum = {my_sum}')
# print('Finished')

# pass语句占位符，执行时不做任何操作；(20220106)
# 字符串索引
# s = 'abced'
# print(s[0:3])
# print(len(s))

# find查找字符串（2022-0107）；
# s = 'Hello world'
# print(s.find('o'))  # 索引值；
# print(s.find('o', 5))  # 索引值；
# print(s.rfind('o'))  # rfind(右索引)
# print(s.find('x'))  # 无索引值，返回-1；
#
# print(s.index('o'))     # 索引值；
# print(s.rindex('o'))    # reindex(右索引)
# print(s.index('xxx'))  # 无索引值ValueError: substring not found，报错；

# len;
# s = 'Hello World'
# print(len(s))
# print(s.count('o'))

# capitalize,title(字符串首字母大写)；
# lower(全部小写),upper(全部大写);
# s = 'Hello World'
# print(s.title())
# print(s.capitalize())
# print(s.lower())
# print(s.upper())

# 拼接、拆分（join）；
# s = 'Hello World'
# print('*'.join(s))

# split,splitlines(结果是列表);
# s = 'Hello World 1111'
# x = s.split()
# print('s=',x)
# print(s.split())

# parttition(左边开始找);rparttion(右边开始找)---结果为元组;
# s = 'Hello World 1111'
# a = s.partition('x')
# print(s.partition('x'))

# lstrip,rstrip,strip:去掉参数中包含的字符；

# s = 'Hello World 1111H'
# print(s.strip('H'))

# (2022-0111);
# 列表：包含一系列数据，类型不一，长度可变；
# 列表使用[]括起来所有元素，各元素间用都好隔开；
# a = ['qq',111,'abc','true']
# print(type(a)) # <class 'list'>;
# print(a[1]) # 111;
# print(len(a)) # 4;

# for循环遍历（2022-0112）；
# for x in a:
#     print(x) # 打印列表a;
# 使用while循环遍历（2022-0112）；

# a = ['qq',111,'abc','true']
# i = 0
# length = len(a)
# while i < length:
#     print(a[i])
#     i += 1

# 查找(in & not in)
# a = ['qq',111,'abc','true','aas']
# if 'abc' in a:
#     print("'abc'存在列表[a]中")
# print(a.index(111)) # 1;
# print(a.count('abc')) # 1;

# 列表(可改变数据类型)：添加(append:末尾添加元素,一次添加一个元素；exrend:末尾添加元素；)、插入(insert:)、修改；
# a = ['qq', 111, 'abc', 'true', 'aas']
# a.append('gods')  # append:末尾添加字符串,一次添加一个元素；
# print(a)
# a.extend(['asd', 'qwq'])  # 在末尾添加整个列表元素；
# a.extend('acsd')  # 添加单个字母；
# # a.extend(20)  # 报错，int无法迭代；
# a.insert(0,'ewqr') # 在索引值0前面，添加元素；
# print(a)

# 删除（delete、pop 、remove，2022-0113）
# a = ['qq', 111, 'abc', 'true', 'aas']
# del (a[1]) # 删除111（需指定索引值）；
# print(a)
# a.pop() # 默认删除最后一个元素'aas'（需指定索引值）；
# print(a)
# a.remove('qq') # 根据内容删除('qq')；
# print(a)

# 排序(sort(升序排列：列表中任意两元素可进行比较)、(reverse=True)，2022-0113)
# a = [23, 111, 45, 234, 198]
# a.insert(0,21)
# print(a)
#
# a.sort() # 升序排列；
# print(a)
#
# a.sort(reverse=True) # 降序排列；
# print(a)

# (元组，2022-0113)；
# 元组与列表类似，但元组中的元素无法修改，元组使用小括号，各元素用逗号分隔开；
# t = (1,2,3,)
# t1 =(2,3,4)
# print(t+t1)
# print(len(t+t1))
# # 元组的遍历、查找 使用方法同列表；
# t += (20,) # 在末尾添加元素；
# print(t)

# 字典--可改变（2022-0114）；(映射类结构，用自定义的数据做索引，访问元素)；
# info = {'name':'sun','age':27} # key-value;
# print(type(info)) # <class 'dict'>;
# print(len(info)) # 2;
# print(info['name'])
# info['age'] = 23 # 修改--字典值value；
# print(info)
# info ['education'] = 'master' # 添加元素；
# print(info)
# del(info['name']) # 删除'name'及对应的值；
# print(info)

# 字典遍历；
# info = {'name':'sun','age':27} # key-value;
# for x in info:
#     print(x) # 打印出键--key;

# print(info.keys()) # 打印出所有的key;
# for x in info.keys():
#     print(x) # 打印出键--key;

# print(info.values()) # 打印出所有的values;
# for x in info.values():
#     print(x) # 打印出值--value;

# info = {'name':'sun','age':27} # key-value;
# for x in info.items():
#     print(x) # 打印出包含key-value对的元素(元组形式)；
#
# for k,v in info.items():
#     print(k,v) # 打印出key-value对；

# Python中的集合是一组key的集合，其中无重复的key。重复的元素被自动过滤掉。
# var = {'abc', 123, 'def', 'abc'}
#
# print(var) # {123, 'abc', 'def'}
#
# print(type(var)) # <class 'set'>;

# remove删除（var.remove(123)）；
# &：交集
# |：并集
# -：集合的差

# # 切片的格式为：[起始位置:结束位置:步长]。
# number = input("请输入字符串或数字：")
# print(number[::-1]) # 逆序打印；
#
# # 列表，元组和字典可以相互嵌套，例如：
# var = [(123, 456), {'name': 'zhangsan'}]
# print(var[0]) # (123, 456)
# print(var[1]['name']) #'zhangsan'

# 函数的定义和调用
# 定义一个函数，能够完成打印信息的功能


# def print_info():
#     """
#             函数名：print_info
#             功能：测试函数文档
#             参数：无
#             返回值：无
#     """
#
#     print('=' * 20)
#     print('abc')
#     print('=' * 20)
#
#
# print('函数外部')
# # 定义完函数后，函数是不会自动执行，需要调用它才可以
# print_info()
#
# help(print_info)

# 定义带有参数的函数

# def add_num(a, b): # a,b形参；
#     c = a + b
#     print(c)
#
#
# add_num(10, 20) # 10，20 实参；

# (设置默认参数，位置参数在前，默认参数在后(默认参数要指向不变对象！！！)，否则报错)；

# 可变参数
# def fun1(*args):
#     print('args =', args)
#     print()
#
#
# def fun2(**kwargs):
#     print('kwargs =', kwargs)
#     print()
#
#
# print('可变位置参数，组装为元组:')
# fun1()
# fun1(10, 20, 30)
#
# print('可以将数据以列表或元组的形式，整体传递:')
# data_list = [10, 20, 30]
# fun1(*data_list)
#
# print('可变关键字参数，组装为字典:')
# fun2()
# fun2(a=10, b=20, c=30)
#
# print('可以将数据以字典的形式，整体传递:')
# data_dict = {'a': 10, 'b': 20, 'c': 30}
# fun2(**data_dict)

# 局部变量，就是在函数内部定义的变量，不同的函数，可以定义相同的名字的局部变量，各自的使用不会产生影响。
# 变量的使用范围就是它的作用域，局部变量的作用域仅限于定义它的这个函数内部。

# 作用域
# 第一句全局变量num
# num = 100
#
# def func():
#     print(num)

# 第一句函数调用
# func()
# 第二句全局变量num
# num = 100
# 当全局变量和局部变量都存在时，作为局部变量使用。

# print(pow(2, 3)) # 8;
# print(round(2 / 3)) # 1;

# import math
# print(math.floor(23.5)) # 23;
# print(math.ceil(23.4)) # 24;

# from math import sqrt
# print(sqrt(9)) # 3;

# import cmath
# print(cmath.sqrt(-1)) # 1j;

# 动态绘制三角形；
# from turtle import *
# forward(100)
# left(120)
# forward(100)
# left(120)
# forward(100)

# 周长；
# import math
# radius1 = input("radius of cricle:")
# radius2 = float(radius1)
# circumference=2*math.pi*radius2
# print("circumference of circle:",circumference)

# 面积
# import math

# r = input('please input r:')
# r2 = float(r)
# s = 2 * math.pi * r2 * r2
# print(s)

# 列表；
# squares=[]
# for value in range(1,10,2):
#     squares.append(value**2)
# print(squares)

# edward = ['Edward Gumby', 42]
# john = ['John Smith', 50]
# database = [edward, john]
# print(database)

# 索引；
# string = 'Hello World!'
# print(string[1]) # e;

# 切片；
# tag = '<a href="http://www.python.org">Python web site</a>'
# print(tag[9:30]) # "http://www.python.org"

# numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
# print(numbers[3:6]) # [4, 5, 6] 切片结束于序列末尾，可省略第二个索引。
# print(numbers[-3:]) # [8, 9, 10] 切片始于序列开头，可省略第一个索引。
# print(numbers[:3]) # [1, 2, 3]  要复制整个序列，可将两个索引都省略。
# print(numbers[0:10:1]) # [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
# print(numbers[0:10:2]) # [1, 3, 5, 7, 9]
# print(numbers[0:10:-2]) # 第一个索引元素位于第二个索引元素后面，即为空；

# 序列相加
# print( [1, 2, 3] + [4, 5, 6]) # [1, 2, 3, 4, 5, 6]
# # 将序列与数x相乘时，将重复这个序列x次来创建一个新序列：
# print([10] * 5) # [10, 10, 10, 10, 10]

# sentence = input("Sentence: ")
# screen_width = 80
# text_width = len(sentence)
# box_width = text_width + 6
# left_margin = (screen_width - box_width) // 2

# print()
# print(' ' * left_margin + '+' + '-' * (box_width-2) + '+')
# print(' ' * left_margin + '| ' + ' ' * text_width + ' |')
# print(' ' * left_margin + '| ' + sentence + ' |')
# print(' ' * left_margin + '| ' + ' ' * text_width + ' |')
# print(' ' * left_margin + '+' + '-' * (box_width-2) + '+')
# print()

# 检查用户名和PIN码
# database = [
#  ['albert', '1234'],
#  ['dilbert', '4242'],
#  ['smith', '7524'],
#  ['jones', '9843']
# ]
# username = input('User name: ')
# pin = input('PIN code: ')
# if [username, pin] in database: print('Access granted')

# 长度、最小值和最大值
# numbers = [100, 34, 678]
# print(len(numbers)) # 3;
# print(max(numbers)) # 678;
# print(min(numbers)) # 34;

# 列表:函数 list;
# print(list('Hello')) # ['H', 'e', 'l', 'l', 'o'];

# 1. 修改列表：给元素赋值
# x = [1, 1, 1]
# x[1] = 2
# print(x) # [1, 2, 1];

# 2. 删除元素
# names = ['Alice', 'Beth', 'Cecil', 'Dee-Dee', 'Earl']
# del names[2] # 删除'Cecil';
# print(names) # ['Alice', 'Beth', 'Dee-Dee', 'Earl'];

# 3. 给切片赋值
# name = list('Perl')
# print(name) # ['P', 'e', 'r', 'l'];
# name[2:] = list('ar') # 将'rl'换成'ar'
# print(name) # ['P', 'e', 'r', 'l'];

# name = list('Perl')
# name[1:] = list('ython')
# print(name)

# 使用切片赋值还可在不替换原有元素的情况下插入新元素。
# numbers = [1, 5]
# numbers[1:1] = [2, 3, 4]
# print(numbers) # [1, 2, 3, 4, 5];

# 2.3.3 列表方法(2022-0119)
# 1. append;方法append用于将一个对象附加到列表末尾。
# squares = []
# for value in range(1,11,2):
#     squares.append(value**2)
# print(squares) # [1, 9, 25, 49, 81]

# 2、clear;方法clear就地清空列表的内容。
# lst = [1,2,3]
# lst.clear() 这类似于切片赋值语句lst[:] = []。
# print(lst) # [];

# 3. copy；方法 copy 复制列表。
# a = [1,2,3]
# b = a
# b[1] = 4
# print(a) # [1, 4, 3]; # 赋值后，列表a的值发生变化；
#
# a = [1,2,3]
# b = a.copy()
# b[1] = 4
# print(a) # [1, 2, 3];使用copy函数后，列表a的值不变；

# # 4. count方法count计算指定的元素在列表中出现了多少次。
# a = ['to', 'be', 'or', 'not', 'to', 'be']
# print(a.count('to')) # 2;

# 5. extend--方法extend让你能够同时将多个值附加到列表末尾，为此可将这些值组成的序列作为参数提供给方法extend。
# a = [1,2,3]
# b = [4,5,6]
# a.extend(b) # 使用extend将列表b加到列表a的后面；
# print(a) # [1, 2, 3, 4, 5, 6];

# 6. index；方法index在列表中查找指定值第一次出现的索引。
# knights = ['We', 'are', 'the', 'knights', 'who', 'say', 'ni']
# print(knights.index('say')) # 5;

# 7. insert；方法insert用于将一个对象插入列表。
# numbers = [1, 2, 3, 5, 6, 7]
# numbers.insert(3,'four')
# print(numbers) # [1, 2, 3, 'four', 5, 6, 7];

# 8. pop;方法pop从列表中删除一个元素（末尾为最后一个元素），并返回这一元素。
# numbers = [1, 2, 3, 5, 6, 7]
# numbers.pop() # 删除数字7；
# print(numbers) # [1, 2, 3, 5, 6]

# 使用pop可实现一种常见的数据结构——栈（stack）；后进先出（LIFO）；
# push和pop是大家普遍接受的两种栈操作（加入和取走）的名称。Python没有提供push，但可
# 使用append来替代。方法pop和append的效果相反，因此将刚弹出的值压入（或附加）后，得到的栈将与原来相同。
# x = [1,2,3]
# x.append(x.pop()) # 方法pop和append的效果相反;
# print(x) # x = [1,2,3];

# 9. remove;方法remove用于删除第一个为指定值的元素;
# x = ['to', 'be', 'or', 'not', 'to', 'be']
# x.remove('to')
# print(x)

# 10. reverse,方法reverse按相反的顺序排列列表中的元素;
# x = [1,2,3]
# x.reverse()
# print(x) # [3, 2, 1];

# 11. sort,方法sort用于对列表就地排序;
# x = [1,43,545,232,432,32,4,22]
# x.sort() # 从小到大排列；
# print(x) # [1, 4, 22, 32, 43, 232, 432, 545];

# 12. 高级排序；
# x = ['aardvark', 'abalone', 'acme', 'add', 'aerate']
# x.sort(key=len)
# print(x) # ['add', 'acme', 'aerate', 'abalone', 'aardvark'];

# 3.1 字符串基本操作;
# website = 'http://www.python.org'
# website[-3:] = 'com' # 报错，字符串不可变；

# 3.2 设置字符串的格式：精简版
# format = "Hello, %s. %s enough for ya?"
# values = ('world', 'Hot')
# print(format % values) # Hello, world. Hot enough for ya?

# print( "{0}, {1} and {2}".format("first", "second", "third")) # first, second and third;
# print( "{3} {0} {2} {1} {3} {0}".format("be", "not", "or", "to")) # to be or not to be;

# 3.3.1 替换字段名
# print( "{foo} {} {bar} {}".format(1, 2, bar=4, foo=3)) # 3 1 4 2;

# 3.4 字符串方法;
# 3.4.1 center--方法center通过在两边添加填充字符（默认为空格）让字符串居中。
# print( "The Middle by Jimmy Eat World".center(39)) # The Middle by Jimmy Eat World 居中；

# 3.4.2 find--方法find在字符串中查找子串。如果找到，就返回子串的第一个字符的索引，否则返回-1。
# print( 'With a moo-moo here, and a moo-moo there'.find('moo')) # 7;
# 注意 字符串方法find返回的并非布尔值。如果find像这样返回0，就意味着它在索引0处找到了指定的子串。

# 3.4.3 join--join是一个非常重要的字符串方法，其作用与split相反，用于合并序列的元素。
# seq = ['1', '2', '3', '4', '5']
# sep = '+'
# a = sep.join(seq)
# print(a) # 1+2+3+4+5;合并一个字符串列表;

# 3.4.4 lower--方法lower返回字符串的小写版本;
# print('Trondheim Hammer Dance'.lower()) # trondheim hammer dance;

# title--首字母大写；
# print('hello python world'.title()) # Hello Python World;

# 另一种方法是使用模块string中的函数capwords。
# import string
# print( string.capwords("that's all, folks")) # That's All, Folks;

# 3.4.5 replace--方法replace将指定子串都替换为另一个字符串，并返回替换后的结果。
# print( 'This is a test'.replace('is', 'eez')) # Theez eez a test;

# 3.4.6 split--split是一个非常重要的字符串方法，其作用与join相反，用于将字符串拆分为序列。
# print( '1+2+3+4+5'.split('+')) # ['1', '2', '3', '4', '5'];

# 3.4.7 strip--方法strip将字符串开头和末尾的空白（但不包括中间的空白）删除，并返回删除后的结果。
# print( ' internal whitespace is kept '.strip()) # internal whitespace is kept;

# 3.4.8 translate---方法translate与replace一样替换字符串的特定部分，但不同的是它只能进行单字符替换


# 4.2 创建和使用字典;字典由键及其相应的值组成，这种键值对称为项（item）。
phonebook = {'Alice': '2341', 'Beth': '9102', 'Cecil': '3258'}
print(phonebook['Cecil']) # 3258;

```







