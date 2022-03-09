# C#-Emgu概述笔记；

## 一、C#的五大数据类型：

**1）类（Class; 如Windows,Form,Console,String,etc）；**

**2）结构体（Structures;  如int32,int64,Single,Double,etc）；**

**3）枚举（Enumeration; 如Horizontal,Alignment,Visibility ,etc）；**

**4）接口（interfaces）；**

**5）委托（Delegates）;**

## 二、C# -功能键：

**1、工具-->选项--->文本编辑器-->所有语言-->常规-->行号；**

**2、工具-->选项--->环境-->字体和颜色-->字体（Consolas）；**

**3、解决方案-->属性-->当前选定内容（执行多个解决方案时）；**

**4、设置背景：主题-->Night;**

**5、设置行号：文件-->偏好设置-->MarkDown-->代码块-->显示行号；**

## 三、C# -语法：

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

## 四、C# -快捷键：

**1、Ctrl+k+c:批量注释代码（ /*、、、*/多行注释；//注释内容； ///文本注释///）；Ctrl+k+u:批量取消注释代码；**

**2、F5:调试运行，Ctrl+F5:非调试运行；F10,逐渐过程；F11，逐语句；**

**3、Ctrl+Shift+N:新建项目；**

**4、#region、#endregion（添加在代码开头、结尾，用于折叠、展开代码）；**

**5、选中几行代码,然后使用 Tab (整体左移)或 Shift+Tab(整体右移) 操作；**

## 五、C#之Hello World

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

## 六、C# -Console-逻辑运算符：

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

## 七、//判断年份是否为闰年(2021-1223)；

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

## 八、//编写一个控制台应用程序，算数运算符；。add(2021-1223)

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

## 九、/add(2021-1227，面积筛选)；遍历完所有面积，打印总面积；

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

## 十、//add(2021-1227,num>255,num=255;num<0,num=0)（控制像素值在0-255）;

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

## 十一、//add(2021-1217，面积筛选，将默认面积area1 <= 0的情况，直接赋值为0)；

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

## 十二、//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);

```c#
//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);
CvInvoke.MatchTemplate(match_img, temp, result, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用归一化系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像；
//add(2021-1227,采用系数匹配法(CcorrNormed)，打印出匹配相似度信息,数值越大越接近准确图像);
```

## 十三、//add(2021-1228，自适应手动调整腐蚀次数，默认腐蚀次数为1)；

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

## 十四、//add(2021-1228，自适应手动调整膨胀次数，默认膨胀次数为1)；

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

## 十五、//add(2021-1228，保存图像处理结果至指定文件夹)；

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

## 十六、//显示、保存图像(2021-1228)；

```c#
//显示、保存图像(2021-1228)；
#region
//CvInvoke.Imshow("img", temp); //显示图片
CvInvoke.Imwrite("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\"+dbf_File2+"match_img1.bmp", match_img1); //保存匹配结果图像；
CvInvoke.WaitKey(0); //暂停按键等待
#endregion
//显示、保存图像(2021-1228)；
```

## 十七、//打印匹配信息,（2021-1228,保存文本信息至指定文件夹）；

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

## 十八、//(add,2021-1228,在匹配信息文本中添加轮廓面积信息，使用Stream将两次打印的txt信息拼接在一起）；

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

## 十九、//(2022-0105,打印信息至Excel表中，用流创建.xlsx文件,将两次信息打印在一张Excel表中，需将该方法放置在后面需打印的位置处；如：轮廓总面积)；

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

## 二十、VS编译出现错误，CS1061“object”未包含“Text”的定义，并且找不到可接受第一个“object”类型参数的可访问扩展方法“Text”(是否缺少 using 指令或程序集引用?)

```c#
//(add,2021-1229,将label.Text改为：(label as TextBox).Text)
label.Text == dt.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");  //mm-dd才显示08-01，否则显示8-1;fff个数表示小数点后显示的位数，这里精确到小数点后3位;
//当输入上述语句时，会出现如下错误：CS1061“object”未包含“Text”的定义，并且找不到可接受第一个“object”类型参数的可访问扩展方法“Text”(是否缺少 using 指令或程序集引用?)
//此时，需将上述代码改为如下所述即可：
(label as TextBox).Text = dt.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
//(add,2021-1229)
```

## 二十一、打印时间

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

## 二十二、(XOR,异或，switch、While、for循环、2022-0104);

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

## 二十三、字节数组转化为图像（2022-0105）；

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

## 二十四、图像转化为字节数组（2022-0105）；

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

## 二十五、打开单张图像某文件夹中单张图像（2022-0106）；

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

## 二十六、EmguCV Image类中的函数

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

## 二十七、Emgu函数总结：

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

## 二十八、Emgu中Mat<--->Image转换；

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

## 二十九、自动模式下，遍历文件夹（需要添加对话框下：folderBrowserDialog控件；）获取匹配区域并画出矩形框(2011-0105）；

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

## 三十、判断Emgu图像类型是否为空

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

## 三十一、数组的使用

```c#
//数组初始化(2022-0107--start);
1、字面值形式指定数组完整内容；
int [] myIntArray = {1,2,3,5,7,9};//myIntArray有5个元素，每个元素被赋予一个整数值；
2、指定数组大小，再使用关键字new初始化所有数组元素；
int [] myInatArray = new int[5];//使用关键字new显示初始化数组，用常量值(5)定义大小，
3、使用非常量的变量进行初始化；
int [] myIntArray = new int [arraysize];
4、字面值形式+指定数组大小，（使用new）初始化所有数组元素；
int [] myIntArray = new int[5] {2,3,4,5,6};//使用这种方式时，数组大小与元素个数必须一致；
//若如下：
    int [] myIntArray = new int [5] {1,2,34};//数组定义十个元素，但实际仅定义3个元素，故编译失败；
//若使用变量定义其大小，该变量必须是一个常量，如：
const int arraySize = 5;
int [] myIntArray = new int[arraySize] {1,2,3,4,5};//若忽略了关键字const，则编译会失败；
//数组初始化(2022-0107--end);

//(数组使用case1,2022-0107--start);
string [] friendNames = { "jack", "black", "michael" };
int i;
Console.WriteLine("Here are {0} of my friends:",friendNames.Length);
for (i = 0; i < friendNames.Length; i++) 
{

    Console.WriteLine("Name with index of {0}: {1}",i, friendNames[i]);
}
Console.ReadKey();
//(数组使用case1,2022-0107--end);

//(数组使用case2,2022-0107--start);
string[] workDay = { "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday", "Saturday", "Sunday"};
int i;
Console.WriteLine("There are {0} days in a week", workDay.Length);
for(i=0; i<workDay.Length; i++)
{
Console.WriteLine("The index of {0} is {1}",i, workDay[i]);
}
Console.ReadKey();
//(数组使用case2,2022-0107--end);

//多维数组（2022-0107--start）
//多维数组使用多个索引访问其元素数组；

```

## 三十二、foreach循环；

