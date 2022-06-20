## 名词解释：堆栈；托管堆；

```c#
// 堆（数据结构）：堆可以被看成是一棵树，如：堆排序。
// 栈（数据结构）：一种先进后出的数据结构。

// 堆（heap）:
// 堆是从下往上分配，所以已用的空间在自由空间下面，C#中所有引用类型的对象分配在托管堆上，托管堆在内存上是连续分配的，并且内存对象的释放受垃圾收集机制的管理，效率相对于栈来说要低的多。

// 栈（stack）(先进后出):
// 栈是自上向下进行填充，即由高内存地址指向低内存地址，并且内存分配是连续的，C#中所有的值类型和引用类型的引用都分配在栈上，栈根据后进先出的原则，依次对分配和释放内存对象。


//堆栈：
//在计算机领域，堆栈是一个不容忽视的概念，堆栈是一种数据结构，而且是一种数据项按序排列的数据结构，只能在一端(称为栈顶(top))对数据项进行插入和删除。在单片机应用中，堆栈是个特殊的存储区，主要功能是暂时存放数据和地址，通常用来保护断点和现场。


// 托管堆：
// 托管堆是CLR中自动内存管理的基础。初始化新进程时，运行时会为进程保留一个连续的地址空间区域。这个保留的地址空间被称为托管堆。托管堆维护着一个指针，用它指向将在堆中分配的下一个对象的地址。最初，该指针设置为指向托管堆的基址。
```



# C# 命名规则：

```c#
// 1、camel命名：首单词首字母小写，其余单词首字母大写(常用于变量命名)；（如public static double overLoad）;
// 2、Pascal命名：首字母大写，其余小写（常用于类或方法命名）；（如 class OverLoad）
```

## 1、Hello_World;

```c#
using System;
namespace HelloWorld_Application
{
    class HelloWorld	//Pascal命名；
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C# World!");
            Console.ReadKey();
        }
    }
}
```

## 2、Array_Compare;

```c#
using System;
namespace ArrayCompareApplication
{
    class ArrayCompare
    {
        static void Main(string[] args)
        {
            /*创建数组*/
            int [] Arrays = {0,1,2,3,4,5,6,7,8,9};
            int max = Arrays[2];
            int min = Arrays[5];
            double sum = 0;//初始值设定为0！；
            double avg = 0;//初始值设定为0！；
            for(int i=0; i<Arrays.Length; i++)
            {
                if(Arrays[i]>max)
                {
                    max = Arrays[i];
                }
                if(Arrays[i]<min)
                {
                    min = Arrays[i];
                }
                sum+=Arrays[i];
            }   	
            	///sum+=Arrays[i];放在此处错误；
                avg = (sum/(Arrays.Length));
            	//max=9,min=0,sum=45,avg=4.5
            	Console.WriteLine("max={0},min={1},sum={2},avg={3}",max,min,sum,avg);
            	Console.ReadKey();
            
        }
    }
}
```

## 3、Prime_Number;

```c#
using System;
namespace PrimeNumberApplication
{
    class PrimeNumber
    {
        /* 1-100素数 */
        static void Main(string[] args)
        {
            for(int i=2; i<=100; i++)
            {
                int j = 2;
                while(i%j!=0)
                {
                    j++;
                }
                if(i==j)
                {
                    Console.WriteLine("{0} is prime number",i);
                }
            }
            Console.ReadKey();
            
        }
    }
}
```

## 4、Public(sttaic);

```c#
//case1;
using System;
namespace RectangleAppliction
{
    class Rectangle
    {
        public double length;
        public double width;
        
        public double GetArea()
        {
            return length*width;
        }
        public void Display()
        {
            Console.WriteLine("length={0}",length);
            Console.WriteLine("width={0}",width);
            Console.WriteLine(GetArea());            
        }
        
        class ExecuteRectangle
        {
			static void Main(string[] args)
			{			
            Rectangle r = new Rectangle();
            r.length = 3.5;
            r.width = 2.5;
            r.Display();
            Console.ReadLine();
			}
        }
        
    }
}

//case2;
class Program
{
    class MyClass
    {
        public static int value = 2022;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(MyClass.value);
        Console.ReadKey();
    }
}
```

### 4.1 十进制转二进制；

