namespace RawImgProcess
{
    partial class ReadRawMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("绝对值模式");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("相对值模式");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("区域模式");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("热力图模式");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadRawMain));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl_Time = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Location = new System.Drawing.Point(2, 146);
            this.Aside.ShowOneNode = true;
            this.Aside.ShowSecondBackColor = true;
            this.Aside.ShowTips = true;
            this.Aside.Size = new System.Drawing.Size(200, 620);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.labelControl_Time);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Location = new System.Drawing.Point(2, 36);
            treeNode1.Name = "节点0";
            treeNode1.Text = "绝对值模式";
            treeNode2.Name = "节点1";
            treeNode2.Text = "相对值模式";
            treeNode3.Name = "节点2";
            treeNode3.Text = "区域模式";
            treeNode4.Name = "节点3";
            treeNode4.Text = "热力图模式";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.Header.SelectedIndex = 0;
            this.Header.Size = new System.Drawing.Size(1020, 110);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(0, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl_Time
            // 
            this.labelControl_Time.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Time.Appearance.Options.UseFont = true;
            this.labelControl_Time.Location = new System.Drawing.Point(743, 35);
            this.labelControl_Time.Name = "labelControl_Time";
            this.labelControl_Time.Size = new System.Drawing.Size(190, 19);
            this.labelControl_Time.TabIndex = 45;
            this.labelControl_Time.Text = "yyyy-MM-dd  HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // ReadRawMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadRawMain";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Text = "热红外相机测试软件";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadRawMain_FormClosing);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl_Time;
        private System.Windows.Forms.Timer timer1;
    }
}

