using DevExpress.Utils.About;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
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
    public partial class BatchImageProcessMode : UIPage
    {
        public BatchImageProcessMode()
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

        Bitmap bt = new Bitmap(640, 512);

        //定义区域模式下，上下限阈值全局变量；
        public int upperPixel_Value;    //上限阈值;
        public int lowerPixel_Value;    //下限阈值;

        //get-set;
        public class Info
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return "Name: " + Name;
            }
        }

        //定义全局变量BmpToImg;
        Image<Bgr, Byte> BmpToImg;

        //定义全局变量imgGray;
        Image<Gray, byte> imgGray;

        //定义全局变量ImgFormat--对应图像格式选择（raw\png\jpg\tiff\bmp）;
        public string ImgFormat;

        //定义全局变量-路径（path）; 文件（dbf_File）;
        string path = string.Empty;

        string dbf_File = string.Empty;
     

        //定义全局变量-str,获取当前程序运行路径(.exe)；
        string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

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


        //图片总数;
        Int32 picturecount = 0;  

        String defaultfilepath;

        //定义对话框全局变量--ofd；
        OpenFileDialog ofd = new OpenFileDialog();

        //设置bool值canStop，控制测试取消按钮);
        private volatile bool canStop = true;

        //定义全局变量--Bits,通过chooseFormatUiComboBox1_SelectedIndexChanged索引选取不同的图像位数（0-8；1-12,2-14）;
        public string Bits;

        //定义全局变量--offlineTestMode_Flag，通过uiComboBox2_SelectedIndexChanged索引选取不同的离线测试模式(0--绝对值模式；1--相对值模式；2--区域模式);
        public int offlineTestMode_Flag;

        //imgFormatUiComboBox1.SelectedIndex选择索引值赋值给offlineImgFormat_Flag;
        public int offlineImgFormat_Flag;

        //将showModeUiComboBox3.SelectedIndex选择索引值赋值给offlineBitFormat_Flag，用于判断图像位数8/12/14；
        public int offlineBitFormat_Flag;

        //定义全局变量--offlineShowMode_Flag，通过uiComboBox3_SelectedIndexChanged索引选取不同的显示模式(0--灰度图模式；1--热力图模式);
        public int offlineShowMode_Flag;

        //public string Bits = "14";    //default--origin;

        //定义全局变量--offlineHeatMapType_Flag,通过heatmapTypeUiComboBox1_SelectedIndexChanged索引选取不同的热力图类型（0-20：Autumn;Bone;Jet....TwilightShifted;）
        public int offlineHeatMapType_Flag;


        //批量处理文件夹图像;
        private void uiButton1_Load_folderImg_Click(object sender, EventArgs e)
        {
            //文件夹测试;
            picturecount = 0;

            //记忆上次打开文件夹路径；
            folderBrowserDialog1.SelectedPath = defaultfilepath;          
            //打开文件夹对话框；           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //记忆上次打开文件夹路径；
                defaultfilepath = folderBrowserDialog1.SelectedPath;

                //ofd.FileName--获取（打开）图像绝对路径（包括图像名称）;ImgData--获取字节数组；
                //ImgData = File.ReadAllBytes(ofd.FileName);

                //使用线程thread1；
                Thread thread1 = new Thread(new ThreadStart(ImgprocessAccelerate));
                thread1.Start();              
            }
        }

        
        public void ImgprocessAccelerate()
        {
           
            //选择文件夹--work;
            //DirectoryInfo folder = new DirectoryInfo(defaultfilepath);


            //判断文件夹是否为空;
            DirectoryInfo folder = new DirectoryInfo(defaultfilepath);

            //为空文件夹; GetFiles获取文件列表; GetDirectories获取子目录列表;
            if (folder.GetFiles().Length + folder.GetDirectories().Length == 0) 
            {
                MessageBox.Show("空文件夹！请重新选择！","温馨提示"); 
                //"确定要退出吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                //label1.Text = "文件夹空！";
            }

            //非空文件夹(选择文件夹，挑选指定的raw图像);
            else
            {
            
            //图像计数：
            double picCount = 0;       
            
            //遍历文件夹;
            foreach (FileInfo nextfile in folder.GetFiles())
            {
                //取消测试;
                if (canStop == false)
                {
                    canStop = !canStop;
                    break;                   

                }

                //遍历文件夹，进行图像计数；
                picCount++;
                               
                //DirectoryInfo对象：（.Name获得文件夹名）;.FullName获得文件夹完整的路径名(包含文件夹名称)；
                //ofd.FileName--获取（打开）图像绝对路径（包括图像名称）;
                //ImgData--获取字节数组；
                ImgData = File.ReadAllBytes(nextfile.FullName);          

                //获取文件夹路径;
                string path = defaultfilepath;

                //获取选定路径下所有.raw图像，存放在files数组;
                //string[] files = Directory.GetFiles(path, "*.raw");   //origin-work;
                //changed--ImgFormat--(raw\jpg\png\tif\bmp);
                string[] files = Directory.GetFiles(path, ImgFormat);
                                      
                ////若选择文件夹中无指定的图像格式，判断为空；              
                if (files.Length == 0)
                {
                    //label1.Visible = true;
                    Invoke((EventHandler)delegate { label1.Text = "无指定图像！"; });
                    Invoke((EventHandler)delegate { label1.Refresh(); });
                    return;                         
                }
                //打开的指定文件夹中有选择的图像格式;              
                else if (files.Length > 0)
                {
                    Invoke((EventHandler)delegate { label1.Text = "已打开图像！"; });
                    Invoke((EventHandler)delegate { label1.Refresh(); });
                    //return;                  
                }
            
                //进度条设置;
                double sumpic = (double)files.Length;
                Invoke((EventHandler)delegate { progressBar1.Value = (int)((picCount / sumpic) * 100); });
                Invoke((EventHandler)delegate { label3.Text = "当前进度: " + Convert.ToInt32((int)((picCount / sumpic) * 100)) + '%' + "\r\n"; });

                //等待50ms;可看清楚pictureBox1显示图像;
                Thread.Sleep(50);

                //图像计数；
                picturecount++;
                Invoke((EventHandler)delegate { label2.Text = "图片总数：" + picturecount.ToString(); });
                Invoke((EventHandler)delegate { label2.Refresh(); });


                //检测内容--显示图像(Jpg\Png-->img)img--work;
                //Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(BmpImg); });
                //Invoke((EventHandler)delegate { pictureBox1.Refresh(); });

                //检测内容--显示图像(Raw-->Bmp)Bmp;
                //Invoke(new EventHandler(delegate { pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height); }));
                //Invoke((EventHandler)delegate { pictureBox1.Refresh(); });

/********************************************离线测试---绝对值模式************************************************************/
                //绝对值模式，其区域模式上下限均设置及热力图设置均为false;
                if (offlineTestMode_Flag == 0)
                {
                    //调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                    GetImgIntProcess();

                    //调用函数将Raw(8,12,14)进行绝对值模式处理;将输入图像Raw转换为的图像数组转换为字节;
                    AbsModeGetImgByteProcess();

                    //调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                    GetImgRGBProcess();

                    //调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                    GetBmpProcess();

                }
/********************************************离线测试---相对值模式************************************************************/
                //相对值模式，其区域模式上下限均设置及热力图设置均为false;
               else if (offlineTestMode_Flag == 1)
               {
                    //调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                    GetImgIntProcess();

                    //调用函数将Raw(8,12,14)进行相对值模式处理;将输入图像Raw转换为的图像数组转换为字节;              
                    RelModeGetImgByteProcess();

                    //调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                    GetImgRGBProcess();

                    //调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                    GetBmpProcess();
               }
/********************************************离线测试---区域模式**************************************************************/
                //区域模式，其上下阈值设置均打开，热力图模式设置关闭；
              else if (offlineTestMode_Flag == 2)
              {
                    //调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                    GetImgIntProcess();

                    //调用函数将Raw(8,12,14)进行区域模式处理;将输入图像Raw转换为的图像数组转换为字节;                           
                    RegionModeGetImgByteProcess();

                    //调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                    GetImgRGBProcess();

                    //调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                    GetBmpProcess();
              }
/********************显示模式选择显示模式（0--灰度图模式；1--热力图模式）******************************************************************/
/*****uiComboBox2.SelectedIndex不同索引对应不同的显示模式选择；*****************************************************************/
/************************************************保存文件夹下灰度图图像--start**********************************************************/   
            //显示模式（0--灰度图模式；1--热力图模式）；
            //灰度图模式;其区域模式上下限均设置及热力图设置均为false;
            if (offlineShowMode_Flag == 0)
            {
                //调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                GetImgIntProcess();

                ////调用函数将Raw(8,12,14)进行绝对值模式处理;
                ////将输入图像Raw转换为的图像数组转换为字节;
                //AbsModeGetImgByteProcess();

                ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                GetImgRGBProcess();

                ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                GetBmpProcess();

                //add(设置本地路径--start);保存批量处理后的文件夹灰度图图像;
                path = str + "\\Result\\FolderGrayImg_Result";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                //add(设为本地路径--end）

                //bt.Save(path + "\\" + dbf_File2 + "_Gray.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                //CvInvoke.Imwrite(path + "\\" + Path.GetFileName(nextfile.FullName), ImageFormat.Bmp); //保存结果图像；
                //bt.Save(path + "\\" + Path.GetFileName(nextfile.Name) + "_.bmp", ImageFormat.Bmp);

                //Path.GetFileNameWithoutExtension(filePath)--无后缀名;Path.GetFileName(filePath)--包含后缀名;
                bt.Save(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Gray.jpg", ImageFormat.Bmp);
                //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；
                if (progressBar1.Value==100)
                {
                    MessageBox.Show("Save GrayImg Successfully!","温馨提示");
                }
            } 
/**************************************************************保存文件夹下灰度图图像--End**********************************************************/                 
            
/**************************************************************保存热力图图像--start**********************************************************/   
            else if(offlineShowMode_Flag==1)
            {
                //调用GetImgIntProcess处理函数;将输入的Raw图像转换为图像数组;       
                GetImgIntProcess();

                ////调用函数将Raw(8,12,14)进行绝对值模式处理;
                ////将输入图像Raw转换为的图像数组转换为字节;
                //AbsModeGetImgByteProcess();

                ////调用函数--GetImgRGBProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像;
                GetImgRGBProcess();

                ////调用函数--GetBmpProcess();将输入图像Raw转换为的图像数组转换为的字节转换为RGB图像转化为Bmp;
                GetBmpProcess();

                BmpToImg = BitmapExtension.ToImage<Bgr, byte>(Bmp);
                Mat ImgToMat1 = BmpToImg.Mat;
                imgGray = new Image<Gray, byte>(BmpToImg.Size);

                //将Mat类型图像ImgToMat转换为imgGray;             
                CvInvoke.CvtColor(ImgToMat1, imgGray, ColorConversion.Bgr2Gray);

                //add(设置本地路径--start);保存批量处理后的文件夹热力图图像;
                path = str + "\\Result\\FolderHeatMap_Result";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                    
                switch(offlineHeatMapType_Flag)
                {
                    case 0:
                        //Autumn颜色映射;
                        imgColorAutumn = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorAutumn;
                        CvInvoke.ApplyColorMap(imgGray, imgColorAutumn, Emgu.CV.CvEnum.ColorMapType.Autumn);                      
                                             
                        //保存结果图像；
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Autumn.jpg", imgColorAutumn); 
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；
                        if (progressBar1.Value==100)
                        {
                            MessageBox.Show("Save AutumnImg Successfully!", "温馨提示");
                        }
                        break;
                     case 1:
                        //Bone颜色映射;                
                        imgColorBone = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorBone;
                        CvInvoke.ApplyColorMap(imgGray, imgColorBone, Emgu.CV.CvEnum.ColorMapType.Bone);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Bone.jpg", imgColorBone); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                       
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save BoneImg Successfully!", "温馨提示");
                        }
                        break;
                     case 2:
                        imgColorJet = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorJet;
                        CvInvoke.ApplyColorMap(imgGray, imgColorJet, Emgu.CV.CvEnum.ColorMapType.Jet);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Jet.jpg", imgColorJet); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save JetImg Successfully!", "温馨提示");
                        }
                        break;
                     case 3:
                        //Winter颜色映射;                   
                        imgColorWinter = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorWinter;
                        CvInvoke.ApplyColorMap(imgGray, imgColorWinter, Emgu.CV.CvEnum.ColorMapType.Winter);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Winter.jpg", imgColorWinter); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save WinterImg Successfully!", "温馨提示");
                        }
                        break;
                      case 4:
                        //Rainbow颜色映射;                     
                        imgColorRainbow = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorRainbow;
                        CvInvoke.ApplyColorMap(imgGray, imgColorRainbow, Emgu.CV.CvEnum.ColorMapType.Rainbow);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Rainbow.jpg", imgColorRainbow); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save RainbowImg Successfully!", "温馨提示");
                        }
                        break;
                      case 5:
                        //Ocean颜色映射;                      
                        imgColorOcean = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorOcean;
                        CvInvoke.ApplyColorMap(imgGray, imgColorOcean, Emgu.CV.CvEnum.ColorMapType.Ocean);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Ocean.jpg", imgColorOcean); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save OceanImg Successfully!", "温馨提示");
                        }
                        break;
                      case 6:
                        //Summer颜色映射;                   
                        imgColorSummer = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorSummer;
                        CvInvoke.ApplyColorMap(imgGray, imgColorSummer, Emgu.CV.CvEnum.ColorMapType.Summer);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Summer.jpg", imgColorSummer); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save SummerImg Successfully!", "温馨提示");
                        }
                        break;
                      case 7:
                        //Spring颜色映射;                    
                        imgColorSpring = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorSpring;
                        CvInvoke.ApplyColorMap(imgGray, imgColorSpring, Emgu.CV.CvEnum.ColorMapType.Spring);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Spring.jpg", imgColorSpring); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save SpringImg Successfully!", "温馨提示");
                        }
                        break;
                      case 8:
                        //Cool颜色映射;                 
                        imgColorCool = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorCool;
                        CvInvoke.ApplyColorMap(imgGray, imgColorCool, Emgu.CV.CvEnum.ColorMapType.Cool);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Cool.jpg", imgColorCool); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save CoolImg Successfully!", "温馨提示");
                        }
                        break;
                      case 9:
                        //Hsv颜色映射;                      
                        imgColorHsv = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorHsv;
                        CvInvoke.ApplyColorMap(imgGray, imgColorHsv, Emgu.CV.CvEnum.ColorMapType.Hsv);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Hsv.jpg", imgColorHsv); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save HsvImg Successfully!", "温馨提示");
                        }
                        break;
                      case 10:
                        //Pink颜色映射;                   
                        imgColorPink = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorPink;
                        CvInvoke.ApplyColorMap(imgGray, imgColorPink, Emgu.CV.CvEnum.ColorMapType.Pink);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Pink.jpg", imgColorPink); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save PinkImg Successfully!", "温馨提示");
                        }
                        break;
                      case 11:
                        //Hot颜色映射;                     
                        imgColorHot = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorHot;
                        CvInvoke.ApplyColorMap(imgGray, imgColorHot, Emgu.CV.CvEnum.ColorMapType.Hot);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Hot.jpg", imgColorHot); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save HotImg Successfully!", "温馨提示");
                        }
                        break;
                      case 12:
                        //Parula颜色映射;                     
                        imgColorParula = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorParula;
                        CvInvoke.ApplyColorMap(imgGray, imgColorParula, Emgu.CV.CvEnum.ColorMapType.Parula);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Parula.jpg", imgColorParula); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save ParulaImg Successfully!", "温馨提示");
                        }
                        break;
                      case 13:
                        //Magma颜色映射;                       
                        imgColorMagma = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorMagma;
                        CvInvoke.ApplyColorMap(imgGray, imgColorMagma, Emgu.CV.CvEnum.ColorMapType.Magma);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Magma.jpg", imgColorMagma); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save MagmaImg Successfully!", "温馨提示");
                        }
                        break;
                      case 14:
                        //Inferno颜色映射;                      
                        imgColorInferno = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorInferno;
                        CvInvoke.ApplyColorMap(imgGray, imgColorInferno, Emgu.CV.CvEnum.ColorMapType.Inferno);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Inferno.jpg", imgColorInferno); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save InfernoImg Successfully!", "温馨提示");
                        }
                        break;
                      case 15:
                        //Plasma颜色映射;                        
                        imgColorPlasma = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorPlasma;
                        CvInvoke.ApplyColorMap(imgGray, imgColorPlasma, Emgu.CV.CvEnum.ColorMapType.Plasma);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Plasma.jpg", imgColorPlasma); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save PlasmaImg Successfully!", "温馨提示");
                        }
                        break;
                      case 16:
                        //Viridis颜色映射;                    
                        imgColorViridis = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorViridis;
                        CvInvoke.ApplyColorMap(imgGray, imgColorViridis, Emgu.CV.CvEnum.ColorMapType.Viridis);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Viridis.jpg", imgColorViridis); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save ViridisImg Successfully!", "温馨提示");
                        }
                        break;
                      case 17:
                        //Cividis颜色映射;                       
                        imgColorCividis = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorCividis;
                        CvInvoke.ApplyColorMap(imgGray, imgColorCividis, Emgu.CV.CvEnum.ColorMapType.Cividis);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Cividis.jpg", imgColorCividis); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save CividisImg Successfully!", "温馨提示");
                        }
                        break;
                      case 18:
                        //Twilight颜色映射;                        
                        imgColorTwilight = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorTwilight;
                        CvInvoke.ApplyColorMap(imgGray, imgColorTwilight, Emgu.CV.CvEnum.ColorMapType.Twilight);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Twilight.jpg", imgColorTwilight); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save TwilightImg Successfully!", "温馨提示");
                        }
                        break;
                      case 19:
                        //TwilightShifted颜色映射;                    
                        imgColorTwilightShifted = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorTwilightShifted;
                        CvInvoke.ApplyColorMap(imgGray, imgColorTwilightShifted, Emgu.CV.CvEnum.ColorMapType.TwilightShifted);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_TwilightShifted.jpg", imgColorTwilightShifted); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save TwilightShiftedImg Successfully!", "温馨提示");
                        }
                        break;
                       case 20:
                        //Turbo颜色映射;                    
                        imgColorTurbo = new Image<Bgr, byte>(BmpToImg.Size);
                        //将imgGray转换为imgColorTurbo;
                        CvInvoke.ApplyColorMap(imgGray, imgColorTurbo, Emgu.CV.CvEnum.ColorMapType.Turbo);
                        CvInvoke.Imwrite(path + "\\" + Path.GetFileNameWithoutExtension(nextfile.Name) + "_Turbo.jpg", imgColorTurbo); //保存结果图像；
                        //如果进度条的值达到100%，则提示用户图像处理完毕，保存成功；                                                                                                                                                                                                                        
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Save TurboImg Successfully!", "温馨提示");
                        }
                        break;