```c#
using System;
namespace IntToBinary
{
    class BinaryApplication
    {
        public static string ConvertIntToBinary(int n)
        {
            string binary = string.Empty;	//定义字符串binary为空；
            int i = n;	//定义i,并赋值为n;
            int m = 0;	//声明m变量，并赋值为0;
            while(i>1)
            {
                i = n/2;	//整除；
                m = n%2;	//取余；
                binary = m.ToString()+binary;
                n = i;
            }
            if(i>0)
            {
                binary="1"+binary;
            }
            return binary;
            
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertIntToBinary(15));
            Console.ReadKey();
        }
    }
}
```

### 4.2  二进制转十进制；

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConvertApplication
{
    class Convert
    {
        public static int ConvertBinaryToInt(string binary)
{
    //判断binatry字符串是否为空；
    if(string.IsNullOrEmpty(binary)==true)
    {
        return -1;
    }
    int n = 0;	//声明n变量，并赋值为0；
    //处理binary中各字符串中的数字；
    for(int i = 0; i<binary.Length; i++)
    {
        //将每一位二进制的值转化为十进制的值；
        n+= Int32.Parse(binary[i].ToString())*(int)Math.Pow(2,binary.Length-i-1);
    }
    return n;	//int 类型，返回值为n;
}
static void Main(string[] args)
{
    Console.WriteLine(ConvertBinaryToInt("1111"));	//15;
    Console.ReadKey();
}
    }
}
```

### 4.3 数据类型(及使用ref\out参数)；

```c#
// 整型（int）;
int i = 2022;

//char类型；
char c1 = 'A';//单引号；

//浮点型（float\double）;
float f = 100.2f;//对于float类型变量的值，需要在数组后面添加f或F;

double d = 100.2d;//对于double类型变量的值，需要在数组后面添加d或D;

//decimal类型;
decimal salary = 1000m;//对于decimal类型变量的值，需要在数组后面添加m;

//bool类型；
bool b1 = true;
bool b1 = false;

//枚举类型（enum）;
public static enum DAY
{
      	MONDAY=0, 
    	TUEDAY, 
   	 	WEDDAY, 
    	THUDAY, 
    	FRIDAY, 
    	SATDAY, 
    	SUNDAY
};

//结构类型（struct）;
struct Books
{
    public string titile;
    public string author;
    public string subject;
    public int book_id;
};

///强制类型转换；
// 将字符串转化为数字；
Console.WriteLine("请输入时间：");
string s = Console.ReadLine();
int value = Int32.Parse(s);

// 将字符串转化为数字；
string s = "123456";
int value = Int32.Parse(s);	//强制类型转换（string----int）；
Console.WriteLine(value);
Console.ReadKey();

// 将整型转化为字符串；
int i = 1223;
string s = i.ToString();	//强制类型转换（int----string）；
Console.WriteLine(s);
Console.ReadKey();


//使用值参数传递数据；

static int GetSum(int i,int j)
        {
            i++;
            j++;
            return i + j;
        }
static void Main(string[] args)
{
int i = 2022;
int j = 100;

Console.WriteLine("执行前：");
Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());	//i=2022;j=100;

int sum = GetSum(i, j);
Console.WriteLine("执行后：");
Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());	//i=2022;j=100;

Console.WriteLine("sum=" + sum.ToString());	//2124;
Console.ReadKey();
}



//使用ref参数传递数据；
static int GetSum(ref int i, ref int j)
        {
            i++;
            j++;
            return i + j;
        }
static void Main(string[] args )
{
int i = 2022;
int j = 100;

Console.WriteLine("执行前：");
Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());	//i=2022;j=100;

int sum = GetSum(ref i, ref j);
Console.WriteLine("执行后：");
Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());//(ref参数，i,j变量均修改)i=2023;j=101;

Console.WriteLine("sum=" + sum.ToString());	//2124;
Console.ReadKey();
}


 //使用out参数返回数据；
static void GetSum(int i,int j, out int sum)
 {
      i++;
      j++;
      sum = i + j;
  }

static void Main(string[] args)
{
     // 使用out参数传递数据；

            int i = 2022;
            int j = 100;
            int sum;

            Console.WriteLine("执行前：");
            Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());  //i=2022;j=100;


            GetSum(i, j, out sum);

            Console.WriteLine("执行后：");
            Console.WriteLine("i=" + i.ToString() + ",j=" + j.ToString());  //i=2022;j=100;


            Console.WriteLine("sum=" + sum.ToString()); //2124;
            Console.ReadKey();
}


