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
    public partial class SingleImageProcessMode : UIPage    //继承UIPage;
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


            //图像格式选择--将五种图像类型写到集合infoList_ChooseImgFormat中;
            IList<Info> infoList_ChooseImgFormat = new List<Info>();

            infoList_ChooseImgFormat.Add(new Info() { Name = "Raw" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Jpg" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Png" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Tif" });
            infoList_ChooseImgFormat.Add(new Info() { Name = "Bmp" });


            //使用集合infoList_ChooseImgFormat添加离线测试模式下5种图像格式至imgFormatUiComboBox1中；
            imgFormatUiComboBox1.DisplayMember = "Name";
            imgFormatUiComboBox1.DataSource = infoList_ChooseImgFormat;


            /********************当选择Raw格式时，可选8,12,14三种图像位数***********************************************************************/
            //图像位数选择--将三种Raw图像位数类型写到集合infoList_ChooseImgBits中;
            IList<Info> infoList_ChooseImgBits = new List<Info>();

            infoList_ChooseImgBits.Add(new Info() { Name = "8" });
            infoList_ChooseImgBits.Add(new Info() { Name = "12" });
            infoList_ChooseImgBits.Add(new Info() { Name = "14" });


            //使用chooseBitFormatUiComboBox1添加离线测试模式下3种图像位数至chooseBitFormatUiComboBox1；
            chooseBitFormatUiComboBox1.DisplayMember = "Name";
            chooseBitFormatUiComboBox1.DataSource = infoList_ChooseImgBits;


            //详情见FCombobox--UIComboDataGridView;添加三列数据;
            //dt.Columns.Add("Column1", typeof(string));
            //dt.Columns.Add("Column2", typeof(string));
            //dt.Columns.Add("Column3", typeof(string));


/**************测试模式设置**********************************************************************************************************
              * 1、绝对值模式；
              * 2、相对值模式;
              * 3、区域模式;
******************************************************************************************************************************/
                  
            //离线测试模式选择--将三种测试模式写到集合infoList_ChooseTestMode中;
            IList<Info> infoList_ChooseTestMode = new List<Info>();

            infoList_ChooseTestMode.Add(new Info() { Name = "绝对值模式" });
            infoList_ChooseTestMode.Add(new Info() { Name = "相对值模式" });
            infoList_ChooseTestMode.Add(new Info() { Name = "区域模式" });
            //infoList1.Add(new Info() { Name = "热力图模式" });


            //使用集合infoList_ChooseTestMode添加离线测试模式下三种测试模式至testModeUiComboBox2中；           
            testModeUiComboBox2.DisplayMember = "Name";
            testModeUiComboBox2.DataSource = infoList_ChooseTestMode;


/***************显示模式设置：灰度图、热力图****************************************************************************************/

            //离线测试显示模式下将两种显示模式写到集合infoList2_ChooseShowMode中;
            IList<Info> infoList2_ChooseShowMode = new List<Info>();
            infoList2_ChooseShowMode.Add(new Info() { Name = "灰度图模式" });
            infoList2_ChooseShowMode.Add(new Info() { Name = "热力图模式" });


            //使用集合infoList2_ChooseShowMode添加离线测试模式下2种显示模式至showModeUiComboBox3中；
            showModeUiComboBox3.DisplayMember = "Name";
            showModeUiComboBox3.DataSource = infoList2_ChooseShowMode;



/***************热力图类型设置****************************************************************************************/

            //离线测试显示模式【热力图模式】下将21种热力图类型写到集合infoList3_ChooseHeatMapType中;
            IList<Info> infoList3_ChooseHeatMapType = new List<Info>();
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Autumn" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Bone" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Jet" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Winter" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Rainbow" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Ocean" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Summer" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Spring" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Cool" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Hsv" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Pink" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Hot" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Parula" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Magma" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Inferno" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Plasma" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Viridis" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Cividis" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Twilight" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "TwilightShifted" });
            infoList3_ChooseHeatMapType.Add(new Info() { Name = "Turbo" });

            //使用集合infoList3_ChooseHeatMapType添加离线测试模式下21种热力图类型至heatmapTypeUiComboBox1中；
            heatmapTypeUiComboBox1.DisplayMember = "Name";
            heatmapTypeUiComboBox1.DataSource = infoList3_ChooseHeatMapType;
        }


        public byte[] ImgData = null;
        public int[] ImgInt = null;
        public byte[] ImgByte = null;
        public byte[,] ImgRGB = null;
        public Bitmap Bmp = null;

        public int Width = 640;
        public int Height = 512;

        //Bits = "8\12\14";
        //public string Bits = "14";    //default--origin;

        //定义全局变量--Bits,通过chooseFormatUiComboBox1_SelectedIndexChanged索引选取不同的图像位数（0-8；1-12,2-14）;
        public string Bits;

        //定义全局变量--offlineTestMode_Flag，通过uiComboBox2_SelectedIndexChanged索引选取不同的离线测试模式(0--绝对值模式；1--相对值模式；2--区域模式);
        public int offlineTestMode_Flag;

        //定义全局变量--offlineShowMode_Flag，通过uiComboBox3_SelectedIndexChanged索引选取不同的显示模式(0--灰度图模式；1--热力图模式);
        public int offlineShowMode_Flag;

        //定义全局变量--offlineHeatMapType_Flag,通过heatmapTypeUiComboBox1_SelectedIndexChanged索引选取不同的热力图类型（0-20：Autumn;Bone;Jet....TwilightShifted;）
        public int offlineHeatMapType_Flag;

        //定义全局变量--默认文件路径（defaultfilepath）；
        String defaultfilepath;

        //定义全局变量-路径（path）; 文件（dbf_File）;
        string path = string.Empty;

        string dbf_File = string.Empty;

        //export-excel;
        private int indexOfExcel_j = 1;
        FileStream filestream = null;

        XSSFWorkbook rawpixel = null;
        ISheet isheet = null;
        IRow rowWrite = null;

        //定义全局变量BmpToImg;--2022-0915;
        Image<Bgr, Byte> BmpToImg;

        //定义全局变量imgGray;--2022-0919;
        Image<Gray, byte> imgGray;

        //定义全局变量pictureState,判断图像是否为空；
        public bool pictureState = true;

/************************定义全局变量--热力图类型*************************************************************/
//定义全局变量热力图类型1--imgColorAutumn;
        Image<Bgr, byte> imgColorAutumn;

        //定义全局变量热力图类型2--imgColorBone;
        Image<Bgr, byte> imgColorBone;

        //定义全局变量热力图类型3--imgColorJet;
        Image<Bgr, byte> imgColorJet;

        //定义全局变量热力图类型4--imgColorWinter;
        Image<Bgr, byte> imgColorWinter;

        //定义全局变量热力图类型5--imgColorRainbow;
        Image<Bgr, byte> imgColorRainbow;

        //定义全局变量热力图类型6--imgColorOcean;
        Image<Bgr, byte> imgColorOcean;

        //定义全局变量热力图类型7--imgColorSummer;
        Image<Bgr, byte> imgColorSummer;

        //定义全局变量热力图类型8--imgColorSpring;
        Image<Bgr, byte> imgColorSpring;

        //定义全局变量热力图类型9--imgColorCool;
        Image<Bgr, byte> imgColorCool;

        //定义全局变量热力图类型10--imgColorHsv;
        Image<Bgr, byte> imgColorHsv;

        //定义全局变量热力图类型11--imgColorPink;
        Image<Bgr, byte> imgColorPink;

        //定义全局变量热力图类型12--imgColorHot;
        Image<Bgr, byte> imgColorHot;

        //定义全局变量热力图类型13--imgColorParula;
        Image<Bgr, byte> imgColorParula;

        //定义全局变量热力图类型14--imgColorMagma;
        Image<Bgr, byte> imgColorMagma;

        //定义全局变量热力图类型15--imgColorInferno;
        Image<Bgr, byte> imgColorInferno;

        //定义全局变量热力图类型16--imgColorPlasma;
        Image<Bgr, byte> imgColorPlasma;

        //定义全局变量热力图类型17--imgColorViridis;
        Image<Bgr, byte> imgColorViridis;

        //定义全局变量热力图类型18--imgColorCividis;
        Image<Bgr, byte> imgColorCividis;

        //定义全局变量热力图类型19--imgColorTwilight;
        Image<Bgr, byte> imgColorTwilight;

        //定义全局变量热力图类型20--imgColorTwilightShifted;
        Image<Bgr, byte> imgColorTwilightShifted;

        //定义全局变量热力图类型21--imgColorTurbo;
        Image<Bgr, byte> imgColorTurbo;


        //定义全局变量-str,获取当前程序运行路径(.exe)；
        string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        //add;
        //DataTable dt = new DataTable();

        //时间设置；
        //DateTime dt = DateTime.Now;

        public class Info
        {
           
            public string Name { get; set; }

            public override string ToString()
            {                
                return  "Name: " + Name;
            }
        }
            

        //线程；
        //Thread thread1;

        //定义对话框全局变量--ofd；
        OpenFileDialog ofd = new OpenFileDialog();

        //Time_Test;
        //System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();

        //定义全局变量bt大小；
        Bitmap bt = new Bitmap(640, 512);
    

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

        //使用线程thread1，将函数ImgData()封装；
        public void ImgprocessAccelerate()
        {

            #region //测试软件运行时间;
            //Time_Test;
            //st.Reset();
            //st.Start();
            #endregion


            #region//var 变量；
            //var  ImgData = File.ReadAllBytes(ofd.FileName);
            //var  ImgInt = GetImgInt(ImgData, Width, Height, Bits);
            //var  ImgByte = GetImgByte(ImgInt, Width, Height, Bits);
            //var  ImgRGB = GetImgRGB(ImgByte, Width, Height);
            //var Bmp = GetBmp(ImgRGB, Width, Height);
            #endregion

            //获取（打开）图像绝对路径（包括图像名称）;
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
              
                //add1-2022-0914;
                //System.Drawing.Image imgSrc = System.Drawing.Image.FromHbitmap(Bmp.GetHbitmap());           

                //显示模式--灰度图；
                if(offlineShowMode_Flag==0)
                {
                    //Thread with Invoke;事件委托；
                    //显示图像--work;（BeginInvoke,异步,也可）；Invoke（同步）;
                    Invoke(new EventHandler(delegate { pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height); }));
                    Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    //MessageBox.Show("Show Gray img!");
                    ////Bmp.Dispose();
                }

                //显示模式--热力图；
                //(选择不同的热力图类型在进行判断，保存不同的格式类型);
                else if (offlineShowMode_Flag == 1)
                {
                    //Bmp转换为Image--work;
                    //Image imgSrc = Image.FromHbitmap(Bmp.GetHbitmap());

                    //Bmp-->image-->Mat; work-2022-0915；              
                    BmpToImg = BitmapExtension.ToImage<Bgr, byte>(Bmp);
                    Mat ImgToMat = BmpToImg.Mat;

                    //Image<Gray, byte> imgSrc = new Image<Gray, byte>(imgSrc.Size);

                    //灰度图;--work;
                    //Image<Gray, byte> imgGray = new Image<Gray, byte>(BmpToImg.Size);
                    imgGray = new Image<Gray, byte>(BmpToImg.Size);

                    //将Mat类型图像ImgToMat转换为imgGray;             
                    CvInvoke.CvtColor(ImgToMat, imgGray, ColorConversion.Bgr2Gray);


/***********************************************热力图类型选择--start***********************************************/
                    //热力图类型1--Autumn；
                    if (offlineHeatMapType_Flag == 0)
                    {
                        //Autumn颜色映射;--work;
                        imgColorAutumn = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorAutumn, Emgu.CV.CvEnum.ColorMapType.Autumn);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorAutumn); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型2--Bone；
                    else if (offlineHeatMapType_Flag == 1)
                    {
                        //Bone颜色映射;--work;                     
                        imgColorBone = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorBone, Emgu.CV.CvEnum.ColorMapType.Bone);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorBone); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型3--Jet；
                    else if (offlineHeatMapType_Flag == 2)
                    {
                        //Jet颜色映射;--work;                        
                        imgColorJet = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorJet, Emgu.CV.CvEnum.ColorMapType.Jet);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorJet); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型4--Winter；
                    else if (offlineHeatMapType_Flag == 3)
                    {
                        //Winter颜色映射;--work;                    
                        imgColorWinter = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorWinter, Emgu.CV.CvEnum.ColorMapType.Winter);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorWinter); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型5--Rainbow；
                    else if (offlineHeatMapType_Flag == 4)
                    {
                        //Rainbow颜色映射;--work;                       
                        imgColorRainbow = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorRainbow, Emgu.CV.CvEnum.ColorMapType.Rainbow);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorRainbow); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }


                    //热力图类型6--Ocean；
                    else if (offlineHeatMapType_Flag == 5)
                    {
                        //Ocean颜色映射;--work;                      
                        imgColorOcean = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorOcean, Emgu.CV.CvEnum.ColorMapType.Ocean);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorOcean); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型7--Summer；
                    else if (offlineHeatMapType_Flag == 6)
                    {
                        //Summer颜色映射;--work;                       
                        imgColorSummer = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorSummer, Emgu.CV.CvEnum.ColorMapType.Summer);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorSummer); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型8--Spring；
                    else if (offlineHeatMapType_Flag == 7)
                    {
                        //Spring颜色映射;--work;                      
                        imgColorSpring = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorSpring, Emgu.CV.CvEnum.ColorMapType.Spring);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorSpring); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型9--Cool；
                    else if (offlineHeatMapType_Flag == 8)
                    {
                        //Cool颜色映射;--work;                     
                        imgColorCool = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorCool, Emgu.CV.CvEnum.ColorMapType.Cool);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorCool); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型10--Hsv；
                    else if (offlineHeatMapType_Flag == 9)
                    {
                        //Hsv颜色映射;--work;                       
                        imgColorHsv = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorHsv, Emgu.CV.CvEnum.ColorMapType.Hsv);                      

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorHsv); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型11--Pink；
                    else if (offlineHeatMapType_Flag == 10)
                    {
                        //Pink颜色映射;--work;                       
                        imgColorPink = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorPink, Emgu.CV.CvEnum.ColorMapType.Pink);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorPink); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型12--Hot；
                    else if (offlineHeatMapType_Flag == 11)
                    {
                        //Hot颜色映射;--work;                        
                        imgColorHot = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorHot, Emgu.CV.CvEnum.ColorMapType.Hot);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorHot); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型13--Parula；
                    else if (offlineHeatMapType_Flag == 12)
                    {
                        //Parula颜色映射;--work;                       
                        imgColorParula = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorParula, Emgu.CV.CvEnum.ColorMapType.Parula);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorParula); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型14--Magma；
                    else if (offlineHeatMapType_Flag == 13)
                    {
                        //Magma颜色映射;--work;                        
                        imgColorMagma = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorMagma, Emgu.CV.CvEnum.ColorMapType.Magma);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorMagma); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型15--Inferno；
                    else if (offlineHeatMapType_Flag == 14)
                    {
                        //Inferno颜色映射;--work;                        
                        imgColorInferno = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorInferno, Emgu.CV.CvEnum.ColorMapType.Inferno);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorInferno); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型16--Plasma；
                    else if (offlineHeatMapType_Flag == 15)
                    {
                        //Plasma颜色映射;--work;                        
                        imgColorPlasma = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorPlasma, Emgu.CV.CvEnum.ColorMapType.Plasma);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorPlasma); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型17--Viridis；
                    else if (offlineHeatMapType_Flag == 16)
                    {
                        //Viridis颜色映射;--work;                      
                        imgColorViridis = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorViridis, Emgu.CV.CvEnum.ColorMapType.Viridis);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorViridis); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型18--Cividis；
                    else if (offlineHeatMapType_Flag == 17)
                    {
                        //Cividis颜色映射;--work;                        
                        imgColorCividis = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorCividis, Emgu.CV.CvEnum.ColorMapType.Cividis);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorCividis); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型19--Twilight；
                    else if (offlineHeatMapType_Flag == 18)
                    {
                        //Twilight颜色映射;--work;                        
                        imgColorTwilight = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorTwilight, Emgu.CV.CvEnum.ColorMapType.Twilight);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorTwilight); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型20--TwilightShifted；
                    else if (offlineHeatMapType_Flag == 19)
                    {
                        //TwilightShifted颜色映射;--work;                       
                        imgColorTwilightShifted = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorTwilightShifted, Emgu.CV.CvEnum.ColorMapType.TwilightShifted);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorTwilightShifted); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }

                    //热力图类型21--Turbo；
                    else if (offlineHeatMapType_Flag == 20)
                    {
                        //Turbo颜色映射;--work;                        
                        imgColorTurbo = new Image<Bgr, byte>(BmpToImg.Size);

                        //将imgGray转换为imgColorAutumn;--work;
                        CvInvoke.ApplyColorMap(imgGray, imgColorTurbo, Emgu.CV.CvEnum.ColorMapType.Turbo);

                        //显示转换后的图像;--work;
                        Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorTurbo); });
                        Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                    }
