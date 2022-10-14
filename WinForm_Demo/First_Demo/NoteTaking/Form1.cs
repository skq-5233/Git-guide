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
    public partial class Login : Form
    {
        //子界面如何传值给主界面；
        //public class NamePasswordChangedEventArgs : EventArgs //事件参数类;
        //{
        //    private string userName = "";   //字段;
        //    public string userName  //属性;
        //    {
        //        get
        //        {
        //            return userName;
        //        }
        //        set
        //        {
        //            userName = value;
        //        }
        //    }

        //    //声明委托；
        //    public delegate void NamePasswordChangedEventHandler(object sender, NamePasswordChangedEventArgs e);
        //    //定义事件；
        //    public event NamePasswordChangedEventHandler NamePasswordChanged;

        //}

        public Login()
        {
            InitializeComponent();
        }

        string userName = "admin";
        string userPassword = "*518*";


        private void Login_Load(object sender, EventArgs e)
        {
            //加载图像：
            picBox1Dialog.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox1Dialog.Image = Image.FromFile(@"C:\Users\eivision\Desktop\11\win10.jpg");

            picBox2Dialog.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox2Dialog.Image = Image.FromFile(@"C:\Users\eivision\Desktop\11\tour.tif");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭程序前进行询问;
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("确定退出程序吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                //退出程序;
                e.Cancel = false;
            }
            else
            {
                //取消退出程序;
                e.Cancel = true;
            }
        }

        //登录按钮;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1_User.Text == userName && textBox2_Pass.Text == userPassword)
            {
                MessageBox.Show("Login Successful!");
                Form2 fm = new Form2();
                fm.Show();
            }
            else if(textBox1_User.Text == userName && textBox2_Pass.Text != userPassword)
            {
                MessageBox.Show("Please Check Your UserPassword!");
            }
            else if(textBox1_User.Text != userName && textBox2_Pass.Text == userPassword)
            {
                MessageBox.Show("Please Check Your userName!");
            }
            else if(textBox1_User.Text != userName && textBox2_Pass.Text != userPassword)
            {
                MessageBox.Show("Please Check Your userName and userPassword!");
            }
        }

        //如何注册新用户？？？;
        private void linkLabel1NewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please Input Your Name and Password!");
            //userName = textBox1_User.Text.ToString();
            //userPassword = textBox2_Pass.Text.ToString();
            Form3 fm1 = new Form3();
            fm1.Show();

        }
    }
}
