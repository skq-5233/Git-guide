namespace ReadRAW
{
    partial class ReadRawImgMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadRawImgMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiButton2_SaveImg = new Sunny.UI.UIButton();
            this.uiButton1_Load_Img = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl_time = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Aside = new Sunny.UI.UINavMenu();
            this.uiNavBar1 = new Sunny.UI.UINavBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnClose = new System.Windows.Forms.Button();
            this.bnOpen = new System.Windows.Forms.Button();
            this.bnEnum = new System.Windows.Forms.Button();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnTriggerExec = new System.Windows.Forms.Button();
            this.cbSoftTrigger = new System.Windows.Forms.CheckBox();
            this.bnStopGrab = new System.Windows.Forms.Button();
            this.bnStartGrab = new System.Windows.Forms.Button();
            this.bnTriggerMode = new System.Windows.Forms.RadioButton();
            this.bnContinuesMode = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bnSavePng = new System.Windows.Forms.Button();
            this.bnSaveTiff = new System.Windows.Forms.Button();
            this.bnSaveJpg = new System.Windows.Forms.Button();
            this.bnSaveBmp = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bnSetParam = new System.Windows.Forms.Button();
            this.bnGetParam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbExposure = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.uiNavBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // uiButton2_SaveImg
            // 
            this.uiButton2_SaveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uiButton2_SaveImg, "uiButton2_SaveImg");
            this.uiButton2_SaveImg.Name = "uiButton2_SaveImg";
            this.uiButton2_SaveImg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2_SaveImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2_SaveImg.Click += new System.EventHandler(this.Save_Img_Click);
            // 
            // uiButton1_Load_Img
            // 
            this.uiButton1_Load_Img.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uiButton1_Load_Img, "uiButton1_Load_Img");
            this.uiButton1_Load_Img.Name = "uiButton1_Load_Img";
            this.uiButton1_Load_Img.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1_Load_Img.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1_Load_Img.Click += new System.EventHandler(this.Load_Raw_Img_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.uiLabel1, "uiLabel1");
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // labelControl_time
            // 
            this.labelControl_time.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.labelControl_time.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl_time.Appearance.Font")));
            this.labelControl_time.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelControl_time.Appearance.Options.UseBackColor = true;
            this.labelControl_time.Appearance.Options.UseFont = true;
            this.labelControl_time.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl_time, "labelControl_time");
            this.labelControl_time.Name = "labelControl_time";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Aside
            // 
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            resources.ApplyResources(this.Aside, "Aside");
            this.Aside.FullRowSelect = true;
            this.Aside.ItemHeight = 50;
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            this.Aside.ShowLines = false;
            this.Aside.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Aside.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiNavBar1
            // 
            this.uiNavBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiNavBar1.Controls.Add(this.pictureBox2);
            this.uiNavBar1.Controls.Add(this.uiLabel1);
            this.uiNavBar1.Controls.Add(this.labelControl_time);
            resources.ApplyResources(this.uiNavBar1, "uiNavBar1");
            this.uiNavBar1.DropMenuFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavBar1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavBar1.Name = "uiNavBar1";
            this.uiNavBar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnClose);
            this.groupBox1.Controls.Add(this.bnOpen);
            this.groupBox1.Controls.Add(this.bnEnum);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // bnClose
            // 
            resources.ApplyResources(this.bnClose, "bnClose");
            this.bnClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnClose.Name = "bnClose";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // bnOpen
            // 
            this.bnOpen.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.bnOpen, "bnOpen");
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.UseVisualStyleBackColor = true;
            this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
            // 
            // bnEnum
            // 
            this.bnEnum.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.bnEnum, "bnEnum");
            this.bnEnum.Name = "bnEnum";
            this.bnEnum.UseVisualStyleBackColor = true;
            this.bnEnum.Click += new System.EventHandler(this.bnEnum_Click);
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            resources.ApplyResources(this.cbDeviceList, "cbDeviceList");
            this.cbDeviceList.Name = "cbDeviceList";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bnTriggerExec);
            this.groupBox3.Controls.Add(this.cbSoftTrigger);
            this.groupBox3.Controls.Add(this.bnStopGrab);
            this.groupBox3.Controls.Add(this.bnStartGrab);
            this.groupBox3.Controls.Add(this.bnTriggerMode);
            this.groupBox3.Controls.Add(this.bnContinuesMode);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // bnTriggerExec
            // 
            resources.ApplyResources(this.bnTriggerExec, "bnTriggerExec");
            this.bnTriggerExec.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnTriggerExec.Name = "bnTriggerExec";
            this.bnTriggerExec.UseVisualStyleBackColor = true;
            this.bnTriggerExec.Click += new System.EventHandler(this.bnTriggerExec_Click);
            // 
            // cbSoftTrigger
            // 
            resources.ApplyResources(this.cbSoftTrigger, "cbSoftTrigger");
            this.cbSoftTrigger.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.UseVisualStyleBackColor = true;
            this.cbSoftTrigger.CheckStateChanged += new System.EventHandler(this.cbSoftTrigger_CheckedChanged);
            // 
            // bnStopGrab
            // 
            resources.ApplyResources(this.bnStopGrab, "bnStopGrab");
            this.bnStopGrab.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnStopGrab.Name = "bnStopGrab";
            this.bnStopGrab.UseVisualStyleBackColor = true;
            this.bnStopGrab.Click += new System.EventHandler(this.bnStopGrab_Click);
            // 
            // bnStartGrab
            // 
            resources.ApplyResources(this.bnStartGrab, "bnStartGrab");
            this.bnStartGrab.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnStartGrab.Name = "bnStartGrab";
            this.bnStartGrab.UseVisualStyleBackColor = true;
            this.bnStartGrab.Click += new System.EventHandler(this.bnStartGrab_Click);
            // 
            // bnTriggerMode
            // 
            resources.ApplyResources(this.bnTriggerMode, "bnTriggerMode");
            this.bnTriggerMode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnTriggerMode.Name = "bnTriggerMode";
            this.bnTriggerMode.TabStop = true;
            this.bnTriggerMode.UseMnemonic = false;
            this.bnTriggerMode.UseVisualStyleBackColor = true;
            this.bnTriggerMode.CheckedChanged += new System.EventHandler(this.bnTriggerMode_CheckedChanged);
            // 
            // bnContinuesMode
            // 
            resources.ApplyResources(this.bnContinuesMode, "bnContinuesMode");
            this.bnContinuesMode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnContinuesMode.Name = "bnContinuesMode";
            this.bnContinuesMode.TabStop = true;
            this.bnContinuesMode.UseVisualStyleBackColor = true;
            this.bnContinuesMode.CheckedChanged += new System.EventHandler(this.bnContinuesMode_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bnSavePng);
            this.groupBox4.Controls.Add(this.bnSaveTiff);
            this.groupBox4.Controls.Add(this.bnSaveJpg);
            this.groupBox4.Controls.Add(this.bnSaveBmp);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // bnSavePng
            // 
            resources.ApplyResources(this.bnSavePng, "bnSavePng");
            this.bnSavePng.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnSavePng.Name = "bnSavePng";
            this.bnSavePng.UseVisualStyleBackColor = true;
            this.bnSavePng.Click += new System.EventHandler(this.bnSavePng_Click);
            // 
            // bnSaveTiff
            // 
            resources.ApplyResources(this.bnSaveTiff, "bnSaveTiff");
            this.bnSaveTiff.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnSaveTiff.Name = "bnSaveTiff";
            this.bnSaveTiff.UseVisualStyleBackColor = true;
            this.bnSaveTiff.Click += new System.EventHandler(this.bnSaveTiff_Click);
            // 
            // bnSaveJpg
            // 
            resources.ApplyResources(this.bnSaveJpg, "bnSaveJpg");
            this.bnSaveJpg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnSaveJpg.Name = "bnSaveJpg";
            this.bnSaveJpg.UseVisualStyleBackColor = true;
            this.bnSaveJpg.Click += new System.EventHandler(this.bnSaveJpg_Click);
            // 
            // bnSaveBmp
            // 
            resources.ApplyResources(this.bnSaveBmp, "bnSaveBmp");
            this.bnSaveBmp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnSaveBmp.Name = "bnSaveBmp";
            this.bnSaveBmp.UseVisualStyleBackColor = true;
            this.bnSaveBmp.Click += new System.EventHandler(this.bnSaveBmp_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bnSetParam);
            this.groupBox5.Controls.Add(this.bnGetParam);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbFrameRate);
            this.groupBox5.Controls.Add(this.tbGain);
            this.groupBox5.Controls.Add(this.tbExposure);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // bnSetParam
            // 
            resources.ApplyResources(this.bnSetParam, "bnSetParam");
            this.bnSetParam.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnSetParam.Name = "bnSetParam";
            this.bnSetParam.UseVisualStyleBackColor = true;
            this.bnSetParam.Click += new System.EventHandler(this.bnSetParam_Click);
            // 
            // bnGetParam
            // 
            resources.ApplyResources(this.bnGetParam, "bnGetParam");
            this.bnGetParam.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnGetParam.Name = "bnGetParam";
            this.bnGetParam.UseVisualStyleBackColor = true;
            this.bnGetParam.Click += new System.EventHandler(this.bnGetParam_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Name = "label5";
            // 
            // tbFrameRate
            // 
            resources.ApplyResources(this.tbFrameRate, "tbFrameRate");
            this.tbFrameRate.Name = "tbFrameRate";
            // 
            // tbGain
            // 
            resources.ApplyResources(this.tbGain, "tbGain");
            this.tbGain.Name = "tbGain";
            // 
            // tbExposure
            // 
            resources.ApplyResources(this.tbExposure, "tbExposure");
            this.tbExposure.Name = "tbExposure";
            // 
            // ReadRawImgMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbDeviceList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiNavBar1);
            this.Controls.Add(this.uiButton2_SaveImg);
            this.Controls.Add(this.uiButton1_Load_Img);
            this.Controls.Add(this.Aside);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReadRawImgMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadRawImg_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.uiNavBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton uiButton1_Load_Img;
        private Sunny.UI.UIButton uiButton2_SaveImg;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl_time;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UINavMenu Aside;
        private Sunny.UI.UINavBar uiNavBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button bnOpen;
        private System.Windows.Forms.Button bnEnum;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnTriggerExec;
        private System.Windows.Forms.CheckBox cbSoftTrigger;
        private System.Windows.Forms.Button bnStopGrab;
        private System.Windows.Forms.Button bnStartGrab;
        private System.Windows.Forms.RadioButton bnTriggerMode;
        private System.Windows.Forms.RadioButton bnContinuesMode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bnSavePng;
        private System.Windows.Forms.Button bnSaveTiff;
        private System.Windows.Forms.Button bnSaveJpg;
        private System.Windows.Forms.Button bnSaveBmp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bnSetParam;
        private System.Windows.Forms.Button bnGetParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrameRate;
        private System.Windows.Forms.TextBox tbGain;
        private System.Windows.Forms.TextBox tbExposure;
    }
}

