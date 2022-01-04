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

## console(控制台应用程序)

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

## //判断年份是否为闰年(2021-1223)；

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

## //编写一个控制台应用程序，算数运算符；。add(2021-1223)

```c#
//编写一个控制台应用程序，要求用户输入4个int值，并显示它们的乘积add(2021-1223)。
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

## //add(2021-1227，面积筛选)；遍历完所有面积，打印总面积；

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

## //add(2021-1227,num>255,num=255;num<0,num=0)（控制像素值在0-255）;

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

## //add(2021-1217，面积筛选，将默认面积area1 <= 0的情况，直接赋值为0)；

```c#
//add(2021-1217，面积筛选)
//遍历完所有面积，打印总面积；
double sum_area = 0;
int ksize = contours.Size;//获取连通区域的个数；
for (int i = 0; i < ksize; i++)//遍历每个连通轮廓；
{
VectorOfPoint contour = contours[i];//获取独立的连通轮廓；
double area = CvInvoke.ContourArea(contour);//计算连通轮廓的面积；

double area1 = Convert.ToDouble(textBox4.Text);//实现string类型到double类型的转换;
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
//add(2021-1217，面积筛选)
```

## //add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);

```c#
//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);
CvInvoke.MatchTemplate(match_img, temp, result, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像；
//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);
```

## //add(2021-1228，自适应手动调整腐蚀次数，默认腐蚀次数为1)；

```c#
//add(2021-1228，自适应手动调整腐蚀次数，默认腐蚀次数为1)；
 private void erode_Click(object sender, EventArgs e)
{
//腐蚀;Tab (代码整体左移)或 Shift+Tab(代码整体右移) ；
#region
//corrosion_img = binary_img.Copy();// 将二值化结果binary_img复制到corrosion_img;           

//try
//{
//    //binary_img = img3.Copy();//将模板图像temp-匹配区域imge2的差运算结果拷贝到binary_img;                
//    //int count1 = Convert.ToInt32(textBox1.Text); ; //string类型转换int类型
//    int num = Convert.ToInt32(textBox1.Text);//实现string类型到int类型的转换;
//    CvInvoke.Threshold(binary_img, binary, num, 255, Emgu.CV.CvEnum.ThresholdType.Binary);//num自适应调节;
//    //pictureBox5.Image = binary.ToImage<Gray, byte>().ToBitmap();
//}
//catch (System.Exception ex)
//{
//    MessageBox.Show("  格式错误，请输入整型！");
//}     
#endregion
    
Mat struct_element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));//指定参数获得结构元素；
//指定参数进行形态学开（先腐蚀后膨胀）操作，（3：腐蚀迭代次数）；
//CvInvoke.MorphologyEx(corrosion_img,corrosion1,Emgu.CV.CvEnum.MorphOp.Open, struct_element, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));//new Point(-1, -1),表示结构元素中心，3，表示形态学开运算中腐蚀迭代次数；

//add(2021-1228，自适应手动调整腐蚀次数，默认腐蚀次数为1)；
int erode_num = Convert.ToInt32(textBox2.Text);//实现string类型到int类型转换（默认腐蚀次数erode_num=1，点击一次腐蚀一次）；
CvInvoke.Erode(corrosion_img, corrosion1, struct_element, new Point(-1, -1), erode_num, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));//指定参数进行形态学腐蚀操作（自适应手动调整输入腐蚀次数）；
    
//指定参数进行形态学腐蚀操作（2：腐蚀2次）；
//CvInvoke.Erode(corrosion_img, corrosion1, struct_element, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));

pictureBox5.Image = corrosion1.ToImage<Gray, byte>().ToBitmap();
corrosion_img = corrosion1;//（将第一次腐蚀的结果作为第二次腐蚀的输入，如此循环，一直腐蚀，直至消失）;

