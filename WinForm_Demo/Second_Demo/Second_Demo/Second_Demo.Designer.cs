namespace Second_Demo
{
    partial class Second_Demo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt1_Create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt4_Circle = new System.Windows.Forms.Button();
            this.bt3_Line = new System.Windows.Forms.Button();
            this.bt2_LoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt5_Rectangle = new System.Windows.Forms.Button();
            this.bt6_Ellipse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt1_DrawLine_Auto = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt2_DrawCircle_Auto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(361, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt1_Create
            // 
            this.bt1_Create.Location = new System.Drawing.Point(15, 22);
            this.bt1_Create.Name = "bt1_Create";
            this.bt1_Create.Size = new System.Drawing.Size(84, 39);
            this.bt1_Create.TabIndex = 1;
            this.bt1_Create.Text = "创建图像";
            this.bt1_Create.UseVisualStyleBackColor = true;
            this.bt1_Create.Click += new System.EventHandler(this.CreateImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(35, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 537);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绘图";
            // 
            // bt4_Circle
            // 
            this.bt4_Circle.Location = new System.Drawing.Point(15, 180);
            this.bt4_Circle.Name = "bt4_Circle";
            this.bt4_Circle.Size = new System.Drawing.Size(84, 28);
            this.bt4_Circle.TabIndex = 5;
            this.bt4_Circle.Text = "添加圆";
            this.bt4_Circle.UseVisualStyleBackColor = true;
            this.bt4_Circle.Click += new System.EventHandler(this.drawcircle_Click);
            // 
            // bt3_Line
            // 
            this.bt3_Line.Location = new System.Drawing.Point(15, 131);
            this.bt3_Line.Name = "bt3_Line";
            this.bt3_Line.Size = new System.Drawing.Size(84, 31);
            this.bt3_Line.TabIndex = 4;
            this.bt3_Line.Text = "添加线段";
            this.bt3_Line.UseVisualStyleBackColor = true;
            this.bt3_Line.Click += new System.EventHandler(this.drawline_Click);
            // 
            // bt2_LoadImage
            // 
            this.bt2_LoadImage.Location = new System.Drawing.Point(15, 79);
            this.bt2_LoadImage.Name = "bt2_LoadImage";
            this.bt2_LoadImage.Size = new System.Drawing.Size(84, 34);
            this.bt2_LoadImage.TabIndex = 3;
            this.bt2_LoadImage.Text = "加载图像";
            this.bt2_LoadImage.UseVisualStyleBackColor = true;
            this.bt2_LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(589, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "显示图像";
            // 
            // bt5_Rectangle
            // 
            this.bt5_Rectangle.Location = new System.Drawing.Point(15, 226);
            this.bt5_Rectangle.Name = "bt5_Rectangle";
            this.bt5_Rectangle.Size = new System.Drawing.Size(84, 33);
            this.bt5_Rectangle.TabIndex = 6;
            this.bt5_Rectangle.Text = "添加矩形";
            this.bt5_Rectangle.UseVisualStyleBackColor = true;
            this.bt5_Rectangle.Click += new System.EventHandler(this.drawrectangle_Click);
            // 
            // bt6_Ellipse
            // 
            this.bt6_Ellipse.Location = new System.Drawing.Point(15, 277);
            this.bt6_Ellipse.Name = "bt6_Ellipse";
            this.bt6_Ellipse.Size = new System.Drawing.Size(84, 35);
            this.bt6_Ellipse.TabIndex = 7;
            this.bt6_Ellipse.Text = "添加椭圆";
            this.bt6_Ellipse.UseVisualStyleBackColor = true;
            this.bt6_Ellipse.Click += new System.EventHandler(this.drawellipse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt1_Create);
            this.groupBox2.Controls.Add(this.bt6_Ellipse);
            this.groupBox2.Controls.Add(this.bt2_LoadImage);
            this.groupBox2.Controls.Add(this.bt5_Rectangle);
            this.groupBox2.Controls.Add(this.bt3_Line);
            this.groupBox2.Controls.Add(this.bt4_Circle);
            this.groupBox2.Location = new System.Drawing.Point(16, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 334);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处理单幅图像";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt2_DrawCircle_Auto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.bt1_DrawLine_Auto);
            this.groupBox3.Location = new System.Drawing.Point(159, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 334);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "处理多幅图像";
            // 
            // bt1_DrawLine_Auto
            // 
            this.bt1_DrawLine_Auto.Location = new System.Drawing.Point(9, 58);
            this.bt1_DrawLine_Auto.Name = "bt1_DrawLine_Auto";
            this.bt1_DrawLine_Auto.Size = new System.Drawing.Size(84, 31);
            this.bt1_DrawLine_Auto.TabIndex = 5;
            this.bt1_DrawLine_Auto.Text = "添加线段";
            this.bt1_DrawLine_Auto.UseVisualStyleBackColor = true;
            this.bt1_DrawLine_Auto.Click += new System.EventHandler(this.drawlinefolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "提示：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "图像数量：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(361, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(495, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "当前进度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "图像名称：";
            // 
            // bt2_DrawCircle_Auto
            // 
            this.bt2_DrawCircle_Auto.Location = new System.Drawing.Point(9, 116);
            this.bt2_DrawCircle_Auto.Name = "bt2_DrawCircle_Auto";
            this.bt2_DrawCircle_Auto.Size = new System.Drawing.Size(84, 31);
            this.bt2_DrawCircle_Auto.TabIndex = 11;
            this.bt2_DrawCircle_Auto.Text = "添加圆";
            this.bt2_DrawCircle_Auto.UseVisualStyleBackColor = true;
            this.bt2_DrawCircle_Auto.Click += new System.EventHandler(this.drawcirlefolder_Click);
            // 
            // Second_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 620);
            this.Controls.Add(this.groupBox1);
            this.Name = "Second_Demo";
            this.Text = "Second_Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt1_Create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt2_LoadImage;
        private System.Windows.Forms.Button bt3_Line;
        private System.Windows.Forms.Button bt4_Circle;
        private System.Windows.Forms.Button bt5_Rectangle;
        private System.Windows.Forms.Button bt6_Ellipse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt1_DrawLine_Auto;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt2_DrawCircle_Auto;
    }
}