```c#
//foreach循环(foreach循环对数组仅进行只读操作，不可改变任何元素的值)可用于定位数组中的每个元素（2022-0107--start）；
//数组使用(20220-0107)；
string[] workDays = { "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday", "Saturday", "Sunday" };
int j;
Console.WriteLine("There are {0} days in a week", workDays.Length);

//foreach循环(2022-0107)；
foreach(string workDay in workDays)
{
Console.WriteLine(workDay);
}

//for (j = 0; j < workDays.Length; j++)
//{
//    Console.WriteLine("The index of {0} is {1}", j, workDays[j]);
//}
Console.ReadKey();
//foreach循环可用于定位数组中的每个元素（2022-0107--end）；

//foreach 循环（2022-0111--start）；
            string[] workMonths = { "January", "February", "March" , "April" , " May", "June", "July", "August", "September" , "October" , "November", "December" };
            Console.WriteLine("There are {0} months in a year",workMonths.Length);
            foreach (string workMonth in workMonths) 
            {
                Console.WriteLine(workMonth);
            }

            Console.ReadKey();
//foreach 循环（2022-0111--end）；
```

## 三十三、将两次txt文本信息及Excel打印在一起（2022-0110）；

```c#
//*********************************************************//
//************加载模板及匹配图像（2022-0110--start）***********//
//********************************************************//

//********************************************************//
//*******************************************************//
//**********************添加表头(2022-0110-start)**************************//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.Util;
using System.Runtime.Serialization;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.Cuda;
using System.IO;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Diagnostics;
using System.Threading;
//********************************************************//
//*******************************************************//
//**********************添加表头(2022-0110-end)**************************//

//**************************************************//
//**************************************************//
//***************定义自变量（2022-0110--start）*************************//
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

    //加载整个文件夹(2022-0106--start)；
    List<string> typeList = new List<string>();

    String defaultfilepath;
    Int32 picturecount = 0;  //图片总数
    //Int32[] classcount;      //各类图片计数

    Int32 classcount = 1;      //各类图片计数

    Thread thread1;
    Int32 ComboBoxindex = 0;
    //加载整个文件夹(2022-0106--end)；

    public Form1()
    {
        InitializeComponent();

        defaultfilepath = "";
        //加载、显示图像；
        #region
        //Image<Bgr, byte> img = new Image<Bgr, byte>("D:\\img\\HIGH\\Image0002.bmp");//加载图像；
        //pictureBox1.Image = img.ToBitmap();//显示图像；
        //Image<Bgr, byte> temp = new Image<Bgr, byte>("D:\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Image_temp00.bmp");//加载模板图像；
        #endregion
    }
}
//**************************************************//
//**************************************************//
//***************定义自变量（2022-0110--end）*************************//

//**************************************************//
//************自动模式下--加载模板及匹配图像（2022-0110--start）***********//
//**************************************************//

private void LoadTemplate1_Click(object sender, EventArgs e)
{
/***********************自动/自动模式下---1-Start；************************************/
/***********************自动/自动模式下---1-加载模板图像；************************************/
/*****************(add,(2021-1231))**************************************/
/******************相当于(LoadTemplate_Click)**********************/


OpenFileDialog OpenFileDialog = new OpenFileDialog();
OpenFileDialog.Filter = "JPEG;BMP;PNG;JPG;GIF|*.JPEG;*.BMP;*.PNG;*.JPG;*.GIF|ALL|*.*";//（模板和加载图像尺寸不一致时，会报错）;
if (OpenFileDialog.ShowDialog() == DialogResult.OK)
{
//(add-2021-1228,保存处理后的图像至指定文件夹)
dbf_File = OpenFileDialog.FileName;
//string dbf_File1 = System.IO.Path.GetFileName(dbf_File);

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
CvInvoke.Imwrite(@"D:\SKQ\VS-Code\Demo\Emgu.CV.CvEnum\Emgu.CV.CvEnum\bin\Debug\test\temp_image_result\" + dbf_File2 + "_temp.bmp", temp); //保存匹配结果图像；
CvInvoke.WaitKey(0); //暂停按键等待
#endregion
}
}

private void Matchimage1_Click(object sender, EventArgs e)
{
//string dbf_File = string.Empty;

/****************自动模式下---2-加载待匹配图像并画出矩形框；*********************/
/**********************************（add,2021-12-31);***********************/
/**************************与line131一致（Matchimage_Click）*****************/


//OpenFileDialog OpenFileDialog = new OpenFileDialog();
OpenFileDialog.Filter = "JPEG;BMP;PNG;JPG;GIF|*.JPEG;*.BMP;*.PNG;*.JPG;*.GIF|ALL|*.*";//（模板和加载图像尺寸不一致时，会报错）;

OpenFileDialog.Multiselect = true;//(2021-1231)该值确定是否可以选择多个文件;

if (OpenFileDialog.ShowDialog() == DialogResult.OK)
{

string[] files = OpenFileDialog.FileNames;//(2021-1231)该值确定是否可以选择多个文件;

//(add-2021-1228,保存处理后的图像至指定文件夹)
dbf_File = OpenFileDialog.FileName;
//string dbf_File1 = System.IO.Path.GetFileName(dbf_File);

string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile
//(add-2021-1228,保存处理后的图像至指定文件夹)

try
{
match_img = new Image<Bgr, Byte>(OpenFileDialog.FileName);
Mat result1 = new Mat(new Size(match_img.Width - temp.Width + 1, match_img.Height - temp.Height + 1), DepthType.Cv32F, 1);//创建mat存储输出匹配结果；
CvInvoke.MatchTemplate(match_img, temp, result1, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);//采用系数匹配法，数值越大越接近准确图像；

//CvInvoke.Normalize(result1, result1, 1, 0, Emgu.CV.CvEnum.NormType.MinMax); //对数据进行（min,max;0-255）归一化；
//double max = 0, min1 = 0;//创建double极值；
//Point max_loc = new Point(0, 0), min_loc1 = new Point(0, 0);//创建dPoint类型，表示极值的坐标；
CvInvoke.MinMaxLoc(result1, ref min, ref max, ref min_loc, ref max_loc);//获取极值及其坐标；

match_img1 = match_img.Copy(); //将原图match_img复制到match_img1中，对match_img1进行画矩形框，避免pictureBox3显示匹配区域出现边框；
CvInvoke.Rectangle(match_img1, new Rectangle(max_loc, temp.Size), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；
pictureBox2.Image = match_img1.ToBitmap();//显示找到模板图像的待搜索图像；

}
catch (System.Exception ex)
{
MessageBox.Show("图像格式错误！");
}
//*********************************************************//
//************加载模板及匹配图像（2022-0110--end）***********//；
//********************************************************//

//遍历整个文件夹（2022-0110）；
private void folder_Click(object sender, EventArgs e)
{
/*******************************测试整个文件夹(加载待匹配图像)--start************************/
/*****************************(2022-0105)***************************/
/*****************************(2022-0105)***************************/

//文件夹测试(2022-0106--start)；
picturecount = 0;

#region
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
#endregion

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

//遍历文件(2022-0110,foreach循环仅对数组内容进行只读访问，不改变数组元素的值);
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

    if (match_img == null)
    {
        Invoke((EventHandler)delegate { label18.Text = "无法加载文件！"; });
        Invoke((EventHandler)delegate { label18.Refresh(); });
        return;
    }

    //开始时间
    #region
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
    #endregion
    picturecount++;

    //保存图像（NG\OK）；
    #region
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
    #endregion

    Invoke((EventHandler)delegate { label13.Text = "图片总数：" + picturecount.ToString(); });
    Invoke((EventHandler)delegate { label13.Refresh(); });


    //检测内容
    Invoke((EventHandler)delegate { pictureBox2.Image = BitmapExtension.ToBitmap(match_img); });
    Invoke((EventHandler)delegate { pictureBox2.Refresh(); });

    //显示label信息：图片测试结果、可能性、处理总时间；
    #region
    //Invoke((EventHandler)delegate { label1.Text = "图片测试结果为：" + typeName + "  可能性为：" + classProb.ToString("0.00000") + "  处理总时间为：" + timespan.ToString() + "ms"; });
    //Invoke((EventHandler)delegate { label1.Refresh(); });
    #endregion

    /****************自动模式下---2-加载待匹配图像并画出矩形框(--start)；*********************/
    /**********************************（add,2022-0106--start);***************************/
    /************************************相当于(Matchimage_Click)*****************************/

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
    /**********************************（add,2022-0106--end);***************************/
    /************************************相当于(Matchimage_Click)*****************************/



    /****************自动模式下---3-获取匹配区域并打印匹配文本信息(--start)；*********************/
    /**********************************（add,2022-0106--start);*******************************/
    /*********************************相当于(MatchingArea_Click)***********************************/

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


    //////datetime格式化并在Excel表中写入时间数据；
    #region
    //DateTime dt = DateTime.Now;

    ////在Excel表中写入时间数据时，设置单元格格式，自定义格式yyyy-MM-dd HH:mm:ss
    //(label as TextBox).Text = dt.ToLocalTime().ToString();   //mm-dd才显示08-01，否则显示8-1
    ////fff个数表示小数点后显示的位数，这里精确到小数点后3位
    #endregion

    ////datetime格式化；
    DateTime dt1 = DateTime.Now;

    //打印匹配信息（2021-1228,保存文本信息至指定文件夹）；(nextFile.Extension:图像名称；nextfile.FullName：完整路径)
    displab2.Text = "时间:" + dt1.ToLocalTime().ToString() + "\n" + "图像名称：" + nextfile.FullName + "\n" +
                    "\n" + "匹配信息: X= " +
                     max_loc.X + "," + " Y= " + max_loc.Y + ";" +
                    "\n" +
                    "最大相似度: " + max.ToString("f2") + ";" + "\n" +
                    "最小相似度: " + min.ToString("f2") + ";" + "\n" + "\n";

    //（2021-1228,保存文本信息至指定文件夹）；
    string txt2 = displab2.Text;
    string filename2 = @"D:\SKQ\VS-Code\Demo\Emgu.CV.CvEnum\Emgu.CV.CvEnum\bin\Debug\test\txt_result\匹配信息.txt";   //文件名，可以带路径

    FileStream fs2 = new FileStream(filename2, FileMode.Append);
    StreamWriter wr2 = null;
    wr2 = new StreamWriter(fs2);

    //System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
    wr2.Write(displab2.Text);
    wr2.Close();
    //（2021-1228,保存文本信息至指定文件夹）；
    #region
    //（add-2021-1229）将文本信息（dislab.Text）保存至Excel表格中；
    //string sContext = displab.Text;// 控件的内容
    //string sExcelPath = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.xlsx"; //excel路径
    //int iSheet = 1;

    // 连接Excel
    //Application app = new Application();
    //WorkBook WB = app.Workbooks.Open(sExcelPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
    //WorkSheet WS = (Worksheet)WB.Worksheets[iSheet];
    //Range range = (Range)worksheet.Cells[iRow, iCol]; ////得到指定行列的单元格
    //range.Value2 = sContext; // 对单元格赋值

    //（add-2021-1229）将文本信息（dislab.Text）保存至Excel表格中；



    //向单元格中写数据(2021-1229,循环写入行、列数据，先定义行数，再定义列数);

    ////datetime格式化；
    //DateTime dt1 = DateTime.Now;

    ////在Excel表中写入时间数据时，设置单元格格式，自定义格式yyyy-MM-dd HH:mm:ss
    //string current_time = dt1.ToString("yyyy-MM-dd HH:mm:ss.fff");   //mm-dd才显示08-01，否则显示8-1
    ////fff个数表示小数点后显示的位数，这里精确到小数点后3位


    //(add-2021-1228,保存处理后的图像至指定文件夹)
    //MessageBox.Show(dbf_File2);//add(filename-2021-1228);
    //(add-2021-1228,保存处理后的图像至指定文件夹)
    #endregion
    /****************自动模式下---3-获取匹配区域并打印匹配文本信息(--end)；*********************/
    /**********************************（add,2022-0106--end);*******************************/
    /*********************************相当于(MatchingArea_Click)***********************************/
     
/****************自动模式下---将两次打印的匹配文本信息输出在一个txt文本中（2022-0110）；*********************/
/********************自动模式下---8-进行二值化轮廓筛选及面积运算(2022-01010--start)******************************************/
/******************* (add-2022-0110,轮廓运算--start）**************************************************************/
/*********************相当于(BinarizedContour_Click--start)***********************************************************/

// canny算子；
#region
//Mat corrosion_img = binary;
//Mat corrosion1 = new Mat();//创建Mat，存储处理后的图像；
//Mat struct_element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));//指定参数获得结构元素；
////指定参数进行形态学开操作；
//CvInvoke.MorphologyEx(corrosion_img, corrosion1, Emgu.CV.CvEnum.MorphOp.Open, struct_element, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));

////开运算2（先腐蚀后膨胀）；
//Mat img7 = corrosion1;
//Mat corrosion2 = new Mat();//创建Mat，存储处理后的图像；
//Mat struct_element1 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));//指定参数获得结构元素；
////指定参数进行形态学开操作；
//CvInvoke.MorphologyEx(img7, corrosion2, Emgu.CV.CvEnum.MorphOp.Open, struct_element1, new Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
#endregion

//(add-2021-1228,保存处理后的图像至指定文件夹)
//dbf_File = OpenFileDialog.FileName;
//string dbf_File1 = System.IO.Path.GetFileName(dbf_File);

//string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile
//(add-2021-1228,保存处理后的图像至指定文件夹)

//(add-2021-1228,显示图像名称)
//MessageBox.Show(dbf_File2);//add(filename-2021-1228);
//(add-2021-1228,显示图像名称)

contour_img = swell;

CvInvoke.Canny(contour_img, canny_img, 120, 180); //指定阈值（第一阈值：120，第二阈值：180）进行Canny算子处理(这里是否需要Canny算子？？)；                       

VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();//创建VectorOfVectorOfPoint类型，用于存储查找到的轮廓；
//add(1215，用于面积筛选)
VectorOfVectorOfPoint use_contours = new VectorOfVectorOfPoint();//创建VectorOfVectorOfPoint类型，用于存储筛选后的轮廓；
//add(1215，用于面积筛选)

//(RetrType.External:提取最外层轮廓；RetrType.List:提取所有轮廓;Emgu.CV.CvEnum.RetrType.Ccomp检索所有轮廓，并将它们组织成两级层级结构：水平是组件的外部边界，二级约束边界的洞）；
CvInvoke.FindContours(canny_img, contours, null, Emgu.CV.CvEnum.RetrType.Ccomp, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);//查找dst所有轮廓并保存（contour_img<-->canny_img）；                                                            

//add(2021-1217，面积筛选)
//遍历完所有面积，打印总面积；
double sum_area = 0;
int ksize = contours.Size;//获取连通区域的个数；
for (int i = 0; i < ksize; i++)//遍历每个连通轮廓；
{
    VectorOfPoint contour = contours[i];//获取独立的连通轮廓；
    double area = CvInvoke.ContourArea(contour);//计算连通轮廓的面积；

    double area1 = Convert.ToDouble(textBox7.Text);//实现string类型到double类型的转换;
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
//打印轮廓总面积信息；
displab3.Text = "轮廓总面积: " + sum_area.ToString() + ";" + "\n" + "\n" + "\n";//打印遍历完的总面积（0044轮廓面积,当阈值选择30时，显示出错,试试RetrType.Ccomp）


//打印匹配信息（2021-1228,保存文本信息至指定文件夹）；
#region
//displab.Text = dbf_File2 + "\n" +
//"轮廓总面积:  " + sum_area.ToString();

////（2021-1228,保存文本信息至指定文件夹）；
//string txt = displab1.Text;
//string filename = "D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息1.txt";   //文件名，可以带路径

//System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
//sw.Write(displab1.Text);
//sw.Close();
#endregion
//(add,2021-1228,在匹配信息Txt文本中添加轮廓面积信息)；
string txt3 = displab3.Text;
string filename3 = @"D:\SKQ\VS-Code\Demo\Emgu.CV.CvEnum\Emgu.CV.CvEnum\bin\Debug\test\txt_result\匹配信息.txt";   //文件名，可以带路径

FileStream fs3 = new FileStream(filename3, FileMode.Append);
StreamWriter wr3 = null;
wr3 = new StreamWriter(fs3);

//System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
wr3.Write(displab3.Text);
wr3.Close();
//(add,2021-1228,在匹配信息Txt文本中添加轮廓面积信息)；
       
//将数据通过Stream写入Excel表格(2022-0110)；
//(add-2021-1231)用流创建或读取.xlsx文件（同时流关联了文件）；
filestream = new FileStream(@"D:\SKQ\VS-Code\Demo\Emgu.CV.CvEnum\Emgu.CV.CvEnum\bin\Debug\test\xlsx_result\匹配信息.xlsx", FileMode.OpenOrCreate);
//(add-2021-1231)用流创建或读取.xlsx文件（同时流关联了文件）

//add(2022-0110)
DirectoryInfo folder1;

folder1 = new DirectoryInfo(defaultfilepath);

//遍历文件
//foreach (FileInfo nextfile in folder1.GetFiles())
//{

    //创建表和sheet;
    if (indexOfExcel_j == 1)
    {
        wk = new XSSFWorkbook();   //创建表对象wk
        isheet = wk.CreateSheet("Sheet1");   //在wk中创建sheet1
                                             //创建表头
        IRow rowtitle = null;
        rowtitle = isheet.CreateRow(0); //创建index=j的行

        ICell cellTitle0 = null;
        cellTitle0 = rowtitle.CreateCell(0); //在index=j的行中创建index=0的单元格
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


    //向单元格中写数据(2021-1231,循环写入行、列数据，先定义行数，再定义列数，这里是2行6列);
    //for (int indexOfExcel_j = 1; indexOfExcel_j < 3; indexOfExcel_j++)//(j:行)；
    //{

    //IRow row2 = null;
    //row2 = isheet.CreateRow(indexOfExcel_j++); //创建index=j的行

    ////datetime格式化；
    DateTime dt2 = DateTime.Now;

    rowWrite = isheet.CreateRow(indexOfExcel_j++); //创建index=j的行

    ICell cell0 = null;
    cell0 = rowWrite.CreateCell(0);  //在index=j的行中创建index=0的单元格
    cell0.SetCellValue(dt2.ToLocalTime().ToString()); //给创建的单元格赋值string

    ICell cell1 = null;
    cell1 = rowWrite.CreateCell(1);  //在index=j的行中创建index=0的单元格
    cell1.SetCellValue(nextfile.FullName); //给创建的单元格赋值string

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


    //显示、保存图像；
    #region
    //CvInvoke.Imshow("img", temp); //显示图片
    CvInvoke.Imwrite(@"test/mask_result/" + Path.GetFileName(nextfile.FullName), mask); //保存匹配结果图像；
    CvInvoke.WaitKey(0); //暂停按键等待
    #endregion
} //add(2022-0110)
//add(2022-0110，和前面遍历文件Line232的foreach (FileInfo nextfile in folder.GetFiles())中的'{'相对应);   
```