dilate_img = corrosion1;//（将腐蚀结果corrosion1复制给dilate_img，作为膨胀的输入）;
}
//add(2021-1228，自适应手动调整腐蚀次数，默认腐蚀次数为1)；
```

## //add(2021-1228，自适应手动调整膨胀次数，默认膨胀次数为1)；

```c#
//add(2021-1228，自适应手动调整膨胀次数，默认膨胀次数为1)；
private void dilate_Click(object sender, EventArgs e)
{

//膨胀（work,单击一次膨胀按钮即膨胀一次）；
#region
//corrosion_img = binary_img.Copy();// 将二值化结果binary_img复制到corrosion_img；            

//try
//{
//    //binary_img = img3.Copy();//将模板图像temp-匹配区域imge2的差运算结果拷贝到binary_img;                
//    //int count1 = Convert.ToInt32(textBox1.Text); ; //string类型转换int类型
//    int num = Convert.ToInt32(textBox1.Text);//实现string类型到int类型的转换;
//    CvInvoke.Threshold(binary_img, binary, num, 255, Emgu.CV.CvEnum.ThresholdType.Binary);//num自适应调节;
//    //pictureBox5.Image = binary.ToImage<Gray, byte>().ToBitmap();
//}
//catch (System.Exception ex)
//{
//    MessageBox.Show("  格式错误，请输入整型！");
//}
#endregion

//add(2021-1228，自适应手动调整膨胀次数，默认膨胀次数为1)；
private void dilate_Click(object sender, EventArgs e)
{

//膨胀（work,单击一次膨胀按钮即膨胀一次）；

//形态学操作类型（add-2021-1228）
//Erode = 0;(形态学腐蚀，消除边界点，使边界向内收缩，可消除没有意义的物体。使用CvInvoke.Erode)；
//Dilate =1;(形态学膨胀，将与物体接触的所有背景点合并到该物体中，使边界向外扩张，可用来填补物体中的空洞。使用 CvInvoke.Dilate)；
//open = 2;(形态学开操作，先腐蚀，后膨胀。即：OPEN(X)=D(E(X))，（使用CvInvoke.MorphologyEx（Emgu.CV.CvEnum.MorphOp.Open）作用：消除小物体，在纤细点处分离物体，位置和形状总是不变)；
//Close = 3;(形态学闭操作，先膨胀，后腐蚀。即：CLOSE(X)=E(D(X)),（使用CvInvoke.MorphologyEx（Emgu.CV.CvEnum.MorphOp.Close））作用：可填平小孔，位置、形状不变。)
//Gradient = 4;(形态学梯度操作，膨胀与腐蚀差。即：Grad(X)=Dilate(X)-Erode(X)。膨胀：扩大图像的边界，腐蚀：缩小图像的边界，膨胀-腐蚀：即为形态学梯度操作，可保存边缘轮廓)；
//Tophat = 5;(形态学高帽，原始图像-开操作图像，即：Tophat(X)=X-Open（X）)；
//Blackhat = 6;(形态学地帽，闭操作图像-原始图像，即：Blackhat(X)=Close(X)-X,结果是：输出图像大部分面积均为偏黑色，故称黑帽操作);
//形态学操作类型（add-2021-1228）

Mat struct_element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));//指定参数获得结构元素；
//指定参数进行形态学开操作； //new Point(-1, -1),表示结构元素中心，3，表示形态学开操作中腐蚀迭代次数；
//CvInvoke.MorphologyEx(corrosion_img, corrosion1, Emgu.CV.CvEnum.MorphOp.Open, struct_element, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));

int dilate_num = Convert.ToInt32(textBox3.Text);//实现string类型到int类型转换（默认腐蚀次数dilate_num=1，点击一次膨胀一次）；
CvInvoke.Dilate(dilate_img, swell, struct_element, new Point(-1, -1), dilate_num, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));//指定参数进行膨胀操作（默认腐蚀次数dilate_num=1，点击一次膨胀一次）；