// ref 参数;
static void Main(string[] args)
{
    int r =10;
    GetInt(ref r);
    Console.WriteLine(r);	//20;
    Console.ReadLine();
}

public static void GetInt(ref int a)
{
    a += a;
}


// out参数；
int F(int j ,out int i)
{
    j--;
    i = j;
    return i+j;
}

int i;
// 调用out参数函数成员时，必须要在out参数前添加out修饰符;
int sum = F(100，out i);	//调用F(int j ,out int i)函数; 
Console.WriteLine(i);	//输出i变量的值;

// c# 中唯一三元运算符(?:)；
条件表达式？result_a :result_b;	//若条件成立，返回result_a;否则，返回result_b;


//continue;组合快捷键shift+tab即可自动排版;
for(int i=0; i<10;i++)
{
    if(i%2==0)  //偶数，continue跳出循环，打印出基数；
    {
        continue;   //如果i等于2，则跳出当前循环，开始下一次；
    }
    Console.WriteLine(i.ToString());
    //Console.ReadKey();
}


//switch--case;
//switch("表达式")
//{
//    case 常量表达式1：语句块1;
//    case 常量表达式2：语句块2;
//    ...
//    default: 语句块n;

//} 

//Example;
int i = 2022;
switch(i)
{
    case 2022:i++;
        break;
    case 2023:i--;
        break;
    default: break;
}

Console.WriteLine(i);
Console.ReadKey();

//for语句--Example;
int sum = 0;
for (int i = 0; i < 101; i++)
{
    if(i % 2  != 0) //偶数和；（若i%2==0），则求取奇数和；
    {
        continue;
    }
    sum += i;   //偶数和；
}

Console.WriteLine(sum);
Console.ReadKey();


//foreach语句--Example;
int[] arrays = { 1,3,5,7,9,3};
int sum =0;
foreach (int i in arrays)
{
    sum+=i;
}

Console.WriteLine(sum);
Console.ReadKey();
```

### 4.4 将控制台信息写入（读取）到指定路径下的Txt中；

```c#
//将文本信息写入指定路径下的txt中；
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static void Main(string[] args)
{
    Console.WriteLine("请输入信息：");
    string str = Console.ReadLine();
    System.IO.File.WriteAllText(@"C:\Users\eivision\Desktop\123.txt",str);
    Console.WriteLine("Successed!");
    Console.ReadKey();
}

// 使用using语句打开名称为123.txt文件；
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using (TextReader reader = File.OpenText(@"C:\Users\eivision\Desktop\123.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
    Console.ReadKey();
}

```

### 4.5 判断闰年；

```c#
// case1--手动输入年份;
static void JudgeYear(int year)
{
    while(year<0)
    {
        Console.Writeline("输入的年份有误，请重新输入！");
        break;
    }
    while(year>0)
    {
        if(year%4==0&&year%100!=0||year%400==0)
        {
            Console.WriteLinew("{0}是闰年！",year);
            break;
        }
        else
        {
            Console.Writeline("{0}非闰年！",year);
            break;
        }
    }
}

static void Main(string[] args)
{
    JudgeYear(2022);	//非闰年！
    Console.ReadKey();
}



//case2--控制台输入任意年份；
static void Main(string[] args)
{
    Console.WriteLine("请输入要判断的年份：");
    string s = Console.ReadLine();
    int year = Int32.Parse(s);	//将字符串转换为整型int；

    //int year = Convert.ToInt32(s);	//将字符串转换为整型int；
    
    while (year < 0)
    {
        Console.WriteLine("输入的年份有误，请重新输入！");
        break;
    }


    while (year > 0)
    {
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("{0}是闰年!", year);
            break;
        }
        else
        {
            Console.WriteLine("{0}非闰年！", year);
            break;
        }
    }

    Console.ReadKey();
}
```

### 4.6 get\set;

```c#
public struct Point
{
    private int x;  //私有；
    private int y;  //私有；
};
public int x
{
    get
    {
        return x;
    }
    set
    {
        x = value;
    }
}
public int y
{
    get
    {
        return y;
    }
    set
    {
        y = value;
    }
}
```

## 5、C# 调用方法；

```c#
using System;
namespace NumberCompareApplication
{
    class NumberCompare
    {
        public int FindMax(int n1, int n2)
        {
            int result;
            if(n1>n2)
            {
                result = n1;
            }
            else
            {
                result = n2;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int max;
            NumberCompare n = new NumberCompare();//通过创建一个实例来引用非静态变量NumberCompare;
            max = n.FindMax(120,230);
            Console.WriteLine("max={0}",max);
            Console.ReadLine();
        }
        
    }
}
```

### 5.1  递归方法调用;

```c#
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
   
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //调用 factorial 方法
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
            Console.ReadLine();

        }
    }
}
```

### 5.2  按值传递参数;

```c#
//实际参数的值会复制给形参，实参和形参使用的是两个不同内存中的值。所以，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全。
//结果表明，即使在函数内改变了值，值也没有发生任何的变化。

