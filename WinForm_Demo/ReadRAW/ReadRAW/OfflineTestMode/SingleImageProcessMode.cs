using DevExpress.Utils.About;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
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
    public partial class SingleImageProcessMode : UIPage
    {

/***************************************设计离线测试-单图像处理模式************************************************************
        *1、【图像格式选择】：Raw,Jpg,Png,Tif,Bmp;----添加到imgFormatUiComboBox1；并在事件中设计SelectedIndexChanged;
        *1.1、当选择图像格式为Raw时，【图像位数选择】：8,12,14；----添加到chooseBitFormatUiComboBox1；并在事件中设计SelectedIndexChanged;
        *2、【测试模式】包括【绝对值模式】、【相对值模式】、【区域模式】及【显示模式】（【灰度图模式】、【热力图模式】）；
        *2.1、 其中【显示模式】为前三个模式共有；
        *2.2、【测试模式】----添加到testModeUiComboBox2；并在事件中设计SelectedIndexChanged; 
        *2.3、【区域模式】----上下限阈值通过TextBox进行设置；
        *3、通过Label显示像素值及坐标信息；
****************************************************************************************************************************/
        public SingleImageProcessMode()
        {
            InitializeComponent();


            //图像格式选择;
            IList<Info> infoList_ChooseImgFormat = new List<Info>();

            infoList_ChooseImgFormat.Add(new Info() { Name = "Raw" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Jpg" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Png" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Tif" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Bmp" });
            

            //使用uiComboBox1添加离线测试模式下5种图像格式；
            imgFormatUiComboBox1.DisplayMember = "Name";
            imgFormatUiComboBox1.DataSource = infoList_ChooseImgFormat;


            //当选择Raw格式时，可选8,12,14图像位数；
            //图像格式选择;
            IList<Info> infoList_ChooseImgBits = new List<Info>();

            infoList_ChooseImgBits.Add(new Info() { Name = "8" });
            infoList_ChooseImgBits.Add(new Info() { Name = "12" });
            infoList_ChooseImgBits.Add(new Info() { Name = "14" });

            chooseBitFormatUiComboBox1.DisplayMember = "Name";
            chooseBitFormatUiComboBox1.DataSource = infoList_ChooseImgBits;



            //dt.Columns.Add("Column1", typeof(string));
            //dt.Columns.Add("Column2", typeof(string));
            //dt.Columns.Add("Column3", typeof(string));


            //测试模式设置：绝对值模式，相对值模式，区域模式;
            IList<Info> infoList_ChooseTestMode = new List<Info>();

            infoList_ChooseTestMode.Add(new Info() { Name = "绝对值模式" });
            infoList_ChooseTestMode.Add(new Info() { Name = "相对值模式" });
            infoList_ChooseTestMode.Add(new Info() { Name = "区域模式" });
            //infoList1.Add(new Info() { Name = "热力图模式" });
            

            //使用uiComboBox2添加离线测试模式下3种模式；            
            testModeUiComboBox2.DisplayMember = "Name";
            testModeUiComboBox2.DataSource = infoList_ChooseTestMode;


            //显示模式设置：灰度图、热力图；
            IList<Info> infoList2_ChooseShowMode = new List<Info>();
            infoList2_ChooseShowMode.Add(new Info() { Name = "灰度图模式" });
            infoList2_ChooseShowMode.Add(new Info() { Name = "热力图模式" });


            //使用uiComboBox3添加显示模式下2种模式；      
            showModeUiComboBox3.DisplayMember = "Name";
            showModeUiComboBox3.DataSource = infoList2_ChooseShowMode;

        }


        public byte[] ImgData = null;
        public int[] ImgInt = null;
        public byte[] ImgByte = null;
        public byte[,] ImgRGB = null;
        public Bitmap Bmp = null;

        public int Width = 640;
        public int Height = 512;

        //Bits = "8\12\14";
        //public string Bits = "14";
        public string Bits;

        //设置offlineTestMode_Flag(0--绝对值模式，1--相对值模式,2--区域模式);
        public int offlineTestMode_Flag;

        //设置offlineShowMode_Flag(0--灰度图模式，1--热力图模式);
        public int offlineShowMode_Flag;

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

        //add;
        //DataTable dt = new DataTable();

        //根据TextBox输入进行判断；
        //bool numberInputFlag =true;

        public class Info
        {
            //public string Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                //return "ID: " + Id + ", Name: " + Name;
                return  "Name: " + Name;
            }
        }
        //add;

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

        //定义uiComboBox2_SelectedIndex初始值;
        private int uiComboBox2_SelectedIndex;

        //设置索引;
        public int SelectedIndex { get; private set; }

        //定义区域模式下，上下限阈值全局变量；
        public int upperPixel_Value;    //上限阈值;

        public int lowerPixel_Value;    //下限阈值;



        //加载Raw原始图像；
        //打开RAW图按钮
        private void Load_Raw_Img_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();

            //origin;
            //ofd.Title = "请选择文件";
            //ofd.Filter = "RAW文件(*.raw)|*.raw|所有文件(*.*)|*.*";

            //ofd.FilterIndex = 1;


            //记忆上次打开文件夹路径；
            folderBrowserDialog1.SelectedPath = defaultfilepath;

            //2022-0906--设置初始路径；
            //ofd.InitialDirectory = @"C:\Users\eivision\Desktop\WinForm_Demo\ReadRAW\ReadRAW\raw";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //使用线程thread1；
                Thread thread1 = new Thread(new ThreadStart(ImgprocessAccelerate));
                thread1.Start();

            }
        }

        //使用线程thread1，将函数ImgData()封装在一起；
        public void ImgprocessAccelerate()
        {
            //Time_Test;
            //st.Reset();
            //st.Start();

            #region//var 变量；
            //var  ImgData = File.ReadAllBytes(ofd.FileName);
            //var  ImgInt = GetImgInt(ImgData, Width, Height, Bits);
            //var  ImgByte = GetImgByte(ImgInt, Width, Height, Bits);
            //var  ImgRGB = GetImgRGB(ImgByte, Width, Height);
            //var Bmp = GetBmp(ImgRGB, Width, Height);
            #endregion

            ImgData = File.ReadAllBytes(ofd.FileName);

            //调用函数--GetImgIntProcess();将输入图像Raw转换为图像数组;
            //GetImgIntProcess();

            /************三种测试模式函数******************************
            * AbsModeGetImgByteProcess()    ----绝对值模式；
            * RelModeGetImgByteProcess()    ----相对值模式；
            * RegionModeGetImgByteProcess() ----区域模式；
            *********************************************************/

            ////调用函数AbsGetImgByteProcess进行绝对值模式下的处理;将输入图像Raw转换为的图像数组转换为字节;
            //AbsModeGetImgByteProcess();

            ////调用函数AbsGetImgByteProcess进行绝对值模式下的处理;将输入图像Raw转换为的图像数组转换为字节;
            //RelModeGetImgByteProcess();

            ////调用函数RegionModeGetImgByteProcess进行区域模式下的处理;将输入图像Raw转换为的图像数组转换为字节;
            //RegionModeGetImgByteProcess();

            //调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
            //GetImgRGBProcess();

            //调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
            //GetBmpProcess();
           
        }


        //GetImgIntProcess()--将输入图像Raw转换为图像数组;
        public void GetImgIntProcess()
        {
            ImgInt = GetImgInt(ImgData, Width, Height, Bits);
            //ImgByte = GetImgByte(ImgInt, Width, Height, Bits);
            //ImgRGB = GetImgRGB(ImgByte, Width, Height);
            //Bmp = GetBmp(ImgRGB, Width, Height);

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

        //（离线测试--绝对值模式下）将输入图像Raw转换为的图像数组转换为字节;
        public void AbsModeGetImgByteProcess()
        {
            //ImgByte = GetImgByte(ImgInt, Width, Height, Bits);

            //绝对值模式（8,12,14）；
            ImgByte = AbsModeGetImgByte(ImgInt, Width, Height, Bits);

            //相对值模式（8,12,14）；
            //ImgByte = AbsModeGetImgByte(ImgInt, Width, Height, Bits);

        }

        //（离线测试--相对值模式下）将输入图像Raw转换为的图像数组转换为字节;
        public void RelModeGetImgByteProcess()
        {
            ImgByte = RelModeGetImgByte(ImgInt, Width, Height, Bits);
        }

        //（离线测试--区域模式下）将输入图像Raw转换为的图像数组转换为字节;
        public void RegionModeGetImgByteProcess()
        {
            ImgByte = RegionModeGetImgByte(ImgInt, Width, Height, Bits);
        }


        //GetImgRGBProcess(); 将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
        public void GetImgRGBProcess()
        {
            ImgRGB = GetImgRGB(ImgByte, Width, Height);
        }


        //调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
        public void GetBmpProcess()
        {
            Bmp = GetBmp(ImgRGB, Width, Height);
        }


        // 文件字节流解析，10位的图是两个字节转为一个整形数据;
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

                    //遍历图像数组像素值；
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


/**********************************Offline-AbsoluteMode--Start****************************************************************/
        /**********************************************
        * uiComboBox2.SelectedIndex == 0,绝对值模式；
        * uiComboBox2.SelectedIndex == 1,相对值模式；
        * uiComboBox2.SelectedIndex == 2,区域模式；
        * uiComboBox2.SelectedIndex == 3,热力图模式--伪彩色applyColorMap函数；
        ********************************************************/

        //离线测试--绝对值模式下将整型数组转换为8位图像数据(mono8,mono12,mono14)；
        public byte[] AbsModeGetImgByte(int[] img, int width, int height, string Bits)
        {
            //判断是否为空;
            if (img == null)
            {
                return null;
            }

            //定义局部变量Img存放字节数组；
            byte[] Img = new byte[img.Length];


            /***********************绝对值模式***********************
            * 1、先遍历查询处图像数组中所有像素值;
            * 2、再进行缩放至0-255；(255*img[i])/(2^8,2^12,2^14);
            ********************************************************/

            try
            {
                switch (Bits)
                {
                    case ("8"):
                        for (int i = 0; i < img.Length; i += 4)
                        {
                            //origin;
                            //Img[i] = (byte)img[i];
                            //Img[i + 1] = (byte)img[i + 1];
                            //Img[i + 2] = (byte)img[i + 2];
                            //Img[i + 3] = (byte)img[i + 3];

                            //将255转化为Int32;
                            //int val = 255;
                            int intVal = Convert.ToInt32(255);

                            Img[i] = (byte)(intVal * img[i] / (2 ^ 8));
                            Img[i + 1] = (byte)(intVal * img[i + 1] / (2 ^ 8));
                            Img[i + 2] = (byte)(intVal * img[i + 2] / (2 ^ 8));
                            Img[i + 3] = (byte)(intVal * img[i + 3] / (2 ^ 8));
                        }
                        break;

                    case ("12"):

                        //遍历图中数组像素值；                           
                        for (int i = 0; i < img.Length; i += 4)
                        {
                            //origin;
                            //Img[i] = (byte)img[i];
                            //Img[i + 1] = (byte)img[i + 1];
                            //Img[i + 2] = (byte)img[i + 2];
                            //Img[i + 3] = (byte)img[i + 3];

                            //将255转化为Int32;
                            //int val = 255;
                            int intVal = Convert.ToInt32(255);

                            Img[i] = (byte)(intVal * img[i] / (2 ^ 12));
                            Img[i + 1] = (byte)(intVal * img[i + 1] / (2 ^ 12));
                            Img[i + 2] = (byte)(intVal * img[i + 2] / (2 ^ 12));
                            Img[i + 3] = (byte)(intVal * img[i + 3] / (2 ^ 12));
                        }
                        break;

                    case ("14"):
                        //遍历图中数组像素值；                           
                        for (int i = 0; i < img.Length; i += 4)
                        {
                            //origin;
                            //Img[i] = (byte)(img[i] >> 6);
                            //Img[i + 1] = (byte)(img[i + 1] >> 6);
                            //Img[i + 2] = (byte)(img[i + 2] >> 6);
                            //Img[i + 3] = (byte)(img[i + 3] >> 6);

                            //将255转化为Int32;
                            //int val = 255;
                            int intVal = Convert.ToInt32(255);

                            Img[i] = (byte)(intVal * img[i] / (2 ^ 14));
                            Img[i + 1] = (byte)(intVal * img[i + 1] / (2 ^ 14));
                            Img[i + 2] = (byte)(intVal * img[i + 2] / (2 ^ 14));
                            Img[i + 3] = (byte)(intVal * img[i + 3] / (2 ^ 14));
                        }
                        break;
                }
            }

            catch (System.Exception ex)
            {
                //label1.Text = ex.ToString();
            }
            finally
            {
                GC.Collect();   // 垃圾回收，释放无用内存空间;
            }
            return Img;
        }
/**********************************Offline-AbsoluteMode--End****************************************************************/


/**********************************Offline-RelativeMode--Start****************************************************************/
        //离线测试--相对值模式下将整型数组转换为8位图像数据(mono8,mono12,mono14)；
        public byte[] RelModeGetImgByte(int[] img, int width, int height, string Bits)
        {
            //判断是否为空;
            if (img == null)
            {
                return null;
            }

            //定义局部变量Img存放字节数组；
            byte[] Img = new byte[img.Length];

            /*************相对值模式***********************************
            * 1、先遍历查询处图像数组中所有像素值;
            * 2、找出图像数组中最大像素值、最小像素值；
            * 3、再进行缩放至0-255；
            ********************************************************/

            try
            {
                switch (Bits)
                {
                    case ("8"):
                        //设置最大值、最小值，max,min均为img[0]; 
                        int min_8 = img[0];
                        int max_8 = img[0];

                        for (int i = 0; i < img.Length; i++)
                        {
                            //遍历图像数组中的所有像素，并查找最大值；
                            if (img[i] > max_8)
                            {
                                max_8 = img[i];
                            }

                            //遍历图像数组中的所有像素，并查找最小值；
                            if (img[i] < min_8)
                            {
                                min_8 = img[i];
                            }
                        }

                        //将像素值缩放至：0-255（相对值模式）;
                        for (int i = 0; i < img.Length; i += 4)
                        {

                            Img[i] = (byte)(255 * (img[i] - min_8) / (max_8 - min_8));
                            Img[i + 1] = (byte)(255 * (img[i + 1] - min_8) / (max_8 - min_8));
                            Img[i + 2] = (byte)(255 * (img[i + 2] - min_8) / (max_8 - min_8));
                            Img[i + 3] = (byte)(255 * (img[i + 3] - min_8) / (max_8 - min_8));

                        }
                        break;

                    case ("12"):
                        //设置最大值、最小值，max,min均为img[0]; 
                        int min_12 = img[0];
                        int max_12 = img[0];

                        for (int i = 0; i < img.Length; i++)
                        {
                            //遍历图像数组中的所有像素，并查找最大值；
                            if (img[i] > max_12)
                            {
                                max_12 = img[i];
                            }

                            //遍历图像数组中的所有像素，并查找最小值；
                            if (img[i] < min_12)
                            {
                                min_12 = img[i];
                            }
                        }

                        //将像素值缩放至：0-255（相对值模式）;
                        for (int i = 0; i < img.Length; i += 4)
                        {
                            Img[i] = (byte)(255 * (img[i] - min_12) / (max_12 - min_12));
                            Img[i + 1] = (byte)(255 * (img[i + 1] - min_12) / (max_12 - min_12));
                            Img[i + 2] = (byte)(255 * (img[i + 2] - min_12) / (max_12 - min_12));
                            Img[i + 3] = (byte)(255 * (img[i + 3] - min_12) / (max_12 - min_12));
                        }
                        break;

                    case ("14"):
                        //设置最大值、最小值，max,min均为img[0]; 
                        int min_14 = img[0];
                        int max_14 = img[0];

                        for (int i = 0; i < img.Length; i++)
                        {

                            //遍历图像数组中的所有像素，并查找最大值；
                            if (img[i] > max_14)
                            {
                                max_14 = img[i];
                            }

                            //遍历图像数组中的所有像素，并查找最小值；
                            if (img[i] < min_14)
                            {
                                min_14 = img[i];
                            }
                        }

                        //将像素值缩放至：0-255（相对值模式）;
                        for (int i = 0; i < img.Length; i += 4)
                        {

                            Img[i] = (byte)(255 * (img[i] - min_14) / (max_14 - min_14));
                            Img[i + 1] = (byte)(255 * (img[i + 1] - min_14) / (max_14 - min_14));
                            Img[i + 2] = (byte)(255 * (img[i + 2] - min_14) / (max_14 - min_14));
                            Img[i + 3] = (byte)(255 * (img[i + 3] - min_14) / (max_14 - min_14));

                        }
                        break;
                }
            }

            catch (System.Exception ex)
            {
                //label1.Text = ex.ToString();
            }
            finally
            {
                GC.Collect();   // 垃圾回收，释放无用内存空间;
            }
            return Img;
        }
/**********************************Offline-RelativeMode--End****************************************************************/


/**********************************Offline-RegionMode--Start****************************************************************/
          //离线测试--相对值模式下将整型数组转换为8位图像数据(mono8,mono12,mono14)；
        public byte[] RegionModeGetImgByte(int[] img, int width, int height, string Bits)
        {
            //判断是否为空;
            if (img == null)
            {
                return null;
            }

            //定义局部变量Img存放字节数组；
            byte[] Img = new byte[img.Length];

            /*************区域模式***********************************
            * 1、先遍历查询处图像数组中所有像素值;
            * 2、将大于阈值上限的像素值设为阈值上限；
            * 3、将小于阈值下限的值设为阈值下限;
            * 4、再进行缩放至0-255；
            ********************************************************/

            try
            {
                //switch (Bits)
                //{
                //    case ("8") ("12"):
                        try
                        {
                            upperPixel_Value = Convert.ToInt32(upThresholdTextBox1.Text);
                            //判断输入像素值，若小于0，则将上限阈值upperPixel_Value直接赋值为0；
                            if (upperPixel_Value < 0)
                            {
                                upperPixel_Value = 0;
                                MessageBox.Show("阈值上限，请输入正整数！");

                            }


                            lowerPixel_Value = Convert.ToInt32(lowThresholdTextBox2.Text);
                            //判断输入像素值，若小于0，则将下限阈值直接赋值为0；
                            if (lowerPixel_Value < 0)
                            {
                                lowerPixel_Value = 0;
                                MessageBox.Show("阈值下限，请输入正整数！");
                            }

                            else if (lowerPixel_Value > upperPixel_Value)
                            {
                                MessageBox.Show("阈值下限不能大于阈值上限！请重输入合理的阈值范围！");
                            }
                        }

                        catch
                        {
                            MessageBox.Show("请输入正确数值格式！");
                            //numberInputFlag = false;
                        }


                        for (int i = 0; i < img.Length; i++)
                        {
                            //若图像中的像素值大于所设上限阈值，则将其赋值为upperPixel_Value；
                            if (img[i] > upperPixel_Value)
                            {
                                img[i] = upperPixel_Value;
                            }

                            //若图像中的像素值小于所设下限阈值，则将其赋值为lowerPixel_Value；
                            if (img[i] < lowerPixel_Value)
                            {
                                img[i] = lowerPixel_Value;
                            }


                        }

                        //区域模式。将区域上下限阈值进行缩放至0-255；
                        for (int i = 0; i < img.Length; i += 4)
                        {

                            Img[i] = (byte)(255 * (img[i] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
                            Img[i + 1] = (byte)(255 * (img[i + 1] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
                            Img[i + 2] = (byte)(255 * (img[i + 2] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
                            Img[i + 3] = (byte)(255 * (img[i + 3] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));

                        }                       
                //        break;
                //}
            }


            catch (System.Exception ex)
            {
                //label1.Text = ex.ToString();
            }
            finally
            {
                GC.Collect();   // 垃圾回收，释放无用内存空间;
            }
            return Img;
        }

        /**********************************Offline-RegionMode--End****************************************************************/



        #region //离线模式下三种图像位数，三种测试方式--综合;
        //// 将整型数组转为8位图像数据
        //public byte[] GetImgByte(int[] img, int width, int height, string Bits)
        //{
        //    if (img == null)
        //    {
        //        return null;
        //    }
        //    byte[] Img = new byte[img.Length];
        //    try
        //    {
        //        switch (Bits)
        //        {
        //            case ("8"):

        //                  /*************绝对值模式***********************************
        //                  * 1、先遍历查询处图像数组中所有像素值;
        //                  * 2、再进行缩放至0-255；(255*img[i])/(2^8,2^12,2^14);
        //                  ********************************************************/

        //                if (offlineTestMode_Flag == 0)
        //                {
        //                    //遍历图中数组像素值；                           
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {
        //                        //origin;
        //                        //Img[i] = (byte)img[i];
        //                        //Img[i + 1] = (byte)img[i + 1];
        //                        //Img[i + 2] = (byte)img[i + 2];
        //                        //Img[i + 3] = (byte)img[i + 3];

        //                        //将255转化为Int32;
        //                        //int val = 255;
        //                        int intVal = Convert.ToInt32(255);

        //                        Img[i] = (byte)(intVal * img[i] / (2 ^ 8));
        //                        Img[i + 1] = (byte)(intVal * img[i + 1] / (2 ^ 8));
        //                        Img[i + 2] = (byte)(intVal * img[i + 2] / (2 ^ 8));
        //                        Img[i + 3] = (byte)(intVal * img[i + 3] / (2 ^ 8));
        //                    }

        //                }


        //               /*************相对值模式***********************************
        //               * 1、先遍历查询处图像数组中所有像素值;
        //               * 2、找出图像数组中最大像素值、最小像素值；
        //               * 3、再进行缩放至0-255；
        //               ********************************************************/

        //                if (offlineTestMode_Flag == 1)  //相对值模式；
        //                {
        //                    //设置最大值、最小值，max,min均为img[0]; 
        //                    int min = img[0];
        //                    int max = img[0];

        //                    for (int i = 0; i < img.Length; i++)
        //                    {
        //                        //遍历图像数组中的所有像素，并查找最大值；
        //                        if (img[i] > max)
        //                        {
        //                            max = img[i];                                  
        //                        }

        //                        //遍历图像数组中的所有像素，并查找最小值；
        //                        if (img[i] < min)
        //                        {
        //                            min = img[i];                                   
        //                        }
        //                    }                       

        //                    //将像素值缩放至：0-255（相对值模式）;
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {

        //                        Img[i] = (byte)(255 * (img[i] - min) / (max - min));
        //                        Img[i + 1] = (byte)(255 * (img[i + 1] - min) / (max - min));
        //                        Img[i + 2] = (byte)(255 * (img[i + 2] - min) / (max - min));
        //                        Img[i + 3] = (byte)(255 * (img[i + 3] - min) / (max - min));

        //                    }

        //                }

        //                /*************区域模式***********************************
        //                * 1、先遍历查询处图像数组中所有像素值;
        //                * 2、将大于阈值上限的像素值设为阈值上限；
        //                * 3、将小于阈值下限的值设为阈值下限;
        //                * 4、再进行缩放至0-255；
        //                ********************************************************/

        //                if (offlineTestMode_Flag == 2)
        //                {
        //                    //利用TextBox自适应调整像素阈值；
        //                    //实现string类型到int类型的转换;                        

        //                    try
        //                    {
        //                        upperPixel_Value = Convert.ToInt32(upThresholdTextBox1.Text);
        //                        //判断输入像素值，若小于0，则将上限阈值upperPixel_Value直接赋值为0；
        //                        if (upperPixel_Value < 0)
        //                        {
        //                            upperPixel_Value = 0;
        //                            MessageBox.Show("阈值上限，请输入正整数！");

        //                        }


        //                        lowerPixel_Value = Convert.ToInt32(lowThresholdTextBox2.Text);
        //                        //判断输入像素值，若小于0，则将下限阈值直接赋值为0；
        //                        if (lowerPixel_Value < 0)
        //                        {
        //                            lowerPixel_Value = 0;
        //                            MessageBox.Show("阈值下限，请输入正整数！");
        //                        }

        //                        else if (lowerPixel_Value > upperPixel_Value)
        //                        {
        //                            MessageBox.Show("阈值下限不能大于阈值上限！请重输入合理的阈值范围！");
        //                        }

        //                    }

        //                    catch
        //                    {
        //                        MessageBox.Show("请输入正确数值格式！");
        //                        //numberInputFlag = false;
        //                    }


        //                    for (int i = 0; i < img.Length; i++)
        //                    {                                
        //                        //若图像中的像素值大于所设上限阈值，则将其赋值为upperPixel_Value；
        //                        if (img[i] > upperPixel_Value)
        //                        {
        //                            img[i] = upperPixel_Value;
        //                        }

        //                        //若图像中的像素值小于所设下限阈值，则将其赋值为lowerPixel_Value；
        //                        if (img[i] < lowerPixel_Value)
        //                        {
        //                            img[i] = lowerPixel_Value;
        //                        }


        //                    }

        //                    //区域模式。将区域上下限阈值进行缩放至0-255；
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {

        //                        Img[i] = (byte)(255 * (img[i] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                        Img[i + 1] = (byte)(255 * (img[i + 1] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                        Img[i + 2] = (byte)(255 * (img[i + 2] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                        Img[i + 3] = (byte)(255 * (img[i + 3] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));

        //                    }
        //                }


        //                //origin;
        //                //for (int i = 0; i < img.Length; i += 4)
        //                //{
        //                //    //Img[i] = (byte)img[i];
        //                //    //Img[i + 1] = (byte)img[i + 1];
        //                //    //Img[i + 2] = (byte)img[i + 2];
        //                //    //Img[i + 3] = (byte)img[i + 3];

        //                //}
        //                break;



        //            case ("12"):

        //                /*************绝对值模式***********************************
        //                  * 1、先遍历查询处图像数组中所有像素值;
        //                  * 2、再进行缩放至0-255；(255*img[i])/(2^8,2^12,2^14);
        //                  ********************************************************/

        //                if (offlineTestMode_Flag == 0)
        //                {
        //                    //遍历图中数组像素值；                           
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {
        //                        //origin;
        //                        //Img[i] = (byte)img[i];
        //                        //Img[i + 1] = (byte)img[i + 1];
        //                        //Img[i + 2] = (byte)img[i + 2];
        //                        //Img[i + 3] = (byte)img[i + 3];

        //                        //将255转化为Int32;
        //                        //int val = 255;
        //                        int intVal = Convert.ToInt32(255);

        //                        Img[i] = (byte)(intVal * img[i] / (2 ^ 12));
        //                        Img[i + 1] = (byte)(intVal * img[i + 1] / (2 ^ 12));
        //                        Img[i + 2] = (byte)(intVal * img[i + 2] / (2 ^ 12));
        //                        Img[i + 3] = (byte)(intVal * img[i + 3] / (2 ^ 12));
        //                    }

        //                }


        //                /*************相对值模式***********************************
        //                * 1、先遍历查询处图像数组中所有像素值;
        //                * 2、找出图像数组中最大像素值、最小像素值；
        //                * 3、再进行缩放至0-255；
        //                ********************************************************/

        //                if (offlineTestMode_Flag == 1)  //相对值模式；
        //                {
        //                    //设置最大值、最小值，max,min均为img[0]; 
        //                    int min = img[0];
        //                    int max = img[0];

        //                    for (int i = 0; i < img.Length; i++)
        //                    {
        //                        //遍历图像数组中的所有像素，并查找最大值；
        //                        if (img[i] > max)
        //                        {
        //                            max = img[i];
        //                        }

        //                        //遍历图像数组中的所有像素，并查找最小值；
        //                        if (img[i] < min)
        //                        {
        //                            min = img[i];
        //                        }
        //                    }

        //                    //将像素值缩放至：0-255（相对值模式）;
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {

        //                        Img[i] = (byte)(255 * (img[i] - min) / (max - min));
        //                        Img[i + 1] = (byte)(255 * (img[i + 1] - min) / (max - min));
        //                        Img[i + 2] = (byte)(255 * (img[i + 2] - min) / (max - min));
        //                        Img[i + 3] = (byte)(255 * (img[i + 3] - min) / (max - min));

        //                    }

        //                }

        //                /*************区域模式***********************************
        //                * 1、先遍历查询处图像数组中所有像素值;
        //                * 2、将大于阈值上限的像素值设为阈值上限；
        //                * 3、将小于阈值下限的值设为阈值下限;
        //                * 4、再进行缩放至0-255；
        //                ********************************************************/

        //                if (offlineTestMode_Flag == 2)
        //                {
        //                    //利用TextBox自适应调整像素阈值；
        //                    //实现string类型到int类型的转换;                        

        //                    try
        //                    {
        //                        upperPixel_Value = Convert.ToInt32(upThresholdTextBox1.Text);
        //                        //判断输入像素值，若小于0，则将上限阈值upperPixel_Value直接赋值为0；
        //                        if (upperPixel_Value < 0)
        //                        {
        //                            upperPixel_Value = 0;
        //                            MessageBox.Show("阈值上限，请输入正整数！");

        //                        }


        //                        lowerPixel_Value = Convert.ToInt32(lowThresholdTextBox2.Text);
        //                        //判断输入像素值，若小于0，则将下限阈值直接赋值为0；
        //                        if (lowerPixel_Value < 0)
        //                        {
        //                            lowerPixel_Value = 0;
        //                            MessageBox.Show("阈值下限，请输入正整数！");
        //                        }

        //                        else if (lowerPixel_Value > upperPixel_Value)
        //                        {
        //                            MessageBox.Show("阈值下限不能大于阈值上限！请重输入合理的阈值范围！");
        //                        }

        //                    }

        //                    catch
        //                    {
        //                        MessageBox.Show("请输入正确数值格式！");
        //                        //numberInputFlag = false;
        //                    }


        //                    for (int i = 0; i < img.Length; i++)
        //                    {
        //                        //若图像中的像素值大于所设上限阈值，则将其赋值为upperPixel_Value；
        //                        if (img[i] > upperPixel_Value)
        //                        {
        //                            img[i] = upperPixel_Value;
        //                        }

        //                        //若图像中的像素值小于所设下限阈值，则将其赋值为lowerPixel_Value；
        //                        if (img[i] < lowerPixel_Value)
        //                        {
        //                            img[i] = lowerPixel_Value;
        //                        }


        //                    }

        //                    //区域模式。将区域上下限阈值进行缩放至0-255；
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {

        //                        Img[i] = (byte)(255 * (img[i] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                        Img[i + 1] = (byte)(255 * (img[i + 1] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                        Img[i + 2] = (byte)(255 * (img[i + 2] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                        Img[i + 3] = (byte)(255 * (img[i + 3] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));

        //                    }
        //                }


        //                //origin;
        //                //for (int i = 0; i < img.Length; i += 4)
        //                //{
        //                //    Img[i] = (byte)(img[i] >> 4);
        //                //    Img[i + 1] = (byte)(img[i + 1] >> 4);
        //                //    Img[i + 2] = (byte)(img[i + 2] >> 4);
        //                //    Img[i + 3] = (byte)(img[i + 3] >> 4);
        //                //}
        //                break;

        //            case ("14"):

        //                /**********************************************
        //                * uiComboBox2.SelectedIndex == 0,绝对值模式；
        //                * uiComboBox2.SelectedIndex == 1,相对值模式；
        //                * uiComboBox2.SelectedIndex == 2,区域模式；
        //                * uiComboBox2.SelectedIndex == 3,热力图模式--伪彩色applyColorMap函数；
        //                ********************************************************/


        //                #region//绝对值模式；
        //                //if (uiComboBox2.SelectedIndex == 0)
        //                //{
        //                //    for (int i = 0; i < img.Length; i++)
        //                //    {
        //                //        Img[i] = (byte)(img[i] >> 6);
        //                //        Img[i + 1] = (byte)(img[i + 1] >> 6);
        //                //        Img[i + 2] = (byte)(img[i + 2] >> 6);
        //                //        Img[i + 3] = (byte)(img[i + 3] >> 6);
        //                //    }

        //                //}
        //                #endregion

        //                /*************绝对值模式***********************************
        //                * 1、先遍历查询处图像数组中所有像素值;
        //                * 2、再进行缩放至0-255；(255*img[i])/(2^8,2^12,2^14);
        //                ********************************************************/

        //                if (offlineTestMode_Flag == 0)
        //                {
        //                    //遍历图中数组像素值；                           
        //                    for (int i = 0; i < img.Length; i+=4)
        //                    {
        //                        //origin;
        //                        //Img[i] = (byte)(img[i] >> 6);
        //                        //Img[i + 1] = (byte)(img[i + 1] >> 6);
        //                        //Img[i + 2] = (byte)(img[i + 2] >> 6);
        //                        //Img[i + 3] = (byte)(img[i + 3] >> 6);

        //                        //将255转化为Int32;
        //                        //int val = 255;
        //                        int intVal = Convert.ToInt32(255);

        //                        Img[i] = (byte)(intVal * img[i]/(2^14));
        //                        Img[i + 1] = (byte)(intVal * img[i + 1]/(2^14));
        //                        Img[i + 2] = (byte)(intVal * img[i + 2]/(2^14));
        //                        Img[i + 3] = (byte)(intVal * img[i + 3]/(2^14));
        //                    }

        //                }


        //                #region////相对值模式；
        //                //if (uiComboBox2.SelectedIndex == 1)
        //                //{
        //                //    //add-max\min均设置为img[0]; 
        //                //    int min = img[0];
        //                //    int max = img[0];

        //                //    //max、min-index;                     
        //                //    int index_min = 0;
        //                //    int index_max = 0;

        //                //    for (int i = 0; i < img.Length; i++)
        //                //    {
        //                //        //origin---绝对值;
        //                //        //Img[i] = (byte)(img[i] >> 6);
        //                //        //Img[i + 1] = (byte)(img[i + 1] >> 6);
        //                //        //Img[i + 2] = (byte)(img[i + 2] >> 6);
        //                //        //Img[i + 3] = (byte)(img[i + 3] >> 6);

        //                //        //add;
        //                //        if (img[i] > max)
        //                //        {
        //                //            max = img[i];

        //                //            index_max = i + 1;
        //                //        }

        //                //        if (img[i] < min)
        //                //        {
        //                //            min = img[i];

        //                //            index_min = i + 1;

        //                //        }


        //                //    }


        //                //    #region//maxpixel\minpixel;
        //                //    //label4.Text = "最小值位置：" + index_min.ToString("f2");
        //                //    //label5.Text = "最大值位置：" + index_max.ToString("f2");

        //                //    //打印max\min;
        //                //    //label2.Text = "最大值是：" + max.ToString("f2");
        //                //    //label3.Text = "最小值是：" + min.ToString("f2");
        //                //    //min = 4400;
        //                //    #endregion

        //                //    //将像素值缩放至：0-255（相对值模式）;
        //                //    for (int i = 0; i < img.Length; i += 4)
        //                //    {

        //                //        Img[i] = (byte)(255 * (img[i] - min) / (max - min));
        //                //        Img[i + 1] = (byte)(255 * (img[i + 1] - min) / (max - min));
        //                //        Img[i + 2] = (byte)(255 * (img[i + 2] - min) / (max - min));
        //                //        Img[i + 3] = (byte)(255 * (img[i + 3] - min) / (max - min));



        //                //        #region//保存至Txt文本信息；
        //                //        //获取文件名；
        //                //        //dbf_File = ofd.FileName;

        //                //        ////////datetime格式化；
        //                //        //DateTime dt = DateTime.Now;

        //                //        //string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile


        //                //        ////打印原始像素信息，保存文本信息至指定文件夹；
        //                //        //label2.Text = "时间:" + dt.ToLocalTime().ToString() + "\n" + "图像名称：" + "\n" + dbf_File2 + "\n" +
        //                //        //                "\n" +
        //                //        //                "最大像素值: " + max.ToString("f2") + ";" + "\n" + "\n" +
        //                //        //                "最小像素值: " + min.ToString("f2") + ";" + "\n" + "\n" +
        //                //        //                "像素值: " + img[i].ToString("f2") + ";" + "\n" + "\n";

        //                //        //label1.Text = "时间:" + dt.ToLocalTime().ToString() + "\n" + "\n" + "图像名称：" + "\n" + dbf_File2 + "\n" +
        //                //        //               "\n" +
        //                //        //               "最大像素值: " + max.ToString("f2") + ";" + "\n" + "\n" +
        //                //        //               "最大像素值位置: " + index_max.ToString("f2") + ";" + "\n" + "\n" +
        //                //        //               "最小像素值: " + min.ToString("f2") + ";" + "\n" + "\n" +
        //                //        //               "最小像素值位置: " + index_min.ToString("f2") + ";" + "\n" + "\n";
        //                //        #endregion


        //                //        #region ////////保存文本信息至指定文件夹；
        //                //        //string txt = label2.Text;

        //                //        ////创建文件夹路径；
        //                //        //path = str + "\\Result\\Excel_Txt_Result";

        //                //        //if (!Directory.Exists(path))
        //                //        //{
        //                //        //    Directory.CreateDirectory(path);
        //                //        //}

        //                //        //string filename = path + "\\" + "图像信息.txt";   //文件名，可以带路径

        //                //        //FileStream fs = new FileStream(filename, FileMode.Append);
        //                //        //StreamWriter wr = null;
        //                //        //wr = new StreamWriter(fs);

        //                //        ////System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
        //                //        //wr.Write(label2.Text);
        //                //        //wr.Close();
        //                //        #endregion



        //                //        #region////保存Excel信息至指定文件夹；
        //                //        //filestream = new FileStream(path + "\\" + "图像信息.xlsx", FileMode.OpenOrCreate);


        //                //        ////创建表和sheet;
        //                //        //if (indexOfExcel_j == 1)
        //                //        //{
        //                //        //    rawpixel = new XSSFWorkbook();   //创建表对象rawpixel
        //                //        //    isheet = rawpixel.CreateSheet("Sheet1");   //在rawpixel中创建sheet1
        //                //        //                                               //创建表头
        //                //        //    IRow rowtitle = null;
        //                //        //    rowtitle = isheet.CreateRow(0); //创建index=j的行

        //                //        //    ICell cellTitle0 = null;
        //                //        //    cellTitle0 = rowtitle.CreateCell(0);  //在index=j的行中创建index=0的单元格
        //                //        //    cellTitle0.SetCellValue("时间"); //给创建的单元格赋值string

        //                //        //    ICell cellTitle1 = null;
        //                //        //    cellTitle1 = rowtitle.CreateCell(1);  //在index=j的行中创建index=0的单元格
        //                //        //    cellTitle1.SetCellValue("图像名称"); //给创建的单元格赋值string

        //                //        //    ICell cellTitle2 = null;
        //                //        //    cellTitle2 = rowtitle.CreateCell(2);  //在index=j的行中创建index=0的单元格
        //                //        //    cellTitle2.SetCellValue("最大值"); //给创建的单元格赋值string

        //                //        //    ICell cellTitle3 = null;
        //                //        //    cellTitle3 = rowtitle.CreateCell(3);  //在index=j的行中创建index=0的单元格
        //                //        //    cellTitle3.SetCellValue("最小值"); //给创建的单元格赋值string

        //                //        //    ICell cellTitle4 = null;
        //                //        //    cellTitle4 = rowtitle.CreateCell(4);  //在index=j的行中创建index=0的单元格
        //                //        //    cellTitle4.SetCellValue("像素值"); //给创建的单元格赋值string
        //                //        //}



        //                //        //////datetime格式化；
        //                //        ////DateTime dt = DateTime.Now;

        //                //        //rowWrite = isheet.CreateRow(indexOfExcel_j++); //创建index=j的行

        //                //        //ICell cell0 = null;
        //                //        //cell0 = rowWrite.CreateCell(0);  //在index=j的行中创建index=0的单元格
        //                //        //cell0.SetCellValue(dt.ToLocalTime().ToString()); //给创建的单元格赋值string

        //                //        //ICell cell1 = null;
        //                //        //cell1 = rowWrite.CreateCell(1);  //在index=j的行中创建index=0的单元格
        //                //        //cell1.SetCellValue(dbf_File2); //给创建的单元格赋值string

        //                //        //ICell cell2 = null;
        //                //        //cell2 = rowWrite.CreateCell(2);  //在index=j的行中创建index=0的单元格
        //                //        //cell2.SetCellValue("max:" + max.ToString("f2")); //给创建的单元格赋值string


        //                //        //ICell cell3 = null;
        //                //        //cell3 = rowWrite.CreateCell(3);  //在index=j的行中创建index=0的单元格
        //                //        //cell3.SetCellValue("min:" + min.ToString("f2")); //给创建的单元格赋值string

        //                //        //ICell cell4 = null;
        //                //        //cell4 = rowWrite.CreateCell(4);  //在index=j的行中创建index=0的单元格

        //                //        ////cell4.SetCellValue("pixel:" + pixel.ToString("f2")); //给创建的单元格赋值string

        //                //        //cell4.SetCellValue("pixel:" + img[i].ToString("f2")); //给创建的单元格赋值string

        //                //        ////通过流filestream将表rawpixel写入文件;
        //                //        //rawpixel.Write(filestream);
        //                //        #endregion


        //                //    }                       

        //                //}
        //                #endregion


        //               /*************相对值模式***********************************
        //               * 1、先遍历查询处图像数组中所有像素值;
        //               * 2、找出图像数组中最大像素值、最小像素值；
        //               * 3、再进行缩放至0-255；
        //               ********************************************************/

        //                if (offlineTestMode_Flag == 1)  //相对值模式；
        //                {
        //                    //设置最大值、最小值，max,min均为img[0]; 
        //                    int min = img[0];
        //                    int max = img[0];

        //                    //max、min-index;                     
        //                    //int index_min = 0;
        //                    //int index_max = 0;

        //                    for (int i = 0; i < img.Length; i++)
        //                    {

        //                        //遍历图像数组中的所有像素，并查找最大值；
        //                        if (img[i] > max)
        //                        {
        //                            max = img[i];

        //                            //index_max = i + 1;
        //                        }

        //                        //遍历图像数组中的所有像素，并查找最小值；
        //                        if (img[i] < min)
        //                        {
        //                            min = img[i];

        //                            //index_min = i + 1;

        //                        }
        //                    }


        //                    #region//maxpixel\minpixel--location;
        //                    //label4.Text = "最小值位置：" + index_min.ToString("f2");
        //                    //label5.Text = "最大值位置：" + index_max.ToString("f2");

        //                    //打印max\min;
        //                    //label2.Text = "最大值是：" + max.ToString("f2");
        //                    //label3.Text = "最小值是：" + min.ToString("f2");
        //                    //min = 4400;
        //                    #endregion


        //                    //将像素值缩放至：0-255（相对值模式）;
        //                    for (int i = 0; i < img.Length; i += 4)
        //                    {

        //                        Img[i] = (byte)(255 * (img[i] - min) / (max - min));
        //                        Img[i + 1] = (byte)(255 * (img[i + 1] - min) / (max - min));
        //                        Img[i + 2] = (byte)(255 * (img[i + 2] - min) / (max - min));
        //                        Img[i + 3] = (byte)(255 * (img[i + 3] - min) / (max - min));                       

        //                    }

        //                }


        //                /*************区域模式***********************************
        //                * 1、先遍历查询处图像数组中所有像素值;
        //                * 2、将大于阈值上限的像素值设为阈值上限；
        //                * 3、将小于阈值下限的值设为阈值下限;
        //                * 4、再进行缩放至0-255；
        //                ********************************************************/

        //                if (offlineTestMode_Flag == 2)
        //                {
        //                    //利用TextBox自适应调整像素阈值；
        //                    //实现string类型到int类型的转换;                        

        //                    try
        //                    {
        //                        upperPixel_Value = Convert.ToInt32(upThresholdTextBox1.Text);
        //                        //判断输入像素值，若小于0，则将上限阈值upperPixel_Value直接赋值为0；
        //                        if (upperPixel_Value < 0)
        //                        {
        //                            upperPixel_Value = 0;
        //                            MessageBox.Show("阈值上限，请输入正整数！");

        //                        }


        //                        lowerPixel_Value = Convert.ToInt32(lowThresholdTextBox2.Text);
        //                        //判断输入像素值，若小于0，则将下限阈值直接赋值为0；
        //                        if (lowerPixel_Value < 0)
        //                        {
        //                            lowerPixel_Value = 0;
        //                            MessageBox.Show("阈值下限，请输入正整数！");
        //                        }

        //                        else if(lowerPixel_Value> upperPixel_Value)
        //                        {
        //                            MessageBox.Show("阈值下限不能大于阈值上限！请重输入合理的阈值范围！");
        //                        }

        //                    }

        //                    catch
        //                    {
        //                        MessageBox.Show("请输入正确数值格式！");
        //                        //numberInputFlag = false;
        //                    }


        //                    for (int i = 0; i < img.Length; i++)
        //                        {
        //                            //origin---绝对值;
        //                            //Img[i] = (byte)(img[i] >> 6);
        //                            //Img[i + 1] = (byte)(img[i + 1] >> 6);
        //                            //Img[i + 2] = (byte)(img[i + 2] >> 6);
        //                            //Img[i + 3] = (byte)(img[i + 3] >> 6);

        //                            //若图像中的像素值大于所设上限阈值，则将其赋值为upperPixel_Value；
        //                            if (img[i] > upperPixel_Value)
        //                            {
        //                                img[i] = upperPixel_Value;
        //                            }

        //                            //若图像中的像素值小于所设下限阈值，则将其赋值为lowerPixel_Value；
        //                            if (img[i] < lowerPixel_Value)
        //                            {
        //                                img[i] = lowerPixel_Value;
        //                            }


        //                        }

        //                        //区域模式。将区域上下限阈值进行缩放至0-255；
        //                        for (int i = 0; i < img.Length; i += 4)
        //                        {

        //                            Img[i] = (byte)(255 * (img[i] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                            Img[i + 1] = (byte)(255 * (img[i + 1] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                            Img[i + 2] = (byte)(255 * (img[i + 2] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));
        //                            Img[i + 3] = (byte)(255 * (img[i + 3] - lowerPixel_Value) / (upperPixel_Value - lowerPixel_Value));

        //                            //origin;
        //                            //Img[i] = (byte)(img[i] >> 6);
        //                            //Img[i + 1] = (byte)(img[i + 1] >> 6);
        //                            //Img[i + 2] = (byte)(img[i + 2] >> 6);
        //                            //Img[i + 3] = (byte)(img[i + 3] >> 6);

        //                        }



        //                }


        //                //热力图模式；
        //                if (offlineTestMode_Flag == 3)
        //                {

        //                    //Image<Bgr, Byte> match_img = convert_img.ToImage<Bgr, Byte>();    //Mat 2 Image;


        //                    //Image<Gray, byte> imgGray = new Image<Gray, byte>(bt.Size);
        //                    //CvInvoke.CvtColor(bt, imgGray, ColorConversion.Bgr2Gray);
        //                    //AppUtils.AttachImageItem(this.WpDemo1Zm, imgGray, "灰度化->");

        //                    //Image<Bgr, byte> imgColorAutumn = new Image<Bgr, byte>(bt.Size);
        //                    //CvInvoke.ApplyColorMap(imgGray, imgColorAutumn, Emgu.CV.CvEnum.ColorMapType.Autumn);
        //                    //AppUtils.AttachImageItem(this.WpDemo1Zm, imgColorAutumn, "灰度化->Autumn颜色映射");
        //                }


        //                #region //冒泡排序(**如何快排?)；
        //                //for (int i = 0; i < img.Length - 1; i++)
        //                //{
        //                //    for (int j = 0; j < img.Length - 1 - i; j++)
        //                //    {
        //                //        if (img[j] > img[j + 1])
        //                //        {
        //                //            int temp = img[j];
        //                //            img[j] = img[j + 1];
        //                //            img[j + 1] = temp;
        //                //        }
        //                //    }
        //                //}

        //                //for (int i = 0; i < img.Length; i++)
        //                //{
        //                //    //Console.WriteLine(img[i].ToString());

        //                //}
        //                #endregion


        //                break;
        //        }
        //    }


        //    catch (System.Exception ex)
        //    {
        //        //label1.Text = ex.ToString();
        //    }
        //    finally
        //    {
        //        GC.Collect();   // 垃圾回收，释放无用内存空间;
        //    }
        //    return Img;
        //}
        #endregion


       
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
        private void SaveImg_Click(object sender, EventArgs e)
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
            MessageBox.Show("Save Image Success!"); //保存完成后，显示提示信息；

            //CvInvoke.Imwrite(path + "\\" + dbf_File2 + "Raw2Bmp.bmp", bt); //保存结果图像；
            //CvInvoke.WaitKey(0); //暂停按键等待;
        }

        //imgFormatUiComboBox1.SelectedIndex不同索引对应不同的图像格式；
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(SelectedIndex);
            //label1.Text = uiComboBox1.SelectedIndex.ToString();         

            if (imgFormatUiComboBox1.SelectedIndex == 0)
            {
                ofd.Title = "请选择文件"; 
                ofd.Filter = "RAW文件(*.raw)|*.raw|所有文件(*.*)|*.*";

                //打开数据位数选择(mono8,mono12,mono14)；
                imgBitFormaLabel1.Visible = true;
                chooseBitFormatUiComboBox1.Visible = true;
            }

            else if (imgFormatUiComboBox1.SelectedIndex == 1)
            {
                ofd.Title = "请选择文件";
                ofd.Filter = "Jpg文件(*.jpg)|*.Jpg|所有文件(*.*)|*.*";

                //关闭数据位数选择(mono8,mono12,mono14)；
                imgBitFormaLabel1.Visible = false;
                chooseBitFormatUiComboBox1.Visible = false;
            }

            else if (imgFormatUiComboBox1.SelectedIndex == 2)
            {
                ofd.Title = "请选择文件";
                ofd.Filter = "Png文件(*.png)|*.png|所有文件(*.*)|*.*";

                //关闭数据位数选择(mono8,mono12,mono14)；
                imgBitFormaLabel1.Visible = false;
                chooseBitFormatUiComboBox1.Visible = false;
            }

            else if (imgFormatUiComboBox1.SelectedIndex == 3)
            {
                ofd.Title = "请选择文件";
                ofd.Filter = "Tif文件(*.tif)|*.Tif|所有文件(*.*)|*.*";

                //关闭数据位数选择(mono8,mono12,mono14)；
                imgBitFormaLabel1.Visible = false;
                chooseBitFormatUiComboBox1.Visible = false;
            }

            else if (imgFormatUiComboBox1.SelectedIndex == 4)
            {
                ofd.Title = "请选择文件";
                ofd.Filter = "Bmp文件(*.bmg)|*.Bmg|所有文件(*.*)|*.*";

                //关闭数据位数选择(mono8,mono12,mono14)；
                imgBitFormaLabel1.Visible = false;
                chooseBitFormatUiComboBox1.Visible = false;
            }

        }

        //uiComboBox2.SelectedIndex不同索引对应不同的测试模式选择；
        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = uiComboBox2.SelectedIndex.ToString();
            //label1.Text = uiComboBox2.SelectedIndex.ToString() + AbsRelFlag.ToString(); //均为false???

            /*********************************************
            * uiComboBox2.SelectedIndex=0--绝对值模式;
            * uiComboBox2.SelectedIndex=1--相对值模式;
            * uiComboBox2.SelectedIndex=2--区域模式
            * uiComboBox2.SelectedIndex=3--热力图模式
            *********************************************/

            //testModeUiComboBox2.SelectedIndex选择索引值赋值给offlineTestMode_Flag，
            //用于判断三种离线测试模式（0-绝对值模式；1-相对值模式；2-区域模式）；
            offlineTestMode_Flag = testModeUiComboBox2.SelectedIndex;
          
/********************************************离线测试---绝对值模式************************************************************/
            //绝对值模式，其区域模式上下限均设置及热力图设置均为false;
            if (offlineTestMode_Flag == 0 )
            {
                //regionMode--close;
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                heatMapLabel1.Visible = false;
                heatmapUiComboTreeView1.Visible = false;


                ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                //GetImgIntProcess();

                ////调用函数将Raw(8,12,14)进行绝对值模式处理;
                ////将输入图像Raw转换为的图像数组转换为字节;
                AbsModeGetImgByteProcess();


                ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                //GetImgRGBProcess();

                ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                //GetBmpProcess();

            }

/********************************************离线测试---相对值模式************************************************************/
            //相对值模式，其区域模式上下限均设置及热力图设置均为false;
            if (offlineTestMode_Flag == 1)
            {
                //regionMode--close;v
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                heatMapLabel1.Visible = false;
                heatmapUiComboTreeView1.Visible = false;

                ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                //GetImgIntProcess();

                ////调用函数将Raw(8,12,14)进行相对值模式处理;
                ////将输入图像Raw转换为的图像数组转换为字节;
                RelModeGetImgByteProcess();


                ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                //GetImgRGBProcess();

                ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                //GetBmpProcess();

            }


/********************************************离线测试---区域模式**************************************************************/
            //区域模式，其上下阈值设置均打开，热力图模式设置关闭；
            else if (offlineTestMode_Flag == 2)
            {
                //regionMode--open;
                upThresholdTextBox1.Visible= true;
                lowThresholdTextBox2.Visible = true;             
                upperThresholdLabel3.Visible = true;
                lowerThresholdLabel4.Visible = true;

                //heatMap--close;
                heatMapLabel1.Visible = false;
                heatmapUiComboTreeView1.Visible = false;

                //////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                //GetImgIntProcess();

                //////调用函数将Raw(8,12,14)进行区域模式处理;
                //////将输入图像Raw转换为的图像数组转换为字节;            
                RegionModeGetImgByteProcess();

                //////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                //GetImgRGBProcess();

                //////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                //GetBmpProcess();
            }

            ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
            GetImgIntProcess();

            ////调用函数将Raw(8,12,14)进行区域模式处理;
            ////将输入图像Raw转换为的图像数组转换为字节;            
            //RegionModeGetImgByteProcess();

            ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
            GetImgRGBProcess();

            ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
            GetBmpProcess();


        }


        /*************显示模式选择******************************/
        //uiComboBox2.SelectedIndex不同索引对应不同的显示模式选择；
        private void uiComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            //将uiComboBox3.SelectedIndex选择索引值赋值给offlineShowMode_Flag，用于判断两种离线显示模式（0-灰度图模式；1-热力图模式）；           
            offlineShowMode_Flag = showModeUiComboBox3.SelectedIndex;

            //显示模式（0--灰度图模式；1--热力图模式）；
            //灰度图模式;其区域模式上下限均设置及热力图设置均为false;
            if (offlineShowMode_Flag == 0)
            {
                //regionMode--close;
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                heatMapLabel1.Visible = false;
                heatmapUiComboTreeView1.Visible = false;
            }

            //热力图模式;其区域模式上下限均设置设置均为false，热力图模式设置为true;
            else if (offlineShowMode_Flag == 1)
            {
                //regionMode--close;
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--open;
                heatMapLabel1.Visible = true;
                heatmapUiComboTreeView1.Visible = true;
            }


            ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;   
            //GetImgIntProcess();

            ////调用函数将Raw(8,12,14)进行绝对值模式处理;
            ////将输入图像Raw转换为的图像数组转换为字节;
            //AbsModeGetImgByteProcess();

            ////调用函数将Raw(8,12,14)进行相对值模式处理;
            ////将输入图像Raw转换为的图像数组转换为字节;
            //RelModeGetImgByteProcess();

            ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
            //GetImgRGBProcess();

            ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
            //GetBmpProcess();

        }


        //选择不同的图像位数；
        private void chooseFormatUiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //通过chooseFormatUiComboBox1索引选择不同的图像位数：8,12,14；
            //if(chooseBitFormatUiComboBox1.SelectedIndex == 0)
            //{
            //    Bits = "8";
            //}

            switch (chooseBitFormatUiComboBox1.SelectedIndex)
            {
                case 0: Bits = "8";             
                    break;
                case 1: Bits = "12";
                    break;
                default: Bits = "14";
                    break;

            }
            
        }



        #region//窗体移动鼠标显示图像灰度值和图像坐标;
        //private void HSmartWindow_HMouseMove(object sender, HMouseEventArgs e)
        //{
        //    HTuple Row = (int)e.Y;
        //    HTuple Column = (int)e.X;
        //    HOperatorSet.GetImageSize(Image, out HTuple W, out HTuple H);
        //    if ((Row >= 0) && (Row < H) && (Column >= 0) && (Column < W))
        //    {
        //        HOperatorSet.GetGrayval(Image, Row, Column, out HTuple GrayValue);
        //        LB_Gray_Value.Text（根据实际控件修改） = $"Row:{Row.D.ToString("0")} Column:{Column.D.ToString("0")} Val:{GrayValue.D.ToString("0")}";
        //    }
        //}
        #endregion


        //点击pictureBox1获取坐标;
        private void pictureBox1_Click(object sender, EventArgs e)
        {          

            ////点击获取picturebox内的X，Y坐标--work;
            int x = Control.MousePosition.X;
            int y = Control.MousePosition.Y;


            //Color color = bt.GetPixel(x, y);

            //pixelValueLabel1.Text = "X坐标："+ x.ToString() + ";" + "\n" + "Y坐标：" + y.ToString() + ";" + "\n" +"像素值："+color.ToString();           

            //work;
            //pixelValueLabel1.Text = "X坐标：" + x.ToString() + ";" + "\n" + "Y坐标：" + y.ToString() + ";";

            //pixelValueLabel1.Text = "X坐标：" + (MousePosition.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (MousePosition.Y - this.Location.Y) +"\n" + "像素值：" + color.ToString();
        }

        //获取坐标;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            //点击获取picturebox内的X，Y坐标;
            //int x = Control.MousePosition.X;
            //int y = Control.MousePosition.Y;


            #region//blog-origin
            //HTuple Row = (int)e.Y;
            //HTuple Column = (int)e.X;
            //HOperatorSet.GetImageSize(Image, out HTuple W, out HTuple H);

            //if ((Row >= 0) && (Row < H) && (Column >= 0) && (Column < W))
            //{
            //    HOperatorSet.GetGrayval(Image, Row, Column, out HTuple GrayValue);
            //    pixelValueLabel1.Text = $"Row:{Row.D.ToString("0")} Column:{Column.D.ToString("0")} Val:{GrayValue.D.ToString("0")}";
            //}
            #endregion

            //绝对值模式或相对值模式;
            if (offlineTestMode_Flag == 0 )
            {
                
                //int x = Control.MousePosition.X;
                //int y = Control.MousePosition.Y;

                if ((e.X >= 0) && (e.Y >= 0))
                {
                    Color color = bt.GetPixel(e.X, e.Y);
                    pixelValueLabel1.Text = "X坐标：" + e.X.ToString() + ";" + "\n" + "Y坐标：" + e.Y.ToString() + ";" + "\n" + "像素值：" + "\n" + color.ToString();


                    //get the pixel from the original image;
                    Color originalColor = bt.GetPixel(e.X, e.Y);

                    //Color originalColor = original.GetPixel(i, j);
                    //create the grayscale version of the pixel;
                    //grayScale--showPixelValue; 
                    //i,j为坐标;.3 , .59, .11 自己可以调整。grayScale 是灰度值;
                    //int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59)+ (originalColor.B * .11));
                    int grayScale = (int)(originalColor.R);


                    pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + ";" + "\n" + "像素值：" + grayScale.ToString();



                }

                //Color color = bt.GetPixel(e.X, e.Y);

                //    pixelValueLabel1.Text = "X坐标：" + x.ToString() + ";" + "\n" + "Y坐标：" + y.ToString() + ";" + "\n" + "像素值：" + color.ToString();

            }


            //相对值模式或区域模式;
            if (offlineTestMode_Flag == 1 || offlineTestMode_Flag == 2)
            {
                //像素坐标应在pictureBox1范围内;
                if ((e.X >= 0) && (e.X < Width) && (e.Y >= 0) && (e.Y < Height))
                {
                   
                    ////get the pixel from the original image
                    Color originalColor = bt.GetPixel(e.X, e.Y);

                    ////create the grayscale version of the pixel
                    //int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                    int grayScale = (int)(originalColor.R);


                    //Color color = bt.GetPixel(e.X, e.Y);
                    //pixelValueLabel1.Text = "X坐标：" + e.X.ToString() + ";" + "\n" + "Y坐标：" + e.Y.ToString() + ";" + "\n" + "像素值：" + "\n" + color.ToString();

                    pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + ";" + "\n" + "像素值：" + grayScale.ToString();

                    //pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + "\n" + "像素值：" + "\n" + color.ToString();

                }

                //pixelValueLabel1.Text = "X坐标：" + e.X.ToString() + ";" + "\n" + "Y坐标：" + e.Y.ToString() + ";";
                //pixelValueLabel1.Text = "X坐标：" + e.X.ToString() + ";" + "\n" + "Y坐标：" + e.Y.ToString() + ";";
            }



            //work;
            //pixelValueLabel1.Text = "X坐标：" + (MousePosition.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (MousePosition.Y - this.Location.Y) + ";";

            //pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + ";";
        }
    }

}









        
    
