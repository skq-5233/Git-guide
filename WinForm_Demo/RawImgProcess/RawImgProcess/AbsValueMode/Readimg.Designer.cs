namespace RawImgProcess.AbsValueMode
{
    partial class Readimg
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
            this.uiButton1_Load_Img = new Sunny.UI.UIButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiButton2_SaveImg = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton1_Load_Img
            // 
            this.uiButton1_Load_Img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1_Load_Img.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1_Load_Img.Location = new System.Drawing.Point(12, 40);
            this.uiButton1_Load_Img.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1_Load_Img.Name = "uiButton1_Load_Img";
            this.uiButton1_Load_Img.Size = new System.Drawing.Size(133, 52);
            this.uiButton1_Load_Img.TabIndex = 8;
            this.uiButton1_Load_Img.Text = "打开图像";
            this.uiButton1_Load_Img.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1_Load_Img.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1_Load_Img.Click += new System.EventHandler(this.uiButton_LoadImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(398, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 512);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "图像信息：";
            // 
            // uiButton2_SaveImg
            // 
            this.uiButton2_SaveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2_SaveImg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2_SaveImg.Location = new System.Drawing.Point(12, 120);
            this.uiButton2_SaveImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2_SaveImg.Name = "uiButton2_SaveImg";
            this.uiButton2_SaveImg.Size = new System.Drawing.Size(133, 52);
            this.uiButton2_SaveImg.TabIndex = 11;
            this.uiButton2_SaveImg.Text = "保存图像";
            this.uiButton2_SaveImg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2_SaveImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2_SaveImg.Click += new System.EventHandler(this.Save_Img_Click);
            // 
            // Readimg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 726);
            this.Controls.Add(this.uiButton2_SaveImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiButton1_Load_Img);
            this.Name = "Readimg";
            this.Text = "打开并保存图像";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton uiButton1_Load_Img;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton uiButton2_SaveImg;
    }
}