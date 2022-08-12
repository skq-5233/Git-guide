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
using Emgu.Util;
using System.Threading;

namespace Second_Demo
{
    public partial class Second_Demo : Form
    {
        public Second_Demo()
        {
            InitializeComponent();
        }

        //获取当前程序运行路径；
        string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        //定义路径；
        string path = string.Empty;

        //定义新图像；
        Mat scr = new Mat();

        //图片总数;
        Int32 picturecount = 0;

        //设置路径；
        String defaultfilepath;

        //设置线程；
        Thread thread1;

        //设置处理多幅图像状态下的绘图线段图像；
        Mat drawLine_img = new Mat();

        Image<Bgr, Byte> drawLine2_img;

        /********************************************************
        *   EmguCV-点结构类型；
        *   MCvpoint2D64f(二维64位双精度浮点型)；
        *   MCvpoint3D32f(三维64位单精度浮点型)；
        *   MCvpoint3D64f(三维64位双精度浮点型)；
        *********************************************************/

        #region//point--MCvPoint3D64f;
        //public struct MCvPoint3D64f : IEquatable<MCvPoint3D64f>
        //{
        //    public double X;
        //    public double Y;
        //    public double Z;

        //    public MCvPoint3D64f(double x,double y,double z);

        //    public static MCvPoint3D64f opetatotr -(MCvPoint3D64f p1, MCvPoint3D64f p2);
        //    public static MCvPoint3D64f operator *(double scale,MCvPoint3D64f p);
        //    public static MCvPoint3D64f operator *(MCvPoint3D64f p, double scale);
        //    public static MCvPoint3D64f operator +(MCvPoint3D64f p1, MCvPoint3D64f p2);

        //    public MCvPoint3D64f CrossProduct(MCvPoint3D64f point);
        //    public double Dotproduct(MCvPoint3D64f point);
        //    public bool Equal(MCvPoint3D64f other);

        //    //public MCvPoint3D32f(float x, float y, float z);   //指定坐标创建 MCvPoint3D32f；
        //    //MCvPoint3D64f mcvPoint = new MCvPoint3D64f(0, 0, 0);

