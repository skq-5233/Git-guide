# C#概述笔记

## C#的五大数据类型：

**1）类（Class; 如Windows,Form,Console,String,etc）；**

**2）结构体（Structures;  如int32,int64,Single,Double,etc）；**

**3）枚举（Enumeration; 如Horizontal,Alignment,Visibility ,etc）；**

**4）接口（interfaces）；**

**5）委托（Delegates）;**

## C# -功能键：

**1、工具-->选项--->文本编辑器-->所有语言-->常规-->行号；**

**2、工具-->选项--->环境-->字体和颜色-->字体（Consolas）；**

**3、解决方案-->属性-->当前选定内容（执行多个解决方案时）；**

## C# -语法：

 **1、match_area_img_out = match_area_img_1.Convert<Gray, Byte>();//（将match_area_img_1转化为灰度图）;(image定义的图像通过Convert转化为灰度图);**

**2、int count1 = Convert.ToInt32(textBox1.Text);  //string类型转换int类型，并利用textBox自动调整大小；**

**3、 displab1.Text = "面积:  " + area.ToString();   //打印信匹配信息；**

**4、 double num1 = Convert.ToDouble(textBox2.Text);//实现string类型到double类型的转换;**              

**5、   使用变量前，需定义变量类型和变量名；**

**6、 myString = "\\"myInteger\\"  is";//(\n换行符；\\"转义符；\\\转义符);**

**7、Console.WriteLine("{0} {1}.", myString, myInteger);//{0} {1}占位符；**

**8、变量名的第一个字符必须要是字母、下划线_、或@；其后字母可以是数字、字母、下划线；**

**9、PascalCase命名：首字母大写，其余小写(namespace名称空间剔除通常使用PascalCase命名法)；camelCase命名：第一个单词小写，其余大写；**

**10、int myInteger;//camel变量命名（首单词小写，后续单词首字母大写）； string myString;//camel变量命名（首单词小写，后续单词首字母大写）；**

**11、int age,height,weight;(同时定义多个相同类型的变量)；**        

**12、 int age=18,height=175,weight=60;(同时定义多个相同类型的变量，并赋值)；**

**13、 match_area_img_1 = match_area_img.AbsDiff(temp);//(1220-add,temp\match_area_img绝对值差值，图像差值绝对值)；**

**14、逻辑运算符中，有这么四类：&&（短路与），&（与），|（或），||（短路或）。&、|、是位操作符，而&&、||、是逻辑操作！。**

**&&和&都是表示与，区别是&&只要第一个条件是false，后面条件就不再判断（无论后面条件是什么，结果都是false）。||和|都是表示“或”，区别是||只要满足第一个条件是true，后面的条件就不再判断（无论后面条件是什么，结果都是true）。而&、|要对所有的条件进行判断。**

**（注：作为经验法则，使用&&（短路与）、||（短路或）性能会有一定提升，故尽可能使用&&（短路与）、||（短路或））。**

15、 

## C# -快捷键：

**1、Ctrl+k+c:批量注释代码（ /*、、、*/多行注释；//注释内容； ///文本注释///）；Ctrl+k+u:批量取消注释代码；**

**2、F5:调试运行，Ctrl+F5:非调试运行；F10,逐渐过程；F11，逐语句；**

**3、Ctrl+Shift+N:新建项目；**

**4、#region、#endregion（添加在代码开头、结尾，用于折叠、展开代码）；**

**5、选中几行代码,然后使用 Tab (整体左移)或 Shift+Tab(整体右移) 操作；**

## C#之Hello World

## ##console(控制台应用程序)##

```c#
Console.WriteLine("Hello World");

Console.ReadKey();
```

![image-20211218102330035](C:\Users\eivision\AppData\Roaming\Typora\typora-user-images\image-20211218102330035.png)

## **创建.NET应用程序的步骤：**

**C#代码---->编译为（CIL）--->存储在程序集中----->通过JIT编译器将代码编译为本机代码。**

## C#应用程序：

### 1）控制台（Console）应用程序；

### 2）Windows窗体应用程序（WinForm）;(可设计图形界面)

## C# -Console-逻辑运算符：

```c#
//关系、逻辑运算符；
Console.WriteLine("Hello C# World!");//打印Hello C# World!;
Console.ReadKey();
Console.WriteLine("请输入你的语文成绩：");
//string str_chinese = Console.ReadLine();
//int chinese = Convert.ToInt32(str_chinese);//将字符串str_chinese转化为整型chinese(int32);
double chinese = Convert.ToDouble(Console.ReadLine());//结果同上两行代码一样；
//double chinese = Convert.ToDouble(str_chinese);//将字符串str_chinese转化为双精度浮点型chinese(double);
Console.WriteLine("请输入你的数学成绩：");
string str_math = Console.ReadLine();
//int math = Convert.ToInt32(str_math);//将字符串str_math转化为整型math(int32);
double math = Convert.ToDouble(str_math);//将字符串str_math转化为双精度浮点型math(double);
Console.WriteLine("请输入你的英语成绩：");
string str_english = Console.ReadLine();
//int english = Convert.ToInt32(str_english);//将字符串str_english转化为整型english(int32);
double english  = Convert.ToDouble(str_english);//将字符串str_english转化为双精度浮点型english(double);
double sum = chinese + math + english;
double avg = sum / 3;
Console.WriteLine("你的三大科总成绩是{0}，平均成绩是{1}",sum,avg);
Console.ReadKey();
bool b = chinese > 90 && math > 90 && english > 90;//逻辑与（bool类型）；
Console.WriteLine(b);
Console.ReadKey();
bool b1 = chinese > 90 || math > 90 || english > 90;//逻辑或（bool类型）；
Console.WriteLine(b1);
Console.ReadKey();
bool b2 = chinese != 90;//逻辑非（bool类型）；
Console.WriteLine(b2);
//add(2021-1222)
```