using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void swap(int x, int y)
      {
         int temp;
         
         temp = x; /* 保存 x 的值 */
         x = y;    /* 把 y 赋值给 x */
         y = temp; /* 把 temp 赋值给 y */
      }
     
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a = 100;
         int b = 200;
         
         Console.WriteLine("在交换之前，a 的值： {0}", a);//a=100
         Console.WriteLine("在交换之前，b 的值： {0}", b);//b=200;
         
         /* 调用函数来交换值 */
         n.swap(a, b);
         
         Console.WriteLine("在交换之后，a 的值： {0}", a);//a=100;
         Console.WriteLine("在交换之后，b 的值： {0}", b);//b=200;
         
         Console.ReadLine();
      }
   }
}
```

### 5.3 按引用（ref）传递参数;

```c#
//引用参数是一个对变量的内存位置的引用。当按引用传递参数时，与值参数不同的是，它不会为这些参数创建一个新的存储位置。引用参数表示与提供给方法的实际参数具有相同的内存位置。
//在 C# 中，使用 ref 关键字声明引用参数。

using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void swap(ref int x, ref int y)
      {
         int temp;

         temp = x; /* 保存 x 的值 */
         x = y;    /* 把 y 赋值给 x */
         y = temp; /* 把 temp 赋值给 y */
       }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a = 100;
         int b = 200;

         Console.WriteLine("在交换之前，a 的值： {0}", a);//a=100;
         Console.WriteLine("在交换之前，b 的值： {0}", b);//b=200;

         /* 调用函数来交换值 */
         n.swap(ref a, ref b);

         Console.WriteLine("在交换之后，a 的值： {0}", a);//a=200;
         Console.WriteLine("在交换之后，b 的值： {0}", b);//b=100;
 
         Console.ReadLine();

      }
   }
}
```

### 5.4 按输出(0ut)传递参数;

```c#
//return 语句可用于只从函数中返回一个值。但是，可以使用 输出参数 来从函数中返回两个值。输出参数会把方法输出的数据赋给自己，其他方面与引用参数相似。
using System;

namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void getValue(out int x )
      {
         int temp = 5;
         x = temp;
      }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a = 100;
         
         Console.WriteLine("在方法调用之前，a 的值： {0}", a);//a=100;
         
         /* 调用函数来获取值 */
         n.getValue(out a);

         Console.WriteLine("在方法调用之后，a 的值： {0}", a);//a=5;
         Console.ReadLine();

      }
   }
}
```

## 6、数组；

### 6.1 初始化数组；

```c#
//1、直接赋值；
string [] str1 = {"c","c++","c#","java","python"};

//2、使用new操作符，并指定数组长度；
string [] str2 = new string [5] {"c","c++","c#","java","python"};

//3、使用new操作符，不指定数组长度；
string [] str2 = new string [] {"c","c++","c#","java","python"};

//4、直接设置数组的各元素值；
string [] str4 = new string[7];
for(int i=0; i<str4.Length;i++)
{
    str4[i]=i.ToString();
}
```

### 6.2 遍历数组（使用下标for\while;不使用下标--foreach）;

```c#
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


//case3--Exercise;
int[] nums = { 1, 23, 4, 34, 5, 6, 7, 3243 };

int max = nums[1];
int min = nums[3];

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
    if (nums[i] < min)
    {
        min = nums[i];
    }
}