        //    ////分别获取X,Y,Z坐标；
        //    //double x = mcvPoint.X;
        //    //double y = mcvPoint.Y;
        //    //double z = mcvPoint.Z;
        //}
        #endregion




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
                if (OFDialog.ShowDialog() == DialogResult.OK)
                {
                    //指定路径加载图像，若OFDialog.FileName含有中文路径，则Mat类打不开，但Image<TColor,TDepth>可以；
                    //Mat scr = new Mat(OFDialog.FileName, Emgu.CV.CvEnum.LoadImageType.AnyColor);
                    scr = new Mat(OFDialog.FileName);

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
     
        private void drawline_Click(object sender, EventArgs e)
        {

            /********************** 在图像上绘制直线段*********************
            * scr -待被画直线的原始图像；           
            * new Point(100, 100)-起始位置设置（矩形左上角坐标；100，100）；new Point(120, 120)：矩形长宽设置；
            * new MCvScalar(0, 155, 0)--颜色设置；
            * 2：画笔宽度；
            * LineType：四、八邻域及锯齿连接；
            ************************************************************/

            //在加载图像上绘制直线段；
            //CvInvoke.Line(scr, new Point(100, 100), new Point(120, 120), new MCvScalar(0, 0, 0), 2, LineType.EightConnected);



            /***********定义直线段随机坐标点*****************************
            * line_p1:线段起始点横坐标；
            * line_p2：线段起始点纵坐标；
            * line_p3:线段终止点横坐标；
            * line_p2：线段终止点纵坐标；
            ************************************************************/

            //画线段产生随机数；
            Random rdLine = new Random();

            int line_p1= rdLine.Next(0, 200);
            int line_p2 = rdLine.Next(0, 200);
            int line_p3 = rdLine.Next(0, 200);
            int line_p4 = rdLine.Next(0, 200);

            CvInvoke.Line(scr, new Point(line_p1, line_p2), new Point(line_p3, line_p4), new MCvScalar(0, 0, 0), 2, LineType.EightConnected);

            //显示图像；
            pictureBox1.Image = scr.ToBitmap();

            //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
            path = str + "\\Result\\DrawLine_Image";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //显示、保存图像；               
            //CvInvoke.Imshow("img", scr);

            //保存结果图像----与.exe在同一路径下；
            CvInvoke.Imwrite(path + "\\" + "DrawLineRandom.bmp", scr);

            //暂停按键等待
            CvInvoke.WaitKey(0);
        }

        private void drawcircle_Click(object sender, EventArgs e)
        {

            /********************** 在图像上绘制圆*********************
            1、***** 绘制空心圆****
            * scr -待被画直线的原始图像；           
            * new Point:圆心位置；
            *  10：半径大小；
            * new MCvScalar(0,0,0)-bgr--颜色设置;
            * 1：画笔粗细；

            2、***** 绘制实心圆****
            *  前四项与绘制空心圆一致；最后一项设置为：-1；
            ************************************************************/

            //画圆(空心圆)；
            //CvInvoke.Circle(scr, new Point(150, 50), 10, new MCvScalar(0, 0, 0), 1);

            //画圆(实心圆)；new MCvScalar(0,0,0)-bgr;new Point:圆心位置； 2：半径大小；-1：画实心圆；
            //CvInvoke.Circle(scr, new Point(150, 50), 2, new MCvScalar(0, 0, 0), -1);




           /***********定义圆心随机坐标点*****************************
           * circle_p1:圆心起始点横坐标；
           * circle_p2：圆心起始点纵坐标；          
           ************************************************************/

            //画圆产生随机数；
            Random rdLine = new Random();

            int circle_p1 = rdLine.Next(0, 250);
            int circle_p2 = rdLine.Next(0, 250);            

            CvInvoke.Circle(scr, new Point(circle_p1, circle_p2), 1, new MCvScalar(0, 0, 0), -1);


            //显示图像；
            pictureBox1.Image = scr.ToBitmap();

            //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
            path = str + "\\Result\\DrawCirle_Image";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //显示、保存图像；               
            //CvInvoke.Imshow("img", scr);

            //保存结果图像----与.exe在同一路径下；
            //保存空心圆结果；
            //CvInvoke.Imwrite(path + "\\" + "DrawCirle-hollow.bmp", scr);  

            //保存实心圆结果；
            CvInvoke.Imwrite(path + "\\" + "DrawCirle-solid.bmp", scr);

            //暂停按键等待
            CvInvoke.WaitKey(0);
        }

        private void drawrectangle_Click(object sender, EventArgs e)
        {
            /********************** 在图像上绘制矩形*********************
            1、***** 绘制空心矩形框****
            * scr -待被画直线的原始图像；           
            * new Rectangle(100, 100, 50, 50):起始位置设置（100：左上角，100：右下角；50：矩形长；50：矩形宽）；          
            * new MCvScalar(0,0,0)-bgr--颜色设置;
            * 2：画笔粗细；

            2、***** 绘制实心矩形框****
            *  前四项与绘制空心矩形一致；最后一项设置为：-2；        
            ************************************************************/
            //画矩形(空心矩形框)；
            //CvInvoke.Rectangle(scr, new Rectangle(80, 80, 10, 10), new MCvScalar(0, 0, 0), 2);

            //画矩形(实心矩形框)；
            CvInvoke.Rectangle(scr, new Rectangle(80, 80, 10, 10), new MCvScalar(0, 0, 0), -2);

            //显示图像；
            pictureBox1.Image = scr.ToBitmap();

            //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
            path = str + "\\Result\\DrawRectangle_Image";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //显示、保存图像；               
            //CvInvoke.Imshow("img", scr);

            //保存结果图像----与.exe在同一路径下；
            //保存空心圆结果；
            //CvInvoke.Imwrite(path + "\\" + "DrawRectangle-hollow.bmp", scr);

            //保存实心圆结果；
            CvInvoke.Imwrite(path + "\\" + "DrawRectangle-solid.bmp", scr);

            //暂停按键等待
            CvInvoke.WaitKey(0);
        }

        private void drawellipse_Click(object sender, EventArgs e)
        {

            /********************** 在图像上绘制椭圆*********************
            1、***** 绘制空心椭圆****
            * scr -待被画椭圆的原始图像；           
            * new Point:圆心位置；
            * new Size(20, 20)：半径大小；
            * new MCvScalar(0,0,0)-bgr--颜色设置;
            * 1：画笔粗细--画空心椭圆；
            * -1:实心椭圆；
          
            ************************************************************/
            CvInvoke.Ellipse(scr, new RotatedRect(new PointF(90, 60), new Size(20, 50), 0), new MCvScalar(0, 0, 0), 1);

            //CvInvoke.Ellipse(scr, new Point(50, 50), new Size(20, 20), 45, 0, 360, new MCvScalar(0, 0, 255), 1);


            //添加文本信息--CvInvoke.PutText();
            //CvInvoke.PutText(scr,"Holy",new Point(80,50),FontFace.HersheySimplex,2,new MCvScalar(0,0,0),2);


            //显示图像；
            pictureBox1.Image = scr.ToBitmap();

            //add--修改路径问题（设为本地路径(与.exe同一路径)--start）
            path = str + "\\Result\\DrawEllipse_Image";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //显示、保存图像；               
            //CvInvoke.Imshow("img", scr);

            //保存结果图像----与.exe在同一路径下；
            //保存空心圆结果；
            CvInvoke.Imwrite(path + "\\" + "DrawRectangle-hollow.bmp", scr);

            //保存实心圆结果；
            //CvInvoke.Imwrite(path + "\\" + "DrawEllipse-solid.bmp", scr);

            //暂停按键等待
            CvInvoke.WaitKey(0);
        }

        /***********************处理多幅图像**************************
        ***** 添加线段;
        /***********************************************************/
        private void drawlinefolder_Click(object sender, EventArgs e)
        {
            //图像计数；
            picturecount = 0;

            //记忆上次打开文件夹路径；
            folderBrowserDialog1.SelectedPath = defaultfilepath; 


            //打开文件夹函数；
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                defaultfilepath = folderBrowserDialog1.SelectedPath; //记忆上次打开文件夹路径；


                thread1 = new Thread(new ThreadStart(ImageProcessingAll));  //创建线程；
                thread1.Start();    //开启线程；
            }
        }