## 三十四、创建并遍历多维数组（2022-0111）；

```c#
double [,] hillhight = new double[3,4];//声明一个四维数组（3行四列）；
//使用字面值进行初始赋值，这里使用嵌套花括号,用逗号分隔开；
double [,] hillhight = {{1,2,3,4},{2,3,4,5},{3,4,5,6}}；//与上述数组大小一样，也是3行四列；
//若要访问多维数组中的个元素，只需指定索引即可，并用都好分开；
hillhight[2,1]//访问上述定义的第三个嵌套数组中的第二个元素（4）；
//遍历多维数组（2022-0111--start）；
            double[,] hillhight = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };//与上述数组大小一样，也是3行四列；
            foreach(double height in hillhight)
            {
                Console.WriteLine("{0}",height);
            }
//遍历多维数组（2022-0111--end）；

//数组的数组（如锯齿数组（jagged array）--2022-0111--start）;
jaggedArray = new int[2][];
jaggedArray[0] = new int[3];
jaggedArray[1] = new int[4];
//或者使用上述字面值赋值的一种改进方式；
jaggedArray = new int[3][]{new int[]{1,2,3},new int[]{1},new int[]{1,2}};
//或者把数组的初始化和声明放在同一行上进行简化；
int[][] jaggedArray ={new int[]{1,2,3},new int[]{1},new int[]{1,2}};
//对锯齿数组进行foreach循环操作（需使用嵌套的foreach循环）；
int[][] divisors1To10 = {new int[]{1},
                         new int[]{1,2},
                         new int[]{1,3},
                         new int[]{1,2,4},
                         new int[]{1,5},
                         new int[]{1,2,3,6},
                         new int[]{1,7},
                         new int[]{1,2,4,8},
                         new int[]{1,3,9},
                         new int[]{1,2,5,10}};
//若使用如下foreach循环会报错；
foreach (int divisor in divisors1To10)
{
    Console.WriteLine(divisor);
}
//数组divisors1To10包含int[]元素而不是int元素，正确的做法是循环遍历每个子数组和数组本身；
foreach (int[] divisorOfInt in divisors1To10)
{
    foreach (int divisor in divisors1To10)
    {
        Console.WriteLine(divisor);
    }
}
//数组的数组（如锯齿数组（jagged array）--2022-0111--end                        
```

