## 1、Hello_World;

```c#
using System;
namespace HelloWorld_Application
{
    class HelloWorld
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

## 4、Public;

```c#
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

```c#
//简单数组；
using System;
namespace ArrayApplication
{
   class MyArray
   {
      static void Main(string[] args)
      {
         int []  n = new int[10]; /* n 是一个带有 10 个整数的数组 */
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

## 7、C# 结构体（Struct）；

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

8、C# 枚举（Enum）；

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

    static void Main()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}
```







