# python函数；

## 一、# matplotlib

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
```

## 二、# if-else语句

```python
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
```

## 三、for循环；

```python
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
```

## 四、# 水仙花数；

```python
# 水仙花数；
# for num in range(100,1000):
#     b = num // 100 % 10
#     s = num //10 %10
#     g = num %10
#     if b**3 + s**3 +g**3 == num:
#         print(num)
```

## 五、# 打印*形矩形(嵌套循环)；

```python
# 打印*形矩形(嵌套循环)；
# h = int(input("请输入高："))
# b = int(input("请输入宽："))
# for i in range(h):
#     for j in range(b):
#         print('*',end='')
#     print()
```

## 六、#break；

```python
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
```

## 七、# continue，结束当前循环；

```python
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
```

## 八、#字符串

```python
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
```

## 九、列表、元组操作

```python
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

## 十、# 函数的定义和调用

```python
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
```

## 十一、绘制三角形、求周长及面积；

```python
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
```

## 十二、列表和元组；

```python
# 第二章 列表和元组（42）；
# 本章重点讨论其中最常用的两种： 列表和元组。
# 列表和元组的主要不同在于，列表是可以修改的，而元组不可以；

# (2022-0219)
# 列表(可改变数据类型)：添加(append:末尾添加元素,一次添加一个元素；exrend:末尾添加元素；)、插入(insert:)、修改；
a = ['qq', 111, 'abc', 'true', 'aas']
a.append('gods')  # append:末尾添加字符串,一次添加一个元素；
print(a) # ['qq', 111, 'abc', 'true', 'aas', 'gods']；
a.extend(['asd', 'qwq'])  # 在末尾添加整个列表元素；
a.extend('acsd')  # 添加单个字母；
# a.extend(20)  # 报错，int无法迭代；
a.insert(0,'ewqr') # 在索引值0前面，添加元素；
print(a) # ['ewqr', 'qq', 111, 'abc', 'true', 'aas', 'gods', 'asd', 'qwq', 'a', 'c', 's', 'd']；

# 2.2.1 索引；
greeting = 'Hello'
greeting[0] # 'H'；(-->)
greeting[-1] # 'o'；(<--)

# 2.2.2 切片；
tag = '<a href="http://www.python.org">Python web site</a>'
tag[9:30] # 'http://www.python.org'；

numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
numbers[7:10] #[8, 9, 10];
numbers[-3:-1] # [8, 9];

# 复制整个序列
numbers[:] # [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

# 步长为1；
numbers[0:10:1] # [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]；

# 步长为2；
numbers[0:10:2] # [1, 3, 5, 7, 9]；

# 2.2.3 序列相加；
[1, 2, 3] + [4, 5, 6] # [1, 2, 3, 4, 5, 6]；一般而言，不能拼接不同类型的序列。

# 2.2.4 乘法
[42] * 10  # [42, 42, 42, 42, 42, 42, 42, 42, 42, 42]；

# 2.3 列表：Python 的主力；
# 2.3.1 函数 list；
list('Hello') # ['H', 'e', 'l', 'l', 'o']；

# 2.3.2 基本的列表操作；
1. 修改列表：给元素赋值；
 x = [1, 1, 1]
 x[1] = 2  
 print(x) # [1, 2, 1]；
 
2. 删除元素；
 names = ['Alice', 'Beth', 'Cecil', 'Dee-Dee', 'Earl']
 del names[2]
 print(names) #	['Alice', 'Beth', 'Dee-Dee', 'Earl'];
    
 # 3. 给切片赋值;
 name = list('Perl')
 name[2:] = list('ar')
 print(name) # ['P', 'e', 'a', 'r'];
    
 # 2.3.3 列表方法
 # 1. append(方法append用于将一个对象附加到列表末尾。)；
 lst = [1, 2, 3]
 lst.append(4)
 print(lst) # [1, 2, 3, 4];

 # 2. clear(方法clear就地清空列表的内容);
 lst = [1, 2, 3]
 lst.clear()
 print(lst) # [];

 # 3. copy(方法 copy 复制列表,常规复制只是将另一个名称关联到列表。);
 a = [1, 2, 3]
 b = a
 b[1] = 4
 print(a) # [1, 4, 3];
    
 a = [1, 2, 3]
 b = a.copy()
 b[1] = 4
 print(a) # [1, 2, 3];
    
 # 4. count(方法count计算指定的元素在列表中出现了多少次。)
  ['to', 'be', 'or', 'not', 'to', 'be'].count('to') # 2;
    
 # 5. extend(方法extend让你能够同时将多个值附加到列表末尾);
 a = [1, 2, 3]
 b = [4, 5, 6]
 a.extend(b)
 print(a) # [1, 2, 3, 4, 5, 6]；

 # 6. index(方法index在列表中查找指定值第一次出现的索引。)
 knights = ['We', 'are', 'the', 'knights', 'who', 'say', 'ni']
 knights.index('who') # 4;
  
 # 7. insert(方法insert用于将一个对象插入列表。)
 numbers = [1, 2, 3, 5, 6, 7]
 numbers.insert(3, 'four')
 print( numbers) # [1, 2, 3, 'four', 5, 6, 7];

 # 8. pop(方法pop从列表中删除一个元素（末尾为最后一个元素），并返回这一元素。)
 x = [1, 2, 3]
 print(x.pop()) # 3;
    
 # 9. remove(方法remove用于删除第一个为指定值的元素。)
 x = ['to', 'be', 'or', 'not', 'to', 'be']
 x.remove('be')
 print(x) # ['to', 'or', 'not', 'to', 'be']；
    
 # 10. reverse(方法reverse按相反的顺序排列列表中的元素);
 x = [1, 2, 3]
 x.reverse()
 print(x) # [3, 2, 1];
    
 # 11. sort(方法sort用于对列表就地排序。)
 x = [4, 6, 2, 1, 7, 9]
 x.sort()
 print(x) # [1, 2, 4, 6, 7, 9]；
    
 # 12. 高级排序(方法sort接受两个可选参数：key和reverse。)
 x = ['aardvark', 'abalone', 'acme', 'add', 'aerate']
 x.sort(key=len)
 print(x) # ['add', 'acme', 'aerate', 'abalone', 'aardvark'];
    
 x = [4, 6, 2, 1, 7, 9]
 x.sort(reverse=True)
 print(x) # [9, 7, 6, 4, 2, 1];

 # 2.4 元组：不可修改的序列(元组是不能修改的);
  1, 2, 3 # ( 1, 2, 3)
```