## 三十五、字符串处理（2022-0111）；

```c#
//string类型变量可以看成是char变量的只读数组，可使用下列语法访问个字符；
strting myString = "A string";
char myChar = myString[1];
//但不能采用这种方式为各字符赋值，若要获取可写char数组，使用数组变量ToCharArray()命令；
string myString = "A string";
char[] myChars = myString.ToCharArray();
//此时，即可处理char数组，也可在foreach循环中使用字符串，
foreach (char character in myString)
{
    Console.WriteLine("{0}",character);
}

//还可使用myString.Length获取元素个数，
string myString = Console.ReadLine();
Console.WriteLine("You typed{0} characters.",myString.Length);

//<string>.ToLower；字符串转换成小写；
//<string>.ToUpper；字符串转换成大写；
Console.WriteLine("请输入单词:");
string userResponse = Console.ReadLine();
if (userResponse.ToLower() == "yes")
{
    //Act on response.
}
userResponse = userResponse.ToLower();
//userResponse.ToLower();
Console.WriteLine("转化后的小写单词是：{0}", userResponse);
Console.ReadKey();

//<string>.TrimStart()；删除字符串前面的空格；
//<string>.TrimEnd()；删除字符串后面的空格；
//<string>.PadLeft()；在字符串左边添加空格；
//<string>.PadRight()；在字符串右边添加空格；

//字符串分割；
class Program
{
    static void Main(string[] args)
    {
        string myString = "This is a test.";
        char[] separator = {' '};
        string[] myWords;
        myWords = myString.Split(separator);//通过''及Split分割字符串；
        foreach (string word in myWords)
        {
            Console.WriteLine("{0}", word);
        }
        Console.ReadKey();
    }
}
}
//列表可以存储一维数组，通过列表的嵌套可以实现多维数组;数组中的所有元素的类型都是相同的，而列表中的元素类型是任意的;

//字符串逆序打印（2022-0112）；
Console.WriteLine("Enter a number or string");
string myString = Console.ReadLine();
string reversedString = "";
for(int index=myString.Length-1;index >=0; index--)
{
    reversedString += myString[index];
}
Console.WriteLine("逆序打印结果是：{0}",reversedString);
Console.ReadKey();

//字符串替换(Replace,2022-0112)；
//case1:
Console.WriteLine("Enter a string:");
string myString = Console.ReadLine();
myString = myString.Replace("no", "yes");
Console.WriteLine("转换后的字符串是{0}", myString);
Console.ReadKey();

 //case2(给字符串加双引号):
Console.WriteLine("Enter a string:");
string myString = Console.ReadLine();
myString = "\"" + myString.Replace(" ", "\" \"")+ "\"";
Console.WriteLine("转换后的字符串是{0}", myString);
Console.ReadKey();
```

