using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;//提供对GDI+基本图形功能的访问
using System.Drawing.Drawing2D;//提供高级的二维和矢量图像功能
using System.Drawing.Imaging;//提供高级GDI+图像处理功能
using System.Drawing.Printing;//提供打印相关服务
using System.Drawing.Text;//提供高级GDI+排版功能
using System.Drawing.Design;//扩展设计时，用户界面逻辑和绘制的类。用于扩展，自定义

using System.Data.SqlClient;


namespace Exercise1
{
    class Program
    {

        #region //枚举（enum）;
        public enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        };
        #endregion

        //枚举-enum--case2;
        public enum Gender
        {
            male,
            female
        }


        //结构-struct-case2;
        public struct Person
        {
            public string _name;
            public Gender _gender;
            public int _age;
        }




        //结构体（struct）;
        #region //case1;

        //public struct Books
        //{
        //    public string title;
        //    public string author;
        //    public string subject;
        //    public int book_id;
        //};
        #endregion



        #region //case2--不能使用protected修饰符;
        //public struct s
        //{
        //    string _name; //_name--字段可存储多个变量；
        //    protected int age;  //错误，不能使用protected修饰符；
        //};
        #endregion


        #region // case3----结构不支持继承；
        //public class A
        //{

        //};
        //public struct S:A   //错误，S结构不能声明基类A(因结构不支持继承，它的函数成员也不能被继承)；
        //{
        //    string name;
        //    int age;
        //}
        #endregion


        #region //case4----构造函数(this)；
        //public struct S
        //{
        //    string name;    //声明name字段；
        //    int age;        //声明age字段；
        //    public S (string name ,int age) //带有两个参数的实例构造函数；
        //    {
        //        this.name = name;   //初始化name字段的值；
        //        this.age = age;     //初始化age字段的值;                                                                                            
        //    }
        //}
        #endregion



        #region //case5---get\set;
        //public struct Point
        //{
        //    private int x;  //私有；
        //    private int y;  //私有；
        //};

        //public int x
        //{
        //    get
        //    {
        //        return x;
        //    }
        //    set
        //    {
        //        x = value;
        //    }
        //}
        //public int y
        //{
        //    get
        //    {
        //        return y;
        //    }
        //    set
        //    {
        //        y = value;
        //    }
        //}

        //public Point(int x, int y) //声明带x和y参数的实例构造函数；
        //{
        //    this.x = x;
        //    this.y = y;
        //}


        #endregion



        #region //get\set--exercise
        //private int _userid;
        //private String _username;


        //public int id
        //{
        //    get
        //    {
        //        return _userid;
        //    }
        //    set
        //    {
        //        _userid = value;
        //    }
        //}

        //public string name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
        #endregion






        //练习1-十进制转二进制；
        #region
        //public static string ConvertIntToBinary(int n)
        //{
        //    string binary = string.Empty;    //保存二进制字符串；
        //    int i = n;   //声明i变量，并赋值为n参数的值；
        //    int m = 0;   //声明m变量，并赋值为0；

        //    while (i > 1)   //当i>1时，重复执行循环体；
        //    {
        //        i = n / 2; //取整；---- 十进制转化为八进制(i = n / 8;);
        //        m = n % 2;   //取余；---- 十进制转化为八进制（m = n % 8;）;
        //        binary = m.ToString() + binary;  //将余数添加到binary字符串中；
        //        n = i;   //将取整后的值赋值给n;
        //    }
        //    if (i > 0)    //此处必须用if;
        //    {
        //        binary = "1" + binary;   //如果余数为1，则在binary的最前面加1；
        //    }
        //    return binary;

        //}
        #endregion




        //练习2-二进制转十进制；
        #region
        //public static int ConvertBinaryToInt(string binary)
        //{
        //    //判断binary参数是否为空字符串；
        //    if(string.IsNullOrEmpty(binary) == true)
        //    {
        //        return -1;
        //    }
        //    int n = 0;  //声明n变量，并赋值为0；

        //    //处理binary中各字符串中的数字；
        //    for (int i =0; i<binary.Length; i++)
        //    {
        //        //将每一位二进制的值转为十进制的值；
        //        n += Int32.Parse(binary[i].ToString()) * (int)Math.Pow(2, binary.Length - i - 1);
        //    }

        //    return n;

        //}
        #endregion




        //数组；
        //int[] arrays = new int[10];



        //使用值(or ref)参数传递数据；
        #region
        //static int GetSum(ref int i,ref int j)
        //{
        //    i++;
        //    j++;
        //    return i + j;
        //}
        #endregion




        //使用out参数返回数据；
        #region
        //static void GetSum(int i,int j, out int sum)
        //{
        //    i++;
        //    j++;
        //    sum = i + j;
        //}
        #endregion





        //判断闰年；
        #region 
        //static void JudgeYear(int year)
        //{

        //    while (year < 0)
        //    {
        //        Console.WriteLine("输入的年份有误，请重新输入！");
        //        break;
        //    }


        //    while(year>0)
        //    {
        //        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)  //逻辑与优先级大于逻辑或；
        //        {
        //            Console.WriteLine("{0}是闰年!", year);
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("{0}非闰年！", year);
        //            break;
        //        }
        //    }


        //}
        #endregion



        //调用Switch--case;
        #region 
        //static void SwitchValue(int i)
        //{
        //    switch (i)
        //    {
        //        case 2020:
        //        case 2021:
        //            {
        //                i++;
        //                break;
        //            }

        //        case 2022:
        //            {
        //                i--;
        //                break;
        //            }

        //    }
        //    Console.WriteLine(i);
        //}
        #endregion


        //  调用 class Program下 另一class ;
        #region
        //class MyClass
        //{
        //    public  static int value = 2022;    //使用public static 即可被Main函数引用；
        //}
        #endregion




        #region//计算for循环的运算时间；
        //static void ConsumeTime()
        // {
        //     DateTime startTime = DateTime.Now;
        //     for(int i =0; i < 1000000000; i++)
        //     {
        //         string s = string.Empty;
        //     }

        //     DateTime endTime = DateTime.Now;
        //     Console.WriteLine(endTime.Subtract(startTime).Milliseconds);

        // }
        #endregion















