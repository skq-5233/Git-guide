using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int number1, number2;

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to Niuma World!");
        }
     
        //点击按钮进行加法运算;
        private void uiButton1_Click(object sender, EventArgs e)
        {
            int result;
            number1 = int.Parse(textBox1.Text.Trim());
            number2 = int.Parse(textBox2.Text.Trim());
            result = number1 + number2;

            textBox3.Text = result.ToString();
        }

        //退出程序前询问是否退出;
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("确实退出程序吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                //退出;
                e.Cancel = false;
            }

            else
            {
                //取消退出;
                e.Cancel = true;
            }
        }

        //取消按钮;
        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