/**************************************************************保存热力图图像--End**********************************************************/
                        }//连接switch(offlineHeatMapType_Flag)

      } //连接else if(offlineShowMode_Flag==1)       
                  
    } //连接foreach();

  }   //连接else();
          
}//连接第一个括号ImgprocessAccelerate();


        //GetImgIntProcess()--将输入图像Raw转换为图像数组;
        public void GetImgIntProcess()
        {
            ImgInt = GetImgInt(ImgData, Width, Height, Bits);
            //记忆上次打开文件夹路径；
            defaultfilepath = folderBrowserDialog1.SelectedPath;
            //判断图像是否为空;
            if (Bmp != null)
            {
                //显示模式--灰度图；
                if (offlineShowMode_Flag == 0)
                {
                    //Thread with Invoke;事件委托；
                    //显示图像--work;（BeginInvoke,异步,也可）；Invoke（同步）;
                    Invoke(new EventHandler(delegate { pictureBox1.Image = new Bitmap(Bmp, pictureBox1.Width, pictureBox1.Height); }));
                    Invoke((EventHandler)delegate { pictureBox1.Refresh(); });

                }
                //显示模式--热力图；
                //(选择不同的热力图类型在进行判断，保存不同的格式类型);
                else if (offlineShowMode_Flag == 1)
                {
                    BmpToImg = BitmapExtension.ToImage<Bgr, byte>(Bmp);
                    Mat ImgToMat = BmpToImg.Mat;
                    imgGray = new Image<Gray, byte>(BmpToImg.Size);

                    //将Mat类型图像ImgToMat转换为imgGray;             
                    CvInvoke.CvtColor(ImgToMat, imgGray, ColorConversion.Bgr2Gray);
/***********************************************热力图类型选择--start***********************************************************/                  
                    switch(offlineHeatMapType_Flag)
                    {
                        //热力图类型1--Autumn；
                        case 0:
                            //Autumn颜色映射;
                            imgColorAutumn = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorAutumn;
                            CvInvoke.ApplyColorMap(imgGray, imgColorAutumn, Emgu.CV.CvEnum.ColorMapType.Autumn);
                            //显示转换后的Autumn图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorAutumn); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型2--Bone；
                        case 1:
                            //Bone颜色映射;                
                            imgColorBone = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorBone;
                            CvInvoke.ApplyColorMap(imgGray, imgColorBone, Emgu.CV.CvEnum.ColorMapType.Bone);
                            //显示转换后的Bone图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorBone); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型3--Jet；
                        case 2:
                            //Jet颜色映射;                       
                            imgColorJet = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorJet;
                            CvInvoke.ApplyColorMap(imgGray, imgColorJet, Emgu.CV.CvEnum.ColorMapType.Jet);
                            //显示转换后的Jet图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorJet); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型4--Winter；
                        case 3:
                            //Winter颜色映射;                   
                            imgColorWinter = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorWinter;
                            CvInvoke.ApplyColorMap(imgGray, imgColorWinter, Emgu.CV.CvEnum.ColorMapType.Winter);
                            //显示转换后的Winter图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorWinter); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型5--Rainbow；
                        case 4:
                            //Rainbow颜色映射;                     
                            imgColorRainbow = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorRainbow;
                            CvInvoke.ApplyColorMap(imgGray, imgColorRainbow, Emgu.CV.CvEnum.ColorMapType.Rainbow);
                            //显示转换后的Rainbow图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorRainbow); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型6--Ocean；
                        case 5:
                            //Ocean颜色映射;                      
                            imgColorOcean = new Image<Bgr, byte>(BmpToImg.Size);

                            //将imgGray转换为imgColorOcean;
                            CvInvoke.ApplyColorMap(imgGray, imgColorOcean, Emgu.CV.CvEnum.ColorMapType.Ocean);

                            //显示转换后的Ocean图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorOcean); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型7--Summer；
                        case 6:
                            //Summer颜色映射;                   
                            imgColorSummer = new Image<Bgr, byte>(BmpToImg.Size);

                            //将imgGray转换为imgColorSummer;
                            CvInvoke.ApplyColorMap(imgGray, imgColorSummer, Emgu.CV.CvEnum.ColorMapType.Summer);

                            //显示转换后的Summer图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorSummer); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型8--Spring；
                        case 7:
                            //Spring颜色映射;                    
                            imgColorSpring = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorSpring;
                            CvInvoke.ApplyColorMap(imgGray, imgColorSpring, Emgu.CV.CvEnum.ColorMapType.Spring);
                            //显示转换后的Spring图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorSpring); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型9--Cool；
                        case 8:
                            //Cool颜色映射;                 
                            imgColorCool = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorCool;
                            CvInvoke.ApplyColorMap(imgGray, imgColorCool, Emgu.CV.CvEnum.ColorMapType.Cool);
                            //显示转换后的Cool图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorCool); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型10--Hsv；
                        case 9:
                            //Hsv颜色映射;                      
                            imgColorHsv = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorHsv;
                            CvInvoke.ApplyColorMap(imgGray, imgColorHsv, Emgu.CV.CvEnum.ColorMapType.Hsv);
                            //显示转换后的Hsv图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorHsv); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型11--Pink；
                        case 10:
                            //Pink颜色映射;                   
                            imgColorPink = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorPink;
                            CvInvoke.ApplyColorMap(imgGray, imgColorPink, Emgu.CV.CvEnum.ColorMapType.Pink);
                            //显示转换后的Pink图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorPink); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型12--Hot；
                        case 11:
                            //Hot颜色映射;                     
                            imgColorHot = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorHot;
                            CvInvoke.ApplyColorMap(imgGray, imgColorHot, Emgu.CV.CvEnum.ColorMapType.Hot);
                            //显示转换后的Hot图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorHot); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型13--Parula；
                        case 12:
                            //Parula颜色映射;                     
                            imgColorParula = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorParula;
                            CvInvoke.ApplyColorMap(imgGray, imgColorParula, Emgu.CV.CvEnum.ColorMapType.Parula);
                            //显示转换后的Parula图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorParula); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型14--Magma；
                        case 13:
                            //Magma颜色映射;                       
                            imgColorMagma = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorMagma;
                            CvInvoke.ApplyColorMap(imgGray, imgColorMagma, Emgu.CV.CvEnum.ColorMapType.Magma);
                            //显示转换后的Magma图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorMagma); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型15--Inferno；
                        case 14:
                            //Inferno颜色映射;                      
                            imgColorInferno = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorInferno;
                            CvInvoke.ApplyColorMap(imgGray, imgColorInferno, Emgu.CV.CvEnum.ColorMapType.Inferno);
                            //显示转换后的Inferno图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorInferno); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型16--Plasma；
                        case 15:
                            //Plasma颜色映射;                        
                            imgColorPlasma = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorPlasma;
                            CvInvoke.ApplyColorMap(imgGray, imgColorPlasma, Emgu.CV.CvEnum.ColorMapType.Plasma);
                            //显示转换后的Plasma图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorPlasma); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型17--Viridis；
                        case 16:
                            //Viridis颜色映射;                    
                            imgColorViridis = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorViridis;
                            CvInvoke.ApplyColorMap(imgGray, imgColorViridis, Emgu.CV.CvEnum.ColorMapType.Viridis);
                            //显示转换后的Viridis图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorViridis); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型18--Cividis；
                        case 17:
                            //Cividis颜色映射;                       
                            imgColorCividis = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorCividis;
                            CvInvoke.ApplyColorMap(imgGray, imgColorCividis, Emgu.CV.CvEnum.ColorMapType.Cividis);
                            //显示转换后的Cividis图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorCividis); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型19--Twilight；
                        case 18:
                            //Twilight颜色映射;                        
                            imgColorTwilight = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorTwilight;
                            CvInvoke.ApplyColorMap(imgGray, imgColorTwilight, Emgu.CV.CvEnum.ColorMapType.Twilight);
                            //显示转换后的Twilight图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorTwilight); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型20--TwilightShifted；
                        case 19:
                            //TwilightShifted颜色映射;                    
                            imgColorTwilightShifted = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorTwilightShifted;
                            CvInvoke.ApplyColorMap(imgGray, imgColorTwilightShifted, Emgu.CV.CvEnum.ColorMapType.TwilightShifted);
                            //显示转换后的TwilightShifted图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorTwilightShifted); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;

                        //热力图类型21--Turbo；
                        default:
                            //Turbo颜色映射;                    
                            imgColorTurbo = new Image<Bgr, byte>(BmpToImg.Size);
                            //将imgGray转换为imgColorTurbo;
                            CvInvoke.ApplyColorMap(imgGray, imgColorTurbo, Emgu.CV.CvEnum.ColorMapType.Turbo);
                            //显示转换后的Turbo图像;
                            Invoke((EventHandler)delegate { pictureBox1.Image = BitmapExtension.ToBitmap(imgColorTurbo); });
                            Invoke((EventHandler)delegate { pictureBox1.Refresh(); });
                            break;                       
                    }

                }                         
                
            }
        }

        //（离线测试--绝对值模式下）将输入图像Raw转换为的图像数组转换为字节;
        public void AbsModeGetImgByteProcess()
        {
            //绝对值模式（8,12,14）；
            ImgByte = AbsModeGetImgByte(ImgInt, Width, Height, Bits);
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

/**********************************Offline-AbsoluteMode**********************************************************************/
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

/***********************绝对值模式*************************************************************************************************
                    * 1、先遍历查询处图像数组中所有像素值;
                    * 2、再进行缩放至0-255；(255*img[i])/(2^8,2^12,2^14);
*********************************************************************************************************************************/
            try
            {
                switch (Bits)
                {
                    case ("8"):
                        for (int i = 0; i < img.Length; i += 4)
                        {                          
                            //将255转化为Int32;                            
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
                            //将255转化为Int32;                           
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
                            //将255转化为Int32;                            
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

/**********************************Offline-RelativeMode**********************************************************************/
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

/**************************相对值模式********************************************************************************************************
                * 1、先遍历查询处图像数组中所有像素值;
                * 2、找出图像数组中最大像素值、最小像素值；
                * 3、再进行缩放至0-255；
*******************************************************************************************************************************/
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

/**********************************Offline-RegionMode****************************************************************************/
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

/*************区域模式************************************************************************************************************
            * 1、先遍历查询处图像数组中所有像素值;
            * 2、将大于阈值上限的像素值设为阈值上限；
            * 3、将小于阈值下限的值设为阈值下限;
            * 4、再进行缩放至0-255；
********************************************************************************************************************************/

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



        #region//保存为bmp格式的图像；
        //        private void uiButton2_SaveImg_Click(object sender, EventArgs e)
        //        {
        //            //获取图像绝对路径（包括图像名称）；
        //            dbf_File = ofd.FileName;
        //            //dbf_File2--获取图像名称;
        //            string dbf_File2 = System.IO.Path.GetFileNameWithoutExtension(dbf_File); // for getting only MyFile
        //            //创建文件夹路径(与.exe在同一路径下)；
        //            path = str + "\\Result\\Save_FolderResult";

        //            if (!Directory.Exists(path))
        //            {
        //                Directory.CreateDirectory(path);
        //            }

        ///*****************保存bmp灰度图像--work*******************************************************************************************/
        //            //offlineShowMode_Flag==0,灰度图;
        //            if (offlineShowMode_Flag == 0)
        //            {
        //                bt.Save(path + "\\" + dbf_File2 + "_Gray.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        //                //CvInvoke.Imwrite(path + "\\" + Path.GetFileName(nextfile.FullName), match_img1); //保存匹配结果图像；

        //                //保存完成后，显示提示信息；
        //                MessageBox.Show("Save GrayImage successfully!");
        //            }

        ///********************保存热力图结果图像******************************************************************************************/
        //        }
        #endregion

        
        //当选择错误文件后，可点击取消文件夹测试;
        private void uiButton1_Cancel_Click(object sender, EventArgs e)
        {
            canStop = !canStop;
        }

        //选择图像位数;
        private void chooseBitFormatUiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //将showModeUiComboBox3.SelectedIndex选择索引值赋值给offlineBitFormat_Flag，用于判断图像位数(0-8;1-12;2-14)；
            offlineBitFormat_Flag = chooseBitFormatUiComboBox1.SelectedIndex;
            switch(offlineBitFormat_Flag)
            {
                case 0:
                    Bits = "8";
                    break;
                case 1:
                    Bits = "12";
                    break;
                default:
                    Bits = "14";
                    break;
            }           
        }

        //显示模式选择（灰度图、伪彩色图）；
        private void heatmapTypeUiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            offlineHeatMapType_Flag = heatmapTypeUiComboBox1.SelectedIndex;

            #region//显示模式（0--灰度图模式；1--热力图模式）；
            //灰度图模式;其区域模式上下限均设置及热力图设置均为false;
            //if (offlineShowMode_Flag == 0)
            //{
            //    //regionMode--close;
            //    upThresholdTextBox1.Visible = false;
            //    lowThresholdTextBox2.Visible = false;
            //    upperThresholdLabel3.Visible = false;
            //    lowerThresholdLabel4.Visible = false;

            //    //heatMap--close;
            //    heatMapLabel1.Visible = false;
            //    heatmapTypeUiComboBox1.Visible = false;
            //}

            //热力图模式;其区域模式上下限均设置设置均为false，热力图模式设置为true;
            //(选择不同的热力图类型再进行判断，显示不同的格式类型);
            //else if (offlineShowMode_Flag == 1)
            //{
            //    //regionMode--close;
            //    upThresholdTextBox1.Visible = false;
            //    lowThresholdTextBox2.Visible = false;
            //    upperThresholdLabel3.Visible = false;
            //    lowerThresholdLabel4.Visible = false;

            //    //heatMap--open;
            //    heatMapLabel1.Visible = true;
            //    heatmapTypeUiComboBox1.Visible = true;
            //}


            //调用ImgprocessAccelerate函数；当选择不同热力图模式时，实时显示结果；
            //ImgprocessAccelerate();
            #endregion

        }

        //测试模式选择;      
        private void testModeUiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            offlineTestMode_Flag = testModeUiComboBox2.SelectedIndex;
            
            //调用图像处理函数;
            //ImgprocessAccelerate();

            //绝对值模式；
            if (offlineTestMode_Flag == 0)
            {
                //regionMode--close;
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                //heatMapLabel1.Visible = false;
                //heatmapTypeUiComboBox1.Visible = false;
            }
            //相对值模式;
            else if(offlineTestMode_Flag==1)
            {
                //regionMode--close;
                upThresholdTextBox1.Visible = false;
                lowThresholdTextBox2.Visible = false;
                upperThresholdLabel3.Visible = false;
                lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                //heatMapLabel1.Visible = false;
                //heatmapTypeUiComboBox1.Visible = false;
            }

            //区域模式;
            else if(offlineTestMode_Flag==2)
            {
                //regionMode--open;
                upThresholdTextBox1.Visible = true;
                lowThresholdTextBox2.Visible = true;
                upperThresholdLabel3.Visible = true;
                lowerThresholdLabel4.Visible = true;

                //heatMap--close;
                //heatMapLabel1.Visible = false;
                //heatmapTypeUiComboBox1.Visible = false;
            }
        }

        //显示模式选择（0--灰度图；1--热力图）;
        private void showModeUiComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            offlineShowMode_Flag = showModeUiComboBox3.SelectedIndex;

            //Origin-Work;
            if (offlineShowMode_Flag == 0)
            {
                //regionMode--close;
                //upThresholdTextBox1.Visible = false;
                //lowThresholdTextBox2.Visible = false;
                //upperThresholdLabel3.Visible = false;
                //lowerThresholdLabel4.Visible = false;

                //heatMap--close;
                heatMapLabel1.Visible = false;
                heatmapTypeUiComboBox1.Visible = false;
            }

            ////热力图模式;其区域模式上下限均设置设置均为false，热力图模式设置为true;
            ////(选择不同的热力图类型再进行判断，显示不同的格式类型);
            else if (offlineShowMode_Flag == 1)
            {
                //regionMode--close;
                //upThresholdTextBox1.Visible = false;
                //lowThresholdTextBox2.Visible = false;
                //upperThresholdLabel3.Visible = false;
                //lowerThresholdLabel4.Visible = false;

                //heatMap--open;
                heatMapLabel1.Visible = true;
                heatmapTypeUiComboBox1.Visible = true;
            }


            //调用ImgprocessAccelerate函数；当选择不同显示模式时，实时显示结果；
            //ImgprocessAccelerate();
        }

        //选择图像格式：
        private void imgFormatUiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            offlineImgFormat_Flag = imgFormatUiComboBox1.SelectedIndex;
            //通过全局变量ImgFormat进行图像格式选择;
            switch (offlineImgFormat_Flag)
            {
                case 0:
                    ImgFormat = "*.raw";
                    break;
                case 1:
                    ImgFormat = "*.jpg";
                    break;
                case 2:
                    ImgFormat = "*.png";
                    break;
                case 3:
                    ImgFormat = "*.tif";
                    break;
                default:
                    ImgFormat = "*.bmp";
                    break;
            }
        }

    }
}
