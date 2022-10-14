namespace Eg3_4
{
    partial class Form1ConnState
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
            this.label1State = new System.Windows.Forms.Label();
            this.textBox1State = new System.Windows.Forms.TextBox();
            this.button1Open = new System.Windows.Forms.Button();
            this.button2Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1State
            // 
            this.label1State.AutoSize = true;
            this.label1State.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1State.Location = new System.Drawing.Point(74, 118);
            this.label1State.Name = "label1State";
            this.label1State.Size = new System.Drawing.Size(96, 12);
            this.label1State.TabIndex = 0;
            this.label1State.Text = "当前连接状态：";
            // 
            // textBox1State
            // 
            this.textBox1State.Location = new System.Drawing.Point(211, 115);
            this.textBox1State.Name = "textBox1State";
            this.textBox1State.Size = new System.Drawing.Size(140, 21);
            this.textBox1State.TabIndex = 1;
            // 
            // button1Open
            // 
            this.button1Open.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1Open.Location = new System.Drawing.Point(95, 229);
            this.button1Open.Name = "button1Open";
            this.button1Open.Size = new System.Drawing.Size(75, 23);
            this.button1Open.TabIndex = 2;
            this.button1Open.Text = "打开";
            this.button1Open.UseVisualStyleBackColor = true;
            this.button1Open.Click += new System.EventHandler(this.button1Open_Click);
            // 
            // button2Close
            // 
            this.button2Close.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2Close.Location = new System.Drawing.Point(248, 229);
            this.button2Close.Name = "button2Close";
            this.button2Close.Size = new System.Drawing.Size(75, 23);
            this.button2Close.TabIndex = 3;
            this.button2Close.Text = "关闭";
            this.button2Close.UseVisualStyleBackColor = true;
            this.button2Close.Click += new System.EventHandler(this.button2Close_Click);
            // 
            // Form1ConnState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 391);
            this.Controls.Add(this.button2Close);
            this.Controls.Add(this.button1Open);
            this.Controls.Add(this.textBox1State);
            this.Controls.Add(this.label1State);
            this.Name = "Form1ConnState";
            this.Text = "连接状态";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1State;
        private System.Windows.Forms.TextBox textBox1State;
        private System.Windows.Forms.Button button1Open;
        private System.Windows.Forms.Button button2Close;
    }
}

