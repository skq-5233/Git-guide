using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eg3_2
{
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            //加载图像;
            picBox1Dialog.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox1Dialog.Image = Image.FromFile(@"C:\Users\eivision\Desktop\11\win10.jpg");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("将要关闭程序,是否继续？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                //关闭窗体;
                e.Cancel = false;
            }
            else
            {
                //取消关闭窗体;
                e.Cancel = true;
            }
        }
    }
}
