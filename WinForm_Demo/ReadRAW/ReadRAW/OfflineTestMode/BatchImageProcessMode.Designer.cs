namespace ReadRAW.OfflineTestMode
{
    partial class BatchImageProcessMode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiButton1_Cancel = new Sunny.UI.UIButton();
            this.uiButton1_Load_folderImg = new Sunny.UI.UIButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseBitFormatUiComboBox1 = new Sunny.UI.UIComboBox();
            this.lowThresholdTextBox2 = new System.Windows.Forms.TextBox();
            this.testModeUiComboBox2 = new Sunny.UI.UIComboBox();
            this.imgBitFormaLabel1 = new System.Windows.Forms.Label();
            this.upperThresholdLabel3 = new System.Windows.Forms.Label();
            this.testModeLabel2 = new System.Windows.Forms.Label();
            this.upThresholdTextBox1 = new System.Windows.Forms.TextBox();
            this.lowerThresholdLabel4 = new System.Windows.Forms.Label();
            this.imgFormatUiComboBox1 = new Sunny.UI.UIComboBox();
            this.imageFormatLabel1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.heatmapTypeUiComboBox1 = new Sunny.UI.UIComboBox();
            this.showModeUiComboBox3 = new Sunny.UI.UIComboBox();
            this.heatMapLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(141, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uiButton1_Cancel);
            this.groupBox1.Controls.Add(this.uiButton1_Load_folderImg);
            this.groupBox1.Location = new System.Drawing.Point(672, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 145);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像操作";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 92;
            this.label1.Text = "提示：";
            // 
            // uiButton1_Cancel
            // 
            this.uiButton1_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1_Cancel.ForeColor = System.Drawing.Color.Black;
            this.uiButton1_Cancel.Location = new System.Drawing.Point(10, 96);
            this.uiButton1_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1_Cancel.Name = "uiButton1_Cancel";
            this.uiButton1_Cancel.Size = new System.Drawing.Size(90, 45);
            this.uiButton1_Cancel.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1_Cancel.TabIndex = 91;
            this.uiButton1_Cancel.Text = "取消测试";
            this.uiButton1_Cancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1_Cancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1_Cancel.Click += new System.EventHandler(this.uiButton1_Cancel_Click);
            // 
            // uiButton1_Load_folderImg
            // 
            this.uiButton1_Load_folderImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1_Load_folderImg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1_Load_folderImg.ForeColor = System.Drawing.Color.Black;
            this.uiButton1_Load_folderImg.Location = new System.Drawing.Point(10, 45);
            this.uiButton1_Load_folderImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1_Load_folderImg.Name = "uiButton1_Load_folderImg";
            this.uiButton1_Load_folderImg.Size = new System.Drawing.Size(90, 45);
            this.uiButton1_Load_folderImg.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1_Load_folderImg.TabIndex = 8;
            this.uiButton1_Load_folderImg.Text = "测试文件夹";
            this.uiButton1_Load_folderImg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1_Load_folderImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1_Load_folderImg.Click += new System.EventHandler(this.uiButton1_Load_folderImg_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(141, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(640, 23);
            this.progressBar1.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 90;
            this.label2.Text = "图像数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "进度条信息：";
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
            this.groupBox2.Location = new System.Drawing.Point(5, 540);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 150);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试参数选择";
            // 
            // chooseBitFormatUiComboBox1
            // 
            this.chooseBitFormatUiComboBox1.DataSource = null;
            this.chooseBitFormatUiComboBox1.FillColor = System.Drawing.Color.White;
            this.chooseBitFormatUiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseBitFormatUiComboBox1.Location = new System.Drawing.Point(102, 50);
            this.chooseBitFormatUiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseBitFormatUiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.chooseBitFormatUiComboBox1.Name = "chooseBitFormatUiComboBox1";
            this.chooseBitFormatUiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.chooseBitFormatUiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.chooseBitFormatUiComboBox1.TabIndex = 92;
            this.chooseBitFormatUiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseBitFormatUiComboBox1.Watermark = "";
            this.chooseBitFormatUiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.chooseBitFormatUiComboBox1.SelectedIndexChanged += new System.EventHandler(this.chooseBitFormatUiComboBox1_SelectedIndexChanged);
            // 
            // lowThresholdTextBox2
            // 
            this.lowThresholdTextBox2.Location = new System.Drawing.Point(305, 114);
            this.lowThresholdTextBox2.Name = "lowThresholdTextBox2";
            this.lowThresholdTextBox2.Size = new System.Drawing.Size(100, 29);
            this.lowThresholdTextBox2.TabIndex = 90;
            this.lowThresholdTextBox2.Text = "200";
            // 
            // testModeUiComboBox2
            // 
            this.testModeUiComboBox2.DataSource = null;
            this.testModeUiComboBox2.DropDownWidth = 300;
            this.testModeUiComboBox2.FillColor = System.Drawing.Color.White;
            this.testModeUiComboBox2.FilterMaxCount = 50;
            this.testModeUiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.testModeUiComboBox2.Location = new System.Drawing.Point(102, 83);
            this.testModeUiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testModeUiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.testModeUiComboBox2.Name = "testModeUiComboBox2";
            this.testModeUiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.testModeUiComboBox2.Size = new System.Drawing.Size(150, 29);
            this.testModeUiComboBox2.TabIndex = 77;
            this.testModeUiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.testModeUiComboBox2.Watermark = "";
            this.testModeUiComboBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.testModeUiComboBox2.SelectedIndexChanged += new System.EventHandler(this.testModeUiComboBox2_SelectedIndexChanged);
            // 
            // imgBitFormaLabel1
            // 
            this.imgBitFormaLabel1.AutoSize = true;
            this.imgBitFormaLabel1.Location = new System.Drawing.Point(11, 52);
            this.imgBitFormaLabel1.Name = "imgBitFormaLabel1";
            this.imgBitFormaLabel1.Size = new System.Drawing.Size(90, 21);
            this.imgBitFormaLabel1.TabIndex = 91;
            this.imgBitFormaLabel1.Text = "位数选择：";
            // 
            // upperThresholdLabel3
            // 
            this.upperThresholdLabel3.AutoSize = true;
            this.upperThresholdLabel3.Location = new System.Drawing.Point(11, 118);
            this.upperThresholdLabel3.Name = "upperThresholdLabel3";
            this.upperThresholdLabel3.Size = new System.Drawing.Size(90, 21);
            this.upperThresholdLabel3.TabIndex = 87;
            this.upperThresholdLabel3.Text = "阈值上限：";
            this.upperThresholdLabel3.Visible = false;
            // 
            // testModeLabel2
            // 
            this.testModeLabel2.AutoSize = true;
            this.testModeLabel2.Location = new System.Drawing.Point(11, 86);
            this.testModeLabel2.Name = "testModeLabel2";
            this.testModeLabel2.Size = new System.Drawing.Size(90, 21);
            this.testModeLabel2.TabIndex = 84;
            this.testModeLabel2.Text = "测试模式：";
            // 
            // upThresholdTextBox1
            // 
            this.upThresholdTextBox1.Location = new System.Drawing.Point(102, 114);
            this.upThresholdTextBox1.Name = "upThresholdTextBox1";
            this.upThresholdTextBox1.Size = new System.Drawing.Size(100, 29);
            this.upThresholdTextBox1.TabIndex = 89;
            this.upThresholdTextBox1.Text = "5000";
            // 
            // lowerThresholdLabel4
            // 
            this.lowerThresholdLabel4.AutoSize = true;
            this.lowerThresholdLabel4.Location = new System.Drawing.Point(212, 117);
            this.lowerThresholdLabel4.Name = "lowerThresholdLabel4";
            this.lowerThresholdLabel4.Size = new System.Drawing.Size(90, 21);
            this.lowerThresholdLabel4.TabIndex = 88;
            this.lowerThresholdLabel4.Text = "阈值下限：";
            this.lowerThresholdLabel4.Visible = false;
            // 
            // imgFormatUiComboBox1
            // 
            this.imgFormatUiComboBox1.DataSource = null;
            this.imgFormatUiComboBox1.FillColor = System.Drawing.Color.White;
            this.imgFormatUiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imgFormatUiComboBox1.Location = new System.Drawing.Point(102, 17);
            this.imgFormatUiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgFormatUiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.imgFormatUiComboBox1.Name = "imgFormatUiComboBox1";
            this.imgFormatUiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.imgFormatUiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.imgFormatUiComboBox1.TabIndex = 12;
            this.imgFormatUiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgFormatUiComboBox1.Watermark = "";
            this.imgFormatUiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.imgFormatUiComboBox1.SelectedIndexChanged += new System.EventHandler(this.imgFormatUiComboBox1_SelectedIndexChanged);
            // 
            // imageFormatLabel1
            // 
            this.imageFormatLabel1.AutoSize = true;
            this.imageFormatLabel1.Location = new System.Drawing.Point(11, 21);
            this.imageFormatLabel1.Name = "imageFormatLabel1";
            this.imageFormatLabel1.Size = new System.Drawing.Size(90, 21);
            this.imageFormatLabel1.TabIndex = 83;
            this.imageFormatLabel1.Text = "图像格式：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.heatmapTypeUiComboBox1);
            this.groupBox4.Controls.Add(this.showModeUiComboBox3);
            this.groupBox4.Controls.Add(this.heatMapLabel1);
            this.groupBox4.Location = new System.Drawing.Point(477, 540);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 131);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "显示模式选择";
            // 
            // heatmapTypeUiComboBox1
            // 
            this.heatmapTypeUiComboBox1.DataSource = null;
            this.heatmapTypeUiComboBox1.DropDownWidth = 300;
            this.heatmapTypeUiComboBox1.FillColor = System.Drawing.Color.White;
            this.heatmapTypeUiComboBox1.FilterMaxCount = 50;
            this.heatmapTypeUiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.heatmapTypeUiComboBox1.Location = new System.Drawing.Point(7, 94);
            this.heatmapTypeUiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heatmapTypeUiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.heatmapTypeUiComboBox1.Name = "heatmapTypeUiComboBox1";
            this.heatmapTypeUiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.heatmapTypeUiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.heatmapTypeUiComboBox1.TabIndex = 95;
            this.heatmapTypeUiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.heatmapTypeUiComboBox1.Watermark = "";
            this.heatmapTypeUiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.heatmapTypeUiComboBox1.SelectedIndexChanged += new System.EventHandler(this.heatmapTypeUiComboBox1_SelectedIndexChanged);
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
            this.showModeUiComboBox3.SelectedIndexChanged += new System.EventHandler(this.showModeUiComboBox3_SelectedIndexChanged);
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
            // BatchImageProcessMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 720);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BatchImageProcessMode";
            this.Text = "批量图像处理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIButton uiButton1_Load_folderImg;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Sunny.UI.UIButton uiButton1_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIComboBox chooseBitFormatUiComboBox1;
        private System.Windows.Forms.TextBox lowThresholdTextBox2;
        private Sunny.UI.UIComboBox testModeUiComboBox2;
        private System.Windows.Forms.Label imgBitFormaLabel1;
        private System.Windows.Forms.Label upperThresholdLabel3;
        private System.Windows.Forms.Label testModeLabel2;
        private System.Windows.Forms.TextBox upThresholdTextBox1;
        private System.Windows.Forms.Label lowerThresholdLabel4;
        private Sunny.UI.UIComboBox imgFormatUiComboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Sunny.UI.UIComboBox heatmapTypeUiComboBox1;
        private Sunny.UI.UIComboBox showModeUiComboBox3;
        private System.Windows.Forms.Label heatMapLabel1;
        private System.Windows.Forms.Label imageFormatLabel1;
    }
}