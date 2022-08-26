using RawImgProcess.AbsValueMode;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawImgProcess
{
    public partial class ReadRawMain : UIHeaderAsideMainFrame
    {
        public ReadRawMain()
        {
            InitializeComponent();

            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 61451);
            TreeNode parent = Aside.CreateNode("绝对值模式", 61451, 24, pageIndex);
            //通过设置PageIndex关联，节点文字、图标由相应的Page的Text、Symbol提供
            Aside.CreateChildNode(parent, AddPage(new Readimg(), ++pageIndex));
            //Aside.CreateChildNode(parent, AddPage(new Saveimg(), ++pageIndex));

            //示例设置某个节点的小红点提示
            Aside.ShowTips = true;
            Aside.SetNodeTipsText(Aside.Nodes[0], "", Color.Red, Color.White);
            //Aside.SetNodeTipsText(parent.Nodes[1], " ", Color.Lime, Color.White);


            pageIndex = 2000;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 61818);
            parent = Aside.CreateNode("相对值模式", 61818, 24, pageIndex);

            //通过设置GUID关联，节点字体图标和大小由UIPage设置
            //Aside.CreateChildNode(parent, AddPage(new Readimg(), Guid.NewGuid()));
            //Aside.CreateChildNode(parent, AddPage(new Saveimg(), Guid.NewGuid()));
            //Aside.CreateChildNode(parent, AddPage(new FFrames(), Guid.NewGuid()));

            pageIndex = 3000;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 61950);
            parent = Aside.CreateNode("区域模式", 61950, 24, pageIndex);

            //直接关联（默认自动生成GUID）
            //Aside.CreateChildNode(parent, AddPage(new FBarChart()));
            //Aside.CreateChildNode(parent, AddPage(new FDoughnutChart()));
            //Aside.CreateChildNode(parent, AddPage(new FLineChart()));
            //Aside.CreateChildNode(parent, AddPage(new FPieChart()));

            pageIndex = 4000;
            Header.SetNodePageIndex(Header.Nodes[3], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[3], 362614);
            parent = Aside.CreateNode("热力图模式", 362614, 24, pageIndex);

            //直接关联（默认自动生成GUID）
            //Aside.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FPipe")));
            //Aside.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FMeter")));
            //Aside.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FLed")));
            //Aside.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FLight")));

        }

        //关闭主窗体程序；
        private void ReadRawMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit(); 
            DialogResult result = MessageBox.Show("确定要退出吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        //设置时间；
        private void Time_Tick(object sender, EventArgs e)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;
            this.labelControl_Time.Text = now.ToString("yyyy-MM-dd  HH:mm:ss");
        }
    }
}
