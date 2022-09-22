using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "0";
            }


            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);


            //调用python
            ScriptRuntime pyRunTime = Python.CreateRuntime();
            dynamic obj = pyRunTime.UseFile("C:/Users/Lee/Desktop/States/test.py");
            label_result.Text = Convert.ToString(obj.add(num1, num2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label_result.Text = "?";
        }


    }
}