## 三十六、static 变量，static函数（2022-0112）；

```c#
//static 函数 —— 内部函数和外部函数
当一个源程序由多个源文件组成时，Ｃ语言根据函数能否被其它源文件中的函数调用，将函数分为内部函数和外部函数。
//1 内部函数(类变量)；（又称静态函数--static）
如果在一个源文件中定义的函数，只能被本文件中的函数调用，而不能被同一程序其它文件中的函数调用，这种函数称为内部函数。
定义一个内部函数，只需在函数类型前再加一个“static”关键字即可，如下所示：
static 函数类型 函数名(函数参数表)
    
//static函数定义（2022-0112--start）；
class program
    static void write() //write()类型为static类型，返回值是void;
{
    Console.WriteLine("Text output from function");
}
	static void Main(string[] args)
    {
        Write();
        Console.ReadKey();
    }
//static函数定义（2022-0112--end）；

//关键字“static”，译成中文就是“静态的”，所以内部函数又称静态函数。但此处“static”的含义不是指存储方式，而是指对函数的作用域仅局限于本文件。
//使用内部函数的好处是：不同的人编写不同的函数时，不用担心自己定义的函数，是否会与其它文件中的函数同名，因为同名也没有关系。

//2 外部函数(--extern)
外部函数的定义：在定义函数时，如果没有加关键字“static”，或冠以关键字“extern”，表示此函数是外部函数：
[extern] 函数类型 函数名(函数参数表)
    
//extern函数定义(全局变量)；（2022-0112--start）；
#ifndef TEST1H
#define TEST1H
extern char g_str[]; // 声明全局变量g_str
void fun1();
#endif
//extern函数定义(全局变量)；（2022-0112--end）；

调用外部函数时，需要对其进行说明：
[extern] 函数类型 函数名(参数类型表)[，函数名2(参数类型表2)……]；
   
//static变量大致分为三种用法
1. 用于局部变量中,成为静态局部变量. 静态局部变量有两个用法,记忆功能和全局生存期.
2. 用于全局变量,主要作用是限制此全局变量被其他的文件调用.
3. 用于类中的成员.表示这个成员是属于这个类但是不属于类中任意特定对象
```

## 三十七、Emgu-图像处理模式切换（手动、自动）

```c#
//模式切换选择（2022-0113--start）；
bool auto_or_manual = true;//设置全局变量；

//设置不同模式转换（手动或自动）；
private void button4_Click(object sender, EventArgs e)
{
    if(auto_or_manual)
    {
    groupBox3.Visible = false;
    groupBox1.Visible = true;
    auto_or_manual = !auto_or_manual;
    }
    else
    {
    groupBox3.Visible = true;
    groupBox1.Visible = false;
    auto_or_manual = !auto_or_manual;
    }
}
//模式切换选择（2022-0113--end）；
```

## 三十八、FormBorderStyle属性：控制winform界面放大、关闭功能属性；

## 三十九、uiTabControl1中不同TabPages切换；

```c#
//模式切换选择（2022-0120--start）；
private void uiHeaderButton1_Click(object sender, EventArgs e)
{                      
    //if (auto_or_manual)
    //{
        //uiHeaderButton1.IsPress = true; //设置默认手动模式button打开；
        //uiHeaderButton2.IsPress = false; //设置默认自动模式button关闭；
        //groupBox3.Visible = false;
        //groupBox1.Visible = true;

        //tabPage1.Visible = true;
        //tabPage2.Visible = false;

        uiTabControl1.SelectedIndex = 0;//从0开始哦，第一个tabpage1；

    //    auto_or_manual = !auto_or_manual;
    //}
    //else
    //{
    //    groupBox3.Visible = true;
    //    groupBox1.Visible = false;
    //    auto_or_manual = !auto_or_manual;
    //}
}

private void uiHeaderButton2_Click(object sender, EventArgs e)
{
    //可直接在起始界面点击自动模式(2022-0118)；
    //if (auto_or_manual)
    //{
        //uiHeaderButton1.IsPress = true; //设置默认手动模式button打开；
        //uiHeaderButton2.IsPress = false; //设置默认自动模式button关闭；
        //groupBox3.Visible = false;
        //groupBox1.Visible = true;

        //tabPage1.Visible = true;
        //tabPage2.Visible = false;
        uiTabControl1.SelectedIndex = 1;//从0开始哦，第二个tabpage2；

    //    auto_or_manual = !auto_or_manual;
    //}
    //可直接在起始界面点击自动模式(2022-0118)；

    //if (!auto_or_manual)
    //{
    //    uiHeaderButton1.IsPress = false; //设置默认手动模式button关闭；
    //    uiHeaderButton2.IsPress = true; //设置默认自动模式button打开；
    //    groupBox3.Visible = true;
    //    groupBox1.Visible = false;

    //    //tabPage1.Visible = false;
    //    //tabPage2.Visible = true;

    //    auto_or_manual = !auto_or_manual;
    //}
}
//模式切换选择（2022-0120--end）；
```

