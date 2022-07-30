using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_2022_0104_
{
    class Program
    {

        //public访问修饰符；
        #region
        //public double Length;
        //public double Width;

        //public double Get_Area()
        //{
        //    return Length * Width;
        //}

        //public void Play()
        //{
        //    Console.WriteLine("长度是：{0}",Length);
        //    Console.WriteLine("宽度是：{0}",Width);
        //    Console.WriteLine("面积是：{0}",Get_Area());
        //}

        //class ExecuteProgram
        //{
        #endregion

        static void Main(string[] args)
        {
            //(XOR,异或，2022-0104);
            #region
            //Console.WriteLine("Input number1:");
            //double n1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Input number2:");
            //double n2 = Convert.ToDouble(Console.ReadLine());

            //bool b = (n1 > 10) ^ (n2 > 10);//(^,XOR，异或);
            //if (b)
            //{
            //    Console.WriteLine("Meet the requirements");

            //}
            //else
            //{
            //    Console.WriteLine("Please input number again!");
            //}
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

            //(溢出检查，checked,2022-0104);
            #region
            //byte destinationVar;
            //short sourceVar = 281;
            //destinationVar = checked((byte)sourceVar);
            //Console.WriteLine("sourceVar val:{0}", sourceVar);
            //Console.WriteLine("destinationVar val:{0}", destinationVar);
            #endregion

            //(打印文本信息，2022-0114)；
            #region
            //int i;
            //string text = "";
            //for(i = 0; i < 10; i++)
            //{
            //    text = "Line " + Convert.ToString(i);
            //    Console.WriteLine("{0}", text);
            //}
            //Console.WriteLine("Lat text output in loop {0}", text);
            #endregion

            // 调用ref参数--0511；
            #region
            //int a1 = 10;
            //int b1 = 20;
            //Console.WriteLine("调用ref前:a1={0},b1={1};", a1, b1);

            //调用ref;
            //Num_Trans(ref a1, ref b1);
            //Console.WriteLine("调用ref前:a1={0},b1={1};", a1, b1);
            //Console.ReadKey();
            #endregion

            //调用params参数，处理实参列表中的数值；
            #region
            //Stu_Score("zhangsan", 110, 99, 120);
            //Console.ReadKey();
            #endregion

            //方法重载(OverLoad)--0511；
            #region
            //Calculate(1, 2);
            //Console.WriteLine(1 + 2);

            //Calculate(1, 2, 3);
            //Console.WriteLine(1 + 2 + 3);

            //重载--double;            
            //Console.WriteLine(Calculate(1.23, 12.3));

            //重载--string;   
            //Console.WriteLine(Calculate("hello", ",c#"));//""--字符；
            //Console.ReadKey();


            //Console.WriteLine(true);
            //Console.WriteLine('c');
            //Console.WriteLine("123");
            //Console.WriteLine(5000m);
            //Console.ReadKey();
            #endregion


            ////方法重载(OverLoad)-调用函数M--0511；
            #region 
            //M(1,3);//调用第一个函数；
            //Console.WriteLine(M(1.5, 2.5));//调用第二个函数；
            //M(1, 2, 3);//调用第三个函数；
            //Console.WriteLine(M("Hello，" ,"World"));//调用第四个函数；S
            //Console.ReadKey();
            #endregion

            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("sum={0}", sum);
            //Console.ReadKey();

            //判断数组中最大值、最小值及求和；
            #region
            //int[] nums =  { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = nums[1];
            //int min = nums[2];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];

            //    }
            //    if (nums[i] < min) 
            //    {
            //        min = nums[i];

            //    }
            //}
            //Console.WriteLine("max={0},min={1}", max, min);           
            //Console.ReadKey();
            #endregion


            //求2-100所有质数；
            #region
            //methond1;
            //int i, j;

            //for (i = 2; i < 100; i++)
            //{
            //    for (j = 2; j <= (i / j); j++)
            //    { 
            //        if ((i % j) == 0) break; // 如果找到，则不是质数
            //    }
            //    if (j > (i / j))
            //        Console.WriteLine("{0} 是质数", i);
            //}

            //Console.ReadLine();
            #endregion

            //methond2;
            #region
            //for (int i=2; i<100;i++)
            //{
            //    int j = 2;
            //    while(i % j !=0)
            //    {
            //        j++;
            //    }
            //    if(i==j)
            //    {
            //        Console.WriteLine("{0}是质数",i);
            //    }

            //}
            //    Console.ReadKey();
            #endregion

            /* 局部变量定义 */
            //continue
            #region
            //int a = 10;

            ///* do 循环执行 */
            //do
            //{
            //    if (a == 15)
            //    {
            //        /* 跳过迭代 */
            //        a = a + 1;
            //        continue;
            //    }
            //    Console.WriteLine("a 的值： {0}", a);
            //    a++;

            //}
            //while (a < 20);

            //Console.ReadLine();
            #endregion

            //1-100质数-0518；
            #region
            //for (int i = 2; i <= 100; i++)
            //{
            //    int j = 2;
            //    while(i%j!=0)
            //    {
            //        j++;
            //    }
            //    if(i==j)
            //    {
            //        Console.WriteLine("{0}是质数", i);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            //public-area
            #region
            //Program p = new Program();
            //p.Length = 2.5;
            //p.Width = 3.1;
            //p.Play();
            //Console.ReadLine();
            #endregion

            //Console.WriteLine(ConvertIntToBinary(15));
            //Console.ReadKey();

            //0607-(ConvertIntToBinary);

            //Console.WriteLine(ConvertIntToBinary(50));
            //Console.ReadKey();


        }

        // ref参数(将参数代入方法并带出)--0511；
        #region
        //public static void Num_Trans(ref int a,ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion

        //params可变参数--0511（ 1、params必须位于方法参数最后。2、params后面必须跟一个数组。）;
        //将实参列表中跟可变参数数组类型一致的元素都当做数组的元素去处理;
        #region
        //求数组总和；
        //public static void Stu_Score(string name, int id,params int [] score)
        //{
        //    int sum = 0;
        //    for(int i = 0; i<score.Length; i++)
        //    {
        //        sum += score[i];
        //    }
        //    Console.WriteLine("{0}的考试总成绩是{1},学号是{2}", name, sum,id);//add id学号；
        //}

        #endregion

        //方法重载(OverLoad)-0511；**方法重载
        //概念：方法的重载指的是方法的名称相同，但是参数不同。
        //参数不同，分为两种情况：
        //1）如果参数的个数相同，那么参数的类型就不能够相同。
        //2）如果参数的类型相同，那么参数的个数就不能相同。
        //**方法的重载跟返回值没有关系。
        #region
        //public static void M(int n1,int n2)
        //{
        //    int result = n1 + n2;
        //    Console.WriteLine(result);//直接调用函数，输出结果；
        //}

        //public static double M(double d1, double d2)
        //{
        //    return d1 + d2;//在调用时，利用Console.WriteLine()进行打印结果并输出；

        //}

        //public static void M(int n1, int n2,int n3)
        //{
        //    int result = n1 + n2 + n3;
        //    Console.WriteLine(result);//直接调用函数，输出结果；
        //}

        //public static string M(string s1, string s2)
        //{
        //  return  s1 + s2;//在调用时，利用Console.WriteLine()进行打印结果并输出；
        //}



        //private static void Calculate(int n1, int n2)
        //{
        //    int result = n1 + n2;
        //}

        //private static void Calculate(int n1, int n2, int n3)
        //{
        //    int result = n1 + n2 + n3;
        //}

        //public  static double Calculate(double d1,double d2)
        //{
        //    return d1 + d2;

        //}

        //public static string Calculate(string s1, string s2)
        //{
        //    return s1 + s2;
        //}

        #endregion

        //}


        //public 修饰符；
        #region
        //using System;
        //namespace RectangleApplication
        //{
        //    class Rectangle
        //    {
        //        public double length;
        //        public double width;

        //        public double Get_Area()
        //        {
        //            return length * width;
        //        }
        //        public void Start()
        //        {
        //            Console.WriteLine("长度是{0}", length);
        //            Console.WriteLine("宽度是{0}", width);
        //            Console.WriteLine("面积是{0}", Get_Area());
        //        }

        //        class ExecuteRectangle()
        //		{
        //			static void Main(string[] args)
        //        {
        //            Rectangle r = new Rectangle();
        //            r.length = 2.5;
        //            r.width = 3.5;
        //            r.Start();
        //            Console.ReadLine();
        //        }
        //    }

        //}
        //}
        #endregion

        //0607-(ConvertIntToBinary);
        //static string ConvertIntToBinary(int n)
        //{
        //    string binary = string.Empty;
        //    int i = n;
        //    int m = 0;
        //    while(i>1)
        //    {
        //        i = n / 2;
        //        m = n % 2;
        //        binary = m.ToString() + binary;
        //        n = i;
        //    }
        //    if(i>0)
        //    {
        //        binary = "1" + binary;
        //    }
        //    return binary;
        //}




       
       



    }
}