        static void Main(string[] args)
        {


            #region //  枚举（enum）;
            //Console.WriteLine("Today is {0}", Day.Friday);
            //Console.ReadKey();
            #endregion



            #region //  结构体（struct）;
            //Books book1;
            //book1.title = "The Science of Nature";
            //book1.author = "Alice";
            //book1.subject = "Nature";
            //book1.book_id = 89757;

            //Console.WriteLine("This book's title is {0}", book1.title);
            //Console.WriteLine("This book's author is {0}", book1.author);
            //Console.WriteLine("This book's subject is {0}", book1.subject);
            //Console.WriteLine("This book's book_id is {0}", book1.book_id);

            //Console.ReadKey();
            #endregion






            #region --练习1--十进制转二进制；
            //Console.WriteLine(ConvertIntToBinary(15));  //1111;
            //Console.ReadKey();
            #endregion




            #region --练习2-二进制转十进制；
            //Console.WriteLine(ConvertBinaryToInt("1111"));  //15;
            //Console.ReadKey();
            #endregion






            #region //将控制台信息写入到指定路径下的txt中；
            //Console.WriteLine("请输入信息：");
            //string str = Console.ReadLine();
            //System.IO.File.WriteAllText(@"C:\Users\eivision\Desktop\123.txt", str);
            //Console.WriteLine("Successed!");
            //Console.ReadKey();



            //Console.WriteLine("请输入文本信息1:");
            //string motto1 = Console.ReadLine();

            //System.IO.File.WriteAllText(@"C:\Users\eivision\Desktop\123.txt",motto1);
            //Console.WriteLine("Successed!");


            //Console.WriteLine("请输入文本信息2:");
            //string motto2 = Console.ReadLine();

            //System.IO.File.AppendAllText(@"C:\Users\eivision\Desktop\123.txt", motto2);
            //Console.WriteLine("Successed!!");
            //Console.ReadKey();
            #endregion





            #region  // 数组；
            //int[] arrays = new int[10];
            //Console.WriteLine(arrays[9]);
            //Console.ReadKey();
            #endregion


            #region // 声明一个名称为MyInterface的接口；并声明一个名称为Name的属性；
            //    interface MyInterface
            //{
            //    string name
            //    {
            //        get;
            //        set;
            //    }
            //}
            #endregion



            #region //委托（delegate）声明一个名称为MyFunction的委托，并包含两个int类型参数；
            //delegate int MyFunction(int x, int y);
            #endregion




            #region //  字符串(string)、整型（int）转换；
            // 将字符串转化为数字；
            //string s = "123456";
            //int value = Int32.Parse(s);  //or(int value = Convert.ToInt32(s));

            //Console.WriteLine(value);
            //Console.ReadKey();

            // 将整型转化为字符串；
            //int i = 1223;
            //string s = i.ToString();

            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion



            #region // 判断1078543s为几天几时几分几秒；
            // 1天=24*3600= 86400；

            ///summary
            /// 对任意输入的时间（s）进行强制类型转换（string---int）;

            //Console.WriteLine("请输入时间：");

            //string s = Console.ReadLine();

            //int seconds = Int32.Parse(s);   //将字符串s强制转换，（string--int）;

            ///summary



            //int seconds = 107853;
            //int days = seconds / 86400; //天数；
            //int secs = seconds % 86400; //天数取整后，剩余秒数；

            //int hours = secs / 3600;    //时数；
            //secs = secs % 3600;    //时数取整后，剩余秒数；

            //int minus = secs / 60;  //分数；
            //secs = secs % 60; //分数取整后，剩余秒数；

            //Console.WriteLine("{0}秒，是{1}天，{2}时,{3}分，{4}秒", seconds, days, hours, minus, secs);
            //Console.ReadKey();

            #endregion




            #region //使用值(or ref)参数传递数据；
            //int i = 2022;
            //int j = 100;

            //Console.WriteLine("执行前：");
            //Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());  //i=2022;j=100;


            //int sum = GetSum(ref i, ref j);

            //Console.WriteLine("执行后：");
            //Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());  //i=2023;j=101;


            //Console.WriteLine("sum=" + sum.ToString()); //2124;
            //Console.ReadKey();
            #endregion




            #region  // 使用out参数传递数据；

            //int i = 2022;
            //int j = 100;
            //int sum;

            //Console.WriteLine("执行前：");
            //Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());  //i=2022;j=100;


            //GetSum(i, j, out sum);

            //Console.WriteLine("执行后：");
            //Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());  //i=2022;j=100;


            //Console.WriteLine("sum=" + sum.ToString()); //2124;
            //Console.ReadKey();
            #endregion



            #region//continue
            //for(int i=0; i<10;i++)
            //{
            //    if(i%2==0)  //偶数，continue跳出循环，打印出奇数；
            //    {
            //        continue;   //如果i等于2，则跳出当前循环，开始下一次；
            //    }
            //    Console.WriteLine(i.ToString());
            //    //Console.ReadKey();
            //}
            #endregion



            #region //switch--case;
            //switch("表达式")
            //{
            //    case 常量表达式1：语句块1;
            //    case 常量表达式2：语句块2;
            //    ...
            //    default: 语句块n;

            //}

            //Example
            //int i = 2022;
            //switch (i)
            //{
            //    case 2022:
            //        i++;
            //        break;
            //    case 2023:
            //        i--;
            //        break;
            //    default: break;
            //}

            //Console.WriteLine(i);
            //Console.ReadKey();
            #endregion




            #region //switch--case--exercise；
            //Console.WriteLine("请输入等级：");
            //string level = Convert.ToString(Console.ReadLine());

            //decimal salary = 3500;
            //bool b = true;

            //switch (level)
            //{
            //    case "A":
            //        salary += 500;
            //        break;

            //    case "B":
            //        salary += 200;
            //        break;

            //    case "C":
            //        salary += 0;
            //        break;

            //    case "D":
            //        salary -= 200;
            //        break;

            //    case "E":
            //        salary -= 500;
            //        break;

            //    default:
            //        Console.WriteLine("输入有误，退出程序！");
            //        b = !b;
            //        break;

            //}

            //if (b)
            //{
            //    Console.WriteLine("salary={0}", salary);
            //    Console.ReadKey();
            //}
            #endregion








            #region //for
            //int sum = 0;
            //for (int i = 0; i < 101; i++)
            //{
            //    if(i % 2  != 0) //偶数和；（若i%2==0），则求取奇数和；
            //    {
            //        continue;
            //    }
            //    sum += i;   //偶数和；
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();


            //foreach语句--Example;
            //int[] arrays = { 1,3,5,7,9,3};
            //int sum = 0;
            //foreach (int i in arrays)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion



            #region //while--break;
            //int sum = 0;
            //int i = 0;
            //while (i < 101)
            //{
            //    if (i > 50)
            //    {
            //        break;    //结束while语句；
            //    }
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion



            #region // while--continue;
            //int sum = 0;
            //int i = 0;
            //while (i < 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        i+=1;
            //        //sum += i;

            //        continue;    //continue 会跳过当前循环中的代码，强迫开始下一次循环。
            //    }

            //    sum += i;
            //    i++;

            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion


            #region // do-while;
            //int sum = 0;
            //int i = 0;
            //do
            //{
            //    sum += i;
            //    i++;
            //}
            //while (i < 101);
            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion



            #region // try--catch--finally;
            //int i = 2022;
            //int j = 0;
            //try
            //{
            //    int result = i / j;

            //}
            //catch
            //{
            //    Console.WriteLine("j变量值为0");
            //}
            //finally
            //{
            //    Console.WriteLine(j.ToString());
            //}
            #endregion



            #region // 使用using语句打开名称为123.txt文件；
            //using (TextReader reader = File.OpenText(@"C:\Users\eivision\Desktop\123.txt"))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //    Console.ReadKey();
            //}
            #endregion



            #region // lock对某个给定对象进行加锁，执行一个语句后，最后释放该锁；
            //object o = 2022;
            //lock(o) //对o对象进行加锁；
            //{
            //    o++;
            //}
            #endregion




            #region //判断是否闰年；
            //Console.WriteLine("请输入要判断的年份：");
            //string s = Console.ReadLine();


            ////将字符串转换为整型int；
            ////int year = Int32.Parse(s);
            //int year = Convert.ToInt32(s);
            ////int year = Convert.ToInt32(Console.ReadLine());

            //while (year < 0)
            //{
            //    Console.WriteLine("输入的年份有误，请重新输入！");
            //    break;
            //}


            //while (year > 0)
            //{
            //    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //    {
            //        Console.WriteLine("{0}是闰年!", year);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}非闰年！", year);
            //        break;
            //    }
            //}

            //Console.ReadKey();
            #endregion




            #region //调用switch--case;
            //int i = 2020;
            //SwitchValue(i);

            //Console.ReadKey();
            #endregion








            #region //  调用 class Program下 另一class ;


            //Console.WriteLine(MyClass.value);
            //Console.ReadKey();

            #endregion





            #region //三目运算符；（？：）
            //double a=0;
            //double b=0;
            //double max;  

            //try
            //{
            //    Console.WriteLine("请输入第一个数字a:");
            //    a = Int32.Parse(Console.ReadLine());

            //}

            //catch (System.Exception ex)
            //{
            //    Console.WriteLine("第一个数字a输入格式有误！");
            //    Console.WriteLine(ex.Message);
            //}


            //try
            //{
            //    Console.WriteLine("请输入第二个数字b:");
            //    b = Int32.Parse(Console.ReadLine());
            //}

            //catch (System.Exception ex)
            //{
            //    Console.WriteLine("第二个数字b输入格式有误！");
            //    Console.WriteLine(ex.Message);
            //}



            //max = (a > b ? a : b);
            //Console.WriteLine("max={0}", max);

            //Console.ReadKey();
            #endregion





            #region //初始化数组；
            /***************

            1、直接赋值；
            string [] str1 = {"c","c++","c#","java","python"};

            2、使用new操作符，并指定数组长度；
            string [] str2 = new string [5] {"c","c++","c#","java","python"};

            3、使用new操作符，不指定数组长度；
            string [] str2 = new string [] {"c","c++","c#","java","python"};

            4、直接设置数组的各元素值；
            string [] str4 = new string[7];
            for(int i=0; i<str4.Length;i++)
            {
                str4[i]=i.ToString();
            }

            ***************/
            #endregion

            //数组分类（一维数组、二维数组、多维数组、交错数组）；
            #region 
            //一维数组；
            //type[] arrays1;  //type可为int,double,string等；arrays1--数组名；

            //二位数组 (中括号中间有一个逗号，表示二维数组，--[,])；
            //type[,] arrays2;  //type可为int,double,string等；arrays2--数组名；

            //string[,] arrays2 = new string[10, 10];
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        arrays2[i, j] = i.ToString() + j.ToString();
            //        Console.WriteLine(arrays2[i, j]);
            //    }
            //}
            //Console.ReadKey();

            //多维数组；
            //type [,,] arrays3; //type可为int,double,string等；arrays3--数组名；

            //string[,,] arrays3 = new string[2, 5, 10];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        for (int k = 0; k < 10; k++)
            //        {
            //            arrays3[i, j, k] = i.ToString() + j.ToString() + k.ToString();
            //            Console.WriteLine(arrays3[i, j, k]);
            //        }
            //    }
            //}

            //Console.ReadKey();


            //交错数组（数组的数组）--两个中括号表示为二维交错数组；
            //type[][] arrays4;   
            //string[][] arrayj = new string[10][];
            //for (int i = 0; i < 10; i++)
            //{
            //    arrayj[i] = new string[i + 1];
            //    Console.WriteLine(arrayj[i]);
            //}
            //Console.ReadKey();
            #endregion




            #region //遍历数组；
            /***************
            //遍历数组；
            1、使用下标遍历数组（for\while等）；
            2、不使用下标（foreach）;

            //case1--使用下标(for)；
            string[] str = new string[10];
            for(int i=0; i<str.Length;i++)
            {
                str[i] = i.ToString();
            }

            //case2---不使用下标（foreach）;
            string [] str = new string[10];
            foreach(string s in str)
            {
                Console.WriteLine(s);
            }

            ****************/
            #endregion




            #region //数组练习（max\min）
            //int[] nums = new int[9];

            //int[] arrays = { 1, 32, 4, 21, 13, 24, 232, 342 };
            //int max = arrays[2];
            //int min = arrays[1];

            //int sum = 0;
            //int avg = 0;

            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    if (arrays[i] > max)
            //    {
            //        max = arrays[i];
            //    }
            //    if (arrays[i] < min)
            //    {
            //        min = arrays[i];
            //    }

            //    sum += arrays[i];
            //    avg = (sum / arrays.Length);
            //}

            //Console.WriteLine("max={0},min={1},sum={2},avg={3}", max, min, sum, avg);
            //Console.ReadKey();
            #endregion





            #region //获取数组长度；
            //int[,] array2D = new int[10, 100];
            //int length = 1;
            //for (int i = 0; i < array2D.Rank; i++)
            //{
            //    length *= array2D.GetLength(i);
            //    Console.WriteLine(length);
            //}
            //Console.ReadKey();
            #endregion



            #region//获取元素索引；

            //int[] array = new int[1000];
            //int sindex = Array.IndexOf(array, 2022);
            //int eindex = Array.LastIndexOf(array, 2022);

            //Console.WriteLine(sindex);
            //Console.WriteLine(eindex);
            //Console.ReadKey();
            #endregion


            //排序数组(Sort方法为快速排序算法，是不稳定排序，该算法时间复杂度为O(nlogn);n-数组长度)；
            #region
            //int[] arrays = { 1, 32, 2, 43, 11 };
            //Array.Sort(arrays);
            //Console.WriteLine(arrays);
            //Console.ReadKey();
            #endregion


            //反转数组；
            #region
            //int[] array = { 1, 32, 2, 43, 11 };
            //Array.Reverse(array, 10, 100);  //反转数组，从第11个元素开始，连续100个元素；
            #endregion



            //interface(接口)；



            //(实现接口)声明一个名称为 MyInterface的接口，它包含四个成员：Name属性，索引器，GetName(int userID)方法和Print事件；
            #region
            //public interface MyInterface
            //{
            //    string Name //Name属性；
            //    {
            //        get;    //get访问器，表示该属性可读；
            //        set;    //set访问器，表示该属性可写；
            //    } 

            //    string this [int index] //索引器；
            //    {
            //        get;    //get访问器，表示该属性可读；
            //        set;    //set访问器，表示该属性可写；
            //    }

            //    string GetName(int userID);
            //    event EventHandler print;

            //}
            #endregion


            //声明一个名称为D的委托，返回类型为int，方法参数为int i,int j;
            //public delegate int D(int i, int j);


            //声明一个名称为PrintEventHandler的事件委托，包含两个参数（sender:事件源；e:与该事件相关的信息）；
            //public delegate void PrintEventHandler(object sender, EventArgs e);


            #region //输入年份、月份，输出对应的该月的天数---练习1；
            //Console.WriteLine("请输入年份：");

            //try
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());