## 十三、使用字符串；

```python
# 3.1 字符串基本操作
# 所有标准序列操作（索引、切片、乘法、成员资格检查、长度、最小值和最大值）都适用于字符串，但别忘了字符串是不可变的;
# 3.3.1 替换字段名;

# 3.2 设置字符串的格式：精简版
format = "Hello, %s. %s enough for ya?"
values = ('world', 'Hot')
print( format % values) # 'Hello, world. Hot enough for ya?';
# 上述格式字符串中的%s称为转换说明符，指出了要将值插入什么地方;

from math import pi
print( "{name} is approximately {value:.2f}.".format(value=pi, name="π")) # 'π is approximately 3.14.'(包含等号的参数称为关键字参数);

# 3.3 设置字符串的格式：完整版;
# 3.3.1 替换字段名;
# 将按顺序将字段和参数配对;
print( "{foo} {} {bar} {}".format(1, 2, bar=4, foo=3)) # '3 1 4 2';

# 3.3.2 基本转换;
print( print("{pi!s} {pi!r} {pi!a}".format(pi="π"))) # π 'π' '\u03c0';# 上述三个标志（s、r和a）指定分别使用str、repr和ascii进行转换;
# 你还可指定要转换的值是哪种类型，更准确地说，是要将其视为哪种类型。例如，你可能提供一个整数，但将其作为小数进行处理。为此可在格式说明（即冒号后面）使用字符f（表示定点数）;
"The number is {num}".format(num=42) # 'The number is 42';
"The number is {num:f}".format(num=42) # 'The number is 42.000000';
 
# 字符串格式设置中的类型说明符;
b 将整数表示为二进制数
c 将整数解读为Unicode码点
d 将整数视为十进制数进行处理，这是整数默认使用的说明符
e 使用科学表示法来表示小数（用e来表示指数）
E 与e相同，但使用E来表示指数
f 将小数表示为定点数
F 与f相同，但对于特殊值（nan和inf），使用大写表示
g 自动在定点表示法和科学表示法之间做出选择。这是默认用于小数的说明符，但在默认情况下至少有1位小数
G 与g相同，但使用大写来表示指数和特殊值
n 与g相同，但插入随区域而异的数字分隔符
o 将整数表示为八进制数
s 保持字符串的格式不变，这是默认用于字符串的说明符
x 将整数表示为十六进制数并使用小写字母
X 与x相同，但使用大写字母
% 将数表示为百分比值（乘以100，按说明符f设置格式，再在后面加上%）

# 3.3.3 宽度、精度和千位分隔符;
# 设置浮点数（或其他更具体的小数类型）的格式时，默认在小数点后面显示6位小数，并根据需要设置字段的宽度，而不进行任何形式的填充。
# 宽度是使用整数指定的;
"{num:10}".format(num=3) # '          3';
"{name:10}".format(name="Bob") # 'Bob          ';
# 精度也是使用整数指定的，但需要在它前面加上一个表示小数点的句点。;
"Pi day is {pi:.2f}".format(pi=pi) # 'Pi day is 3.14';
# 最后，可使用逗号来指出你要添加千位分隔符;
'One googol is {:,}'.format(10**100) # 'One googol is 10,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,00 0,000,000,000,000,000,000,000,000,000,000,000,000,000,000'
 
# 3.3.4 符号、对齐和用 0 填充;
# 3.4 字符串方法;
# 3.4.1 center--(方法center通过在两边添加填充字符（默认为空格）让字符串居中。);
print("The Middle by Jimmy Eat World".center(39)) # ' The Middle by Jimmy Eat World ';
print( "The Middle by Jimmy Eat World".center(39, "*")) # '*****The Middle by Jimmy Eat World*****';

# 3.4.2 find(方法find在字符串中查找子串。如果找到，就返回子串的第一个字符的索引，否则返回-1。);
print( 'With a moo-moo here, and a moo-moo there'.find('moo')) # 7;
# 注意 字符串方法find返回的并非布尔值。如果find像这样返回0，就意味着它在索引0处找到了指定的子串。;

# 3.4.3 join--(join是一个非常重要的字符串方法，其作用与split相反，用于合并序列的元素。);
seq = ['1', '2', '3', '4', '5']
print(sep.join(seq)) # (1+2+3+4+5')--合并一个字符串列表;

# 3.4.4 lower--(方法lower返回字符串的小写版本)。
print('Trondheim Hammer Dance'.lower()) #  trondheim hammer dance';
# 一个与lower相关的方法是title（参见附录B）。它将字符串转换为词首大写，即所有单词的首字母都大写，其他字母都小写。
print("that's all folks".title()) # "That'S All, Folks";
# 另一种大写方法是使用模块string中的函数capwords。
import string
print(string.capwords("that's all, folks")) # That's All, Folks";

# 3.4.5 replace--(方法replace将指定子串都替换为另一个字符串，并返回替换后的结果。)
print('This is a test'.replace('is', 'eez')) # 'Theez eez a test';

# 3.4.6 split--(split是一个非常重要的字符串方法，其作用与join相反，用于将字符串拆分为序列。)
print( '1+2+3+4+5'.split('+')) # ['1', '2', '3', '4', '5'];

# 3.4.7 strip--(方法strip将字符串开头和末尾的空白（但不包括中间的空白）删除，并返回删除后的结果。)
print( ' internal whitespace is kept '.strip()) # 'internal whitespace is kept'

# 3.4.8 translate--(方法translate与replace一样替换字符串的特定部分，但不同的是它只能进行单字符替换。使用translate前必须创建一个转换表)
table = str.maketrans('cs', 'kz')  # (c-->k;s-->z);
print('this is an incredible test'.translate(table)) # 'thiz iz an inkredible tezt';( (c-->k;s-->z))

# 3.4.9 判断字符串是否满足特定的条件
# 3.5 小结
# 函数；
string.capwords(s[, sep]) # 使用split根据sep拆分s，将每项的首字母大写，再以空格为分隔符将它们合并起来;
ascii(obj) # 创建指定对象的ASCII表示;
```

