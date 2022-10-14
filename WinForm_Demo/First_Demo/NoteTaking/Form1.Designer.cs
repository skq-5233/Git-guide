namespace NoteTaking
{
    partial class Login
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
            this.picBox1Dialog = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_User = new System.Windows.Forms.TextBox();
            this.textBox2_Pass = new System.Windows.Forms.TextBox();
            this.picBox2Dialog = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1NewUser = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1Dialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2Dialog)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1Dialog
            // 
            this.picBox1Dialog.Location = new System.Drawing.Point(1, 4);
            this.picBox1Dialog.Name = "picBox1Dialog";
            this.picBox1Dialog.Size = new System.Drawing.Size(481, 116);
            this.picBox1Dialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1Dialog.TabIndex = 0;
            this.picBox1Dialog.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(234, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(236, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // textBox1_User
            // 
            this.textBox1_User.Location = new System.Drawing.Point(325, 175);
            this.textBox1_User.Name = "textBox1_User";
            this.textBox1_User.Size = new System.Drawing.Size(100, 21);
            this.textBox1_User.TabIndex = 3;
            // 
            // textBox2_Pass
            // 
            this.textBox2_Pass.Location = new System.Drawing.Point(325, 244);
            this.textBox2_Pass.Name = "textBox2_Pass";
            this.textBox2_Pass.PasswordChar = '*';
            this.textBox2_Pass.Size = new System.Drawing.Size(100, 21);
            this.textBox2_Pass.TabIndex = 4;
            // 
            // picBox2Dialog
            // 
            this.picBox2Dialog.Location = new System.Drawing.Point(32, 175);
            this.picBox2Dialog.Name = "picBox2Dialog";
            this.picBox2Dialog.Size = new System.Drawing.Size(130, 104);
            this.picBox2Dialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2Dialog.TabIndex = 5;
            this.picBox2Dialog.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(238, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(350, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1NewUser
            // 
            this.linkLabel1NewUser.AutoSize = true;
            this.linkLabel1NewUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1NewUser.Location = new System.Drawing.Point(32, 316);
            this.linkLabel1NewUser.Name = "linkLabel1NewUser";
            this.linkLabel1NewUser.Size = new System.Drawing.Size(57, 12);
            this.linkLabel1NewUser.TabIndex = 8;
            this.linkLabel1NewUser.TabStop = true;
            this.linkLabel1NewUser.Text = "注册用户";
            this.linkLabel1NewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1NewUser_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.linkLabel1NewUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox2Dialog);
            this.Controls.Add(this.textBox2_Pass);
            this.Controls.Add(this.textBox1_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox1Dialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1Dialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2Dialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1Dialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_User;
        private System.Windows.Forms.TextBox textBox2_Pass;
        private System.Windows.Forms.PictureBox picBox2Dialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1NewUser;
    }
}