            //    Console.WriteLine("请输入月份：");
            //    int month = Convert.ToInt32(Console.ReadLine());


            //    if (year < 0)
            //    {
            //        Console.WriteLine("输入年份有误，程序退出！");
            //    }


            //    if (month < 0 || month > 12)
            //    {
            //        Console.WriteLine("输入月份有误，程序退出！");
            //    }




            //    switch (month)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("{0}年{1}月，有31天", year, month);
            //            break;


            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("{0}年{1}月，有30天", year, month);
            //            break;

            //    }




            //    bool b = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            //    if (b)
            //    {
            //        switch (month)
            //        {
            //            case 2:
            //                Console.WriteLine("{0}年{1}月，有29天", year, month);
            //                break;
            //        }
            //    }

            //    else
            //    {
            //        switch (month)
            //        {
            //            case 2:
            //                Console.WriteLine("{0}年{1}月，有28天", year, month);
            //                break;
            //        }

            //    }
            //}


            //catch(System.Exception ex)  //打印异常情况下的信息；
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //finally
            //{
            //    Console.WriteLine("----------程序运行结束--------");
            //}
            #endregion






            #region //输入年份、月份，输出对应的该月的天数---练习2；
            //Console.WriteLine("请输入年份：");
            //try
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("请输入月份：");
            //    int month = Convert.ToInt32(Console.ReadLine());

            //    int day = 0;
            //    bool y = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            //    bool m = true;

            //    if (year < 0)
            //    {
            //        Console.WriteLine("输入年份有误,程序退出！");
            //    }

            //    if (month < 0 || month > 12)
            //    {
            //        Console.WriteLine("输入月份有误，程序退出！");
            //        m = false;
            //    }

            //    if(m)
            //    {
            //        switch (month)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 8:
            //            case 10:
            //            case 12:
            //                day = 31;
            //                break;


            //            case 4:
            //            case 6:
            //            case 9:
            //            case 11:
            //                day = 30;


            //                break;

            //        }

            //        if (y)
            //        {
            //            switch (month)
            //            {
            //                case 2:
            //                    day = 29;

            //                    break;
            //            }
            //        }

            //        else
            //        {
            //            switch (month)
            //            {
            //                case 2:
            //                    day = 28;

            //                    break;
            //            }

            //        }

            //        Console.WriteLine("{0}年{1}月，有{2}天", year, month, day);
            //    }



            //}

            //catch(System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.ReadKey();
            #endregion





            #region //判断用户名及密码是否正确，并于3次后结束程序---练习;
            //string userName = "";
            //string userPwd = "";
            //int i = 0;

            //while ((userName != "admin" || userPwd != "88888888") && (i < 3))
            //{
            //    Console.WriteLine("用户名不得为空，请输入用户名：");
            //    userName = Console.ReadLine();

            //    Console.WriteLine("用户名密码不得为空，请输入用户名密码：");
            //    userPwd = Console.ReadLine();

            //    i++;

            //}

            //if((userName == "admin" && userPwd == "88888888") && (i < 3))
            //{
            //    Console.WriteLine("Welcome to niuma world!");
            //}
            //Console.ReadKey();
            #endregion





            //声明一个名称为year的隐形局部变量；
            //var year = 2022;