//CvInvoke.Dilate(dilate_img, swell, struct_element, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));//指定参数进行膨胀操作（2：膨胀2次）；
pictureBox5.Image = swell.ToImage<Gray, byte>().ToBitmap();
dilate_img = swell; //（将第一次膨胀的结果作为第二次膨胀的输入，如此循环，一直膨胀）;
}
//add(2021-1228，自适应手动调整膨胀次数，默认膨胀次数为1)；
```

## //add(2021-1228，保存图像处理结果至指定文件夹)；

```c#
//add(2021-1228，保存图像处理结果至指定文件夹)；
private void LoadTemplate_Click(object sender, EventArgs e)
{
// 加载模板图像；
OpenFileDialog OpenFileDialog = new OpenFileDialog();
OpenFileDialog.Filter = "JPEG;BMP;PNG;JPG;GIF|*.JPEG;*.BMP;*.PNG;*.JPG;*.GIF|ALL|*.*";//（模板和加载图像尺寸不一致时，会报错）;
if (OpenFileDialog.ShowDialog() == DialogResult.OK)
{
//获取文件名；
string dbf_File = string.Empty;
OpenFileDialog OpenFileDialog = new OpenFileDialog();
       
//(add-2021-1228,保存处理后的图像至指定文件夹)
dbf_File = OpenFileDialog.FileName;
//string dbf_File1 = System.IO.Path.GetFileName(dbf_File);
//获取文件名；
string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile
//(add-2021-1228,保存处理后的图像至指定文件夹)

try
{
    temp = new Image<Bgr, Byte>(OpenFileDialog.FileName);
    pictureBox1.Image = temp.ToBitmap();

}
catch (System.Exception ex)
{
    MessageBox.Show("图像格式错误！");
}

//(add-2021-1228,保存处理后的图像至指定文件夹)
//MessageBox.Show(dbf_File2);//add(filename-2021-1228);
//(add-2021-1228,保存处理后的图像至指定文件夹)

//显示、保存图像；
#region
////CvInvoke.Imshow("img", temp); //显示图片
CvInvoke.Imwrite("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\" + dbf_File2 + "_temp.bmp", temp); //保存匹配结果图像；
CvInvoke.WaitKey(0); //暂停按键等待
#endregion
}
}
//add(2021-1228，保存图像处理结果至指定文件夹)；
```

## //显示、保存图像(2021-1228)；

```c#
//显示、保存图像(2021-1228)；
#region
//CvInvoke.Imshow("img", temp); //显示图片
CvInvoke.Imwrite("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\"+dbf_File2+"match_img1.bmp", match_img1); //保存匹配结果图像；
CvInvoke.WaitKey(0); //暂停按键等待
#endregion
//显示、保存图像(2021-1228)；
```

## //打印匹配信息,（2021-1228,保存文本信息至指定文件夹）；

```c#
//打印匹配信息,（2021-1228,保存文本信息至指定文件夹）；
displab.Text =
"匹配信息: X " +
max_loc.X + " Y " + max_loc.Y + "\n" +
"\n" +
"最大相似度:" + max.ToString("f2") + "\n" + "\n"+
"最小相似度:" + min.ToString("f2");

//（2021-1228,保存文本信息至指定文件夹）；
string txt = displab.Text;
string filename = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.txt";   //文件名，可以带路径

System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
sw.Write(displab.Text);
sw.Close();
//（2021-1228,保存文本信息至指定文件夹）；
string txt = textBox1.Text;
string filename = "temp.txt";   //文件名，可以带路径
System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
sw.Write(txt);
sw.Close();
//（2021-1228,保存文本信息至指定文件夹）；
```

## //(add,2021-1228,在匹配信息文本中添加轮廓面积信息，使用Stream将两次打印的txt信息拼接在一起）；

```c#
//(add,2021-1228,在匹配信息Txt文本中添加轮廓面积信息)；
//打印轮廓总面积信息；
displab1.Text = "轮廓总面积:  " + sum_area.ToString() + ";"+"\n" + "\n";//打印遍历完的总面积（0044轮廓面积,当阈值选择30时，显示出错,试试RetrType.Ccomp）
string txt = displab1.Text;
string filename = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.txt";   //文件名，可以带路径

FileStream fs = new FileStream(filename, FileMode.Append);
StreamWriter wr = null;
wr = new StreamWriter(fs);

//System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
wr.Write(displab1.Text);
wr.Close();
//(add,2021-1228,在匹配信息Txt文本中添加轮廓面积信息)；
```

## VS编译出现错误，CS1061“object”未包含“Text”的定义，并且找不到可接受第一个“object”类型参数的可访问扩展方法“Text”(是否缺少 using 指令或程序集引用?)

```c#
//(add,2021-1229,将label.Text改为：(label as TextBox).Text)
label.Text == dt.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");  //mm-dd才显示08-01，否则显示8-1;fff个数表示小数点后显示的位数，这里精确到小数点后3位;
//当输入上述语句时，会出现如下错误：CS1061“object”未包含“Text”的定义，并且找不到可接受第一个“object”类型参数的可访问扩展方法“Text”(是否缺少 using 指令或程序集引用?)
//此时，需将上述代码改为如下所述即可：
(label as TextBox).Text = dt.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
//(add,2021-1229)
```

## 打印时间

```c#
////datetime格式化(2021-1229)；
DateTime dt = DateTime.Now;

////在Excel表中写入时间数据时，设置单元格格式，自定义格式yyyy-MM-dd HH:mm:ss
//(label as TextBox).Text = dt.ToLocalTime().ToString();   //mm-dd才显示08-01，否则显示8-1
////fff个数表示小数点后显示的位数，这里精确到小数点后3位

//打印匹配信息（2021-1229,保存文本信息至指定文件夹并打印时间）；
displab.Text = "时间:"+ dt.ToLocalTime().ToString() + "图像名称：" +dbf_File2 + "\n" +
"\n" + "匹配信息: X " + 
max_loc.X + "," + " Y " + max_loc.Y + ";" +
"\n" +
"最大相似度:" + max.ToString("f2") + ";" + "\n" +
"最小相似度:" + min.ToString("f2") + ";" + "\n";

//（2021-1228,保存文本信息至指定文件夹）；
string txt = displab.Text;
string filename = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.txt";   //文件名，可以带路径

FileStream fs = new FileStream(filename, FileMode.Append);
StreamWriter wr = null;
wr = new StreamWriter(fs);

//System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
wr.Write(displab.Text);
wr.Close();
//（2021-1229,保存文本信息至指定文件夹）；
```

## (XOR,异或，switch、While循环、2022-0104);

```c#
//(XOR,异或，for循环、2022-0104);
#region
Console.WriteLine("Input number1:");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input number2:");
double n2 = Convert.ToDouble(Console.ReadLine());

bool b = (n1 > 10) ^ (n2 > 10);
if (b)
{
Console.WriteLine("Meet the requirements");

}
else
{
Console.WriteLine("Please input number again!");
}
#endregion


//(switch-case-break;2022-0104);
#region
//const string my_Favorite_Fruit = "apple";
//const string he_Favorite_Fruit = "banana";
//const string she_Favorite_Fruit = "orange";

//Console.WriteLine("Please Enter Your Favorite Fruit:");
//string fruit = Convert.ToString(Console.ReadLine());

//switch(fruit.ToLower())
//{
//    case my_Favorite_Fruit:
//        Console.WriteLine("I like it too!!!");
//        break;
//    case he_Favorite_Fruit:
//        Console.WriteLine("He likes it too!!!");
//        break;
//    case she_Favorite_Fruit:
//        Console.WriteLine("She likes it too!!!");
//        break;

//}

//Console.WriteLine("Hello {0},Good morning!!!",fruit);
//Console.ReadKey();
#endregion

//(for循环，1-100加法，1-15乘法总和)；
#region
//int multiplication = 1;
//int sum = 0;
//for (int i=1; i<101; i++)
//{

//sum += i;       
////multiplication *=  i;
////Console.WriteLine(multiplication);
//Console.WriteLine(sum);
////Console.ReadKey();
//}
#endregion

//(do-while循环);
#region
//int i = 1;
//do
//{
//    Console.WriteLine("{0}", i++);
//}
//while (i <= 10);
#endregion

//(While循环，2022-0104);
#region
//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine("{0}", i++);
//}
#endregion

//(for循环，2022-0104）；
#region
//int i;
//for(i=1; i<=10;i++)
//{
//    Console.WriteLine("{0}",i);
//}
#endregion
```