## 四十、Label默认为空；

```c#
label18.Text = ""; (2022-0125);
```

## 四十一、记忆上次打开文件夹路径(2022-0125)；

```c#
 private void folder_Click(object sender, EventArgs e)
{
    /*
    ******************************自动模式下遍历文件夹--1--测试整个文件夹(加载待匹配图像)--start************************
    *****************************(add,2022-0121)--start*************************************************************
    *****************************(add,2022-0121)--start*************************************************************
    */

    //文件夹测试(2022-0121--start)；
    picturecount = 0;

    folderBrowserDialog1.SelectedPath = defaultfilepath; //记忆上次打开文件夹路径(2022-0125)；

    //(打开文件夹函数--2022-0106--start)
    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    {
        defaultfilepath = folderBrowserDialog1.SelectedPath; //记忆上次打开文件夹路径(2022-0125)；

        thread1 = new Thread(new ThreadStart(ImageProcessingAll));//创建线程
        thread1.Start();
    }
} 
```

##  四十二、C#中OpenFileDialog获取文件名和文件路径的常用方法；

```c#
System.IO.Path.GetFullPath(openFileDialog1.FileName);  //绝对路径

System.IO.Path.GetExtension(openFileDialog1.FileName); //文件扩展名

System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);//文件名没有扩展名

System.IO.Path.GetFileName(openFileDialog1.FileName); //得到文件

System.IO.Path.GetDirectoryName(openFileDialog1.FileName);//得到路径
```

## 四十三、progressBar设置进度条；

```c#
private void ImageProcessingAll()   //处理文件指定文件夹下所有图片
{
//Mat img;  //待测试图片
 DirectoryInfo folder;

folder = new DirectoryInfo(defaultfilepath);
double pic = 0;//(图像计数-0214)；


//遍历文件夹；
foreach (FileInfo nextfile in folder.GetFiles())
{
    //Invoke((EventHandler)delegate { label2.Text = "图片名称：" + Path.GetFileName(nextfile.FullName); });
    //Invoke((EventHandler)delegate { label2.Refresh(); });

    pic++;//(图像计数-0214)；

    Point max_loc1 = new Point(0, 0);
    Point classNumber = max_loc1;    //最大可能性位置

    //string typeName = typeList[classNumber.X];

    // DirectoryInfo对象.Name获得文件夹名;.FullName获得文件夹完整的路径名(2022-0125)
    convert_img = CvInvoke.Imread(nextfile.FullName, ImreadModes.AnyColor);

    //Image<Bgr, byte> matToimg = match_img.ToImage<Bgr, byte>();


    Image<Bgr, Byte> match_img = convert_img.ToImage<Bgr, Byte>();//Mat 2 Image;

    if (match_img == null)
    {
        Invoke((EventHandler)delegate { label18.Text = "无法加载文件！"; });
        Invoke((EventHandler)delegate { label18.Refresh(); });
        return;
    }


    //(add--2022-0214--遍历文件夹内图像数量--start);
    string path = defaultfilepath;
    string[] files = Directory.GetFiles(path, "*.bmp");

    //int SumCount = 0;
    //foreach (string file in files)//遍历图像数量;
    //{
    //    SumCount++;
    //}


    //(设计进度条-0214--start)；
    //progressBar1.Value = 0;  //清空进度条
    double sumpic = (double)files.Length;
    progressBar1.Value = (int)(pic / sumpic * 100);
    label26.Text = "当前进度: " + Convert.ToInt32((int)(pic / sumpic * 100)) + '%' + "\r\n";
    Thread.Sleep(50);
    //(设计进度条-0214--end)；

    //for (int i = 0; i < files.Length; i++)
    //{
    //    progressBar1.Value += (i / files.Length);
    //    textBox2.Text = "当前进度:" + i.ToString() + '%'+ "\r\n";
    //    Thread.Sleep(50);
    //}

    //int SumCount = 0;
    //foreach (string file in files)//遍历图像数量;
    //{
    //    SumCount++;
    //}
    //(add--2022-0214--遍历文件夹内图像数量--end);

    //int SumCount = 0;
    //for (int i = 0; i < defaultfilepath.Length; i++) //遍历图像数量不对？
    //{
    //    //string[] bb = nextfile[i].Split(new char[] { '.' });
    //    //if (bb[1].ToLower() == "bmp")
    //    SumCount++;

    //}

    //开始时间；

    //int Value = default(int);

    //Value = (picturecount++ / SumCount++) * 100;//进度条不显示；

    picturecount++;
    //图像计数；
    Invoke((EventHandler)delegate { label13.Text = "图片总数：" + picturecount.ToString(); });//数量是原文件夹内2倍？
    Invoke((EventHandler)delegate { label13.Refresh(); });

    //检测内容
    Invoke((EventHandler)delegate { pictureBox11.Image = BitmapExtension.ToBitmap(match_img); });
    Invoke((EventHandler)delegate { pictureBox11.Refresh(); });
```

## 四十四、取消文件夹测试；