Console.WriteLine("max={0},min={1}", max, min);
Console.ReadKey();
```

### 6.3  简单数组及多维数组使用--（params 关键字）；

```c#
//简单数组；
using System;
namespace ArrayApplication
{
   class MyArray
   {
      static void Main(string[] args)
      {
         int []  n = new int[10]; /* n 是一个带有 10 个(均为0)整数的数组 */
         int i,j;

         /* 初始化数组 n 中的元素 */        
         for ( i = 0; i < 10; i++ )
         {
            n[ i ] = i + 100;
         }

         /* 输出每个数组元素的值 */
         for (j = 0; j < 10; j++ )
         {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
         Console.ReadKey();
      }
   }
}
/***************************************************************************************************/

//多维数组；
using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            /* 一个带有 5 行 2 列的数组 */
            int[,] a = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8} };

            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
                }
            }
           Console.ReadKey();
        }
    }
}
/***************************************************************************************************/

//params 关键字(参数数组)；
//在使用数组作为形参时，C# 提供了 params 关键字，使调用数组为形参的方法时，既可以传递数组实参，也可以传递一组数组元素。
//params 的使用格式为：
//public 返回类型 方法名称( params 类型名称[] 数组名称 )
using System;

namespace ArrayApplication
{
   class ParamArray
   {
      public int AddElements(params int[] arr)
      {
         int sum = 0;
         foreach (int i in arr)
         {
            sum += i;
         }
         return sum;
      }
   }
     
   class TestClass
   {
      static void Main(string[] args)
      {
         ParamArray app = new ParamArray();
         int sum = app.AddElements(512, 720, 250, 567, 889);
         Console.WriteLine("总和是： {0}", sum);//2938;
         Console.ReadKey();
      }
   }
}
```

## 7、接口（interface）;

```c#
//声明一个MyInterface的接口，并声明一个名称为name的属性；
interface MyInterface
{
    string name
    {
        get;
        set;
    }
}
```

## 8、委托（delegate）;

```c#
// 声明一个名称为MyFunction的委托。该委托指定的方法包含两个Int类型的参数，且返回一个int的值。
delegate int MyFunction(int x, int y);
```



## 9、C# 结构体（Struct）；

```c#
//在 C# 中，结构体是值类型数据结构。它使得一个单一变量可以存储各种数据类型的相关数据。
//struct 关键字用于创建结构体。

//定义结构体
//为了定义一个结构体，您必须使用 struct 语句。struct 语句为程序定义了一个带有多个成员的新的数据类型。
//例如，您可以按照如下的方式声明 Book 结构：
struct Books
{
    public string title;
    public string author;
    public string subject;
    public string book_id;
};//";"不可少！
/***************************************************************************************************/

using System;
using System.Text;
     
struct Books
{
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

public class testStructure
{
   public static void Main(string[] args)
   {

      Books Book1;        /* 声明 Book1，类型为 Books */
      Books Book2;        /* 声明 Book2，类型为 Books */

      /* book 1 详述 */
      Book1.title = "C Programming";
      Book1.author = "Nuha Ali";
      Book1.subject = "C Programming Tutorial";
      Book1.book_id = 6495407;

      /* book 2 详述 */
      Book2.title = "Telecom Billing";
      Book2.author = "Zara Ali";
      Book2.subject =  "Telecom Billing Tutorial";
      Book2.book_id = 6495700;

      /* 打印 Book1 信息 */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* 打印 Book2 信息 */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);      

      Console.ReadKey();

   }
}
```

## 10、C# 枚举（Enum）；

```c#
//枚举是一组命名整型常量。枚举类型是使用 enum 关键字声明的。
//C# 枚举是值类型。换句话说，枚举包含自己的值，且不能继承或传递继承。
//声明 enum 变量
//声明枚举的一般语法：
enum <enum_name>
{ 
    enumeration list 
};

//case;
using System;

public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main(string[] args)
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}
```

## 11、C# 类（Class）；

```c#
//类的定义
//类的定义是以关键字 class 开始，后跟类的名称。类的主体，包含在一对花括号内。下面是类定义的一般形式：
<access specifier> class  class_name
{
    // member variables
    <access specifier> <data type> variable1;
    <access specifier> <data type> variable2;
    ...
    <access specifier> <data type> variableN;
    // member methods
    <access specifier> <return type> method1(parameter_list)
    {
        // method body
    }
    <access specifier> <return type> method2(parameter_list)
    {
        // method body
    }
    ...
    <access specifier> <return type> methodN(parameter_list)
    {
        // method body
    }
}
/***************************************************************************************************/


