namespace Eg2_2
{
    partial class FrmbkColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmbkColor));
            this.btColor = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // btColor
            // 
            this.btColor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btColor, "btColor");
            this.btColor.ForeColor = System.Drawing.Color.Black;
            this.btColor.Name = "btColor";
            this.btColor.Style = Sunny.UI.UIStyle.Custom;
            this.btColor.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btColor.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // FrmbkColor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btColor);
            this.MaximizeBox = false;
            this.Name = "FrmbkColor";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btColor;
    }
}