```c#
 private volatile bool canStop = true;//add(设置bool值canStop，控制测试取消按钮，2022-0214);
 private void Cancel_Click(object sender, EventArgs e)//取消测试按钮；
 {
    canStop = !canStop;
 }

private void folder_Click(object sender, EventArgs e)//文件夹测试按钮；
{
    /*
     ******************************自动模式下遍历文件夹--1--测试整个文件夹(加载待匹配图像)--start************************
     *****************************(add,2022-0121)--start*************************************************************
     *****************************(add,2022-0121)--start*************************************************************
     */
    //文件夹测试(2022-0121--start)；
    picturecount = 0;
    folderBrowserDialog1.SelectedPath = defaultfilepath; //记忆上次打开文件夹路径(2022-0125)；

    //(打开文件夹函数--2022-0106--start)
    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    {
        defaultfilepath = folderBrowserDialog1.SelectedPath; //记忆上次打开文件夹路径(2022-0125)；

        thread1 = new Thread(new ThreadStart(ImageProcessingAll));//创建线程(work-0214)
        thread1.Start();//(开启线程--work-0214)
    }
}

private void ImageProcessingAll()   //处理文件指定文件夹下所有图片
{
    //nMax = 0;
    //nMin = 1;
    //double dThreValue = Convert.ToDouble(ThreshTb.Text);
    //Mat img;  //待测试图片
    DirectoryInfo folder;
    folder = new DirectoryInfo(defaultfilepath);
    double pic = 0;//(图像计数-0214)；

    //遍历文件夹；
    foreach (FileInfo nextfile in folder.GetFiles())
    {
        //Invoke((EventHandler)delegate { label2.Text = "图片名称：" + Path.GetFileName(nextfile.FullName); });
        //Invoke((EventHandler)delegate { label2.Refresh(); });

        // 使用匿名方法定义线程的执行体;
        #region  
            //add(2022-0214--start);
            //thread1 = new Thread(new ThreadStart(ImageProcessingAll));//创建线程(work-0214)
            //Thread thread = new Thread(delegate (object param)
            /*{*/// 等待“停止”信号，如果没有收到信号则执行 
            //thread1 = new Thread(new ThreadStart(ImageProcessingAll));//创建线程(work-0214)
            //thread1.Start();//(work-0214)
            //if (canStop == true)//有问题，无法运行？
            //{

            //    thread1 = new Thread(new ThreadStart(ImageProcessingAll));//创建线程(work-0214)
            //    thread1.Start();//(work-0214)

            //    //ImageProcessingAll();
            //}
            // 此时已经收到停止信号，可以在此释放资源并初始化变量;

            //});
            //add(2022-0214--end);
            #endregion

            if (canStop == false)
            {
                canStop = !canStop;
                break;
                //thread1.Abort();//可暂停但不退出；

            }

        pic++;//(图像计数-0214)；

        Point max_loc1 = new Point(0, 0);
        Point classNumber = max_loc1;    //最大可能性位置

        //string typeName = typeList[classNumber.X];

        // DirectoryInfo对象.Name获得文件夹名;.FullName获得文件夹完整的路径名(2022-0125)
        convert_img = CvInvoke.Imread(nextfile.FullName, ImreadModes.AnyColor);

        //Image<Bgr, byte> matToimg = match_img.ToImage<Bgr, byte>();


        Image<Bgr, Byte> match_img = convert_img.ToImage<Bgr, Byte>();//Mat 2 Image;

        if (match_img == null)
        {
            Invoke((EventHandler)delegate { label18.Text = "无法加载文件！"; });
            Invoke((EventHandler)delegate { label18.Refresh(); });
            return;
        }


        //(add--2022-0214--遍历文件夹内图像数量--start);
        string path = defaultfilepath;
        string[] files = Directory.GetFiles(path, "*.bmp");


        /*
         *************(设计进度条-2022-0214--start)**************
         *******************************************************
         */

        //progressBar1.Value = 0;  //清空进度条
        double sumpic = (double)files.Length;
        progressBar1.Value = (int)(pic / sumpic * 100);
        label26.Text = "当前进度: " + Convert.ToInt32((int)(pic / sumpic * 100)) + '%' + "\r\n";
        Thread.Sleep(50);

        /*
         *************(设计进度条-2022-0214--end)****************
         *******************************************************
         */

        //进度条设计；
        #region
            //for (int i = 0; i < files.Length; i++)
            //{
            //    progressBar1.Value += (i / files.Length);
            //    textBox2.Text = "当前进度:" + i.ToString() + '%'+ "\r\n";
            //    Thread.Sleep(50);
            //}

            //int SumCount = 0;
            //foreach (string file in files)//遍历图像数量;
            //{
            //    SumCount++;
            //}
            //(add--2022-0214--遍历文件夹内图像数量--end);

            //int SumCount = 0;
            //for (int i = 0; i < defaultfilepath.Length; i++) 
            //{
            //    //string[] bb = nextfile[i].Split(new char[] { '.' });
            //    //if (bb[1].ToLower() == "bmp")
            //    SumCount++;

            //}
            #endregion


        //图像计数；
        picturecount++;
        Invoke((EventHandler)delegate { label13.Text = "图片总数：" + picturecount.ToString(); });
        Invoke((EventHandler)delegate { label13.Refresh(); });

        //检测内容
        Invoke((EventHandler)delegate { pictureBox11.Image = BitmapExtension.ToBitmap(match_img); });
        Invoke((EventHandler)delegate { pictureBox11.Refresh(); });
```

## 四十五、Winform左上角图标及右上角放大、缩小、退出功能；

```c#
1、在属性中选择主窗体（Form），若需要隐藏左上角窗体图标及右上角放大、缩小、退出功能键，找到FormBorderStyle，选择None；
2、若需要修改程序窗体图标，在属性中选择主窗体（Form），找到Icon，选择修改图标；
```

## 四十六、线程间操作无效: 从不是创建控件“progressBar1”的线程访问它；

```c#
/*
 *************(设计进度条-2022-0214--start)**************
 **************************************************
 */

//progressBar1.Value = 0;  //清空进度条（origin）
double sumpic = (double)files.Length;
progressBar1.Value = (int)((pic / sumpic) * 100);//(debug-0218--线程间操作无效: 从不是创建控件“progressBar1”的线程访问它。)
label26.Text = "当前进度: " + Convert.ToInt32((int)((pic / sumpic) * 100)) + '%' + "\r\n";//(work-0216)
Thread.Sleep(50);

//Invoke(2022-0221)（改用Invoke）;
double sumpic = (double)files.Length;
Invoke((EventHandler)delegate { progressBar1.Value = (int)((pic / sumpic) * 100); });
Invoke((EventHandler)delegate { label26.Text = "当前进度: " + Convert.ToInt32((int)((pic / sumpic) * 100)) + '%' + "\r\n"; });
Thread.Sleep(50);

/*
*************(设计进度条-2022-0214--end)****************
**************************************************
*/
```

## 四十七、获取当前程序运行路径，并与.exe在同一路径下；

```c#
//获取和设置包含该应用程序的目录的名称(0228)
//获取当前程序运行路径；
string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

//add--修改路径问题（设为本地路径(与.exe同一路径)--start）
path = str + "\\Result\\Temp_result";

if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}
//add--修改路径问题（设为本地路径(与.exe同一路径)--end）
//显示、保存图像；
#region
////CvInvoke.Imshow("img", temp); //显示图片
//CvInvoke.Imwrite(@"D:\SKQ\VS-Code\Demo\Template-Matching2022-0113\result\" + dbf_File2 + "_temp.bmp", temp); //保存模板图像；
CvInvoke.Imwrite(path  + "\\" + dbf_File2 + "_temp.bmp", temp); //保存至本地文件夹Result;
CvInvoke.WaitKey(0); //暂停按键等待；

//获取和设置包含该应用程序的目录的名称。(推荐)
string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
result: X:\xxx\xxx\ (.exe文件所在的目录+"\")
                     
//listbox 删除选中项;
//删除单个：
ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
//删除多个：
ListBox1.Items.Remove(ListBox1.SelectedItem);                 
```

## 四十八、在原项目基础上新建一个form窗体；

```c#
public partial class Form1 : Form
{
  Form form1 = new Form();//实体化一个Form类;
}
//利用buitton按钮打开新的窗体(form1)；
private void uiButton6_Click(object sender, EventArgs e)
{
  form1.Show();//弹出form1;
}
```

## 四十九、winform打开本地的txt文件并显示在窗体中;

```c#
private void button2_Click(object sender, EventArgs e)
{
    OpenFileDialog filename = new OpenFileDialog(); //定义打开文件
    filename.InitialDirectory = Application.StartupPath; //初始路径,这里设置的是程序的起始位置，可自由设置
    filename.Filter = "All files(*.*)|*.*|txt files(*.txt)|*.txt";//设置打开类型,设置个*.*和*.txt就行了
    filename.FilterIndex = 2;                  //文件类型的显示顺序（上一行.txt设为第二位）
    filename.RestoreDirectory = true; //对话框记忆之前打开的目录
    if(filename.ShowDialog() == DialogResult.OK)
    {
        textBox1.Text = filename.FileName.ToString();//获得完整路径在textBox1中显示
        StreamReader sr = new StreamReader(filename.FileName);//将选中的文件在textBox2中显示
        textBox2.Text = sr.ReadToEnd();
        sr.Close();
    }
}
```

