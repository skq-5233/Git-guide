namespace Eg3_1
{
    partial class frmAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1First = new System.Windows.Forms.TextBox();
            this.textBox2Second = new System.Windows.Forms.TextBox();
            this.textBox3Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiButton1OK = new Sunny.UI.UIButton();
            this.uiButton1Exit = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "和";
            // 
            // textBox1First
            // 
            this.textBox1First.Location = new System.Drawing.Point(12, 106);
            this.textBox1First.Name = "textBox1First";
            this.textBox1First.Size = new System.Drawing.Size(79, 21);
            this.textBox1First.TabIndex = 3;
            // 
            // textBox2Second
            // 
            this.textBox2Second.Location = new System.Drawing.Point(142, 106);
            this.textBox2Second.Name = "textBox2Second";
            this.textBox2Second.Size = new System.Drawing.Size(79, 21);
            this.textBox2Second.TabIndex = 4;
            // 
            // textBox3Result
            // 
            this.textBox3Result.Location = new System.Drawing.Point(272, 106);
            this.textBox3Result.Name = "textBox3Result";
            this.textBox3Result.Size = new System.Drawing.Size(79, 21);
            this.textBox3Result.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // uiButton1OK
            // 
            this.uiButton1OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1OK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1OK.Location = new System.Drawing.Point(37, 174);
            this.uiButton1OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1OK.Name = "uiButton1OK";
            this.uiButton1OK.Size = new System.Drawing.Size(100, 35);
            this.uiButton1OK.TabIndex = 8;
            this.uiButton1OK.Text = "提交";
            this.uiButton1OK.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1OK.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1OK.Click += new System.EventHandler(this.uiButton1OK_Click);
            // 
            // uiButton1Exit
            // 
            this.uiButton1Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1Exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1Exit.Location = new System.Drawing.Point(218, 174);
            this.uiButton1Exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1Exit.Name = "uiButton1Exit";
            this.uiButton1Exit.Size = new System.Drawing.Size(100, 35);
            this.uiButton1Exit.TabIndex = 9;
            this.uiButton1Exit.Text = "退出";
            this.uiButton1Exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1Exit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1Exit.Click += new System.EventHandler(this.uiButton1Exit_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.uiButton1Exit);
            this.Controls.Add(this.uiButton1OK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3Result);
            this.Controls.Add(this.textBox2Second);
            this.Controls.Add(this.textBox1First);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加法器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1First;
        private System.Windows.Forms.TextBox textBox2Second;
        private System.Windows.Forms.TextBox textBox3Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIButton uiButton1OK;
        private Sunny.UI.UIButton uiButton1Exit;
    }
}

