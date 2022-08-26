namespace RawImgProcess.AbsValueMode
{
    partial class Saveimg
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
            this.uiButton2_SaveImg = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButton2_SaveImg
            // 
            this.uiButton2_SaveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2_SaveImg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2_SaveImg.Location = new System.Drawing.Point(43, 106);
            this.uiButton2_SaveImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2_SaveImg.Name = "uiButton2_SaveImg";
            this.uiButton2_SaveImg.Size = new System.Drawing.Size(133, 52);
            this.uiButton2_SaveImg.TabIndex = 9;
            this.uiButton2_SaveImg.Text = "保存图像";
            this.uiButton2_SaveImg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2_SaveImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2_SaveImg.Click += new System.EventHandler(this.Save_Img_Click);
            // 
            // Saveimg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.uiButton2_SaveImg);
            this.Name = "Saveimg";
            this.Text = "Save";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton2_SaveImg;
    }
}