## 五十、选中当前矩形框时，该矩形框红色加粗显示，并在label中显示当前选中区域坐标信息及时间；

```c#
private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
   {
    //if(ifListBoxDel == false)
    //{
 //如何获取余下列表最小索引；               
//取坐标、生成框(使用match_img图像无法画出多矩形框，仅可画出一个？？0302)
//   CvInvoke.Rectangle(match_img, new Rectangle(new Point(rectangleLocations[this.listBox1.SelectedIndex].x1, rectangleLocations[this.listBox1.SelectedIndex].y1), new Size(rectangleLocations[this.listBox1.SelectedIndex].x2 - rectangleLocations[this.listBox1.SelectedIndex].x1, rectangleLocations[this.listBox1.SelectedIndex].y2 - rectangleLocations[this.listBox1.SelectedIndex].y1)), new MCvScalar(0, 255, 0), 1);//绘制矩形，匹配得到的结果(1：调整矩形粗细)；
//CvInvoke.Rectangle(temp, new Rectangle(new Point(rectangleLocations[index].x1, rectangleLocations[index].y1), new Size(100, 100)), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；               

//创建一矩形，左上角坐标为(80,80)，大小为50*50;                      
//CvInvoke.Rectangle(match_img1, new Rectangle(new Point(80, 80), new Size(50, 50)), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；

//CvInvoke.Rectangle(match_img1, new Rectangle(max_loc, temp.Size), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；
//    pictureBox1.Image = match_img.ToBitmap();//显示找到模板图像的待搜索图像；


    //    //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
    //    path = str + "\\Template-Result\\Match_result";

    //    if (!Directory.Exists(path))
    //    {
    //        Directory.CreateDirectory(path);
    //    }
    //    //add--修改路径问题（设为本地路径(与.exe同一路径)--end）
    //    string dbf_File2 = Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile

    //    //显示、保存图像；
    //    //CvInvoke.Imshow("img", temp); //显示图片
    //    //CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_temp.bmp", temp); //保存匹配结果图像(含矩形框)；
    //    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_match_img.bmp", match_img); //保存匹配结果图像(含矩形框)；
    //    CvInvoke.WaitKey(0); //暂停按键等待
    //}
    //else
    //{
    //    ifListBoxDel = !ifListBoxDel;
    //}
    if (ifListBoxDel == false)//解决索引为-1问题（2022-0304）；
    {
        match_img = temp.Copy(); //将原图temp复制到match_img中，对match_img进行画矩形框，避免pictureBox显示匹配区域出现边框；  
        pictureBox1.Image = match_img.ToBitmap();//显示找到模板图像的待搜索图像；
        //对当前选中区域进行判断，若选中的listBox1区域与列表中的坐标完全一致时，则对当前选中的区域（列表坐标信息）进行标红并加粗显示（2022-0304）；
        for (int i = 0; i < rectangleLocations.Count; i++)
                {

                    if (rectangleLocations[this.listBox1.SelectedIndex].x1 == rectangleLocations[i].x1 &&
                       rectangleLocations[this.listBox1.SelectedIndex].y1 == rectangleLocations[i].y1 &&
                       rectangleLocations[this.listBox1.SelectedIndex].x2 == rectangleLocations[i].x2 &&
                       rectangleLocations[this.listBox1.SelectedIndex].y2 == rectangleLocations[i].y2
                        )
                    {
//取坐标、生成框(使用match_img图像画出多矩形框)
CvInvoke.Rectangle(match_img, new Rectangle(new Point(rectangleLocations[i].x1, rectangleLocations[i].y1), new Size(rectangleLocations[i].x2 - rectangleLocations[i].x1, rectangleLocations[i].y2 - rectangleLocations[i].y1)), new MCvScalar(0, 0, 255), 2);//绘制矩形，匹配得到的结果(1：调整矩形粗细)；
                                                                                                                                                                                                                                                                                  //CvInvoke.Rectangle(temp, new Rectangle(new Point(rectangleLocations[index].x1, rectangleLocations[index].y1), new Size(100, 100)), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；               
  }
            else
            {
CvInvoke.Rectangle(match_img, new Rectangle(new Point(rectangleLocations[i].x1, rectangleLocations[i].y1), new Size(rectangleLocations[i].x2 - rectangleLocations[i].x1, rectangleLocations[i].y2 - rectangleLocations[i].y1)), new MCvScalar(0, 255, 0), 1);//绘制矩形，匹配得到的结果(1：调整矩形粗细)；
                    }
//创建一矩形，左上角坐标为(80,80)，大小为50*50;                      
//CvInvoke.Rectangle(match_img1, new Rectangle(new Point(80, 80), new Size(50, 50)), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；
//CvInvoke.Rectangle(match_img1, new Rectangle(max_loc, temp.Size), new MCvScalar(0, 255, 0), 3);//绘制矩形，匹配得到的结果；

//add--修改路径问题（设为本地路径(与.exe同一路径)--start）
            path = str + "\\Template-Result\\Match_result";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


        }
        pictureBox1.Image = match_img.ToBitmap();//显示找到模板图像的待搜索图像；
        //add--修改路径问题（设为本地路径(与.exe同一路径)--end）
        string dbf_File2 = Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile 
        //显示、保存图像；
        //CvInvoke.Imshow("img", temp); //显示图片
        //CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_temp.bmp", temp); //保存匹配结果图像(含矩形框)；
        CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_match_img.bmp", match_img); //保存匹配结果图像(含矩形框)；
        CvInvoke.WaitKey(0); //暂停按键等待

//选中当前区域时，显示当前区域的坐标信息（2022-0304）；
                //datetime格式化；
                DateTime dt = DateTime.Now;
                displab.Text = "时间:" + dt.ToLocalTime().ToString() + "\n" +
                  "坐标信息: X1=" +
                  rectangleLocations[this.listBox1.SelectedIndex].x1 + "," + " Y1=" + rectangleLocations[this.listBox1.SelectedIndex].y1 + "; " +
                  "X2=" + rectangleLocations[this.listBox1.SelectedIndex].x2 + ", " +
                  "Y2=" + rectangleLocations[this.listBox1.SelectedIndex].y2 + ";" + "\n" + "\n";

            }
            else
            {
                ifListBoxDel = !ifListBoxDel;
            }
```

## 五十一、将一个模块嵌入到另一个程序软件中；

```c# 
//需将待嵌入模块的命名空间与主程序软件命名空间保持一致；
// 以下方法或属性之间的调用具有二义性(各版本动态库一定要正确引用;)
pictureBox1.Image = match_img.ToBitmap();//显示找到模板图像的待搜索图像；
//设置主窗体的IsMdiContainer属性为True;
//若Form2需要引用Form1模块，则需要将Form1的命名空间改为与Form2保持一致；
//对名称空间而言，可直接修改；但对于工程名称来说则不可以直接修改；
```
