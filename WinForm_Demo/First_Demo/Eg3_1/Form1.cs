using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eg3_1
{
    public partial class frmAdd : Form
    {
        int num1, num2;
        public frmAdd()
        {
            InitializeComponent();
        }
        private void uiButton1OK_Click(object sender, EventArgs e)
        {
            //实现加法运算;
            int result;
            num1 = int.Parse(textBox1First.Text.Trim());
            num2 = int.Parse(textBox2Second.Text.Trim());
            result = num1 + num2;
            textBox3Result.Text = result.ToString();
        }
        private void uiButton1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