```c#
Typota整体代码左移，Ctrl+[;整体代码右移,Ctrl+];
//add算数运算符(2021-1223)
double chinese, math;
string name;
Console.WriteLine("请输入你的名字：");
name = Console.ReadLine();
Console.WriteLine("你好！{0}，欢迎你！！！",name);
Console.WriteLine("请输入你的语文成绩：");
chinese = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入你的数学成绩：");
math = Convert.ToDouble(Console.ReadLine());
double sum = chinese + math; 
Console.WriteLine("你的考试总成绩为：{0}",sum);
double sub =Math.Abs(chinese-math);
double avg = sum / 2;
Console.WriteLine("你的语文、数学平均成绩为{0}",avg);
Console.WriteLine("你的语文、数学成绩差值为：{0}",sub);
double product = chinese * math;
Console.WriteLine("你的语文、数学成绩乘积值为:{0}",product);
double divide = chinese / math;
Console.WriteLine("你的语文成绩是数学成绩的{0}倍",divide);
double divide1= chinese % math;
Console.WriteLine("你的语文成绩除数学成绩的余数为{0}",divide1);
Console.ReadKey();
//add(2021-1223)
```

```c#
//判断年份是否为闰年(2021-1223)；
//int year;
Console.WriteLine("请输入要判断的年份：");
int year = Convert.ToInt32(Console.ReadLine());
bool b = (year % 400) == 0 || (year % 4 == 0 && year % 100 != 0);//逻辑与的优先级妖高于逻辑或；
Console.WriteLine(b);
//使用 if esle判断语句；
if (b == true)
{
    Console.WriteLine("{0}是闰年",year);
}
else
{
    Console.WriteLine("{0}是平年",year);
}

Console.ReadKey();
//add(2021-1223)
```

```c#
//编写一个控制台应用程序，要求用户输入4个int值，并显示它们的乘积。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Chapter3_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //算数运算符；
            int a, b1, c, d;
            Console.WriteLine("请输入4个数值：");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a的值是{0}", a);

            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b1的值是{0}",b1);

            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c的值是{0}",c);

            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d的值是{0}",d);

            double product = a * b1 * c * d; 

            Console.WriteLine("所有数值的乘积结果是：{0}", product);
            Console.ReadKey();
        }
    }
}
//add(2021-1223)
```

```c#
//add(2021-1227，面积筛选)
//遍历完所有面积，打印总面积；
double sum_area = 0;
int ksize = contours.Size;//获取连通区域的个数；
for (int i = 0; i < ksize; i++)//遍历每个连通轮廓；
{
    VectorOfPoint contour = contours[i];//获取独立的连通轮廓；
    double area = CvInvoke.ContourArea(contour);//计算连通轮廓的面积；

    double area1 = Convert.ToDouble(textBox2.Text);//实现string类型到double类型的转换;
    //add(2021-1227,当输入面积小于0时，area==0);
    if (area1 <= 0)
    {
        area1 = 0;
    }
    //add(2021-1227,当输入面积小于0时，num1==0);

    //add(2021-1227，当轮廓面积大于阈值面积时，才执行下列语句，实现面积相加，否则跳出条件语句）；
    if (area > area1)//对每一轮廓区域面积进行面积筛选；                                
    {

        use_contours.Push(contour);//添加筛选后的连通轮廓；
        sum_area += area;//遍历结果相加；

    }

}
//add(2021-1227)
```

```c#
//add(2021-1227,num>255,num=255;num<0,num=0);
int num = Convert.ToInt32(textBox1.Text);//实现string类型到int类型的转换;
if (num > 255)
{
    num = 255;
}
if (num <=0)
{
    num = 0;
}
//add(2021-1227,num>255,num=255;num<0,num=0);
CvInvoke.Threshold(binary_img, binary, num, 255, Emgu.CV.CvEnum.ThresholdType.Binary);//num自适应调节;
pictureBox5.Image = binary.ToImage<Gray, byte>().ToBitmap();
corrosion_img = binary;
//add(2021-1227,num>255,num=255;num<0,num=0);
```

```c#
//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);
CvInvoke.MatchTemplate(match_img, temp, result, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像；
//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);
```

