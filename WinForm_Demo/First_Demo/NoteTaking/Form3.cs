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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string userName = "";
        string userPassword = "";

        private void Form3_Load(object sender, EventArgs e)
        {
            //加载图像：
            picBox1Dialog.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox1Dialog.Image = Image.FromFile(@"C:\Users\eivision\Desktop\11\win10.jpg");
        }

        //取消;
        private void button2_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体程序前询问是否退出;
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("确定退出吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
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

        //子窗体传值给父窗体???;
        private void button1_OK_Click(object sender, EventArgs e)
        {
            userName = textBox1_userName.Text.ToString();
            userPassword = textBox2_userPassword.Text.ToString();
            MessageBox.Show("Create Successfully!");
        }


    }
}