        private void ImageProcessingAll()   //处理文件指定文件夹下所有图片
        {
                     
            DirectoryInfo folder;

            folder = new DirectoryInfo(defaultfilepath);

            //图像计数；
            double pic = 0;

            //遍历文件夹；
            foreach (FileInfo nextfile in folder.GetFiles())
            {
                Invoke((EventHandler)delegate { label5.Text = "图片名称：" + Path.GetFileName(nextfile.FullName); });
                Invoke((EventHandler)delegate { label5.Refresh(); });

                //图像计数；
                pic++;


                // DirectoryInfo对象.Name获得文件夹名;.FullName获得文件夹完整的路径名
                drawLine_img = CvInvoke.Imread(nextfile.FullName, ImreadModes.AnyColor);

                //Mat 2 Image------drawLine_img-->drawLine1_img;
                Image<Bgr, Byte> drawLine1_img = drawLine_img.ToImage<Bgr, Byte>();

                //判断是否为空；
                if (drawLine1_img == null)
                {
                    Invoke((EventHandler)delegate { label2.Text = "无法加载文件！"; });
                    Invoke((EventHandler)delegate { label2.Refresh(); });
                    return;
                }


                //遍历文件夹内图像数量;
                string path = defaultfilepath;
                //string[] files = Directory.GetFiles(path, "*.bmp");   //origin;

                string[] files = Directory.GetFiles(path, "*.jpg"); //work;

                //string[] files = Directory.GetFiles(path, "JPEG;BMP;PNG;JPG;GIF|*.JPEG;*.BMP;*.PNG;*.JPG;*.GIF|ALL|*.*");
               

                //progressBar1.Value = 0;  //清空进度条
                //获取文加下图像总数；
                double sumpic = (double)files.Length;


                //Invoke使用委托delegate解决测试文件夹过程中卡顿现象；
                Invoke((EventHandler)delegate { progressBar1.Value = (int)((pic / sumpic) * 100); });
                Invoke((EventHandler)delegate { label4.Text = "当前进度: " + Convert.ToInt32((int)((pic / sumpic) * 100)) + '%' + "\r\n"; });

                Thread.Sleep(50);

                //当进度条完成后，提示用户已完成；
                if (pic == sumpic)
                {
                    DialogResult dr01 = MessageBox.Show("ProgressBar1 has been finished!");
                }
              


                //图像计数；
                picturecount++;
                Invoke((EventHandler)delegate { label3.Text = "图像数量：" + picturecount.ToString(); });
                Invoke((EventHandler)delegate { label3.Refresh(); });


                //检测内容
                Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(drawLine1_img); });
                Invoke((EventHandler)delegate { pictureBox1.Refresh(); });



                /***********定义直线段随机坐标点*****************************
                * line_p1:线段起始点横坐标；
                * line_p2：线段起始点纵坐标；
                * line_p3:线段终止点横坐标；
                * line_p2：线段终止点纵坐标；
                ************************************************************/

                //画线段产生随机数（包括线段的起始、终止坐标）；
                Random rdLine = new Random();

                int line_p1 = rdLine.Next(0, 250);
                int line_p2 = rdLine.Next(0, 250);
                int line_p3 = rdLine.Next(0, 250);
                int line_p4 = rdLine.Next(0, 250);

                CvInvoke.Line(drawLine1_img, new Point(line_p1, line_p2), new Point(line_p3, line_p4), new MCvScalar(0, 0, 0), 2, LineType.EightConnected);
                


                drawLine2_img = drawLine1_img.Copy();