/***********************************************热力图类型选择--end***********************************************/

                }



                #region//其他信息: 无法将类型为“System.Drawing.Bitmap”的对象强制转换为类型“Emgu.CV.IInputArray”。
                //method1;
                //var imgSrc1 = (IInputArray)imgSrc;  //将imgSrc（System.Drawing.Bitmap）转化为Emgu.CV.IInputArray

                //method2;
                #endregion//var imgSrc1 = imgSrc.toArray(); //Image未包含toArray的定义，并且找不到可接受第一个Image类型参数的扩展方法toArray；



                //检测内容--origin;
                //Invoke((EventHandler)delegate { pictureBox11.Image = BitmapExtension.ToBitmap(match_img); });
                //Invoke((EventHandler)delegate { pictureBox11.Refresh(); });


                //Invoke(new EventHandler(delegate { pictureBox1.Image = new Image<Bgr, byte>(imgColorAutumn, pictureBox1.Width, pictureBox1.Height); }));


                //Thread with Invoke;事件委托；
                //显示图像--work;（BeginInvoke,异步,也可）；Invoke（同步）;
                //Invoke(new EventHandler(delegate { pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height); }));
                //Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                ////Bmp.Dispose();
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

            //获取图像绝对路径（包括图像名称）；
            dbf_File = ofd.FileName;

            //////////datetime格式化；
            //DateTime dt = DateTime.Now;

            //dbf_File2--获取图像名称;
            string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile

            //创建文件夹路径(与.exe在同一路径下)；
            path = str + "\\Result\\Save_Result";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

