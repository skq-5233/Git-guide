namespace ReadRAW.OfflineTestMode
{
    partial class SingleImageProcessMode
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Autumn");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bone");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Jet");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Winter");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rainbow");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ocean");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Summer");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Spring");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cool");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Hsv");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Pink");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Hot");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Parula");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Magma");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Inferno");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Plasma");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Viridis");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Cividis");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Twilight");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("TwilightShifted");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Turbo");
            this.uiButton1_Load_Img = new Sunny.UI.UIButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiButton2_SaveImg = new Sunny.UI.UIButton();
            this.imgFormatUiComboBox1 = new Sunny.UI.UIComboBox();
            this.testModeUiComboBox2 = new Sunny.UI.UIComboBox();
            this.heatmapUiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            this.imageFormatLabel1 = new System.Windows.Forms.Label();
            this.testModeLabel2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upperThresholdLabel3 = new System.Windows.Forms.Label();
            this.lowerThresholdLabel4 = new System.Windows.Forms.Label();
            this.upThresholdTextBox1 = new System.Windows.Forms.TextBox();
            this.lowThresholdTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseBitFormatUiComboBox1 = new Sunny.UI.UIComboBox();
            this.imgBitFormaLabel1 = new System.Windows.Forms.Label();
            this.heatMapLabel1 = new System.Windows.Forms.Label();
            this.pixelValueLabel1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.showModeUiComboBox3 = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1_Load_Img
            // 
            this.uiButton1_Load_Img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1_Load_Img.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1_Load_Img.Location = new System.Drawing.Point(14, 34);
            this.uiButton1_Load_Img.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1_Load_Img.Name = "uiButton1_Load_Img";
            this.uiButton1_Load_Img.Size = new System.Drawing.Size(100, 52);
            this.uiButton1_Load_Img.TabIndex = 8;
            this.uiButton1_Load_Img.Text = "打开图像";
            this.uiButton1_Load_Img.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1_Load_Img.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1_Load_Img.Click += new System.EventHandler(this.Load_Raw_Img_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // uiButton2_SaveImg
            // 
            this.uiButton2_SaveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2_SaveImg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2_SaveImg.Location = new System.Drawing.Point(14, 109);
            this.uiButton2_SaveImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2_SaveImg.Name = "uiButton2_SaveImg";
            this.uiButton2_SaveImg.Size = new System.Drawing.Size(100, 52);
            this.uiButton2_SaveImg.TabIndex = 11;
            this.uiButton2_SaveImg.Text = "保存图像";
            this.uiButton2_SaveImg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2_SaveImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2_SaveImg.Click += new System.EventHandler(this.SaveImg_Click);
            // 
            // imgFormatUiComboBox1
            // 
            this.imgFormatUiComboBox1.DataSource = null;
            this.imgFormatUiComboBox1.FillColor = System.Drawing.Color.White;
            this.imgFormatUiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imgFormatUiComboBox1.Location = new System.Drawing.Point(102, 19);
            this.imgFormatUiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgFormatUiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.imgFormatUiComboBox1.Name = "imgFormatUiComboBox1";
            this.imgFormatUiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.imgFormatUiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.imgFormatUiComboBox1.TabIndex = 12;
            this.imgFormatUiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgFormatUiComboBox1.Watermark = "";
            this.imgFormatUiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.imgFormatUiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // testModeUiComboBox2
            // 
            this.testModeUiComboBox2.DataSource = null;
            this.testModeUiComboBox2.DropDownWidth = 300;
            this.testModeUiComboBox2.FillColor = System.Drawing.Color.White;
            this.testModeUiComboBox2.FilterMaxCount = 50;
            this.testModeUiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.testModeUiComboBox2.Location = new System.Drawing.Point(102, 86);
            this.testModeUiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testModeUiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.testModeUiComboBox2.Name = "testModeUiComboBox2";
            this.testModeUiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.testModeUiComboBox2.Size = new System.Drawing.Size(150, 29);
            this.testModeUiComboBox2.TabIndex = 77;
            this.testModeUiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.testModeUiComboBox2.Watermark = "";
            this.testModeUiComboBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.testModeUiComboBox2.SelectedIndexChanged += new System.EventHandler(this.uiComboBox2_SelectedIndexChanged);
            // 
            // heatmapUiComboTreeView1
            // 
            this.heatmapUiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.heatmapUiComboTreeView1.FillColor = System.Drawing.Color.White;
            this.heatmapUiComboTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heatmapUiComboTreeView1.Location = new System.Drawing.Point(10, 91);
            this.heatmapUiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heatmapUiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.heatmapUiComboTreeView1.Name = "heatmapUiComboTreeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "Autumn";
            treeNode2.Name = "节点0";
            treeNode2.Text = "Bone";
            treeNode3.Name = "节点1";
            treeNode3.Text = "Jet";
            treeNode4.Name = "节点2";
            treeNode4.Text = "Winter";
            treeNode5.Name = "节点3";
            treeNode5.Text = "Rainbow";
            treeNode6.Name = "节点4";
            treeNode6.Text = "Ocean";
            treeNode7.Name = "节点5";
            treeNode7.Text = "Summer";
            treeNode8.Name = "节点6";
            treeNode8.Text = "Spring";
            treeNode9.Name = "节点7";
            treeNode9.Text = "Cool";
            treeNode10.Name = "节点8";
            treeNode10.Text = "Hsv";
            treeNode11.Name = "节点9";
            treeNode11.Text = "Pink";
            treeNode12.Name = "节点10";
            treeNode12.Text = "Hot";
            treeNode13.Name = "节点11";
            treeNode13.Text = "Parula";
            treeNode14.Name = "节点12";
            treeNode14.Text = "Magma";
            treeNode15.Name = "节点13";
            treeNode15.Text = "Inferno";
            treeNode16.Name = "节点14";
            treeNode16.Text = "Plasma";
            treeNode17.Name = "节点15";
            treeNode17.Text = "Viridis";
            treeNode18.Name = "节点16";
            treeNode18.Text = "Cividis";
            treeNode19.Name = "节点17";
            treeNode19.Text = "Twilight";
            treeNode20.Name = "节点18";
            treeNode20.Text = "TwilightShifted";
            treeNode21.Name = "节点19";
            treeNode21.Text = "Turbo";
            this.heatmapUiComboTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.heatmapUiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.heatmapUiComboTreeView1.Size = new System.Drawing.Size(150, 29);
            this.heatmapUiComboTreeView1.TabIndex = 82;
            this.heatmapUiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.heatmapUiComboTreeView1.Visible = false;
            this.heatmapUiComboTreeView1.Watermark = "";
            this.heatmapUiComboTreeView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // imageFormatLabel1
            // 
            this.imageFormatLabel1.AutoSize = true;
            this.imageFormatLabel1.Location = new System.Drawing.Point(11, 23);
            this.imageFormatLabel1.Name = "imageFormatLabel1";
            this.imageFormatLabel1.Size = new System.Drawing.Size(90, 21);
            this.imageFormatLabel1.TabIndex = 83;
            this.imageFormatLabel1.Text = "图像格式：";
            // 
            // testModeLabel2
            // 
            this.testModeLabel2.AutoSize = true;
            this.testModeLabel2.Location = new System.Drawing.Point(11, 89);
            this.testModeLabel2.Name = "testModeLabel2";
            this.testModeLabel2.Size = new System.Drawing.Size(90, 21);
            this.testModeLabel2.TabIndex = 84;
            this.testModeLabel2.Text = "测试模式：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiButton1_Load_Img);
            this.groupBox1.Controls.Add(this.uiButton2_SaveImg);
            this.groupBox1.Location = new System.Drawing.Point(33, 516);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 168);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像操作";
            // 
            // upperThresholdLabel3
            // 
            this.upperThresholdLabel3.AutoSize = true;
            this.upperThresholdLabel3.Location = new System.Drawing.Point(11, 121);
            this.upperThresholdLabel3.Name = "upperThresholdLabel3";
            this.upperThresholdLabel3.Size = new System.Drawing.Size(90, 21);
            this.upperThresholdLabel3.TabIndex = 87;
            this.upperThresholdLabel3.Text = "阈值上限：";
            this.upperThresholdLabel3.Visible = false;
            // 
            // lowerThresholdLabel4
            // 
            this.lowerThresholdLabel4.AutoSize = true;
            this.lowerThresholdLabel4.Location = new System.Drawing.Point(11, 146);
            this.lowerThresholdLabel4.Name = "lowerThresholdLabel4";
            this.lowerThresholdLabel4.Size = new System.Drawing.Size(90, 21);
            this.lowerThresholdLabel4.TabIndex = 88;
            this.lowerThresholdLabel4.Text = "阈值下限：";
            this.lowerThresholdLabel4.Visible = false;
            // 
            // upThresholdTextBox1
            // 
            this.upThresholdTextBox1.Location = new System.Drawing.Point(102, 117);
            this.upThresholdTextBox1.Name = "upThresholdTextBox1";
            this.upThresholdTextBox1.Size = new System.Drawing.Size(100, 29);
            this.upThresholdTextBox1.TabIndex = 89;
            this.upThresholdTextBox1.Text = "0";
            // 
            // lowThresholdTextBox2
            // 
            this.lowThresholdTextBox2.Location = new System.Drawing.Point(102, 148);
            this.lowThresholdTextBox2.Name = "lowThresholdTextBox2";
            this.lowThresholdTextBox2.Size = new System.Drawing.Size(100, 29);
            this.lowThresholdTextBox2.TabIndex = 90;
            this.lowThresholdTextBox2.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chooseBitFormatUiComboBox1);
            this.groupBox2.Controls.Add(this.lowThresholdTextBox2);
            this.groupBox2.Controls.Add(this.testModeUiComboBox2);
            this.groupBox2.Controls.Add(this.imgBitFormaLabel1);
            this.groupBox2.Controls.Add(this.upperThresholdLabel3);
            this.groupBox2.Controls.Add(this.testModeLabel2);
            this.groupBox2.Controls.Add(this.upThresholdTextBox1);
            this.groupBox2.Controls.Add(this.lowerThresholdLabel4);
            this.groupBox2.Controls.Add(this.imgFormatUiComboBox1);
            this.groupBox2.Controls.Add(this.imageFormatLabel1);
            this.groupBox2.Location = new System.Drawing.Point(208, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 180);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试参数选择";
            // 
            // chooseBitFormatUiComboBox1
            // 
            this.chooseBitFormatUiComboBox1.DataSource = null;
            this.chooseBitFormatUiComboBox1.FillColor = System.Drawing.Color.White;
            this.chooseBitFormatUiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseBitFormatUiComboBox1.Location = new System.Drawing.Point(102, 53);
            this.chooseBitFormatUiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseBitFormatUiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.chooseBitFormatUiComboBox1.Name = "chooseBitFormatUiComboBox1";
            this.chooseBitFormatUiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.chooseBitFormatUiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.chooseBitFormatUiComboBox1.TabIndex = 92;
            this.chooseBitFormatUiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseBitFormatUiComboBox1.Visible = false;
            this.chooseBitFormatUiComboBox1.Watermark = "";
            this.chooseBitFormatUiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.chooseBitFormatUiComboBox1.SelectedIndexChanged += new System.EventHandler(this.chooseFormatUiComboBox1_SelectedIndexChanged);
            // 
            // imgBitFormaLabel1
            // 
            this.imgBitFormaLabel1.AutoSize = true;
            this.imgBitFormaLabel1.Location = new System.Drawing.Point(11, 55);
            this.imgBitFormaLabel1.Name = "imgBitFormaLabel1";
            this.imgBitFormaLabel1.Size = new System.Drawing.Size(90, 21);
            this.imgBitFormaLabel1.TabIndex = 91;
            this.imgBitFormaLabel1.Text = "位数选择：";
            this.imgBitFormaLabel1.Visible = false;
            // 
            // heatMapLabel1
            // 
            this.heatMapLabel1.AutoSize = true;
            this.heatMapLabel1.Location = new System.Drawing.Point(6, 68);
            this.heatMapLabel1.Name = "heatMapLabel1";
            this.heatMapLabel1.Size = new System.Drawing.Size(90, 21);
            this.heatMapLabel1.TabIndex = 91;
            this.heatMapLabel1.Text = "颜色类型：";
            this.heatMapLabel1.Visible = false;
            // 
            // pixelValueLabel1
            // 
            this.pixelValueLabel1.AutoSize = true;
            this.pixelValueLabel1.Location = new System.Drawing.Point(5, 29);
            this.pixelValueLabel1.Name = "pixelValueLabel1";
            this.pixelValueLabel1.Size = new System.Drawing.Size(122, 21);
            this.pixelValueLabel1.TabIndex = 92;
            this.pixelValueLabel1.Text = "像素值及坐标：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pixelValueLabel1);
            this.groupBox3.Location = new System.Drawing.Point(688, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 103);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "像素信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.showModeUiComboBox3);
            this.groupBox4.Controls.Add(this.heatMapLabel1);
            this.groupBox4.Controls.Add(this.heatmapUiComboTreeView1);
            this.groupBox4.Location = new System.Drawing.Point(554, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 168);
            this.groupBox4.TabIndex = 94;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "显示模式选择";
            // 
            // showModeUiComboBox3
            // 
            this.showModeUiComboBox3.DataSource = null;
            this.showModeUiComboBox3.DropDownWidth = 300;
            this.showModeUiComboBox3.FillColor = System.Drawing.Color.White;
            this.showModeUiComboBox3.FilterMaxCount = 50;
            this.showModeUiComboBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.showModeUiComboBox3.Location = new System.Drawing.Point(7, 27);
            this.showModeUiComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showModeUiComboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.showModeUiComboBox3.Name = "showModeUiComboBox3";
            this.showModeUiComboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.showModeUiComboBox3.Size = new System.Drawing.Size(150, 29);
            this.showModeUiComboBox3.TabIndex = 78;
            this.showModeUiComboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.showModeUiComboBox3.Watermark = "";
            this.showModeUiComboBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.showModeUiComboBox3.SelectedIndexChanged += new System.EventHandler(this.uiComboBox3_SelectedIndexChanged);
            // 
            // SingleImageProcessMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 720);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SingleImageProcessMode";
            this.Text = "单图像处理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1_Load_Img;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIButton uiButton2_SaveImg;
        private Sunny.UI.UIComboBox imgFormatUiComboBox1;
        private Sunny.UI.UIComboBox testModeUiComboBox2;
        private Sunny.UI.UIComboTreeView heatmapUiComboTreeView1;
        private System.Windows.Forms.Label imageFormatLabel1;
        private System.Windows.Forms.Label testModeLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label upperThresholdLabel3;
        private System.Windows.Forms.Label lowerThresholdLabel4;
        private System.Windows.Forms.TextBox upThresholdTextBox1;
        private System.Windows.Forms.TextBox lowThresholdTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label heatMapLabel1;
        private System.Windows.Forms.Label pixelValueLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Sunny.UI.UIComboBox showModeUiComboBox3;
        private System.Windows.Forms.Label imgBitFormaLabel1;
        private Sunny.UI.UIComboBox chooseBitFormatUiComboBox1;
    }
}