                //显示图像；
                pictureBox1.Image = drawLine2_img.ToBitmap();




                //add--修改路径问题（设为本地路径(与.exe同一路径);
                path = str + "\\Auto-Folder-Image-Result\\DrawCircle_Result";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

              
                CvInvoke.Imwrite(path + "\\" + Path.GetFileName(nextfile.FullName), drawLine2_img); //保存结果图像；
                CvInvoke.WaitKey(0); //暂停按键等待


                }
            }

        private void drawcirlefolder_Click(object sender, EventArgs e)
        {
            //图像计数；
            picturecount = 0;

            //记忆上次打开文件夹路径；
            folderBrowserDialog1.SelectedPath = defaultfilepath; 


            //打开文件夹函数；
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                defaultfilepath = folderBrowserDialog1.SelectedPath; //记忆上次打开文件夹路径；


                thread1 = new Thread(new ThreadStart(ImageProcessingAll_Circle));  //创建线程；
                thread1.Start();    //开启线程；
            }
        }

        private void ImageProcessingAll_Circle()   //处理文件指定文件夹下所有图片
        {

            DirectoryInfo folder;

            folder = new DirectoryInfo(defaultfilepath);

            //图像计数；
            double pic = 0;

            //遍历文件夹；
            foreach (FileInfo nextfile in folder.GetFiles())
            {
                Invoke((EventHandler)delegate { label5.Text = "图片名称：" + Path.GetFileName(nextfile.FullName); });
                Invoke((EventHandler)delegate { label5.Refresh(); });

                //图像计数；
                pic++;


                // DirectoryInfo对象.Name获得文件夹名;.FullName获得文件夹完整的路径名
                drawLine_img = CvInvoke.Imread(nextfile.FullName, ImreadModes.AnyColor);

                //Mat 2 Image------drawLine_img-->drawLine1_img;
                Image<Bgr, Byte> drawLine1_img = drawLine_img.ToImage<Bgr, Byte>();

                //判断是否为空；
                if (drawLine1_img == null)
                {
                    Invoke((EventHandler)delegate { label2.Text = "无法加载文件！"; });
                    Invoke((EventHandler)delegate { label2.Refresh(); });
                    return;
                }


                //遍历文件夹内图像数量;
                string path = defaultfilepath;
                //string[] files = Directory.GetFiles(path, "*.bmp");   //origin;

                string[] files = Directory.GetFiles(path, "*.jpg"); //work;

                //string[] files = Directory.GetFiles(path, "JPEG;BMP;PNG;JPG;GIF|*.JPEG;*.BMP;*.PNG;*.JPG;*.GIF|ALL|*.*");


                //progressBar1.Value = 0;  //清空进度条
                //获取文加下图像总数；
                double sumpic = (double)files.Length;


                //Invoke使用委托delegate解决测试文件夹过程中卡顿现象；
                Invoke((EventHandler)delegate { progressBar1.Value = (int)((pic / sumpic) * 100); });
                Invoke((EventHandler)delegate { label4.Text = "当前进度: " + Convert.ToInt32((int)((pic / sumpic) * 100)) + '%' + "\r\n"; });

                Thread.Sleep(50);

                //当进度条完成后，提示用户已完成；
                if (pic == sumpic)
                {
                    DialogResult dr01 = MessageBox.Show("ProgressBar1 has been finished!");
                }



                //图像计数；
                picturecount++;
                Invoke((EventHandler)delegate { label3.Text = "图像数量：" + picturecount.ToString(); });
                Invoke((EventHandler)delegate { label3.Refresh(); });


                //检测内容
                Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(drawLine1_img); });
                Invoke((EventHandler)delegate { pictureBox1.Refresh(); });



                /***********定义圆心随机坐标点*****************************
                * circle_p1:圆心起始点横坐标；
                * circle_p2：圆心起始点纵坐标；          
                ************************************************************/

                //画圆产生随机数；
                Random rdLine = new Random();

                int circle_p1 = rdLine.Next(50, 250);
                int circle_p2 = rdLine.Next(50, 250);

                CvInvoke.Circle(drawLine1_img, new Point(circle_p1, circle_p2), 2, new MCvScalar(0, 0, 0), -1);



                drawLine2_img = drawLine1_img.Copy();

                //显示图像；
                pictureBox1.Image = drawLine2_img.ToBitmap();




                //add--修改路径问题（设为本地路径(与.exe同一路径);
                path = str + "\\Auto-Folder-Image-Result\\DrawCircle_Result";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                CvInvoke.Imwrite(path + "\\" + Path.GetFileName(nextfile.FullName), drawLine2_img); //保存结果图像；
                CvInvoke.WaitKey(0); //暂停按键等待


            }
        }












    }
}
