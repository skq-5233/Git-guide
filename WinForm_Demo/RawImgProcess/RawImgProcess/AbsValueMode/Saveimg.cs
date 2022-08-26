using Emgu.CV;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawImgProcess.AbsValueMode
{
    public partial class Saveimg : UIPage
    {
        public Saveimg()
        {
            InitializeComponent();
        }

        //默认路径；
        String defaultfilepath;

        //设置路径；
        string path = string.Empty;

        //文件名；
        string dbf_File = string.Empty;

        //设置对话框；
        OpenFileDialog ofd = new OpenFileDialog();

        //获取当前程序运行路径；
        string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        //定义Bmp大小；
        Bitmap bt = new Bitmap(640, 512);


        private void Save_Img_Click(object sender, EventArgs e)
        {
            //获取文件名；
            dbf_File = ofd.FileName;

            //////////datetime格式化；
            //DateTime dt = DateTime.Now;

            string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile

            //创建文件夹路径；
            path = str + "\\Result\\Save_Result";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //保存bmp图像；
            bt.Save(path + "\\" + dbf_File2 + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            MessageBox.Show("Save Image Success!");

            //CvInvoke.Imwrite(path + "\\" + dbf_File2 + "Raw2Bmp.bmp", bt); //保存结果图像；
            //CvInvoke.WaitKey(0); //暂停按键等待
        }
    }
}