            #region //case1-----(输出输入数字的2倍，输入q时退出程序)；

            //while (true)
            //{
            //    Console.WriteLine("请输入数字,输入q退出程序！");
            //    string input = Console.ReadLine();


            //    try
            //    {
            //        if (input != "q")
            //        {

            //            int a = Int32.Parse(input);

            //            Console.WriteLine(a * 2);

            //        }

            //        else
            //        {
            //            Console.WriteLine("退出程序！");
            //            break;
            //        }

            //    }

            //    catch(System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    Console.ReadKey();

            //}
            #endregion




            #region//case1---练习1--请输入正整数，并打印其2倍，当输入为q时，则退出程序！
            //while(true)
            //{
            //    Console.WriteLine("请输入正整数，并打印其2倍，当输入为q时，则退出程序！");
            //    string input = Console.ReadLine();

            //    try
            //    {
            //        if (input != "q")
            //        {
            //            int a = Int32.Parse(input);
            //            Console.WriteLine(a * 2);

            //        }

            //        else
            //        {
            //            Console.WriteLine("退出程序！");
            //            break;
            //        }
            //    }


            //    catch(System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    Console.ReadKey();
            //}
            #endregion






            #region //case2----(输入正整数，当输入end时，显示当前输入最大值\最小值)；

            //string input = "";
            //int max = 0;
            //int min = 10;

            //while (true)
            //{
            //    Console.WriteLine("输入正整数，当输入end时，显示最大值、最小值");
            //    input = Console.ReadLine();

            //    try
            //    {
            //        if (input != "end")
            //        {
            //            int a = Int32.Parse(input);

            //            if (a > max)
            //            {
            //                max = a;
            //            }

            //            if(a<min)
            //            {
            //                min = a;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("max={0},min={1}", max,min);
            //            break;
            //        }
            //        Console.ReadKey();
            //    }

            //    catch (System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    Console.ReadKey();

            //}
            #endregion





            #region //case2----练习1--输入正整数，当输入end时，显示最大值、最小值；
            //string input = "";
            //int min = 5;
            //int max = 0;

            //while(true)
            //{
            //    Console.WriteLine("输入正整数，当输入end时，显示最大值、最小值");
            //    input = Console.ReadLine();

            //    try
            //    {
            //        if (input != "end")
            //        {
            //            int a = Int32.Parse(input);

            //            if (a > max)
            //            {
            //                max = a;
            //            }

            //            if (a < min)
            //            {
            //                min = a;
            //            }


            //        }

            //        else
            //        {
            //            Console.WriteLine("退出程序！");
            //            Console.WriteLine("min={0},max={1}", min, max);
            //            break;

            //        }
            //    }

            //    catch(System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //    Console.ReadKey();
            //}
            #endregion




            #region //获取当前时间；yyyy-MM-dd hh:mm:ss
            //DateTime time = DateTime.Now;
            //string timeString = String.Format("yyyy-MM-dd hh:mm:ss", value);


            //将一段文本分割为每一个单词；
            //string text = "To Be Or Not To Be,This Is A Question!";
            //string words = text.Split(new char[] {''});

            //DateTime maxdt = DateTime.MaxValue;
            //DateTime time = DateTime.Now;

            //Console.WriteLine(time);
            //Console.ReadKey();

            //IsLeapYear(int year)判断指定年份是否为闰年，如果是：返回true;如果否，返回false;
            //bool IsLeapYear = DateTime.IsLeapYear(2010);
            //Console.WriteLine(IsLeapYear);
            //Console.ReadKey();

            //Substract--计算时间差;
            //TimeSpan ts = new TimeSpan(1, 1, 2, 3, 40);
            //DateTime subdt = DateTime.Now.Subtract(ts);

            //Console.WriteLine(subdt);
            //Console.ReadKey();


            //add-添加时间；
            //DateTime adddt = DateTime.Now.AddDays(1);//在当前时间基础上添加一天；
            //Console.WriteLine(adddt);
            //Console.ReadKey();



            //计算for循环的运算时间；
            //ConsumeTime();
            //Console.ReadKey();
            #endregion




            #region//Stream
            //FileStream（文件流）；
            //FileStream fs = ...;    //
            //long length = fs.Length;    //获取流的长度；


            //MemoryStream（内存流）；
            //MemoryStream ms = new MemoryStream(100);   //创建内存流，容量100；
            //long length = ms.Length;

            //用文件流创建或读取.xlsx文件（同时流关联了文件）
            //FileStream filestream = null;
            //filestream = new FileStream("D:\\SKQ\\VS-Code\\Demo\\Emgu.CV.CvEnum\\Result\\匹配信息.xlsx", FileMode.OpenOrCreate);


            //使用Fileinfo类的Create()方法创建一个名称为"my.ini"文件；
            //FileInfo fi = new FileInfo("my.ini");
            //fi.Create();

            //Dispose();释放资源；
            //容器：1、面板(Panel); 2、组合框（GroupBox）; 3、选项卡（TabControl\TabPage）;

            //}
            #endregion





            #region //打开文本对话框；
            //private void btnFile_Click(object sender, EventArgs e)
            //{
            //    //创建浏览文件对话框的实例；

            //    OpenFileDialog ofd = new OpenFileDialog();
            //    ofd.Filter = "文本文件(*.txt)|*.txt|All files (*.*)|*.*";

            //    //设置为文本文件或所有文件；
            //    ofd.DefaultExt = "txt";

            //    //打开对话框；
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        //获取文件全路径；
            //        tbFile.Text = ofd.FileName; //tbFile:对应的Text的名称；
            //    }
            //}
            #endregion








            #region //保存文本对话框；
            //    private void btnSave_Click(object sender, EventArgs e)
            //{
            //    //创建保存文本对话框的实例；
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "文本文件(*.txt)|*.txt|All files(*.*)|*.*";

            //    //设置为文本文件或所有文件；
            //    sfd.DefaultExt = "txt";

            //    //打开对话框；
            //    if(sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        //打开文件并获取文件流；
            //        FileStream fs = (FileStream)sfd.OpenFile();

            //        //读取rtbMessage控件的数据，并转化为byte[]数组；
            //        byte[] data = System.Text.Encoding.UTF8.GetBytes(rtbMessage.Text);

            //        //将内容写入文件；
            //        fs.Write(data,0,data.Length);
            //        fs.Close();

            //    }

            //}
            #endregion






            #region //目录浏览对话框
            //创建FolderBrowerDialog类的实例fdb;
            //private void btnFolder_Click(object sender, EventArgs e)
            //{
            //    //创建浏览目录对话框的实例；
            //    FolderBrowserDialog fdb = new FolderBrowserDialog();

            //    //打开对话框；
            //    if (fdb.ShowDialog() == DialogResult.OK)
            //    {
            //        //显示选择目录路径；
            //        tbFolder.text = fdb.SelectedPath;
            //    }

            //}
            #endregion





            //while-continue;


            #region //case1--（1-100间，除了能够被7整除外的所有整数和）;
            //int sum = 0;
            //int i = 1;

            //while(i<=100)
            //{

            //    if(i%7==0)
            //    {
            //        i++;  //若无i++;则一直卡在i=7处；
            //        continue;   //跳出当前循环，开启下一次循环；
            //    }

            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine("sum={0}",sum);   //sum=4315;
            //Console.ReadKey();
            #endregion








            #region//case1-1--使用for循环+continue;
            //int sum = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }

            //    sum += i;
            //}
            //Console.WriteLine("sum={0}",sum);   //4315;
            //Console.ReadKey();
            #endregion









            #region//case2---1-100素数；
            //for+2次Tab自动出现for循环公式；

            //int sum = 0;

            //for (int i = 2; i <= 100; i++)  //当执行完Console.Writeline()时，再执行i++(自增1)；
            //{
            //    bool flag = true;  //若该句放在最前面，仅输出2,3;
            //    for (int j = 2; j < i; j++) //当执行完Console.Writeline()时，再执行i++(自增1)；
            //    {
            //        if (i % j == 0) //能被2和到自身的前一个数整除;
            //        {
            //            flag = false;
            //            break;

            //        }
            //    }
            //    if (flag)
            //    {
            //        sum += i;
            //        Console.WriteLine("Prime is {0}", i);