/*****************保存bmp灰度图像--work*******************************************************************************************/
            //offlineShowMode_Flag==0,灰度图;
            if (offlineShowMode_Flag == 0)
            {
                bt.Save(path + "\\" + dbf_File2 + "_Gray.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                //保存完成后，显示提示信息；
                MessageBox.Show("Save GrayImage Success!"); 
            }

/********************保存热力图结果图像----start******************************************************************************************/
            ////offlineShowMode_Flag==1,热力图(选择不同的热力图类型在进行判断，保存不同的格式类型);
            else if (offlineShowMode_Flag == 1)
            {
                //offlineHeatMapType_Flag--热力图类型1--Autumn；
                if (offlineHeatMapType_Flag == 0)
                {
                    //Autumn颜色映射;--work;
                    imgColorAutumn = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorAutumn, Emgu.CV.CvEnum.ColorMapType.Autumn);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Autumn.bmp", imgColorAutumn);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Autumn Image successfully!");                 
                }

                //热力图类型2--Bone；
                else if (offlineHeatMapType_Flag == 1)
                {
                    //Bone颜色映射;--work;                     
                    imgColorBone = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorBone, Emgu.CV.CvEnum.ColorMapType.Bone);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Bone.bmp", imgColorBone);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Bone Image successfully!");             
                }

                //热力图类型3--Jet；
                else if (offlineHeatMapType_Flag == 2)
                {
                    //Jet颜色映射;--work;                        
                    imgColorJet = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorJet, Emgu.CV.CvEnum.ColorMapType.Jet);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Jet.bmp", imgColorJet);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Jet Image successfully!");

                }
                //热力图类型4--Winter；
                else if (offlineHeatMapType_Flag == 3)
                {
                    //Winter颜色映射;--work;                    
                    imgColorWinter = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorWinter, Emgu.CV.CvEnum.ColorMapType.Winter);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Winter.bmp", imgColorWinter);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Winter Image successfully!");
                }

                //热力图类型5--Rainbow；
                else if (offlineHeatMapType_Flag == 4)
                {
                    //Rainbow颜色映射;--work;                       
                    imgColorRainbow = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorRainbow, Emgu.CV.CvEnum.ColorMapType.Rainbow);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Rainbow.bmp", imgColorRainbow);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Rainbow Image successfully!");
                }

                //热力图类型6--Ocean；
                else if (offlineHeatMapType_Flag == 5)
                {
                    //Ocean颜色映射;--work;                      
                    imgColorOcean = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorOcean, Emgu.CV.CvEnum.ColorMapType.Ocean);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Ocean.bmp", imgColorOcean);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Ocean Image successfully!");
                }

                //热力图类型7--Summer；
                else if (offlineHeatMapType_Flag == 6)
                {
                    //Summer颜色映射;--work;                       
                    imgColorSummer = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorSummer, Emgu.CV.CvEnum.ColorMapType.Summer);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Summer.bmp", imgColorSummer);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Summer Image successfully!");

                }

                //热力图类型8--Spring；
                else if (offlineHeatMapType_Flag == 7)
                {
                    //Spring颜色映射;--work;                      
                    imgColorSpring = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorSpring, Emgu.CV.CvEnum.ColorMapType.Spring);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Spring.bmp", imgColorSpring);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Spring Image successfully!");
                }

                //热力图类型9--Cool；
                else if (offlineHeatMapType_Flag == 8)
                {
                    //Cool颜色映射;--work;                     
                    imgColorCool = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorCool, Emgu.CV.CvEnum.ColorMapType.Cool);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Cool.bmp", imgColorCool);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Cool Image successfully!");
                }

                //热力图类型10--Hsv；
                else if (offlineHeatMapType_Flag == 9)
                {
                    //Hsv颜色映射;--work;                       
                    imgColorHsv = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorHsv, Emgu.CV.CvEnum.ColorMapType.Hsv);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Hsv.bmp", imgColorHsv);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Hsv Image successfully!");
                }

                //热力图类型11--Pink；
                else if (offlineHeatMapType_Flag == 10)
                {
                    //Pink颜色映射;--work;                       
                    imgColorPink = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorPink, Emgu.CV.CvEnum.ColorMapType.Pink);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Pink.bmp", imgColorPink);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Pink Image successfully!");
                }

                //热力图类型12--Hot；
                else if (offlineHeatMapType_Flag == 11)
                {
                    //Hot颜色映射;--work;                        
                    imgColorHot = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorHot, Emgu.CV.CvEnum.ColorMapType.Hot);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Hot.bmp", imgColorHot);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Hot Image successfully!");
                }

                //热力图类型13--Parula；
                else if (offlineHeatMapType_Flag == 12)
                {
                    //Parula颜色映射;--work;                       
                    imgColorParula = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorParula, Emgu.CV.CvEnum.ColorMapType.Parula);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Parula.bmp", imgColorParula);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Parula Image successfully!");
                }

                //热力图类型14--Magma；
                else if (offlineHeatMapType_Flag == 13)
                {
                    //Magma颜色映射;--work;                        
                    imgColorMagma = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorMagma, Emgu.CV.CvEnum.ColorMapType.Magma);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Magma.bmp", imgColorMagma);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Magma Image successfully!");
                }

                //热力图类型15--Inferno；
                else if (offlineHeatMapType_Flag == 14)
                {
                    //Inferno颜色映射;--work;                        
                    imgColorInferno = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorInferno, Emgu.CV.CvEnum.ColorMapType.Inferno);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Inferno.bmp", imgColorInferno);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Inferno Image successfully!");
                }

                //热力图类型16--Plasma；
                else if (offlineHeatMapType_Flag == 15)
                {
                    //Plasma颜色映射;--work;                        
                    imgColorPlasma = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorPlasma, Emgu.CV.CvEnum.ColorMapType.Plasma);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Plasma.bmp", imgColorPlasma);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Plasma Image successfully!");
                }

                //热力图类型17--Viridis；
                else if (offlineHeatMapType_Flag == 16)
                {
                    //Viridis颜色映射;--work;                      
                    imgColorViridis = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorViridis, Emgu.CV.CvEnum.ColorMapType.Viridis);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Viridis.bmp", imgColorViridis);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Viridis Image successfully!");
                }

                //热力图类型18--Cividis；
                else if (offlineHeatMapType_Flag == 17)
                {
                    //Cividis颜色映射;--work;                        
                    imgColorCividis = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorCividis, Emgu.CV.CvEnum.ColorMapType.Cividis);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Cividis.bmp", imgColorCividis);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Cividis Image successfully!");
                }

                //热力图类型19--Twilight；
                else if (offlineHeatMapType_Flag == 18)
                {
                    //Twilight颜色映射;--work;                        
                    imgColorTwilight = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorTwilight, Emgu.CV.CvEnum.ColorMapType.Twilight);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Twilight.bmp", imgColorTwilight);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Twilight Image successfully!");
                }

                //热力图类型20--TwilightShifted；
                else if (offlineHeatMapType_Flag == 19)
                {
                    //TwilightShifted颜色映射;--work;                       
                    imgColorTwilightShifted = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorTwilightShifted, Emgu.CV.CvEnum.ColorMapType.TwilightShifted);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_TwilightShifted.bmp", imgColorTwilightShifted);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_TwilightShifted Image successfully!");
                }

                //热力图类型21--Turbo；
                else if (offlineHeatMapType_Flag == 20)
                {
                    //Turbo颜色映射;--work;                        
                    imgColorTurbo = new Image<Bgr, byte>(BmpToImg.Size);

                    //将imgGray转换为imgColorAutumn;--work;
                    CvInvoke.ApplyColorMap(imgGray, imgColorTurbo, Emgu.CV.CvEnum.ColorMapType.Turbo);

                    CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Turbo.bmp", imgColorTurbo);
                    //保存完成后，显示提示信息；
                    MessageBox.Show("Save HeatMap_Turbo Image successfully!");
                }

                //CvInvoke.Imwrite(path + "\\" + dbf_File2 + "_Autumn.bmp", imgColorAutumn);
                ////保存完成后，显示提示信息；
                //MessageBox.Show("Save HeatMap Image Success!");
            }
