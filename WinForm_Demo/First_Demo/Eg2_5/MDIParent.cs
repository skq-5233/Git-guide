using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eg2_5
{
        //        2.3、排列MDI子窗体；
        //public void LayoutMdi(MdiLayout value)
        //MdiLayout.ArrangeIcons--所有MDI子图标均排列在MDI父窗体的工作区;
        //MdiLayout.Cascade--所有MDI子图标均层叠在MDI父窗体的工作区;
        //MdiLayout.TileHorizontal--所有MDI子图标均水平平铺在MDI父窗体的工作区;
        //MdiLayout.TileVertical--所有MDI子图标均垂直平铺在MDI父窗体的工作区;
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            //显示MDIChild1;
            MDIChild1 ChildForm1 = new MDIChild1();
            ChildForm1.MdiParent = this;
            ChildForm1.Show();

            //显示MDIChild2;
            MDIChild2 ChilderForm2 = new MDIChild2();
            ChilderForm2.MdiParent = this;
            ChilderForm2.Show();

            //加载皮肤动态链接库文件实现界面美化;
            //Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
            //skin.SkinFile = System.Environment.CurrentDirectory + "\\skins\\" + "Wave.ssk";    //通过选择不同的皮肤文件*.ssk更换不同效果;
            //skin.Active = true;
        }


        private void uiButton1_Click(object sender, EventArgs e)
        {
            //水平平铺;
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            //垂直平铺;
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            //层叠排列;
            LayoutMdi(MdiLayout.Cascade);
        }

        //关闭主界面窗体时，提示是否关闭；
        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("将要关闭窗体，是否继续?","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                //窗体关闭事件继续;
                e.Cancel = false;
            }
            else
            {
                //窗体关闭事件取消;
                e.Cancel = true;
            }
        }

    }
}