## 十四、当索引行不通时；

```python
# 4.1 字典的用途(73);
# 字典的名称指出了这种数据结构的用途；
# 4.2 创建和使用字典；
# 字典由键及其相应的值组成，这种键值对称为项（item）；

phonebook = {'Alice': '2341', 'Beth': '9102', 'Cecil': '3258'}
print(phonebook['Cecil']) # 3258;
# 注意 在字典（以及其他映射类型）中，键必须是独一无二的，而字典中的值无需如此；

# 4.2.1 函数 dict；
# 可使用函数dict①从其他映射（如其他字典）或键值对序列创建字典。
{'age': 42, 'name': 'Gumby'}
print(d['name']) # 'Gumby';

# 还可使用关键字实参来调用这个函数，如下所示：
d = dict(name='Gumby', age=42)
print(d) # {'age': 42, 'name': 'Gumby'};

# 4.2.2 基本的字典操作;
 len(d)返回字典d包含的项（键值对）数。
 d[k]返回与键k相关联的值。
 d[k] = v将值v关联到键k。
 del d[k]删除键为k的项。
 k in d检查字典d是否包含键为k的项

# 4.2.3 将字符串格式设置功能用于字典;
# 必须使用format_map来指出你将通过一个映射来提供所需的信息。;
phonebook = {'Alice': '2341', 'Beth': '9102', 'Cecil': '3258'}
"Cecil's phone number is {Cecil}.".format_map(phonebook) # "Cecil's phone number is 3258.";

# 4.2.4 字典方法;
# 1. clear--(方法clear删除所有的字典项，这种操作是就地执行的（就像list.sort一样），因此什么都不返回（返回None）。)
phonebook = {'Alice': '2341', 'Beth': '9102', 'Cecil': '3258'}
returned_value = d.clear()
print(d) # {};

# 2. copy(方法copy返回一个新字典，其包含的键值对与原来的字典相同（这个方法执行的是浅复制，因为值本身是原件，而非副本）。)
x = {'username': 'admin', 'machines': ['foo', 'bar', 'baz']}
y = x.copy()
y['username'] = 'mlh'
y['machines'].remove('bar')
print(y) # {'username': 'mlh', 'machines': ['foo', 'baz']}；
print(x) # {'username': 'admin', 'machines': ['foo', 'baz']};

# 为了避免如果修改副本中的值（就地修改而不是替换），原件也将发生变化，一种办法是执行深复制；
from copy import deepcopy
d = {}
d['names'] = ['Alfred', 'Bertrand']
c = d.copy()
dc = deepcopy(d)
d['names'].append('Clive')
print(c) # {'names': ['Alfred', 'Bertrand', 'Clive']};
print(dc) # {'names': ['Alfred', 'Bertrand']};

# 3. fromkeys(方法fromkeys创建一个新字典，其中包含指定的键，且每个键对应的值都是None。);
{}.fromkeys(['name', 'age']) # {'age';: None, 'name': None};

# 4. get(方法get为访问字典项提供了宽松的环境。);
d['name'] = 'Eric'
d.get('name') # 'Eric';

# 5. items(方法items返回一个包含所有字典项的列表，其中每个元素都为(key, value)的形式。)
d = {'title': 'Python Web Site', 'url': 'http://www.python.org', 'spam': 0}
d.items() # dict_items([('url', 'http://www.python.org'), ('spam', 0), ('title', 'Python Web Site')])

# 6. keys(方法keys返回一个字典视图，其中包含指定字典中的键。)
# 7. pop(方法pop可用于获取与指定键相关联的值，并将该键值对从字典中删除。)
d = {'x': 1, 'y': 2}
print( d.pop('x')) # 1;
print(d) # {'y': 2};
# 8. popitem(方法popitem类似于list.pop，但list.pop弹出列表中的最后一个元素，而popitem随机地弹出一个字典项，因为字典项的顺序是不确定的);
d = {'url': 'http://www.python.org', 'spam': 0, 'title': 'Python Web Site'}
d.popitem() # ('url', 'http://www.python.org');
print(d) # {'spam': 0, 'title': 'Python Web Site'}；

# 9. setdefault（方法setdefault有点像get，因为它也获取与指定键相关联的值，但除此之外，setdefault还在字典不包含指定的键时，在字典中添加指定的键-值对。)
d = {}
d.setdefault('name', 'N/A') # {'name': 'N/A'};
# 10. update（方法update使用一个字典中的项来更新另一个字典）；
# 11. values（方法values返回一个由字典中的值组成的字典视图。不同于方法keys，方法values返回的视图可能包含重复的值。);
d = {}
d[1] = 1
d[2] = 2
d[3] = 3
d[1] = 1
print(d.values()) # dict_values([1, 2, 3, 1]);
```