using System;
namespace BoxApplication
{
    class Box
    {
       public double length;   // 长度
       public double breadth;  // 宽度
       public double height;   // 高度
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();        // 声明 Box2，类型为 Box
            double volume = 0.0;         // 体积
            double area = 0.0;

            // Box1 详述
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // Box2 详述
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;
           
            // Box1 的面积、体积
            area = Box1.height * Box1.length;
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Box1's area={0}, Box1's volume = {1}", area, volume);
 
            // Box2 的面积、体积
             area =  Box2.height * Box2.length;
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Box2's area={0}, Box2's volume = {1}", area,volume);
            Console.ReadKey();
        }
    }
}
```

### 11.1 成员函数和封装;

```c#
//类的成员函数是一个在类定义中有它的定义或原型的函数，就像其他变量一样。作为类的一个成员，它能在类的任何对象上操作，且能访问该对象的类的所有成员。
//成员变量是对象的属性（从设计角度），且它们保持私有来实现封装。这些变量只能使用公共成员函数来访问。

using System;
namespace BoxApplication
{
    class Box
    {
       private double length;   // 长度
       private double breadth;  // 宽度
       private double height;   // 高度
       public void setLength( double len )
       {
            length = len;
       }

       public void setBreadth( double bre )
       {
            breadth = bre;
       }

       public void setHeight( double hei )
       {
            height = hei;
       }
       public double getVolume()
       {
           return length * breadth * height;
       }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();                // 声明 Box2，类型为 Box
            double volume;                               // 体积


            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);
       
            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}" ,volume);//210;

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);//1560;
           
            Console.ReadKey();
        }
    }
}
```

### 11.2 C# 中的构造函数;

```c#
//类的 构造函数 是类的一个特殊的成员函数，当创建类的新对象时执行。
//构造函数的名称与类的名称完全相同，它没有任何返回类型。

using System;
namespace LineApplication
{
   class Line
   {
      private double length;   // 线条的长度
      public Line()
      {
         Console.WriteLine("对象已创建");
      }

      public void setLength( double len )
      {
         length = len;
      }
      public double getLength()
      {
         return length;
      }

      static void Main(string[] args)
      {
         Line line = new Line();    
         // 设置线条长度
         line.setLength(6.0);
         Console.WriteLine("线条的长度： {0}", line.getLength());
         Console.ReadKey();
      }
   }
}
```

### 11.3 C# 中的析构函数;

```c#
//类的析构函数是类的一个特殊的成员函数，当类的对象超出范围时执行。
//析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
//析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。

using System;
namespace LineApplication
{
   class Line
   {
      private double length;   // 线条的长度
      public Line()  // 构造函数
      {
         Console.WriteLine("对象已创建");
      }
      ~Line() //析构函数
      {
         Console.WriteLine("对象已删除");
      }

      public void setLength( double len )
      {
         length = len;
      }
      public double getLength()
      {
         return length;
      }

      static void Main(string[] args)
      {
         Line line = new Line();
         // 设置线条长度
         line.setLength(6.0);
         Console.WriteLine("线条的长度： {0}", line.getLength());          
      }
   }
}
```

### 11.4 C# 类的静态成员;

```c#
// 我们可以使用 static 关键字把类成员定义为静态的。当我们声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。
// 关键字 static 意味着类中只有一个该成员的实例。静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取。静态变量可在成员函数或类的定义外部进行初始化。你也可以在类的定义内部初始化静态变量。

using System;
namespace StaticVarApplication
{
    class StaticVar
    {
       public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();        
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());//6;
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());//6;
            Console.ReadKey();
        }
    }
}
```

## 12、C# 继承；

```c#
//继承是面向对象程序设计中最重要的概念之一。继承允许我们根据一个类来定义另一个类，这使得创建和维护应用程序变得更容易。同时也有利于重用代码和节省开发时间。

//当创建一个类时，程序员不需要完全重新编写新的数据成员和成员函数，只需要设计一个新的类，继承了已有的类的成员即可。这个已有的类被称为的基类，这个新的类被称为派生类。

//继承的思想实现了 属于（IS-A） 关系。例如，哺乳动物 属于（IS-A） 动物，狗 属于（IS-A） 哺乳动物，因此狗 属于（IS-A） 动物。

```







