using Emgu.CV;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadRAW.OfflineTestMode
{
    public partial class AbsValueMode : UIPage
    {
        public AbsValueMode()
        {
            InitializeComponent();
        }

        public byte[] ImgData = null;
        public int[] ImgInt = null;
        public byte[] ImgByte = null;
        public byte[,] ImgRGB = null;
        public Bitmap Bmp = null;

        public int Width = 640;
        public int Height = 512;

        //Bits = "8\12\14";
        public string Bits = "14";

        //默认路径；
        String defaultfilepath;

        //设置路径；
        string path = string.Empty;

        string dbf_File = string.Empty;

        //export-excel;
        private int indexOfExcel_j = 1;
        FileStream filestream = null;

        XSSFWorkbook rawpixel = null;
        ISheet isheet = null;
        IRow rowWrite = null;

        //获取当前程序运行路径；
        string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        //时间设置；
        //DateTime dt = DateTime.Now;


        //线程；
        //Thread thread1;
        //设置对话框；
        OpenFileDialog ofd = new OpenFileDialog();

        //Time_Test;
        //System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();

        //定义Bmp大小；
        Bitmap bt = new Bitmap(640, 512);

        //加载Raw原始图像；
        //打开RAW图按钮
        private void Load_Raw_Img_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件";

            ofd.Filter = "RAW文件(*.raw)|*.raw|所有文件(*.*)|*.*";
            ofd.FilterIndex = 1;


            //记忆上次打开文件夹路径；
            folderBrowserDialog1.SelectedPath = defaultfilepath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //使用线程thread1；
                Thread thread1 = new Thread(new ThreadStart(ImgprocessAccelerate));
                thread1.Start();

                //ImgprocessAccelerate();

            }
        }

        //使用线程thread1，将以下几种函数封装在一起；
        public void ImgprocessAccelerate()
        {
            //Time_Test;
            //st.Reset();
            //st.Start();

            //var  ImgData = File.ReadAllBytes(ofd.FileName);
            //var  ImgInt = GetImgInt(ImgData, Width, Height, Bits);
            //var  ImgByte = GetImgByte(ImgInt, Width, Height, Bits);
            //var  ImgRGB = GetImgRGB(ImgByte, Width, Height);
            //var Bmp = GetBmp(ImgRGB, Width, Height);

            ImgData = File.ReadAllBytes(ofd.FileName);
            ImgInt = GetImgInt(ImgData, Width, Height, Bits);
            ImgByte = GetImgByte(ImgInt, Width, Height, Bits);
            ImgRGB = GetImgRGB(ImgByte, Width, Height);
            Bmp = GetBmp(ImgRGB, Width, Height);

            //Time_Test;
            //st.Stop();
            //MessageBox.Show(st.ElapsedMilliseconds.ToString());   //showtime;

            //记忆上次打开文件夹路径；
            defaultfilepath = folderBrowserDialog1.SelectedPath;

            //thread1 = new Thread(new ThreadStart(ImageProcessingAll));  //创建线程；
            //thread1.Start();    //开启线程；

            //获取文件名；
            //dbf_File = ofd.FileName;

            if (Bmp != null)
            {
                //This.Invoke({ pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height) })
                //pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height);   //origin;

                //Thread with Invoke;事件委托；
                Invoke(new EventHandler(delegate { pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height); }));
                //Bmp.Dispose();
            }

        }

        // 文件字节流解析，10位的图是两个字节转为一个整形数据
        public int[] GetImgInt(byte[] img, int width, int height, string Bits)
        {
            if (img == null)
            {
                return null;
            }
            int Index = 0;
            int[] OriImg = new int[width * height];
            try
            {
                if (Bits == "8")
                {
                    if (img.Length != width * height)
                    {
                        return null;
                    }
                    for (int i = 0; i < img.Length; i += 4)
                    {
                        OriImg[i] = img[i];
                        OriImg[i + 1] = img[i + 1];
                        OriImg[i + 2] = img[i + 2];
                        OriImg[i + 3] = img[i + 3];
                    }
                    return OriImg;
                }
                else if (Bits == "12" || Bits == "14")
                {
                    if (img.Length != width * height * 2)
                    {
                        return null;
                    }
                    //图像的像素个数一定是4的倍数，所以一次性处理4个像素，循环展开，提高循环效率
                    for (int i = 1; i < img.Length; i += 8)
                    {
                        OriImg[Index] = (0x00FF & img[i - 1]) | (0xFF00 & img[i] << 8);
                        Index++;
                        OriImg[Index] = (0x00FF & img[i + 1]) | (0xFF00 & img[i + 2] << 8);
                        Index++;
                        OriImg[Index] = (0x00FF & img[i + 3]) | (0xFF00 & img[i + 4] << 8);
                        Index++;
                        OriImg[Index] = (0x00FF & img[i + 5]) | (0xFF00 & img[i + 6] << 8);
                        Index++;
                    }
                    return OriImg;
                }
            }
            finally
            {
                GC.Collect();
            }
            return null;
        }


        // 将整型数组转为8位图像数据
        public byte[] GetImgByte(int[] img, int width, int height, string Bits)
        {
            if (img == null)
            {
                return null;
            }
            byte[] Img = new byte[img.Length];
            try
            {
                switch (Bits)
                {
                    case ("8"):
                        for (int i = 0; i < img.Length; i += 4)
                        {
                            Img[i] = (byte)img[i];
                            Img[i + 1] = (byte)img[i + 1];
                            Img[i + 2] = (byte)img[i + 2];
                            Img[i + 3] = (byte)img[i + 3];
                        }
                        break;
                    case ("12"):
                        for (int i = 0; i < img.Length; i += 4)
                        {
                            Img[i] = (byte)(img[i] >> 4);
                            Img[i + 1] = (byte)(img[i + 1] >> 4);
                            Img[i + 2] = (byte)(img[i + 2] >> 4);
                            Img[i + 3] = (byte)(img[i + 3] >> 4);
                        }
                        break;
                    case ("14"):


                        //add-max\min均设置为img[0]; 

                        int min = img[0];
                        int max = img[0];

                        //max、min-index;                     
                        int index_min = 0;
                        int index_max = 0;

                        for (int i = 0; i < img.Length; i++)
                        {
                            //Img[i] = (byte)(img[i] >> 6);
                            //Img[i + 1] = (byte)(img[i + 1] >> 6);
                            //Img[i + 2] = (byte)(img[i + 2] >> 6);
                            //Img[i + 3] = (byte)(img[i + 3] >> 6);


                            if (img[i] > max)
                            {
                                max = img[i];

                                index_max = i + 1;
                            }

                            if (img[i] < min)
                            {
                                min = img[i];

                                index_min = i + 1;

                            }



                        }

                        //label4.Text = "最小值位置：" + index_min.ToString("f2");
                        //label5.Text = "最大值位置：" + index_max.ToString("f2");

                        //打印max\min;
                        //label2.Text = "最大值是：" + max.ToString("f2");
                        //label3.Text = "最小值是：" + min.ToString("f2");
                        //min = 4400;

                        //将像素值缩放至：0-255;
                        for (int i = 0; i < img.Length; i += 4)
                        {

                            Img[i] = (byte)(255 * (img[i] - min) / (max - min));
                            Img[i + 1] = (byte)(255 * (img[i + 1] - min) / (max - min));
                            Img[i + 2] = (byte)(255 * (img[i + 2] - min) / (max - min));
                            Img[i + 3] = (byte)(255 * (img[i + 3] - min) / (max - min));



                            //保存至Txt文本信息；
                            //获取文件名；
                            dbf_File = ofd.FileName;

                            ////////datetime格式化；
                            DateTime dt = DateTime.Now;

                            string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile


                            ////打印原始像素信息，保存文本信息至指定文件夹；
                            //label2.Text = "时间:" + dt.ToLocalTime().ToString() + "\n" + "图像名称：" + "\n" + dbf_File2 + "\n" +
                            //                "\n" +
                            //                "最大像素值: " + max.ToString("f2") + ";" + "\n" + "\n" +
                            //                "最小像素值: " + min.ToString("f2") + ";" + "\n" + "\n" +
                            //                "像素值: " + img[i].ToString("f2") + ";" + "\n" + "\n";

                            label1.Text = "时间:" + dt.ToLocalTime().ToString() + "\n" + "\n" + "图像名称：" + "\n" + dbf_File2 + "\n" +
                                           "\n" +
                                           "最大像素值: " + max.ToString("f2") + ";" + "\n" + "\n" +
                                           "最大像素值位置: " + index_max.ToString("f2") + ";" + "\n" + "\n" +
                                           "最小像素值: " + min.ToString("f2") + ";" + "\n" + "\n" +
                                           "最小像素值位置: " + index_min.ToString("f2") + ";" + "\n" + "\n";


                            #region ////////保存文本信息至指定文件夹；
                            //string txt = label2.Text;

                            ////创建文件夹路径；
                            //path = str + "\\Result\\Excel_Txt_Result";

                            //if (!Directory.Exists(path))
                            //{
                            //    Directory.CreateDirectory(path);
                            //}

                            //string filename = path + "\\" + "图像信息.txt";   //文件名，可以带路径

                            //FileStream fs = new FileStream(filename, FileMode.Append);
                            //StreamWriter wr = null;
                            //wr = new StreamWriter(fs);

                            ////System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
                            //wr.Write(label2.Text);
                            //wr.Close();
                            #endregion



                            #region////保存Excel信息至指定文件夹；
                            //filestream = new FileStream(path + "\\" + "图像信息.xlsx", FileMode.OpenOrCreate);


                            ////创建表和sheet;
                            //if (indexOfExcel_j == 1)
                            //{
                            //    rawpixel = new XSSFWorkbook();   //创建表对象rawpixel
                            //    isheet = rawpixel.CreateSheet("Sheet1");   //在rawpixel中创建sheet1
                            //                                               //创建表头
                            //    IRow rowtitle = null;
                            //    rowtitle = isheet.CreateRow(0); //创建index=j的行

                            //    ICell cellTitle0 = null;
                            //    cellTitle0 = rowtitle.CreateCell(0);  //在index=j的行中创建index=0的单元格
                            //    cellTitle0.SetCellValue("时间"); //给创建的单元格赋值string

                            //    ICell cellTitle1 = null;
                            //    cellTitle1 = rowtitle.CreateCell(1);  //在index=j的行中创建index=0的单元格
                            //    cellTitle1.SetCellValue("图像名称"); //给创建的单元格赋值string

                            //    ICell cellTitle2 = null;
                            //    cellTitle2 = rowtitle.CreateCell(2);  //在index=j的行中创建index=0的单元格
                            //    cellTitle2.SetCellValue("最大值"); //给创建的单元格赋值string

                            //    ICell cellTitle3 = null;
                            //    cellTitle3 = rowtitle.CreateCell(3);  //在index=j的行中创建index=0的单元格
                            //    cellTitle3.SetCellValue("最小值"); //给创建的单元格赋值string

                            //    ICell cellTitle4 = null;
                            //    cellTitle4 = rowtitle.CreateCell(4);  //在index=j的行中创建index=0的单元格
                            //    cellTitle4.SetCellValue("像素值"); //给创建的单元格赋值string
                            //}



                            //////datetime格式化；
                            ////DateTime dt = DateTime.Now;

                            //rowWrite = isheet.CreateRow(indexOfExcel_j++); //创建index=j的行

                            //ICell cell0 = null;
                            //cell0 = rowWrite.CreateCell(0);  //在index=j的行中创建index=0的单元格
                            //cell0.SetCellValue(dt.ToLocalTime().ToString()); //给创建的单元格赋值string

                            //ICell cell1 = null;
                            //cell1 = rowWrite.CreateCell(1);  //在index=j的行中创建index=0的单元格
                            //cell1.SetCellValue(dbf_File2); //给创建的单元格赋值string

                            //ICell cell2 = null;
                            //cell2 = rowWrite.CreateCell(2);  //在index=j的行中创建index=0的单元格
                            //cell2.SetCellValue("max:" + max.ToString("f2")); //给创建的单元格赋值string


                            //ICell cell3 = null;
                            //cell3 = rowWrite.CreateCell(3);  //在index=j的行中创建index=0的单元格
                            //cell3.SetCellValue("min:" + min.ToString("f2")); //给创建的单元格赋值string

                            //ICell cell4 = null;
                            //cell4 = rowWrite.CreateCell(4);  //在index=j的行中创建index=0的单元格

                            ////cell4.SetCellValue("pixel:" + pixel.ToString("f2")); //给创建的单元格赋值string

                            //cell4.SetCellValue("pixel:" + img[i].ToString("f2")); //给创建的单元格赋值string

                            ////通过流filestream将表rawpixel写入文件;
                            //rawpixel.Write(filestream);
                            #endregion


                        }

                        //label2.Text = "最大值是：" + Img[10].ToString("f2");

                        #region //冒泡排序(**如何快排?)；
                        //for (int i = 0; i < img.Length - 1; i++)
                        //{
                        //    for (int j = 0; j < img.Length - 1 - i; j++)
                        //    {
                        //        if (img[j] > img[j + 1])
                        //        {
                        //            int temp = img[j];
                        //            img[j] = img[j + 1];
                        //            img[j + 1] = temp;
                        //        }
                        //    }
                        //}

                        //for (int i = 0; i < img.Length; i++)
                        //{
                        //    //Console.WriteLine(img[i].ToString());

                        //}
                        #endregion


                        break;
                }
            }


            catch (Exception) {; }
            finally
            {
                GC.Collect();
            }
            return Img;
        }


        //byte[]转为RGB图像矩阵byte[3,]
        public byte[,] GetImgRGB(byte[] img, int width, int height)
        {
            if (img == null)
            {
                return null;
            }
            byte[,] Img = new byte[3, width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Img[0, y * width + x] = img[y * width + x];
                    Img[1, y * width + x] = img[y * width + x];
                    Img[2, y * width + x] = img[y * width + x];
                }
            }
            return Img;
        }


        // RGB图像矩阵转为Bitmap
        public Bitmap GetBmp(byte[,] img, int width, int height)
        {
            if (img == null || width * height * 3 != img.Length)
            {
                return null;
            }

            //Bitmap bt = new Bitmap(width, height);    //origin;

            BitmapData data = bt.LockBits(new Rectangle(new Point(), bt.Size), ImageLockMode.WriteOnly, bt.PixelFormat);
            int ofs = 0;
            int pix;
            try
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        pix = Color.FromArgb(img[0, y * width + x], img[1, y * width + x], img[2, y * width + x]).ToArgb();
                        Marshal.WriteInt32(data.Scan0, ofs, pix);
                        ofs += 4;
                    }
                }
            }
            catch (EndOfStreamException)
            {
            }
            finally
            {
                bt.UnlockBits(data);
            }
            return bt;
        }

        //保存为bmp格式的图像；
        private void Save_Img_Click(object sender, EventArgs e)
        {
            //int width = 640;
            //int height = 512;
            //Bitmap bitmap = new Bitmap(width, height);
            //bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);

            //bitmap里面要有图片，自定义，我就不贴了
            //前一段为保存路径加文件名，后一段为保存格式，我这里保存为bmp格式，也可以为.jpeg或者.png之类的
            //string path = "D:\\bmp\\test.bmp";

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
            CvInvoke.WaitKey(0); //暂停按键等待
        }






    }
}