## 十五、条件、循环及其他语句；

```python
# 字符串是根据字符的字母排列顺序进行比较的。
>>> "alpha" < "beta" 
True
# 5.1 再谈 print 和 import;
# 提示 对很多应用程序来说，使用模块logging来写入日志比使用print更合适，详情请参阅第19章。
# 5.1.1 打印多个参数；(可同时打印多个表达式)
print('Age:', 42) # (Age: 42);

name = 'Gumby' 
salutation = 'Mr.' 
greeting = 'Hello,' 
print(greeting, salutation, name) # Hello, Mr. Gumby;

# 5.1.2 导入时重命名;
# 在语句末尾添加as子句并指定别名。
import math as foobar 
foobar.sqrt(4) # 2;

# 下面是一个导入特定函数并给它指定别名的例子：
from math import sqrt as foobar 
foobar(4) # 2;

# 5.2 赋值魔法;
# 5.2.1 序列解包
# 可同时（并行）给多个变量赋值;
x, y, z = 1, 2, 3 
print(x, y, z) # (1,2,3)

# 使用方法popitem，它随便获取一个键-值对并以元组的方式返回。
scoundrel = {'name': 'Robin', 'girlfriend': 'Marion'} 
key, value = scoundrel.popitem() 
print(key) #'girlfriend' 
print(value) # 'Marion'

# 可使用星号运算符（*）来收集多余的值，这样无需确保值和变量的个数相同，如下例所示：
a, b, *rest = [1, 2, 3, 4] # 带星号的变量最终包含的总是一个列表;
print(rest) # [3, 4]);

# 5.2.2 链式赋值(链式赋值是一种快捷方式，用于将多个变量关联到同一个值);
x = y = somefunction() 
# 上述代码与下面的代码等价：
y = somefunction() 
x = y

# 5.2.3 增强赋值;
# 代码x = x + 1 改为：x += 1。这称为增强赋值；

# 5.3 代码块：缩进的乐趣；
# 代码块是一组语句，可在满足条件时执行（if语句），可执行多次（循环），等等。代码块是通过缩进代码（即在前面加空格）来创建的。
# 5.4 条件和条件语句；
# 5.4.1 这正是布尔值的用武之地；
# 标准真值为0（表示假）和1（表示真）；

# 5.4.2 有条件地执行和 if 语句；
name = input('What is your name? ') 
if name.endswith('Gumby'): 
 print('Hello, Mr. Gumby')
# 这就是if语句，让你能够有条件地执行代码。这意味着如果条件（if和冒号之间的表达式）为前面定义的真，就执行后续代码块（这里是一条print语句）；如果条件为假，就不执行；

# 5.4.3 else 子句；
name = input('What is your name?') 
if name.endswith('Gumby'): 
 print('Hello, Mr. Gumby') 
else: 
 print('Hello, stranger')

# 还有一个与if语句很像的“亲戚”，它就是条件表达式——C语言中三目运算符的Python版本。
status = "friend" if name.endswith("Gumby") else "stranger"
# 如果条件（紧跟在if后面）为真，表达式的结果为提供的第一个值（这里为"friend"），否则为第二个值（这里为"stranger"）。

# 5.4.4 elif 子句；
num = int(input('Enter a number: ')) 
if num > 0: 
 print('The number is positive') 
elif num < 0: 
 print('The number is negative') 
else: 
 print('The number is zero')

# 5.4.5 代码块嵌套；
name = input('What is your name? ') 
if name.endswith('Gumby'): 
 if name.startswith('Mr.'): 
 print('Hello, Mr. Gumby') 
 elif name.startswith('Mrs.'): 
 print('Hello, Mrs. Gumby') 
 else: 
 print('Hello, Gumby') 
else: 
 print('Hello, stranger')

# 5.4.6 更复杂的条件；
# 1. 比较运算符；
x == y x 等于y
x < y x小于y
x > y x大于y
x >= y x大于或等于y
x <= y x小于或等于y
x != y x不等于y
x is y x和y是同一个对象
x is not y x和y是不同的对象
x in y x是容器（如序列）y的成员
x not in y x不是容器（如序列）y的成员

#  相等运算符；要确定两个对象是否相等，可使用比较运算符，用两个等号（==）表示。一个等号是赋值运算符，用于修改值，而进行比较时你可不想这样做。
>>> x == y 
True 
>>> x is y 
False
# 显然，这两个列表相等但不相同。；
# 总之，==用来检查两个对象是否相等，而is用来检查两个对象是否相同（是同一个对象）。

#  in：成员资格运算符；
name = input('What is your name?') 
if 's' in name:
    print('Your name contains the letter "s".') 
else: 
 print('Your name does not contain the letter "s".')

#  字符串和序列的比较；
# 字符串是根据字符的字母排列顺序进行比较的。
>>> "alpha" < "beta" 
True

# 2. 布尔运算符；(编写一个程序，让它读取一个数，并检查这个数是否位于1～10（含）。)
number = int(input('Enter a number between 1 and 10: ')) 
if number <= 10 and number >= 1: 
 print('Great!') 
else: 
 print('Wrong!')
# 5.4.7 断言;
# 基本上，你可要求某些条件得到满足（如核实函数参数满足要求或为初始测试和调试提供帮助），为此可在语句中使用关键字assert。
>>> age = 10 
>>> assert 0 < age < 100 
>>> age = -1 
>>> assert 0 < age < 100 
Traceback (most recent call last): 
 File "<stdin>", line 1, in ? 
AssertionError

# 5.5 循环;
# 5.5.1 while 循环;
x = 1 
while x <= 100: 
 print(x) 
 x += 1 # (1-100);
    
# 你还可以使用循环来确保用户输入名字，如下所示：
name = '' 
while not name: 
 name = input('Please enter your name: ') 
print('Hello, {}!'.format(name))

# 5.5.2 for 循环;
# 可迭代对象是可使用for循环进行遍历的对象;
numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9] 
for number in numbers: 
 print(number) # (0-9);

# 提示 只要能够使用for循环，就不要使用while循环。;
# 5.5.3 迭代字典;
# 要遍历字典的所有关键字，可像遍历序列那样使用普通的for语句。
d = {'x': 1, 'y': 2, 'z': 3} 
for key in d: 
 print(key, 'corresponds to', d[key]) 
# x corresponds to 1
# y corresponds to 2
# z corresponds to 3

# 5.5.4 一些迭代工具;
# 1. 并行迭代--有时候，你可能想同时迭代两个序列。假设有下面两个列表：
names = ['anne', 'beth', 'george', 'damon'] 
ages = [12, 45, 32, 102] 
# 如果要打印名字和对应的年龄，可以像下面这样做：
for i in range(len(names)): 
 print(names[i], 'is', ages[i], 'years old') 
# anne is 12 years old
# beth is 45 years old
# george is 32 years old
# damon is 102 years old

# 可使用list将其转换为列表。
names = ['anne', 'beth', 'george', 'damon'] 
ages = [12, 45, 32, 102] 
list(zip(names, ages)) 
for name, age in zip(names, ages): 
 print(name, 'is', age, 'years old')
[('anne', 12), ('beth', 45), ('george', 32), ('damon', 102)]
# anne is 12 years old
# beth is 45 years old
# george is 32 years old
# damon is 102 years old

# 2. 迭代时获取索引;
# 是使用内置函数enumerate。
for index, string in enumerate(strings): 
 if 'xxx' in string: 
 strings[index] = '[censored]'

# 3. 反向迭代和排序后再迭代；
# 来看另外两个很有用的函数：reversed(逆序打印)和sorted(从小到大排序)
>>> sorted([4, 3, 6, 8, 3]) 
[3, 3, 4, 6, 8]

>>> list(reversed('Hello, world!')) 
['!', 'd', 'l', 'r', 'o', 'w', ' ', ',', 'o', 'l', 'l', 'e', 'H']

# 提示 要按字母表排序，可先转换为小写。为此，可将sort或sorted的key参数设置为str.lower。例如，sorted("aBc", key=str.lower)返回['a', 'B', 'c']。

# 5.5.5 跳出循环；
# 1. break
# 要结束（跳出）循环，可使用break。假设你要找出小于100的最大平方值（整数与自己相乘的结果），可从100开始向下迭代。
from math import sqrt 
for n in range(99, 0, -1): 
 root = sqrt(n) 
 if root == int(root): 
 	print(n) # 81；
 	break
    
# 如果你运行这个程序，它将打印81并结束。注意到我向range传递了第三个参数——步长，
# 即序列中相邻数的差。通过将步长设置为负数，可让range向下迭代，如上面的示例所示；还可让它跳过一些数：   
print(list(range(0, 10, 2))) # [0, 2, 4, 6, 8]；

# 2. continue (语句continue没有break用得多。它结束当前迭代，并跳到下一次迭代开头。);
# 3. while True/break成例
word = 'dummy' 
while word: 
 word = input('Please enter a word: ') 
 # 使用这个单词做些事情：
 print('The word was', word)

# 使用成例while True/break。
while True: 
 word = input('Please enter a word: ') 
 if not word: break 
 # 使用这个单词做些事情：
 print('The word was ', word)
    
# 5.5.6 循环中的 else 子句;
from math import sqrt 
for n in range(99, 81, -1): 
 	root = sqrt(n) 
 	if root == int(root): 
 	print(n) 
 	break 
else: 
 print("Didn't find it!")

# 5.6 简单推导;
print([x * x for x in range(10)]) # [0, 1, 4, 9, 16, 25, 36, 49, 64, 81];
# 5.7 三人行-(pass、del和exec。);
# 5.7.1 什么都不做--(pass);
# 5.7.2 使用 del 删除
# 5.7.3 使用 exec 和 eval 执行字符串及计算其结果
# 1. exec (函数exec将字符串作为代码执行。)
>>> exec("print('Hello, world!')") 
Hello, world!

# 2. eval (eval是一个类似于exec的内置函数。)
>>> scope = {} 
>>> scope['x'] = 2 
>>> scope['y'] = 3 
>>> eval('x * y', scope) 
6
# 5.8.1 本章介绍的新函数
chr(n) # 返回一个字符串，其中只包含一个字符，这个字符对应于传入的顺序值n（0 ≤
n < 256）
eval(source[,globals[,locals]]) # 计算并返回字符串表示的表达式的结果
exec(source[, globals[, locals]]) # 将字符串作为语句执行
enumerate(seq) # 生成可迭代的索引值对
ord(c) # 接受一个只包含一个字符的字符串，并返回这个字符的顺序值（一个整数）
range([start,] stop[, step]) # 创建一个由整数组成的列表
reversed(seq) # 按相反的顺序返回seq中的值，以便用于迭代
sorted(seq[,cmp][,key][,reverse]) # 返回一个列表，其中包含seq中的所有值且这些值是经过排序的
xrange([start,] stop[, step]) # 创建一个用于迭代的xrange对象
zip(seq1, seq2,...) # 创建一个适合用于并行迭代的新序列
```

