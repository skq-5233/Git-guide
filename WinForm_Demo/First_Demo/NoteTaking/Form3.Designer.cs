namespace NoteTaking
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.picBox1Dialog = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.textBox2_userPassword = new System.Windows.Forms.TextBox();
            this.button1_OK = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1Dialog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(63, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // picBox1Dialog
            // 
            this.picBox1Dialog.Location = new System.Drawing.Point(0, 2);
            this.picBox1Dialog.Name = "picBox1Dialog";
            this.picBox1Dialog.Size = new System.Drawing.Size(428, 155);
            this.picBox1Dialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1Dialog.TabIndex = 1;
            this.picBox1Dialog.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // textBox1_userName
            // 
            this.textBox1_userName.Location = new System.Drawing.Point(151, 214);
            this.textBox1_userName.Name = "textBox1_userName";
            this.textBox1_userName.Size = new System.Drawing.Size(100, 21);
            this.textBox1_userName.TabIndex = 3;
            // 
            // textBox2_userPassword
            // 
            this.textBox2_userPassword.Location = new System.Drawing.Point(151, 254);
            this.textBox2_userPassword.Name = "textBox2_userPassword";
            this.textBox2_userPassword.PasswordChar = '*';
            this.textBox2_userPassword.Size = new System.Drawing.Size(100, 21);
            this.textBox2_userPassword.TabIndex = 4;
            // 
            // button1_OK
            // 
            this.button1_OK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_OK.Location = new System.Drawing.Point(69, 316);
            this.button1_OK.Name = "button1_OK";
            this.button1_OK.Size = new System.Drawing.Size(75, 23);
            this.button1_OK.TabIndex = 5;
            this.button1_OK.Text = "确定";
            this.button1_OK.UseVisualStyleBackColor = true;
            this.button1_OK.Click += new System.EventHandler(this.button1_OK_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2_Cancel.Location = new System.Drawing.Point(214, 316);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2_Cancel.TabIndex = 6;
            this.button2_Cancel.Text = "取消";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.button2_Cancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 360);
            this.Controls.Add(this.button2_Cancel);
            this.Controls.Add(this.button1_OK);
            this.Controls.Add(this.textBox2_userPassword);
            this.Controls.Add(this.textBox1_userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox1Dialog);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册新用户";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1Dialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox1Dialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.TextBox textBox2_userPassword;
        private System.Windows.Forms.Button button1_OK;
        private System.Windows.Forms.Button button2_Cancel;
    }
}