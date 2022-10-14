using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eg2_4
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //case1--直接打开多个子窗体；
            ////实例化MDIChild1对象，命名为ChildForm1;
            //MDIChild1 ChildForm1 = new MDIChild1();
            ////指定即将打开的MDIChild1对象的MdiParent，即MDIChild1对象的MDI父窗口，为当前的主MDI窗口;
            //ChildForm1.MdiParent = this;
            ////显示新窗体--ChildForm1;
            //ChildForm1.Show();

            ////实例化MDIChild2对象，命名为ChildForm2；
            //MDIChild2 ChildForm2 = new MDIChild2();
            ////指定即将打开的MDIChild2对象的MdiParent，即MDIChild2对象的MDI父窗口，为当前的主MDI窗口;
            //ChildForm2.MdiParent = this;
            ////显示新窗体--childForm2;
            //ChildForm2.Show();

            //case2--防止重复打开窗口(以子窗体1为例，子窗体2操作方法一样);
            //直接检测是否已经打开此MDI窗体;
            //使用循环（foreach）来判断是否已经打开了;
            foreach(Form childrenForm in this.MdiChildren)
            {
                //检测是不是当前子窗体的名称;
                if(childrenForm.Name=="MDIChild1")
                {
                    //如果当前子窗体名称是MDIChild1，则显示；
                    childrenForm.Visible = true;
                    //激活该窗体；
                    childrenForm.Activate();
                    return;
                }
            }

            //打开子窗体;
            MDIChild1 ChildForm1 = new MDIChild1();
            ChildForm1.MdiParent = this;
            ChildForm1.Show();


        }
    }
}
