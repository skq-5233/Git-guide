using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using System.IO;
using Emgu.CV.CvEnum;

namespace First_Demo
{
    public partial class First_Demo : Form
    {
        public First_Demo()
        {
            InitializeComponent();
        }


        //获取当前程序运行路径；
        string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        //定义路径；
        string path = string.Empty;

        private void CreateImage_Click(object sender, EventArgs e)
        {

            //创建一张尺寸为400*400的红色图像；
            Image<Bgr, byte> image = new Image<Bgr, byte>(400, 400, new Bgr(0, 0, 255));

            //在picturebox中显示图像；
            pictureBox1.Image = image.ToBitmap();


            //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
            path = str + "\\Result\\Create_Image";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //显示、保存图像；               
            //CvInvoke.Imshow("img", image); 

            //保存结果图像----与.exe在同一路径下；
            CvInvoke.Imwrite(path + "\\" + "Create.bmp", image); 

            //暂停按键等待
            CvInvoke.WaitKey(0); 



        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            
            {
                //实例化打开对话框；
                OpenFileDialog OFDialog = new OpenFileDialog();

                //判断是否打开对话框；
                if(OFDialog.ShowDialog() == DialogResult.OK)
                {
                    //指定路径加载图像，若OFDialog.FileName含有中文路径，则Mat类打不开，但Image<TColor,TDepth>可以；
                    //Mat scr = new Mat(OFDialog.FileName, Emgu.CV.CvEnum.LoadImageType.AnyColor);
                    Mat scr = new Mat(OFDialog.FileName);

                    pictureBox1.Image = scr.ToBitmap();

                    //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
                    path = str + "\\Result\\Load_Image";

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    //显示、保存图像；               
                    //CvInvoke.Imshow("img", image); 

                    //保存结果图像----与.exe在同一路径下；
                    CvInvoke.Imwrite(path + "\\" + "Load.bmp", scr);

                    //暂停按键等待
                    CvInvoke.WaitKey(0);

                }
            }

        }
    }
}
