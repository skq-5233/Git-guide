namespace ReadRAW
{
    partial class ReadRawImg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadRawImg));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl_time = new DevExpress.XtraEditors.LabelControl();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.labelControl);
            resources.ApplyResources(this.Header, "Header");
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Aside
            // 
            resources.ApplyResources(this.Aside, "Aside");
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            // labelControl
            // 
            this.labelControl.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelControl.Appearance.Options.UseBackColor = true;
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl, "labelControl");
            this.labelControl.Name = "labelControl";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // ReadRawImg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.labelControl_time);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Name = "ReadRawImg";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, -113, 1008, 729);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadRawImg_FormClosing);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.labelControl_time, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl_time;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.Label label2;
    }
}

