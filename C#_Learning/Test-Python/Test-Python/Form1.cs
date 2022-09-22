using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Test_Python
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region C# 调用Python;
            //if (textBox1.Text == string.Empty)
            //{
            //    textBox1.Text = "0";
            //}
            //if (textBox2.Text == string.Empty)
            //{
            //    textBox2.Text = "0";
            //}


            //int num1 = Convert.ToInt32(textBox1.Text);
            //int num2 = Convert.ToInt32(textBox2.Text);


            ////调用python
            //ScriptRuntime pyRunTime = Python.CreateRuntime();
            //dynamic obj = pyRunTime.UseFile("‪C:/Users/eivision/Desktop/test.py");
            //label_result.Text = Convert.ToString(obj.add(num1, num2));
            #endregion


            //C# 调用exe;
            label1.Text = "waiting . . .";
            string num1;
            if (textBox1.Text.Length != 0)
                num1 = textBox1.Text;
            else
                num1 = "0";

            string pyexePath = @".\test.exe";

            Process p = new Process();
            p.StartInfo.FileName = pyexePath;//需要执行的文件路径
            p.StartInfo.UseShellExecute = false; //必需
            p.StartInfo.RedirectStandardOutput = true;//输出参数设定
            p.StartInfo.RedirectStandardInput = true;//传入参数设定
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = num1;//参数以空格分隔，如果某个参数为空，可以传入””
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();//关键，等待外部程序退出后才能往下执行}
            //Console.Write(output);//输出
            textBox1.Text = Convert.ToString(output);
            p.Close();

            label1.Text = "finish";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label1.Text = "?";
        }


    }
}