/********************保存热力图结果图像----end******************************************************************************************/

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
                heatmapTypeUiComboBox1.Visible = false;


                ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                GetImgIntProcess();

                ////调用函数将Raw(8,12,14)进行绝对值模式处理;
                ////将输入图像Raw转换为的图像数组转换为字节;
                AbsModeGetImgByteProcess();


                ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                GetImgRGBProcess();

                ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                GetBmpProcess();

            }

/********************************************离线测试---相对值模式************************************************************/
            //相对值模式，其区域模式上下限均设置及热力图设置均为false;
            else if (offlineTestMode_Flag == 1)
            {
                //regionMode--close;v
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                heatMapLabel1.Visible = false;
                heatmapTypeUiComboBox1.Visible = false;

                ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                GetImgIntProcess();

                ////调用函数将Raw(8,12,14)进行相对值模式处理;
                ////将输入图像Raw转换为的图像数组转换为字节;
                RelModeGetImgByteProcess();


                ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                GetImgRGBProcess();

                ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                GetBmpProcess();

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
                heatmapTypeUiComboBox1.Visible = false;

                //////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                GetImgIntProcess();

                //////调用函数将Raw(8,12,14)进行区域模式处理;
                //////将输入图像Raw转换为的图像数组转换为字节;            
                RegionModeGetImgByteProcess();

                //////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                GetImgRGBProcess();

                //////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                GetBmpProcess();
            }