            //    }

            //}
            //Console.WriteLine("sum is {0}", sum);   //所有素数求和（1060）；
            //Console.ReadKey();
            #endregion







            #region //1-100-prime-exercise;

            //int sum = 0;
            //int count = 1;


            //for (int i = 2; i <= 100; i++)
            //{
            //    bool flag = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if(flag)
            //    {
            //        sum += i;
            //        Console.WriteLine("{0} is prime, count={1} ,sum={2}",i,count,sum);
            //        count++;
            //    }
            //}

            //Console.ReadKey();
            #endregion



            #region //素数；
            //int sum = 0;
            //int count = 1;

            //for (int i = 2; i < 100; i++)
            //{
            //    bool flag = true;

            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }

            //    if (flag)
            //    {
            //        sum += i;
            //        Console.WriteLine("prime is {0},count={1},sum={2}", i, count, sum);
            //        count++;
            //    }
            //}
            //Console.ReadKey();
            #endregion




            #region//GDI+Graphics;
            //获取Panel控件的pChart的Graphics对象，画一条直线；
            //Graphics g = pChart.CreateGrapyics();
            //g.DrawLine(new Pen(Color.Red), 0, 100, 300, 200);

            //创建随机数；
            //Random ram = new Random();
            #endregion






            #region //shuixianshua;
            //for (int i = 100; i < 1000; i++)
            //{
            //    int a = i / 100;
            //    int b = i % 100 / 10;
            //    int c = i % 10;

            //    if(a*a*a+b*b*b+c*c*c==i)
            //    {
            //        Console.WriteLine("shuixianhuashu is {0}", i);

            //    }
            //}
            //Console.ReadLine();
            #endregion




            #region //Exercise;
            //int sum = 0;
            //int max = 0;
            //int min = 0;

            //string  input = "";

            //while(true)
            //{
            //    Console.WriteLine("Input Your Number,Output max ,sum,min");
            //    input = Console.ReadLine();

            //    try
            //    {
            //        if (input != "end")
            //        {
            //            int a = Convert.ToInt32(input);

            //            if (a > max)
            //            {
            //                max = a;
            //            }
            //            if (a < min)
            //            {
            //                min = a;
            //            }

            //            sum += a;
            //        }

            //        else
            //        {
            //            Console.WriteLine("max={0},in={1},sum={2}", max, min, sum);
            //            break;
            //        }
            //    }

            //    catch(System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    Console.ReadKey();

            //}
            #endregion






            #region //99乘法表（9行9列）；

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j); //Console.Write();9行9列；
            //    }
            //    Console.WriteLine();    //换行并对齐（9行9列）;
            //}
            //Console.ReadKey();
            #endregion








            #region //99乘法表（三角形状）；

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);   //Console.Write();
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            #endregion





            #region //输入一个正整数，输出所有和为该整数的组合；
            //Console.WriteLine("输入一个正整数，输出所有组合");

            //try
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i <= n; i++)
            //    {
            //        Console.WriteLine("{0}+{1}={2}", i, n - i, n);
            //    }

            //}

            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            #endregion






            #region //SqlConnection\SqlCommand\SqlDataReader\SqlDataAdapter\DataSet\DataView;
            /*****************sql********************

            1、SqlConnection：用于连接SQL Server数据库;
            其步骤如下：

            1）创建连接字符串；
            使用4个“名称/值”对，连接CSharp3DB数据库；local:本机； user id、pwd:用户名和密码；database:指定被连接的数据库的名称；
            string connectionString = "data source=(local); user id = sa;pwd=123456;database=CSharp3DB;";

            2) 创建SqlConnection类的实例；
            SqlConnection con = new SqlConnection();    //创建SqlConnection类实例；
            con.ConnectionString = connectionString;    //设置con实例的连接字符串为connectionString；

            3）打开数据库的连接，即建立ADO.NET与数据库的会话；
             //打开数据库的连接，即建立ADO.NET与数据库的会话；
            try
            {
                con.Open();
                
            }

            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            4）关闭数据库的连接；
            //在try语句的finally块中调用con实例Close()方法关闭数据库连接，并释放该连接占用的资源；
            finally
            {
                if(con!=null)
                {
                    con.Close();    //关闭数据库连接；
                }
            }


            2、SqlCommand对象可以执行对数据源的操作或命令，如检索、插入、更新、删除等，即它能够执行指定的SQL语句或存储过程；

            1）ExecuteReader()方法：读取数据，并返回SqlDataReader对象；
            2）ExecuteNonQuery()方法：执行指定的SQL语句或存储过程，并返回该操作影响的行数；
            3）ExecuteXmlReader()方法：读取数据，并返回XmlReader对象；
            4）ExecuteScalar()方法：读取数据，并返回结果集合中的第一行第一列的值；

            //examples;
            cmd实例调用ExecuteReader()方法执行它的SQL语句或存储过程；返回结果保存为dr对象，（类型为SqlDatareader()）;
            (1)
            SqlDatareader dr = cmd.ExecuteReader(); //cmd为SqlCommand类的实例；

            (2)cmd实例调用ExecuteNonQuery()方法执行它的SQL语句或存储过程；返回结果保存为result变量，（类型为int）
            int result = cmd.ExecuteNonQuery();



            3、SqlDataReader对象提供一种从SQL Server数据库中快速读取数据的方法，且在读取数据时必须保持与数据库的连接；
            具有如下3个特征：
            1）只能读取数据：不能对数据库执行任何修改或插入操作；
            2）只能向前读取数据：不能再次读取已经被访问的数据；
            3）直接把数据传递到对象，WinForm或Wed窗体页；

            //example;
            在if语句中使用Read()方法读取dr实例的第一条记录值；若记录存在，则读取该记录的 id列的值，并保存为idValue变量；
            if(dr.Read())
            {
                string idvalue = dr["id"].ToString();
            }



            4、DataSet对象，提供了一种被称为断开式的数据访问机制，是数据在内存驻留中的一种表示形式；


            5、SqlDataAdapter对象表示一组操作数据的命令和一个数据库连接；
            SqlDataAdapter对象提供以下4种命令；
            1) SelectCommand:检索（查询）数据；
            2）InsertCommand:插入数据；
            3）UpdateCommand:修改数据；
            4）DeleteCommand:删除数据；

            SqlDataAdapter对象最常用的方法是用于填充DataSet对象，该功能由其Fill()方法实现，一般需要如下6个步骤；
            1）创建连接字符串；
            string connectionString = "data source=(local); user id = sa;pwd=123456;database=CSharp3DB;";

            2) 创建SqlConnection类的实例；
            SqlConnection con = new SqlConnection();    //创建SqlConnection类实例；
            con.ConnectionString = connectionString;    //设置con实例的连接字符串为connectionString；


            3) 创建查询数据的SQL语句或存储过程；
            string cmdText = "select * from Data";

            4)创建 SqlDataAdapter类实例；
            SqlDataAdapter da = new  SqlDataAdapter(cmdText,con);   //创建 SqlDataAdapter类的实例cmd;

            5)打开数据库的连接，获取数据并填充到数据集；
            DataSet ds = new DataSet(); //创建DataSet对象ds;
            con.Open(); //打开数据库的连接；
            da.Fill(ds);    //获取数据，并填充DataSet对象ds;


            6)关闭数据库连接；
            con.Close();




            在button_click中写入连接数据库事件；
            
            private void btnConnect_Click(object sender,EventArgs e)
        {
            //设置连接字符串；
            string connectionString = "data source = localhost; user id = sa; pwd = 123456; database = CSharp3DB;";

            //创建SqlConnection类实例，用于连接SQL Server数据库；
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            try
            {
                con.Open();
                rtbMessage.Text = "连接数据库" + con.Database + "成功!\n" + con.ConnectionString;

            }

            catch (System.Exception ex)
            {
                rtbMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
            *************************************/
            #endregion






            #region //连续输入若干（default:5）数字（不能小于0或大于100），求其和，均值；

            //double sum = 0.0d;
            //double avg = 0.0D;
            //int i = 0;

            //bool flag = true;

            //for (i = 1; i < 6; i++)   //共i-1（i-1=6-1=5）个数；
            //{
            //    Console.WriteLine("Input Your Number:");

            //    try
            //    {
            //        int n = Convert.ToInt32(Console.ReadLine());

            //        if (n >= 0 && n < 100)
            //        {
            //            sum += n;

            //        }

            //        else
            //        {
            //            Console.WriteLine("输入有误!退出程序！");

            //            break;
            //        }
            //    }

            //    catch (System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        flag = false;
            //    }


            //}

            //if (flag)
            //{
            //    avg = sum / (i - 1);
            //    Console.WriteLine("sum={0},avg={1}", sum, avg);
            //}

            //Console.ReadKey();

            #endregion





            #region //prime Exercise;
            //int count = 0;
            //for (int i = 2; i < 101; i++)
            //{
            //    bool flag = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {

            //            flag = false;
            //            continue;
            //        }
            //    }
            //    if(flag)
            //    {
            //        count++;
            //        Console.WriteLine("Prime is {0}, {1}",i,count);
            //    }
            //}
            //Console.ReadKey();
            #endregion






            #region //产生随机数；
            //Random rd = new Random();

            //while(true)
            //{
            //    int number = rd.Next(1, 7);   //产生1-6的随机数；

            //    Console.WriteLine("Input Your Name:");
            //    string userName = Console.ReadLine();

            //    switch(number)
            //    {
            //        case 1:
            //            Console.WriteLine("{0},You Are A Dancer!",userName);
            //            break;

            //        case 2:
            //            Console.WriteLine("{0},You Are A Teacher!",userName);
            //            break;
            //        case 3:
            //            Console.WriteLine("{0},You Are An Engineer!",userName);
            //            break;
            //        case 4:
            //            Console.WriteLine("{0},You Are A Doctorer!",userName);
            //            break;

            //        case 5:
            //            Console.WriteLine("{0},You Are A Civil Servant!",userName);
            //            break;

            //        default:
            //            Console.WriteLine("{0}, You Are A Loser!",userName);
            //            break;
            //    }

            //        Console.ReadKey();
            //}



            //while(true)   //练习1；
            //{
            //    Random rd = new Random();
            //    int number = rd.Next(1, 10);
            //    Console.WriteLine(number);
            //    Console.ReadKey();
            //}





            //while(true)      //练习2；
            //{
            //    Random rd = new Random();
            //    int number = rd.Next(1, 10);
            //    Console.WriteLine("number={0}", number);
            //    Console.ReadKey();
            //}




            //练习3；
            //Random rd = new Random();

            //while(true)
            //{
            //    int rd_Number = rd.Next(1, 8);

            //    Console.WriteLine("input Your Name:");
            //    string userName = Console.ReadLine();

            //    switch (rd_Number)
            //    {
            //        case 1:
            //            Console.WriteLine("{0},Today is Monday,rd_Number={1}", userName, rd_Number);
            //            break;

            //        case 2:
            //            Console.WriteLine("{0},Today is Tuesday,rd_Number={1}", userName, rd_Number);
            //            break;

            //        case 3:
            //            Console.WriteLine("{0},Today is Wednesday,rd_Number={1}", userName, rd_Number);
            //            break;

            //        case 4:
            //            Console.WriteLine("{0},Today is Thursday,rd_Number={1}", userName, rd_Number);
            //            break;

            //        case 5:
            //            Console.WriteLine("{0},Today is Friday,rd_Number={1}", userName, rd_Number);
            //            break;

            //        case 6:
            //            Console.WriteLine("{0},Today is Saturday,rd_Number={1}", userName, rd_Number);
            //            break;

            //        default:
            //            Console.WriteLine("{0},Today is Sunday,rd_Number={1}", userName, rd_Number);
            //            break;
            //    }
            //    Console.ReadKey();
            //}

            #endregion





            #region//1-100--prime;
            //int sum = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    bool flag = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }

            //    if(flag)
            //    {
            //        sum += i;
            //        Console.WriteLine("Prime is {0},    Sum is {1}", i,sum);

            //    }
            //}
            //Console.ReadKey();
            #endregion






            #region //九九乘法表；
            //case1:
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);

            //    }

            //    Console.WriteLine();


            //}
            //Console.ReadKey();


            //case2:
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);

            //    }

            //    Console.WriteLine();


            //}
            //Console.ReadKey();
            #endregion






            #region //设置用户名及密码登录，一直输入直至正确；
            //string userName = "";
            //string userPwd = "";



            //while(true)
            //{
            //    Console.WriteLine("Input Your Name:");
            //    userName = Console.ReadLine();

            //    Console.WriteLine("Input Your Password:");
            //    userPwd = Console.ReadLine();

            //    if(userName=="admin"&&userPwd=="123456")
            //    {
            //        Console.WriteLine("Welcome To Niuma World!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please Check Your name and pwd!");
            //    }
            //}
            //Console.ReadKey();

            #endregion




            #region//prime-exercise;
            //for (int i = 2; i < 101; i++)
            //{
            //    bool flag = true;

            //    for (int j = 2; j < i; j++)
            //    {
            //        if(i%j==0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }

            //    if(flag)
            //    {
            //        Console.WriteLine("Prime is {0}", i);
            //    }
            //}
            //Console.ReadKey();
            #endregion





            #region //struct-enum--exercise;
            //Person person1;

            //person1._name = "fawaikuangtuzhangsan";
            //person1._gender = Gender.male;
            //person1._age = 22;

            //Person person2;
            //person2._name = "buzhiminglisi";
            //person2._gender = Gender.female;
            //person2._age = 19;

            //Console.WriteLine("person1's name is {0},gender is {1},age is {2}",person1._name,person1._gender,person1._age);

            //Console.WriteLine("person2's name is {0},gender is {1},age is {2}", person2._name, person2._gender, person2._age);
            //Console.ReadKey();
            #endregion







            #region //case1--arrays-exercise;
            //int[] arrays = new int[10];

            //int max = 0;
            //int min = 0;
            //double sum = 0;
            //double avg=0;


            ////Console.WriteLine("Input your number:");
            ////string n = Console.ReadLine();

            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    arrays[i] = i;

            //    max = arrays[2];
            //    min = arrays[3];

            //    if(arrays[i]>max)
            //    {
            //        max = arrays[i];
            //    }

            //    if (arrays[i] < min)
            //    {
            //        min = arrays[i];
            //    }


            //    sum += i;
            //    avg = sum / 10;

            //Console.WriteLine(arrays[i]);
            //}
            //Console.WriteLine("max={0},min={1},sum={2},avg={3}", max, min, sum, avg);

            //Console.ReadKey();
            #endregion








            #region //case2--arrays-exercise;
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int max = int.MinValue; //max取最小值，使得数组中的所有值均比max大；
            //int min = int.MaxValue; //min取最大值，使得数组中的所有值均比min小；

            //double sum = 0.0d;
            //double avg = 0.0d;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] += i;

            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }

            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }

            //    sum += nums[i];
            //    avg = sum / 9;
            //    Console.WriteLine(nums[i]);
            //}

            //Console.WriteLine("MAX={0},MIN={1},SUM={2},AVG={3}", max, min, sum, avg);
            //Console.ReadKey();
            #endregion






            #region //case3--arrays-exercise--将数组中的元素进行逆序排列并打印；

            //int [] arr3 = { 9, 2, 5, 7, 8 };

            ////逆序前
            //Console.WriteLine("逆序前：");
            //for (int i = 0; i < arr3.Length; i++)
            //{               
            //    Console.WriteLine(arr3[i]);
            //}
            //Console.ReadKey();

            ////foreach (var i in arr3)
            ////{
            ////    Console.Write(i + " ");
            ////}

            ////逆序
            //for (int i = 0; i < arr3.Length/2; i++)
            //{

            //        int temp = arr3[i];
            //        arr3[i] = arr3[arr3.Length - i - 1];
            //        arr3[arr3.Length - i - 1] = temp;


            //}
            //Console.WriteLine("逆序后：");
            //for (int i = 0; i < arr3.Length; i++)
            //{

            //    Console.WriteLine(arr3[i]);
            //}
            //Console.ReadKey();
            #endregion








            #region//数组中元素逆序打印-exercise;

            //string[] strs = { "a", "b", "c", "d", "e", "f", "g" };

            //Console.WriteLine("逆序前：");

            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine(strs[i]);
            //}

            //for (int i = 0; i < strs.Length / 2; i++)   //i--交换次数；
            //{
            //    string temp = strs[i];
            //    strs[i] = strs[strs.Length - i - 1];
            //    strs[strs.Length - i - 1] = temp;
            //}

            //Console.WriteLine("逆序后：");
            //for (int i = 0; i < strs.Length; i++)   //i--数组长度；
            //{
            //    Console.WriteLine(strs[i]);
            //}
            //Console.ReadKey();





            //case1--exercise;
            //int[] nums = { 1, 3, 5, 7, 9};

            //for (int i = 0; i < nums.Length/2; i++)   //i--交换次数；
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[nums.Length - i - 1];
            //    nums[nums.Length - i - 1] = temp;
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();







            //case2--将字符串分割为：老三|老四|老五|...

            //string[] names = { "老三", "老四", "老五", "老马" };

            //string str = null;
            //int i;

            //for (i = 0; i < names.Length-1; i++)
            //{


            //    str += names[i] + "|";  //key;

            //}


            //Console.WriteLine(str + names[names.Length - 1]);   //names[names.Length - 1]--最后一个元素；
            //Console.ReadKey();





            //对数组中的元素进行冒泡排序；

            //int[] nums = { 1, 5, 2, 4, 3, 9, 7, 6, 8, 0 };

            //for (int i = 0; i < nums.Length-1; i++)     //i--交换次数；
            //{
            //    for (int j = 0; j < nums.Length-i-1; j++)   //j--待交换的数组元素；
            //    {
            //        if(nums[j]>nums[j+1])   //nums[j]>nums[j+1]--升序（从小到大）；反之，降序（从大到小）；
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            #endregion















            #region//enum-string-zonghe-exercise(switch-case);

            //Console.WriteLine("Input Your Number:");

            //try
            //{
            //    string n = Console.ReadLine();

            //    bool b = true;

            //    int n1 = int.Parse(n);

            //    while(n1<0||n1>7)
            //    {
            //        Console.WriteLine("输入数字不在有效范围内！");
            //        b = false;
            //        break;
            //    }


            //    if(b)
            //    {
            //        switch (n)
            //        {
            //            case "1":
            //                Days day1 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day1);
            //                break;


            //            case "2":
            //                Days day2 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day2);
            //                break;


            //            case "3":
            //                Days day3 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day3);
            //                break;

            //            case "4":
            //                Days day4 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day4);
            //                break;


            //            case "5":
            //                Days day5 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day5);
            //                break;


            //            case "6":
            //                Days day6 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day6);
            //                break;

            //            default:
            //                Days day7 = (Days)Enum.Parse(typeof(Days), n);
            //                Console.WriteLine("Today is {0}", day7);
            //                break;


            //        }
            //    }
            //}



            //catch(System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.ReadKey();

            #endregion







            #region //函数方法的调用问题；

            /***
            在Main()函数中，调用如Test()函数，则称Main()函数为调用者，Test()称为被调用者；
            若被调用者Test()想要得到调用者的值，则使用以下方法：
             
            Test（int a）

            //case1;
             static void Main(string[] args)
            {
                int a = 3;
                int res = Test(a);
                Console.WriteLine(res);
                Console.ReadKey();

            }
            
              public static int Test(int a)
            {
                a = a + 5;
                return a;
            }


            //case2;
             static void Main(string[] args)
            {
                bool b = RunYear(2000);
                Console.WriteLine(b);
                Console.ReadKey();
            }

             public static bool RunYear(int year)
           {
            bool b = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            return b;
           }
            
            2、使用静态字段来模拟全局变量(定义全局变量)；
            public static void _number=10
            ***/
            #endregion



            //函数--方法练习1；
            /**************
            1、不管形参、实参均是开辟了空间；
            2、方法功能要单一；
            3、方法忌讳出现提示用户输入字眼；

           
            //case1:获取max;
            static void Main(string[] args)
            {
                int a = 11;
                int b = 23;

                int max = GetMax(a, b); //实参；or  int max = GetMax(10, 20); //实参；


                Console.WriteLine(max);
                Console.ReadKey();
            }



            public static int GetMax(int n1, int n2)   //形参；
            {
                int max = n1 > n1 ? n1 : n2;
                return max;

            }


            //case2:将输入的转换为数字；
             while(true)
            {
                Console.WriteLine("Input a number:");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number);
                    break;
                }
                catch(System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please input a number again!");
                }
                
            }

            

            //case3：调用方法将输入的转换为数字；
            static void Main(string[] args)
            {
                Console.WriteLine("Input a number:");
                string input = Console.ReadLine();
                int number = GetNumber(input);
                Console.WriteLine(number);
                Console.ReadKey();

            }
          
             public static int GetNumber(string s)
            {
                while(true)
                {
                    try
                    {
                        int number = Convert.ToInt32(s);
                        return number;
                    }
                    catch
                    {
                        Console.WriteLine("请重新输入：");
                        s = Console.ReadLine();
                    }
                }
            }



            //cadse4:调用方法进行数组求和；

              static void Mian(string[] args)
                {
                    int[] nums = { 1, 3, 5, 7, 9 };

                    int sum = GetSum(nums);
                    Console.WriteLine(sum);
                    Console.ReadKey();
                }
            
              public static int GetSum(int [] arrays)
                {
                    int sum = 0;
                    for (int i = 0; i < arrays.Length; i++)
                    {
                        sum += arrays[i];
                    }
                    return sum;
                }



            //case4:调用方法判断闰年；
            static void Main(string[] args)
            {
               
                bool b = RunYear(2000);
                Console.WriteLine(b);   //True;
                Console.ReadKey();
            }

            public static bool RunYear(int year)
            {
                bool b = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                return b;
            }





            //case5:调用方法：string to number;

            static void Main(string[] args)
            {
                Console.WriteLine("Input a number:");
                string input = Console.ReadLine();
                int number = GetNumber(input);

                Console.WriteLine(number);
                Console.ReadKey();
            }

             public static int GetNumber(string s)
            {
                while(true)
                {
                    try
                    {
                        int number = Convert.ToInt32(s);
                        return number;
                    }
                    catch
                    {
                        Console.WriteLine("Please input again!");
                        s = Console.ReadLine();
                    }
                }
            }



            //case6:调用方法：Only Input yes or no;
            strtic void Main(string[] args)
            {
                Console.WriteLine("Input a string:");
                string input = Console.ReadLine();

                string str = YesOrNo(input);
                Console.WriteLine(str);
                Console.ReadKey();

            }



            public static string YesOrNo(string s)
            {
                while(true)
                {
                    if(s=="yes"||s=="no")
                    {
                        return s;
                    }
                    else
                    {
                        Console.WriteLine("Please input yes or no again!");
                        s = Console.ReadLine();
                    }
                }
            }


            //调用方法：计算数组的和；
            static void Main(string[] args)
            {
                int[] nums = { 1, 3, 5, 7, 9 };

                int sum = GetSum(nums);

                Console.WriteLine(sum);
                Console.ReadKey();
            }


             public static int GetSum(int[] arrays)
            {
                int sum = 0;
                for (int i = 0; i < arrays.Length; i++)
                {
                    sum += arrays[i];
                }
                return sum;
            }


             //调用方法：求数组的max、min、sum、avg；
               static void Main(string[] args)
                {
                    int[] numbers = { 1, 3, 5, 7, 9 };

                    int[] res = GetMaxMinSumAvg(numbers);

                    Console.WriteLine("max={0},min={1},sum={2},avg={3}", res[0], res[1], res[2], res[3]);
                    Console.ReadKey();
                }


             public static int[] GetMaxMinSumAvg(int[] arrays)
            {
                // 设置一个数组用于接受max、min、sum、avg;
                int[] res = new int[4];

                //max;
                res[0] = arrays[2];
                //min;
                res[1] = arrays[0];
                //sum;
                res[2] = 0;
                //avg;
                res[3] = 0;

                for (int i = 0; i < arrays.Length; i++)
                {
                    if (arrays[i] > res[0])
                    {
                        res[0] = arrays[i]; //max;
                    }

                    if(arrays[i]<res[1])
                    {
                        res[1] = arrays[i]; //min;
                    }

                    //sum;
                    res[2] += arrays[i];

                    //avg;
                    res[3] = res[2] / arrays.Length;

                }
                return res;

            }





            //调用方法：out参数（可返回不同类型的值）；
                      
            static void Main(string[] args)
            {
                int[] numbers = { 1, 3, 5, 7, 9 };

                int max;
                int min;
                int sum;
                int avg;
                bool b;
                string s;
                double d;


                Test(numbers, out max, out min, out sum, out avg, out b, out s, out d);

                Console.WriteLine("max={0}", max);
                Console.WriteLine("min={0}", min);
                Console.WriteLine("sum={0}", sum);
                Console.WriteLine("avg={0}", avg);

                Console.WriteLine("b={0}", b);
                Console.WriteLine("s={0}", s);
                Console.WriteLine("d={0}", d);

                Console.ReadKey();
            }

            public static void Test(int[] nums,out int max,out int min,out int sum,out int avg,out bool b,out string s,out double d)
            {
                //out参数要求在方法内部进行赋值；
                max = nums[0];
                min = nums[1];
                sum = 0;
                avg = nums[2];

                for (int i = 0; i < nums.Length; i++)
                {
                    if(nums[i]>nums[0])
                    {
                        max = nums[i];
                    }

                    if(nums[i]<nums[1])
                    {
                        min = nums[i];
                    }

                    sum += nums[i];
                    avg = sum / nums.Length;

                }

                b = true;
                s = "123abc";
                d = 3.1415926;

            }


            //调用方法：提示用户输入用户名及密码，返回登录信息；

             static void Main(atring[] args)
            {
                Console.WriteLine("请输入用户名：");
                string userName = Console.ReadLine();

                Console.WriteLine("请输入密码：");
                string userPwd = Console.ReadLine();

                string msg;

                bool b = IsLogIn(userName, userPwd, out msg);

                Console.WriteLine("登录结果{0}", b);
                Console.WriteLine("登录信息{0}", msg);

                Console.ReadKey();
            }
            

            public static bool IsLogIn(string name, string pwd, out string msg)
            {
           
                    if (name == "admin" && pwd == "888888")
                    {
                        msg = "登录成功！";
                        return true;
                    
                    }
                    else if (name == "admin" && pwd != "888888")
                    {
                        msg = "密码错误！";
                        return false;
                    }

                    else if (name != "admin" && pwd == "888888")
                    {
                        msg = "用户名错误！";
                        return false;
                    }
                    else
                    {
                        msg = "用户名及密码均错误！";
                        return false;
                    }
            
            }

            //调用方法：out--TryPatse(字符串-->整数);
            static void Main(string[] args)
            {
                int num;
                bool b = int.TryParse("123abc", out num);

                Console.WriteLine(num); //0;
                Console.WriteLine(b);   //false;
                Console.ReadKey();
            }

             public static bool MyTryParse(string s, out int result)
            {
                result = 0;
                try
                {
                    result = Convert.ToInt32(s);
                    return true;
                }
                catch
                {
                    return false;
                }
            
            }


            //调用方法：ref参数；
             static void Main(string[] args)
            {
                //使用方法来交换两个int类型的变量
                int n1 = 10;
                int n2 = 20;
                //int temp = n1;
                //n1 = n2;
                //n2 = temp;
                ExchangeVariables(ref n1, ref  n2);
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.ReadKey();
                //n1 = n1 - n2;//-10 20
                //n2 = n1 + n2;//-10 10
                //n1 = n2 - n1;//20 10

            }

            /// <summary>
            /// 交换两个数的值
            /// </summary>
            /// <param name="n1">变量1</param>
            /// <param name="n2">变量2</param>
            public static void ExchangeVariables(ref int n1, ref  int n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }


            //调用方法：params--参数求学生总成绩；
            static void Main(string[] args)
            {
                GetSum("zhangsan", 90, 85, 80);
                Console.ReadKey();
            }



            public static void GetSum(string name, params int[] nums)
            {
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine("{0}，这次考试总成绩是{1}",name, sum);
            }


            //调用方法：求任意长度的整型数组和；

            static void Main(string[] args)
            {   
                int sum = GetSum(1, 3, 5, 7, 9);
                Console.WriteLine(sum);
                Console.ReadKey();
            }

              public static int GetSum(params int[] nums)
            {
                int sum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
                return sum;
            }


            //调用方法：方法的综合练习；p86--方法的练习输入两个数字，并判断大小，且第一个数字不能大于第二个数字，否则重新输入，并求取两个数字间的整数和；
            static void Main(string[] args)
            {
                Console.WriteLine("Please input number1:");
                string input1 = Console.ReadLine();
                int number1 = GetNumber(input1);

                Console.WriteLine("Please input number2:");
                string input2 = Console.ReadLine();
                int number2 = GetNumber(input2);

                //调用方法：转换整数；
                JudgeNumber(ref number1, ref number2);

                //调用方法：判断两个数大小；
                int sum = GetSum(number1, number2);

                Console.WriteLine(sum);
                Console.ReadKey();
            }

             //转换整数；
            public static int GetNumber(string s)
            {
                while(true)
                {
                    try
                    {
                        int n1 = Convert.ToInt32(s);
                        return n1;
                    }
                    catch(System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        s = Console.ReadLine();
                    }
                }
            }


             //判断两个数大小；
            public static void JudgeNumber(ref int number1,ref int number2)
            {
                while(true)
                {
                    if(number1<number2)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("number1 doesn't more than number2!please input again!");

                        Console.WriteLine("Please input number1:");
                        string input1 = Console.ReadLine();
                        number1 = GetNumber(input1);

                        Console.WriteLine("Please input number2:");
                        string input2 = Console.ReadLine();
                        number2 = GetNumber(input2);
                    }
                }
            }

             //求和；
            public static int GetSum(int n1,int n2)
            {
                int sum = 0;

                for (int i = n1; i <= n2; i++)
                {
                    sum += i;                
                }
                return sum;
            }

             ***************/

            #region //方法重载；方法相同，参数不同；
            //其中：参数不同分为：参数类型相同，个数不同；参数类型不同，个数相同；

            //(case1,case2:参数类型相同，个数不同)；       
            //(case2,case3,case4:参数类型不同，个数相同)；


            ////case1;
            //private static void M(int n1,int n2,int n3)
            //{
            //    int result = n1 + n2 + n3;
            //}

            ////case2;
            //private static void M(int n1,int n2)
            //{
            //    int result = n1 + n2;
            //}

            ////case3;
            //private static double M(double d1,double d2)
            //{
            //    return d1 + d2;
            //}

            ////case4;
            //private static string M(string s1,string s2)
            //{
            //    return s1 + s2;
            //}
            #endregion




            #region//方法递归（方法自己调用自己）；
            //static void Main(string[] args)
            //{
            //    TellStory();
            //    Console.ReadKey();
            //}

            // //定义全局变量；
            //private static int i = 0;

            //private static void TellStory()
            //{
            //    Console.WriteLine("秦人不暇自哀，而后人哀之！");
            //    Console.WriteLine("后人哀之而不鉴之！");
            //    Console.WriteLine("亦使后人而复哀后人矣！\n");

            //    i++;
            //    if (i > 10)   //打印10遍
            //    {
            //        return;
            //    }
            //    TellStory();

            //}
            #endregion



            #region //比较数组中最长的字符；
            //static void Main(string[] args)
            //{
            //string[] words = { "123", "abcd", "1234544", "dedas" };
            //string max = Getlongest(words);

            //Console.WriteLine(max);
            //Console.ReadKey();
            //    
            //}

            //private static string Getlongest(string[] s)
            //{
            //    string max = s[0];
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i].Length > max.Length)
            //        {
            //            max = s[i];
            //        }
            //    }
            //    return max;
            //}
            #endregion



            string[] names = {"alice","mechimel","jane","australical"};

            string result = GetLongest(names);

            Console.WriteLine(result);
            Console.ReadKey();




        }




        //比较数组中最长的字符；
        private static string GetLongest(string[] s)
        {
            string max = s[1];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }








        //求数组平均值，并保留两位小数；









    }
}