## 十六、抽象；

```python
# 6.1 懒惰是一种美德;
# 计算一些斐波那契数;
fibs = [0, 1] 
for i in range(8): 
 fibs.append(fibs[-2] + fibs[-1])
print(fibs) # [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];

# 6.2 抽象和结构;
# 6.3 自定义函数;
def fibs(num): 
 result = [0, 1] 
 for i in range(num-2): 
 	result.append(result[-2] + result[-1]) 
 return result

>>> fibs(10) 
[0, 1, 1, 2, 3, 5, 8, 13, 21, 34]

# 6.3.1 给函数编写文档;
# 6.3.2 其实并不是函数的函数
# 6.4 参数魔法
# 6.4.1 值从哪里来;
# 在def语句中，位于函数名后面的变量通常称为形参，而调用函数时提供的值称为实参;
# 6.4.2 我能修改参数吗
>>> def try_to_change(n): 
... n = 'Mr. Gumby' 
... 
>>> name = 'Mrs. Entity' 
>>> try_to_change(name) 
>>> name 
'Mrs. Entity'

# 6.4.3 关键字参数和默认值;
# 有时候，参数的排列顺序可能难以记住，尤其是参数很多时。为了简化调用工作，可指定参数的名称。
>>> hello_1(greeting='Hello', name='world') 
Hello, world! 
# 在这里，参数的顺序无关紧要。
>>> hello_1(name='world', greeting='Hello') 
Hello, world!
# 像这样使用名称指定的参数称为关键字参数，主要优点是有助于澄清各个参数的作用;
# 6.4.4 收集参数;
# 6.4.5 分配参数;
# 6.4.6 练习使用参数;
def story(**kwds): 
 return 'Once upon a time, there was a ' \ 
 '{job} called {name}.'.format_map(kwds) 
    
def power(x, y, *others): 
 if others: 
 	print('Received redundant parameters:', others) 
 return pow(x, y) 

def interval(start, stop=None, step=1): 
 'Imitates range() for step > 0' 
 if stop is None: # 如果没有给参数stop指定值，
 	start, stop = 0, start # 就调整参数start和stop的值
 result = [] 
 i = start # 从start开始往上数
 while i < stop: # 数到stop位置
 	result.append(i) # 将当前数的数附加到result末尾
 i += step # 增加到当前数和step（> 0）之和
 return result

# 6.5 作用域;
# 有一个名为vars的内置函数，它返回这个不可见的字典;
>>> x = 1 
>>> scope = vars() 
>>> scope['x'] 
1 
>>> scope['x'] += 1 
>>> x 
2

# 6.6 递归;
# 简单地说，递归意味着引用（这里是调用）自身。
# 6.6.1 两个经典案例：阶乘和幂;
# n的阶乘为n × (n-1) × (n-2) × … × 1，在数学领域的用途非常广泛
def factorial(n):
 result = n
 for i in range(1, n):
 	result *= i
 return result
print(factorial(3)) # 1*2*3=6;

# power(x, n)（x的n次幂）是将数字x自乘n - 1次的结果，即将n个x相乘的结果;
def power(x, n): 
 result = 1 
 for i in range(n): 
 	result *= x 
 return result
print(power(2, 1)) # 2;

# 6.6.2 另一个经典案例：二分查找;
# 6.7 小结;
# 6.7.1 本章介绍的新函数;
map(func, seq[, seq, ...]) # 对序列中的所有元素执行函数
filter(func, seq) # 返回一个列表，其中包含对其执行函数时结果为真的所有元素
reduce(func, seq[, initial]) # 等价于 func(func(func(seq[0], seq[1]), seq[2]), ...)
sum(seq) # 返回 seq 中所有元素的和
apply(func[, args[, kwargs]]) # 调用函数（还提供要传递给函数的参数）
```

## 十七、再谈抽象；

```python
# 7.1 对象魔法；
# 7.1.1 多态；
# 7.1.2 多态和方法；
>>> object.get_price() 
2.5 # 像这样与对象属性相关联的函数称为方法；
>>> from random import choice 
>>> x = choice(['Hello, world!', [1, 2, 'e', 'e', 4]])
>>> x.count('e') 
2



```