/****************************【离线模式】外部调用（否则出错！）GetImgIntProcess()、GetImgRGBProcess()及GetBmpProcess()函数**********************/
            ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
            GetImgIntProcess();
           

            ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
            GetImgRGBProcess();

            ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
            GetBmpProcess();
        }


/**********************************************显示模式选择******************************************************************/
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
                heatmapTypeUiComboBox1.Visible = false;
            }

            //热力图模式;其区域模式上下限均设置设置均为false，热力图模式设置为true;
            //(选择不同的热力图类型再进行判断，显示不同的格式类型);
            else if (offlineShowMode_Flag == 1)
            {
                //regionMode--close;
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--open;
                heatMapLabel1.Visible = true;
                heatmapTypeUiComboBox1.Visible = true;
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

            //work;
            //pixelValueLabel1.Text = "X坐标：" + x.ToString() + ";" + "\n" + "Y坐标：" + y.ToString() + ";";

            //获取像素值;
            //Color originalColor = bt.GetPixel(x, y);
            //int grayScale = (int)(originalColor.R);   //RGB通道像素值一样，这里仅取R通道值;
            //pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + ";" + "\n" + "像素值：" + grayScale.ToString();
           
        }

        //获取坐标;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {         
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

                    //获取像素值;
                    int grayScale = (int)(originalColor.R);
                    pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + ";" + "\n" + "像素值：" + grayScale.ToString();

                }               

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

                    //获取像素值;
                    int grayScale = (int)(originalColor.R);
                    pixelValueLabel1.Text = "X坐标：" + (e.X - this.Location.X) + ";" + "\n" + "Y坐标：" + (e.Y - this.Location.Y) + ";" + "\n" + "像素值：" + grayScale.ToString();                   

                }                
            }
        }

        private void heatmapTypeUiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //heatmapTypeUiComboBox1.SelectedIndex(0-20:Autumn;Bone;Jet;.....TwilightShifted;Turbo)
            offlineHeatMapType_Flag = heatmapTypeUiComboBox1.SelectedIndex;

            //点击热力图类型，立即响应产生热力图结果;
            ////调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
            GetImgIntProcess();

            ////调用函数将Raw(8,12,14)进行绝对值模式处理;
            ////将输入图像Raw转换为的图像数组转换为字节;
            //AbsModeGetImgByteProcess();

            ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
            GetImgRGBProcess();

            ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
            GetBmpProcess();

        }
    }

}









        
    
