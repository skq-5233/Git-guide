using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eg2_2
{
    public partial class FrmbkColor : Form
    {
        public FrmbkColor()
        {
            InitializeComponent();
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            //设置背景颜色;
            //this.BackColor = Color.BlueViolet;
            this.BackColor = Color.FromArgb(125,200,135);
        }
    }
}
