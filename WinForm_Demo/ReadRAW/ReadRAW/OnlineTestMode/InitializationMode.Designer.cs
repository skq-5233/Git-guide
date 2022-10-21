namespace ReadRAW.OnlineTestMode
{
    partial class InitializationMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnClose = new Sunny.UI.UIButton();
            this.bnOpen = new Sunny.UI.UIButton();
            this.bnEnum = new Sunny.UI.UIButton();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnTriggerExec = new Sunny.UI.UIButton();
            this.cbSoftTrigger = new Sunny.UI.UICheckBox();
            this.bnStopGrab = new Sunny.UI.UIButton();
            this.bnStartGrab = new Sunny.UI.UIButton();
            this.bnTriggerMode = new Sunny.UI.UIRadioButton();
            this.bnContinuesMode = new Sunny.UI.UIRadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bnSavePng = new Sunny.UI.UIButton();
            this.bnSaveTiff = new Sunny.UI.UIButton();
            this.bnSaveJpg = new Sunny.UI.UIButton();
            this.bnSaveBmp = new Sunny.UI.UIButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bnSetParam = new Sunny.UI.UIButton();
            this.bnGetParam = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbExposure = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnClose);
            this.groupBox1.Controls.Add(this.bnOpen);
            this.groupBox1.Controls.Add(this.bnEnum);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 72);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备初始化";
            // 
            // bnClose
            // 
            this.bnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnClose.ForeColor = System.Drawing.Color.Black;
            this.bnClose.Location = new System.Drawing.Point(200, 23);
            this.bnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(85, 36);
            this.bnClose.Style = Sunny.UI.UIStyle.Custom;
            this.bnClose.TabIndex = 51;
            this.bnClose.Text = "关闭相机";
            this.bnClose.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // bnOpen
            // 
            this.bnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnOpen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnOpen.ForeColor = System.Drawing.Color.Black;
            this.bnOpen.Location = new System.Drawing.Point(105, 23);
            this.bnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.Size = new System.Drawing.Size(85, 36);
            this.bnOpen.Style = Sunny.UI.UIStyle.Custom;
            this.bnOpen.TabIndex = 50;
            this.bnOpen.Text = "打开相机";
            this.bnOpen.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnOpen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
            // 
            // bnEnum
            // 
            this.bnEnum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnEnum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnEnum.ForeColor = System.Drawing.Color.Black;
            this.bnEnum.Location = new System.Drawing.Point(10, 23);
            this.bnEnum.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnEnum.Name = "bnEnum";
            this.bnEnum.Size = new System.Drawing.Size(85, 36);
            this.bnEnum.Style = Sunny.UI.UIStyle.Custom;
            this.bnEnum.TabIndex = 49;
            this.bnEnum.Text = "查找相机";
            this.bnEnum.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnEnum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnEnum.Click += new System.EventHandler(this.bnEnum_Click);
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(338, 12);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(474, 29);
            this.cbDeviceList.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(177, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bnTriggerExec);
            this.groupBox3.Controls.Add(this.cbSoftTrigger);
            this.groupBox3.Controls.Add(this.bnStopGrab);
            this.groupBox3.Controls.Add(this.bnStartGrab);
            this.groupBox3.Controls.Add(this.bnTriggerMode);
            this.groupBox3.Controls.Add(this.bnContinuesMode);
            this.groupBox3.Location = new System.Drawing.Point(3, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 164);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像采集";
            // 
            // bnTriggerExec
            // 
            this.bnTriggerExec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnTriggerExec.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnTriggerExec.ForeColor = System.Drawing.Color.Black;
            this.bnTriggerExec.Location = new System.Drawing.Point(88, 111);
            this.bnTriggerExec.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnTriggerExec.Name = "bnTriggerExec";
            this.bnTriggerExec.Size = new System.Drawing.Size(80, 36);
            this.bnTriggerExec.Style = Sunny.UI.UIStyle.Custom;
            this.bnTriggerExec.TabIndex = 53;
            this.bnTriggerExec.Text = "软触发一次";
            this.bnTriggerExec.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnTriggerExec.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnTriggerExec.Click += new System.EventHandler(this.bnTriggerExec_Click);
            // 
            // cbSoftTrigger
            // 
            this.cbSoftTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSoftTrigger.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSoftTrigger.Location = new System.Drawing.Point(1, 115);
            this.cbSoftTrigger.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbSoftTrigger.Size = new System.Drawing.Size(77, 25);
            this.cbSoftTrigger.TabIndex = 49;
            this.cbSoftTrigger.Text = "软触发";
            this.cbSoftTrigger.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbSoftTrigger.CheckedChanged += new System.EventHandler(this.cbSoftTrigger_CheckedChanged);
            // 
            // bnStopGrab
            // 
            this.bnStopGrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnStopGrab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnStopGrab.ForeColor = System.Drawing.Color.Black;
            this.bnStopGrab.Location = new System.Drawing.Point(88, 61);
            this.bnStopGrab.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnStopGrab.Name = "bnStopGrab";
            this.bnStopGrab.Size = new System.Drawing.Size(80, 36);
            this.bnStopGrab.Style = Sunny.UI.UIStyle.Custom;
            this.bnStopGrab.TabIndex = 52;
            this.bnStopGrab.Text = "停止采集";
            this.bnStopGrab.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnStopGrab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnStopGrab.Click += new System.EventHandler(this.bnStopGrab_Click);
            // 
            // bnStartGrab
            // 
            this.bnStartGrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnStartGrab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnStartGrab.ForeColor = System.Drawing.Color.Black;
            this.bnStartGrab.Location = new System.Drawing.Point(3, 61);
            this.bnStartGrab.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnStartGrab.Name = "bnStartGrab";
            this.bnStartGrab.Size = new System.Drawing.Size(80, 36);
            this.bnStartGrab.Style = Sunny.UI.UIStyle.Custom;
            this.bnStartGrab.TabIndex = 51;
            this.bnStartGrab.Text = "开始采集";
            this.bnStartGrab.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnStartGrab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnStartGrab.Click += new System.EventHandler(this.bnStartGrab_Click);
            // 
            // bnTriggerMode
            // 
            this.bnTriggerMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnTriggerMode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnTriggerMode.Location = new System.Drawing.Point(90, 26);
            this.bnTriggerMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnTriggerMode.Name = "bnTriggerMode";
            this.bnTriggerMode.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.bnTriggerMode.Size = new System.Drawing.Size(80, 29);
            this.bnTriggerMode.TabIndex = 50;
            this.bnTriggerMode.Text = "触发模式";
            this.bnTriggerMode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnTriggerMode.CheckedChanged += new System.EventHandler(this.bnTriggerMode_CheckedChanged);
            // 
            // bnContinuesMode
            // 
            this.bnContinuesMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnContinuesMode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnContinuesMode.Location = new System.Drawing.Point(5, 26);
            this.bnContinuesMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnContinuesMode.Name = "bnContinuesMode";
            this.bnContinuesMode.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.bnContinuesMode.Size = new System.Drawing.Size(80, 29);
            this.bnContinuesMode.TabIndex = 49;
            this.bnContinuesMode.Text = "连续模式";
            this.bnContinuesMode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bnSavePng);
            this.groupBox4.Controls.Add(this.bnSaveTiff);
            this.groupBox4.Controls.Add(this.bnSaveJpg);
            this.groupBox4.Controls.Add(this.bnSaveBmp);
            this.groupBox4.Location = new System.Drawing.Point(3, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 131);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "图像保存";
            // 
            // bnSavePng
            // 
            this.bnSavePng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSavePng.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnSavePng.ForeColor = System.Drawing.Color.Black;
            this.bnSavePng.Location = new System.Drawing.Point(87, 78);
            this.bnSavePng.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnSavePng.Name = "bnSavePng";
            this.bnSavePng.Size = new System.Drawing.Size(80, 36);
            this.bnSavePng.Style = Sunny.UI.UIStyle.Custom;
            this.bnSavePng.TabIndex = 57;
            this.bnSavePng.Text = "保存PNG";
            this.bnSavePng.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSavePng.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnSavePng.Click += new System.EventHandler(this.bnSavePng_Click);
            // 
            // bnSaveTiff
            // 
            this.bnSaveTiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSaveTiff.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnSaveTiff.ForeColor = System.Drawing.Color.Black;
            this.bnSaveTiff.Location = new System.Drawing.Point(1, 78);
            this.bnSaveTiff.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnSaveTiff.Name = "bnSaveTiff";
            this.bnSaveTiff.Size = new System.Drawing.Size(80, 36);
            this.bnSaveTiff.Style = Sunny.UI.UIStyle.Custom;
            this.bnSaveTiff.TabIndex = 56;
            this.bnSaveTiff.Text = "保存TIFF";
            this.bnSaveTiff.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSaveTiff.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnSaveTiff.Click += new System.EventHandler(this.bnSaveTiff_Click);
            // 
            // bnSaveJpg
            // 
            this.bnSaveJpg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSaveJpg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnSaveJpg.ForeColor = System.Drawing.Color.Black;
            this.bnSaveJpg.Location = new System.Drawing.Point(88, 28);
            this.bnSaveJpg.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnSaveJpg.Name = "bnSaveJpg";
            this.bnSaveJpg.Size = new System.Drawing.Size(80, 36);
            this.bnSaveJpg.Style = Sunny.UI.UIStyle.Custom;
            this.bnSaveJpg.TabIndex = 55;
            this.bnSaveJpg.Text = "保存JPG";
            this.bnSaveJpg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSaveJpg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnSaveJpg.Click += new System.EventHandler(this.bnSaveJpg_Click);
            // 
            // bnSaveBmp
            // 
            this.bnSaveBmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSaveBmp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnSaveBmp.ForeColor = System.Drawing.Color.Black;
            this.bnSaveBmp.Location = new System.Drawing.Point(3, 28);
            this.bnSaveBmp.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnSaveBmp.Name = "bnSaveBmp";
            this.bnSaveBmp.Size = new System.Drawing.Size(80, 36);
            this.bnSaveBmp.Style = Sunny.UI.UIStyle.Custom;
            this.bnSaveBmp.TabIndex = 54;
            this.bnSaveBmp.Text = "保存BMP";
            this.bnSaveBmp.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSaveBmp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.groupBox5.Location = new System.Drawing.Point(1, 401);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 188);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "参数设置";
            // 
            // bnSetParam
            // 
            this.bnSetParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSetParam.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnSetParam.ForeColor = System.Drawing.Color.Black;
            this.bnSetParam.Location = new System.Drawing.Point(87, 140);
            this.bnSetParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnSetParam.Name = "bnSetParam";
            this.bnSetParam.Size = new System.Drawing.Size(80, 36);
            this.bnSetParam.Style = Sunny.UI.UIStyle.Custom;
            this.bnSetParam.TabIndex = 58;
            this.bnSetParam.Text = "设置参数";
            this.bnSetParam.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSetParam.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnSetParam.Click += new System.EventHandler(this.bnSetParam_Click);
            // 
            // bnGetParam
            // 
            this.bnGetParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnGetParam.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bnGetParam.ForeColor = System.Drawing.Color.Black;
            this.bnGetParam.Location = new System.Drawing.Point(2, 140);
            this.bnGetParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.bnGetParam.Name = "bnGetParam";
            this.bnGetParam.Size = new System.Drawing.Size(80, 36);
            this.bnGetParam.Style = Sunny.UI.UIStyle.Custom;
            this.bnGetParam.TabIndex = 57;
            this.bnGetParam.Text = "获取参数";
            this.bnGetParam.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnGetParam.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.bnGetParam.Click += new System.EventHandler(this.bnGetParam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "帧率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(4, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "增益";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "曝光";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Enabled = false;
            this.tbFrameRate.Location = new System.Drawing.Point(75, 95);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(93, 29);
            this.tbFrameRate.TabIndex = 2;
            // 
            // tbGain
            // 
            this.tbGain.Enabled = false;
            this.tbGain.Location = new System.Drawing.Point(75, 60);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(93, 29);
            this.tbGain.TabIndex = 1;
            // 
            // tbExposure
            // 
            this.tbExposure.Enabled = false;
            this.tbExposure.Location = new System.Drawing.Point(74, 28);
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(93, 29);
            this.tbExposure.TabIndex = 0;
            // 
            // InitializationMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 720);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbDeviceList);
            this.Controls.Add(this.groupBox1);
            this.Name = "InitializationMode";
            this.Text = "初始化模式";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIButton bnEnum;
        private Sunny.UI.UIButton bnOpen;
        private Sunny.UI.UIButton bnClose;
        private Sunny.UI.UIRadioButton bnContinuesMode;
        private Sunny.UI.UIRadioButton bnTriggerMode;
        private Sunny.UI.UIButton bnStartGrab;
        private Sunny.UI.UIButton bnStopGrab;
        private Sunny.UI.UICheckBox cbSoftTrigger;
        private Sunny.UI.UIButton bnTriggerExec;
        private System.Windows.Forms.GroupBox groupBox4;
        private Sunny.UI.UIButton bnSaveBmp;
        private Sunny.UI.UIButton bnSaveJpg;
        private Sunny.UI.UIButton bnSaveTiff;
        private Sunny.UI.UIButton bnSavePng;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrameRate;
        private System.Windows.Forms.TextBox tbGain;
        private System.Windows.Forms.TextBox tbExposure;
        private Sunny.UI.UIButton bnGetParam;
        private Sunny.UI.UIButton bnSetParam;
    }
}