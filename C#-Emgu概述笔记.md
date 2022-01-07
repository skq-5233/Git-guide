# C#-Emgu概述笔记；

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
CvInvoke.MatchTemplate(match_img, temp, result, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用归一化系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像；
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

## //(2022-0105,打印信息至Excel表中，用流创建.xlsx文件,将两次信息打印在一张Excel表中，需将该方法放置在后面需打印的位置处；如：轮廓总面积)；

```c#
//add(2022-0107,导出Excel表--start)，NPOI库见具体md文档；添加如下：
public partial class Form1 : Form
{
//(add,2021-1229,获取文件名);
string dbf_File = string.Empty;
OpenFileDialog OpenFileDialog = new OpenFileDialog();
private int indexOfExcel_j = 1;
FileStream filestream = null;

XSSFWorkbook wk = null;
ISheet isheet = null;
IRow rowWrite = null;

double max = 0, min = 0;//创建double极值；
Point max_loc = new Point(0, 0), min_loc = new Point(0, 0);//创建dPoint类型，表示极值的坐标；
}
//add(2022-0107导出Excel表--end)

//add(2022-0106-start，面积筛选)
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
//add(2022-0106--end，面积筛选)  

//打印轮廓总面积信息(2022-0106-start)；
displab1.Text = "轮廓总面积: " + sum_area.ToString() + ";" + "\n" + "\n" + "\n";//打印遍历完的总面积（0044轮廓面积,当阈值选择30时，显示出错,试试RetrType.Ccomp）

//打印匹配信息（2021-1228,保存文本信息至指定文件夹）；
#region
//displab.Text = dbf_File2 + "\n" +
//                 "轮廓总面积:  " + sum_area.ToString();

////（2021-1228,保存文本信息至指定文件夹）；
//string txt = displab1.Text;
//string filename = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息1.txt";   //文件名，可以带路径

//System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
//sw.Write(displab1.Text);
//sw.Close();
#endregion
//(add,2022-0106--start,在匹配信息Txt文本中添加轮廓面积信息)；
string txt = displab1.Text;
string filename = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.txt";   //文件名，可以带路径

FileStream fs = new FileStream(filename, FileMode.Append);
StreamWriter wr = null;
wr = new StreamWriter(fs);

//System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
wr.Write(displab1.Text);
wr.Close();
//(add,2022-0106--end,在匹配信息Txt文本中添加轮廓面积信息)；

//(add-2022-0106--start)用流创建或读取.xlsx文件（同时流关联了文件）
filestream = new FileStream("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.xlsx", FileMode.OpenOrCreate);

//创建表和sheet;
if (indexOfExcel_j == 1)
{
wk = new XSSFWorkbook();   //创建表对象wk
isheet = wk.CreateSheet("Sheet1");   //在wk中创建sheet1
//创建表头
IRow rowtitle = null;
rowtitle = isheet.CreateRow(0); //创建index=j的行

ICell cellTitle0 = null;
cellTitle0 = rowtitle.CreateCell(0);  //在index=j的行中创建index=0的单元格
cellTitle0.SetCellValue("时间"); //给创建的单元格赋值string

ICell cellTitle1 = null;
cellTitle1 = rowtitle.CreateCell(1);  //在index=j的行中创建index=0的单元格
cellTitle1.SetCellValue("图像名称"); //给创建的单元格赋值string

ICell cellTitle2 = null;
cellTitle2 = rowtitle.CreateCell(2);  //在index=j的行中创建index=0的单元格
cellTitle2.SetCellValue("匹配信息坐标X"); //给创建的单元格赋值string

ICell cellTitle3 = null;
cellTitle3 = rowtitle.CreateCell(3);  //在index=j的行中创建index=0的单元格
cellTitle3.SetCellValue("匹配信息坐标Y"); //给创建的单元格赋值string

ICell cellTitle4 = null;
cellTitle4 = rowtitle.CreateCell(4);  //在index=j的行中创建index=0的单元格
cellTitle4.SetCellValue("最大相似度"); //给创建的单元格赋值string


ICell cellTitle5 = null;
cellTitle5 = rowtitle.CreateCell(5);  //在index=j的行中创建index=0的单元格
cellTitle5.SetCellValue("最小相似度"); //给创建的单元格赋值string

ICell cellTitle6 = null;
cellTitle6 = rowtitle.CreateCell(6);  //在index=j的行中创建index=0的单元格
cellTitle6.SetCellValue("轮廓总面积"); //给创建的单元格赋值strin
}

#region
//向单元格中写数据(2021-1231,循环写入行、列数据，先定义行数，再定义列数，这里是2行6列);
//for (int indexOfExcel_j = 1; indexOfExcel_j < 3; indexOfExcel_j++)//(j:行)；
//{

//IRow row2 = null;
//row2 = isheet.CreateRow(indexOfExcel_j++); //创建index=j的行

////datetime格式化；
#endregion
DateTime dt = DateTime.Now;

rowWrite = isheet.CreateRow(indexOfExcel_j++); //创建index=j的行

ICell cell0 = null;
cell0 = rowWrite.CreateCell(0);  //在index=j的行中创建index=0的单元格
cell0.SetCellValue(dt.ToLocalTime().ToString()); //给创建的单元格赋值string

ICell cell1 = null;
cell1 = rowWrite.CreateCell(1);  //在index=j的行中创建index=0的单元格
cell1.SetCellValue(dbf_File2); //给创建的单元格赋值string

ICell cell2 = null;
cell2 = rowWrite.CreateCell(2);  //在index=j的行中创建index=0的单元格
cell2.SetCellValue("X:" + max_loc.X); //给创建的单元格赋值string

ICell cell3 = null;
cell3 = rowWrite.CreateCell(3);  //在index=j的行中创建index=0的单元格
cell3.SetCellValue("Y:" + max_loc.Y); //给创建的单元格赋值string

ICell cell4 = null;
cell4 = rowWrite.CreateCell(4);  //在index=j的行中创建index=0的单元格
cell4.SetCellValue(max.ToString("f2")); //给创建的单元格赋值string


ICell cell5 = null;
cell5 = rowWrite.CreateCell(5);  //在index=j的行中创建index=0的单元格
cell5.SetCellValue(min.ToString("f2")); //给创建的单元格赋值string

ICell cell6 = null;
cell6 = rowWrite.CreateCell(6);  //在index=j的行中创建index=0的单元格
cell6.SetCellValue(sum_area.ToString()); //给创建的单元格赋值string


//通过流将表中写入的数据一次性写入文件中;
wk.Write(filestream); //通过流filestream将表wk写入文件

//(add,20211231)
//filestream.Close(); //关闭文件流filestream
//wk.Close(); //关闭Excel表对象wk

Mat mask = contour_img.ToImage<Bgr, byte>().CopyBlank().Mat;//获取一张背景为黑色的图像，尺寸大小与contour_img一样(类型Bgr);
CvInvoke.DrawContours(mask, use_contours, -1, new MCvScalar(0, 0, 255));//采用红色画笔在mask掩膜图像中画出所有轮廓；(MCvScalar是一个具有单元素到四元素间的一个数组)
pictureBox6.Image = mask.ToImage<Bgr, byte>().ToBitmap();//显示轮廓区域图像；
//(add-2022-0106--end)用流创建或读取.xlsx文件（同时流关联了文件）;
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

## (XOR,异或，switch、While、for循环、2022-0104);

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

## 字节数组转化为图像（2022-0105）；

```c#
public static Image byte2img(byte[] buffer)
{
    MemoryStream ms = new MemoryStream(buffer);
    ms.Position = 0;
    Image img = Image.FromStream(ms);
    ms.Close();
    return img;
}
//字节数组转化为图像（2022-0105）；
```

## 图像转化为字节数组（2022-0105）；

```c#
public static byte[] byte2img(Bitmap Bit)
{
    byte[] back = null;
    MemoryStream ms = new MemoryStream();
    Bit.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
    back = ms.GetBuffer();
    return back;
}
//图像转化为字节数组（2022-0105）；
```

## 打开单张图像某文件夹中单张图像（2022-0106）；

```c#
//打开单张图像(2022-0106--start);
private void LoadTemplate1_Click(object sender, EventArgs e)
{
/***********************自动模式下---1-Start；************************************/
/***********************自动模式下---1-加载模板图像；************************************/
/*****************(add,(2021-1231))**************************************/
/******************与line_91一致(LoadTemplate_Click)**********************/

//(打开单张图像，2022-0106-start)
OpenFileDialog OpenFileDialog = new OpenFileDialog();
OpenFileDialog.Filter = "JPEG;BMP;PNG;JPG;GIF|*.JPEG;*.BMP;*.PNG;*.JPG;*.GIF|ALL|*.*";//（模板和加载图像尺寸不一致时，会报错）;
if (OpenFileDialog.ShowDialog() == DialogResult.OK)
{
//(add-2021-1228,保存处理后的图像至指定文件夹)
dbf_File = OpenFileDialog.FileName;//(获取文件夹路径)；
//string dbf_File1 = System.IO.Path.GetFileName(dbf_File);

string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile(获取dbf_File2路径名称);
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
CvInvoke.Imwrite("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\" + dbf_File2 + "_temp.bmp", temp);//保存匹配图像(dbf_File2:图像名称)；
CvInvoke.WaitKey(0); //暂停按键等待
#endregion
}
}
//(打开单张图像，2022-0106-end)
```

## EmguCV Image类中的函数

```C#
//(add,2022-0106--start);
1、Image<TColor, TDepth> AbsDiff     返回两幅图片或此图与某个yanse像素的差的绝对值的图片
2、Image<TColor, TDepth> Add           返回这张图片与图片或颜色直接相加的图片（矩阵加法）

3、Image<Gray, byte> Canny               边缘检测

4、Image<TColor, TDepth> Clone()    拷贝

5、Image<TColor, TDepth> ConcateHorizontal     返回与另一张图片横向链接的图片

6、Image<TColor, TDepth> ConcateVertical          返回与另一张图片总想链接的图片

7、Image<TColor, TOtherDepth> Convert                转换为其他格式的Image图片

8、void ConvertFrom 从Mat或其他类型的Image图片转换回这种格式的图片

9、Image<TColor, TOtherDepth> ConvertScale       变换大小

10、Image<TColor, TDepth> Copy 复制图片 或只复制该图片的指定区域

11、Image<TColor, TDepth> CopyBlank()                 复制出一张空图

12、Image<TColor, TDepth> Dilate             扩大像素点的效果 效果图链接：点击打开链接

13、void Draw         在该图片上绘制之前检测到的圆或长方形等

14、Image<TColor, TDepth> Erode                         腐蚀效果（可调节）：效果图链接点击打开链接

15、Image<TColor, TDepth> Flip                             翻转图片，有方式可选

16、TColor GetAverage                      获取此图片所有像素点颜色的平均值

17、CircleF[][] HoughCircles             霍夫圆变换，用于检测圆形，返回值为检测到的点的坐标

18、LineSegment2D[][] HoughLines          霍夫线变换（还没用过，效果还不知道）

19、Image<TColor, TDepth> Max        返回一张图片，图片的每个像素点的颜色为原图片在这像素点的颜色与参数图片或颜色的最大值

20、Image<TColor, TDepth> Min          返回一张图片，图片的每个像素点的颜色为原图片在这像素点的颜色与参数图片或颜色的最小值
21、void MinMax        返回一张图片的像素点的最小值和最大值以及它们的位置位置

22、Image<TColor, TDepth> Mul     与图片或颜色数值直接相乘（矩阵乘法）

23、Image<TColor, TDepth> Not()     图片有颜色的地方alpha值变为0，透明的地方alpha变为255（猜测）

24、Image<TColor, TDepth> Or        图片与图片或颜色数值的或运算

25、Image<TColor, TDepth> Pow     矩阵的乘方运算

26、Image<TColor, TDepth> PyrDown()        降低图片分辨率

27、Image<TColor, TDepth> PyrUp()              提高图片分辨率

28、Image<TColor, TDepth> Resize                改变图片大小

29、Image<TColor, TDepth> Rotate                 图片旋转（crop值设为false可以显示完整的图片）

30、Image<Gray, TDepth>[] Split()                    色彩分割

31、Image<TColor, TDepth> Sub                     从图片中减去某个颜色（矩阵减法）

32、Image<TColor, TDepth> SubR                 负的sub

33、Bitmap ToBitmap           转换为Bitmap格式
//(add,2022-0106--end);
```

## Emgu函数总结：

```c#
//Emgucv常用函数总结(2022-0106--start);
读取图片
Mat SCr = new Mat(Form1.Path, Emgu.CV.CvEnum.LoadImageType.AnyColor);
//根据路径创建指定的灰度图片
Mat scr = new Mat(Form1.Path, Emgu.CV.CvEnum.LoadImageType.Grayscale);
获取灰度    //图像类型转换， bgr 转成 gray 类型。MAT Bw = New MAT
CvInvoke.CvtColor(SCr, bw, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
//相当于二值化图 --黑白 根据大小10判断为0还是255
CvInvoke.Threshold(bw,bw,10,255,Emgu.CV.CvEnum.ThresholdType.BinaryInv);
//获取指定区域图片 SCr为mat类型
Rectangle rectangle = new Rectangle(10,10,10,10);
SCr = SCr.ToImage<Bgr, byte>().GetSubRect(rectangle).Mat;
//将Mat类型转换为Image类型
Image<Bgr, byte> Su = SCr.ToImage<Bgr, byte>();
Image<Bgr, byte> Img = new Image<Bgr, byte>(new Bitmap(""));//路径声明
Image<Bgr, byte> Sub = SCr.ToImage<Bgr, byte>().GetSubRect(rectangle);//指定范围
//指定参数获得结构元素
Mat Struct_element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
//膨胀
CvInvoke.Dilate(bw, bw, Struct_element, new Point(1,1),3,Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
//腐蚀 当Struct_element模型创建不合理或者膨胀腐蚀次数较大时可能图像会发生偏移
CvInvoke.Erode(bw, bw, Struct_element, new Point(-1, -1), 3,Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
//轮廓提取
VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
//筛选后
CvInvoke.FindContours(bw, contours, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
int ksize = contours.Size;//获取连通区域的个数。     
VectorOfPoint contour = contours[i];//获取独立的连通轮廓   
Rectangle rect = CvInvoke.BoundingRectangle(contour);//提取最外部矩形。
double Length = CvInvoke.ArcLength(contour, false);//计算连通轮廓的周长。
//画出轮廓
Mat mask = bw.ToImage<Bgr, byte>().CopyBlank().Mat;
//获取一张背景为黑色的图像， 大小与 scr 的大小一样， 类型为 Bgr。
CvInvoke.DrawContours(mask, contours, -1, new MCvScalar(0, 0, 255));
Image<Ycc, byte> ycc_img = bgr_img.Convert<Ycc, byte>();//把 bgr颜色图片转成ycbcr类型。
Ycc min = new Ycc(152, 38, 118);//最小值的颜色。
Ycc max = new Ycc(94, 43, 118);//最大值得颜色。
Image<Gray, byte> result = ycc_img.InRange(min, max);//进行颜色提取。
Image<Bgr, byte> bgr_img = Ma.ToImage<Bgr, byte>();//载入一张 Bgr 类型的图片。
Bgr min = new Bgr(255, 255, 255);//白色的最小值， 允许一定154的误差。
Bgr max = new Bgr(255, 255, 255);//白色的最大值， 允许一定的误差。
Image<Gray, byte> result = bgr_img.InRange(min, max);//进行颜色提取。
Image<Bgr, Byte> imageSource = new Image<Bgr, Byte>(SCr.Bitmap);
Image<Hsv, Byte> imageHsv = imageSource.Convert<Hsv, Byte>();//将色彩空间从BGR转换到HSV
Image<Gray, Byte>[] imagesHsv = imageHsv.Split();//分解成H、S、V三部分
CvInvoke.AbsDiff(Ma1, Ma2, Ma); // 返回两幅图片或此图与某个yanse像素的差的绝对值的图片
CvInvoke.Add(Ma1, Ma2, Ma); // 返回这张图片与图片或颜色直接相加的图片（矩阵加法）  (适应两种效果)
//CvInvoke.HConcat(Ma1, Ma2, Ma); //返回与另一张图片横向链接的图片
//CvInvoke.VConcat(Ma1, Ma2, Ma);//返回与另一张图片纵向链接的图片

//清除小于平均顶点10的二值图
Point[] po = { new Point(0, 0), new Point(res.Width, 0), new Point(res.Width, minAvg - Gets.Fges[1] + 52), new Point(0, minAvg - Gets.Fges[1] + 52) };
VectorOfPoint vp = new VectorOfPoint(po);
//CvInvoke.DrawContours(res, vp, -1, new MCvScalar(0, 0, 255));
CvInvoke.FillConvexPoly(res,vp,new MCvScalar(0),LineType.EightConnected);//填充指定区域

/// <summary>
/// 灰度直方图计算  手动计算、/获取百分比的阀值  0.95
/// </summary>
public static void GetDenseHistogram95(ref int huidu, Mat ma)
{
    DenseHistogram dense = new DenseHistogram(256, new RangeF(0, 255));
    dense.Calculate(new Image<Gray, Byte>[] { ma.ToImage<Gray, byte>() }, true, null);
    //计算直方图数据。
    float[] data = dense.GetBinValues();
    float[] data2 = dense.GetBinValues();
    //获得直方图数据。
    /*** 进行数据归一化到[0,256]区域内并且绘制直方图***/
    float max = data[0]; //最大值
    for (int j = 1; j < data.Length; j++)
    {
        if (data[j] > max)
        {
            max = data[j];
        }
    }
    float Sum = data2.ToList().Sum();
    float FloCount = 0;
    for (int k = 0; k < data.Length; k++)
    {
        data[k] = data[k] * 256 / max;
        FloCount += data2[k];
        if (FloCount / Sum >= 0.95)
        {
            huidu = k;
            break;
        }
    }}

//各种颜色空间 Hsv/Rgb/Hls/Xyz/Ycc/Gray
public static Image<Hsv, Byte> imageHsv=new Image<Hsv, byte>(mat.Bitmap);
public static Image<Rgb, Byte> Rgbimg = new Image<Rgb, byte>(mat.Bitmap);
public static Image<Hls, Byte> Hlsimg = new Image<Hls, byte>(mat.Bitmap);
public static Image<Xyz, Byte> Xyzimg = new Image<Xyz, byte>(mat.Bitmap);
public static Image<Ycc, Byte> Yccimg = new Image<Ycc, byte>(mat.Bitmap);
public static Image<Gray, Byte> Grayimg = new Image<Gray, byte>(mat.Bitmap);
Image<Gray, Byte>[] imagesHsvs = imageHsv.Split();//分解成H、S、V三部分其他相同
//高斯滤波实现
CvInvoke.GaussianBlur(ma, ma, new Size(5, 5), 4);
//形态学闭运算，先膨胀后腐蚀  Others.matWithPhi(by)自定义模型
CvInvoke.MorphologyEx(ma, ma, Emgu.CV.CvEnum.MorphOp.Close, Others.matWithPhi(by), new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
CvInvoke.MedianBlur(ma, ma, 5);//中值滤波实现
CvInvoke.PutText(ma05, "G num: 1", new Point(10, 100), FontFace.HersheyComplex, 0.5, new MCvScalar(255)); //指定坐标(10, 100)显示文字，中文乱码，
VectorOfPoint vp = new VectorOfPoint();
CvInvoke.ConvexHull(pointof, vp);////查找最小外接矩形cvInpaint
double dou = CvInvoke.ContourArea(vp, false);  //计算面积
VectorOfPoint vect = new VectorOfPoint();
CvInvoke.FindNonZero(ma, vect); //获取非0的点
Mat maSave1 = ma5.Clone();//备份 保留原有图片
CvInvoke.AdaptiveThreshold(ma, mas, 255, AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 3, 0);//查找最适合二值图
//Emgucv常用函数总结(2022-0106--end);
```

Emgu中Mat<--->Image转换；

```c#
//Emgucv常用函数总结(2022-0106--start);
Image<Bgr, Byte> match_img = convert_img.ToImage<Bgr, Byte>();//Mat 2 Image（彩色图）;
Image<Gray, Byte> match_img = grayImg.ToImage<Gray, Byte>(); //灰度图

（1）  Image<Bgr,byte> 转为 Bitmap 可通过函数 img.ToBitmap(); 

（2）   Bitmap 转为 Image 可通过读取实现 Image<Bgr,byte> img = new Image<Bgr,byte> （bitmap）;

（3）  Mat 类可以通过  Image<Bgr,byte>matToimg = Matimg.ToImage<Bgr,byte>();

//Emgucv常用函数总结(2022-0106--end);

//获取灰度图像像素值(2022-0107--start)：
Image<Gray, Byte> img = grayImg.ToImage<Gray, Byte>();
double meanValue = 0, sum = 0; 
for (int i = 0; i < img.Rows; i++)
{
  for (int j = 0; j < img.Cols; j++)
  {
    sum += img[i, j].Intensity;
  }
}
meanValue = sum / (img.Rows * img.Cols);
//获取灰度图像像素值(2022-0107--end)：
```



## 自动模式下，遍历文件夹（需要添加对话框下：folderBrowserDialog控件；）获取匹配区域并画出矩形框(2011-0105）；

```c#
//(表头添加如下,2022-0107-start)：
using System.Threading;//创建线程,使用多线程；
//Form1添加如下：
public partial class Form1 : Form
{
Mat convert_img = new Mat();
//加载整个文件夹(2022-0106--start)；
List<string> typeList = new List<string>();

String defaultfilepath;
Int32 picturecount = 0;  //图片总数
//Int32[] classcount;      //各类图片计数

Int32 classcount = 1;      //各类图片计数

Thread thread1;
Int32 ComboBoxindex = 0;
//加载整个文件夹(2022-0106--end)；
}

public Form1()
{
InitializeComponent();

defaultfilepath = "";

//(表头添加如下,2022-0107-end)：

//(自动模式下遍历整个文件夹--2022-0107--start);
private void folder_Click(object sender, EventArgs e)

/*******************************测试整个文件夹(加载待匹配图像)--start************************/
/*****************************(2022-0105)***************************/
/*****************************(2022-0105)***************************/

//文件夹测试(2022-0106--start)；
picturecount = 0;

//for (int i = 0; i < classcount.Length; i++)
//{
//    classcount[i] = 0;
//}

//if (defaultfilepath != "")
//{
//    folderBrowserDialog1.SelectedPath = defaultfilepath;
//}
//else
//{
//    folderBrowserDialog1.SelectedPath = Application.StartupPath;
//}

//(打开文件夹函数--2022-0106--start)
if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
{
defaultfilepath = folderBrowserDialog1.SelectedPath;
thread1 = new Thread(new ThreadStart(ImageProcessingAll));//创建线程
thread1.Start();
}
}
//文件夹测试函数(2022-0106--end);

//文件夹测试函数(2022-0106--start);
private void ImageProcessingAll()   //处理文件指定文件夹下所有图片
{

//nMax = 0;
//nMin = 1;
//double dThreValue = Convert.ToDouble(ThreshTb.Text);

//Mat img;  //待测试图片
DirectoryInfo folder;

folder = new DirectoryInfo(defaultfilepath);

//遍历文件
foreach (FileInfo nextfile in folder.GetFiles())
{
//Invoke((EventHandler)delegate { label2.Text = "图片名称：" + Path.GetFileName(nextfile.FullName); });
//Invoke((EventHandler)delegate { label2.Refresh(); });

Point max_loc1 = new Point(0, 0);
Point classNumber = max_loc1;    //最大可能性位置

//string typeName = typeList[classNumber.X];

convert_img = CvInvoke.Imread(nextfile.FullName, Emgu.CV.CvEnum.ImreadModes.AnyColor);

//Image<Bgr, byte> matToimg = match_img.ToImage<Bgr, byte>();


Image<Bgr, Byte> match_img = convert_img.ToImage<Bgr, Byte>();//Mat 2 Image;

//if (match_img.IsEmpty)
//{
//    Invoke((EventHandler)delegate { label18.Text = "无法加载文件！"; });
//    Invoke((EventHandler)delegate { label18.Refresh(); });
//    return;
//}

//开始时间
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();   //开始监视代码运行时间

//对输入图像数据进行处理
//Mat blob = DnnInvoke.BlobFromImage(img, 1.0f, new Size(224, 224), new MCvScalar(), true, false);

//进行图像种类预测
//Mat prob;

//net.SetInput(blob);      //设置输入数据
//prob = net.Forward();    //推理

//得到最可能分类输出
//Mat probMat = prob.Reshape(1, 1);
//double minVal = 0;  //最小可能性
//double maxVal = 0;  //最大可能性
//Point minLoc = new Point();
//Point maxLoc = new Point();

//CvInvoke.MinMaxLoc(probMat, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
//double classProb = maxVal;     //最大可能性
//Point classNumber = maxLoc;    //最大可能性位置


//if (nMin > maxVal)
//{
//    nMin = maxVal;
//}
//if (nMax < maxVal)
//{
//    nMax = maxVal;
//}

//string typeName = typeList[classNumber.X];

//stopwatch.Stop();  //  停止监视
//long timespan = stopwatch.ElapsedMilliseconds;  //获取当前实例测量得出的总时间

//classcount[classNumber.X]++;
//picturecount++;

//classcount[classNumber.X]++;
picturecount++;

//if (ComboBoxindex == 1)    //保存NG图像
//{
//no******/
//if (classNumber.X == 0)
//{
//    CvInvoke.Imwrite("result/NG/" + Path.GetFileName(nextfile.FullName), img);
//}
//no******/

//    if (maxVal < dThreValue)
//    {
//        CvInvoke.Imwrite("result/NG/" + Path.GetFileName(nextfile.FullName), img);
//    }


//}
//else if (ComboBoxindex == 2)    //保存OK图像
//{
//if (classNumber.X == 1)
//{
//    CvInvoke.Imwrite("result/OK/" + Path.GetFileName(nextfile.FullName), img);
//}
//if (maxVal > dThreValue)
//{
//    CvInvoke.Imwrite("result/OK/" + Path.GetFileName(nextfile.FullName), img);
//}
Invoke((EventHandler)delegate { label13.Text = "图片总数：" + picturecount.ToString(); });
Invoke((EventHandler)delegate { label13.Refresh(); });


//检测内容
Invoke((EventHandler)delegate { pictureBox2.Image = BitmapExtension.ToBitmap(match_img); });
Invoke((EventHandler)delegate { pictureBox2.Refresh(); });

//Invoke((EventHandler)delegate { label1.Text = "图片测试结果为：" + typeName + "  可能性为：" + classProb.ToString("0.00000") + "  处理总时间为：" + timespan.ToString() + "ms"; });
//Invoke((EventHandler)delegate { label1.Refresh(); });

//string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile/*****************/
//(add-2021-1228,保存处理后的图像至指定文件夹)
/***************/
//Point max_loc = new Point(0, 0), min_loc = new Point(0, 0);//创建dPoint类型，表示极值的坐标；
//try //******************//
//{


/****************自动模式下---2-加载待匹配图像并画出矩形框(--start)；*********************/
/**********************************（add,2022-0106--start);***********************/

//****************//
//match_img = new Image<Bgr, Byte>(OpenFileDialog.FileName);               
Mat result1 = new Mat(new Size(match_img.Width - temp.Width + 1, match_img.Height - temp.Height + 1), DepthType.Cv32F, 1);//创建mat存储输出匹配结果；
CvInvoke.MatchTemplate(match_img, temp, result1, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用系数匹配法，数值越大越接近准确图像；
//****************//
//CvInvoke.Normalize(result1, result1, 1, 0, Emgu.CV.CvEnum.NormType.MinMax); //对数据进行（min,max;0-255）归一化；
//double max = 0, min = 0;//创建double极值；
//Point max_loc = new Point(0, 0), min_loc = new Point(0, 0);//创建dPoint类型，表示极值的坐标；

//****************//
CvInvoke.MinMaxLoc(result1, ref min, ref max, ref min_loc, ref max_loc);//获取极值及其坐标；

match_img1 = match_img.Copy(); //将原图match_img复制到match_img1中，对match_img1进行画矩形框，避免pictureBox3显示匹配区域出现边框；
CvInvoke.Rectangle(match_img1, new Rectangle(max_loc, temp.Size), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；
pictureBox2.Image = match_img1.ToBitmap();//显示找到模板图像的待搜索图像；

//显示、保存图像； 
#region
//****************//
//CvInvoke.Imshow("img", temp); //显示图片
//****************//

//CvInvoke.Imwrite("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\" + dbf_File2 + "_match_img1.bmp", match_img1); //保存匹配结果图像；

CvInvoke.Imwrite("test/match_img_result/" + Path.GetFileName(nextfile.FullName), match_img1); //保存匹配结果图像；
CvInvoke.WaitKey(0); //暂停按键等待

/****************自动模式下---2-加载待匹配图像并画出矩形框(--end)；*********************/
/**********************************（add,2022-0106--end);***********************/



/****************自动模式下---3-获取匹配区域(--start)；*********************/
/**********************************（add,2022-0106--start);***********************/

// 获取匹配区域；
Mat result = new Mat(new Size(match_img.Width - temp.Width + 1, match_img.Height - temp.Height + 1), DepthType.Cv32F, 1);//创建mat存储输出匹配结果；
CvInvoke.MatchTemplate(match_img, temp, result, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像；
//CvInvoke.Normalize(result, result, 1, 0, Emgu.CV.CvEnum.NormType.MinMax); //对数据进行（min,max;0-255）归一化；
//double max = 0, min = 0;//创建double极值；
//Point max_loc = new Point(0, 0), min_loc = new Point(0, 0);//创建dPoint类型，表示极值的坐标；
CvInvoke.MinMaxLoc(result, ref min, ref max, ref min_loc, ref max_loc);//获取极值及其坐标；

//(add-2021-1228,保存处理后的图像至指定文件夹)
//dbf_File = OpenFileDialog.FileName;
//string dbf_File1 = System.IO.Path.GetFileName(dbf_File);

//string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile
//(add-2021-1228,保存处理后的图像至指定文件夹)

match_area_img = match_img.Copy(new Rectangle(max_loc, temp.Size)); //将原图match_img复制到match_area_img中，显示匹配区域；
pictureBox3.Image = match_area_img.ToBitmap();//显示匹配区域；

//显示、保存图像；
#region
//CvInvoke.Imshow("img", temp); //显示图片
CvInvoke.Imwrite("test/match_area_img_result/" + Path.GetFileName(nextfile.FullName), match_area_img); //保存匹配结果图像；
CvInvoke.WaitKey(0); //暂停按键等待
#endregion
/****************自动模式下---3-获取匹配区域(--end)；*********************/
/**********************************（add,2022-0106--end);***********************/
//(自动模式下遍历整个文件夹--2022-0107--start);
```

## 判断Emgu图像类型是否为空

```c#
//Emgu图像类型判断是否为空(2022-0107--start)；
1、若图像类型为Mat,即：
if(Mat.IsEmpty)
{
    Invoke((EventHandler)delegate { label1.Text = "无法加载文件！"; });
    Invoke((EventHandler)delegate { label1.Refresh(); });
    return;
}
2、若图像类型为Image,即：
if(Image == null)
{
    Invoke((EventHandler)delegate { label1.Text = "无法加载文件！"; });
    Invoke((EventHandler)delegate { label1.Refresh(); });
    return;
}
//Emgu图像类型判断是否为空(2022-0107--end)；
```



