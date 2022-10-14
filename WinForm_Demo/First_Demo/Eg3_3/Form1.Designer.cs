namespace Eg3_3
{
    partial class Form1tablet
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1_OpenFile = new System.Windows.Forms.Button();
            this.button2_SaveFile = new System.Windows.Forms.Button();
            this.button3_Font = new System.Windows.Forms.Button();
            this.button4_Undo = new System.Windows.Forms.Button();
            this.button5_Redo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7_Cut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(684, 363);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1_OpenFile
            // 
            this.button1_OpenFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_OpenFile.Location = new System.Drawing.Point(12, 384);
            this.button1_OpenFile.Name = "button1_OpenFile";
            this.button1_OpenFile.Size = new System.Drawing.Size(65, 30);
            this.button1_OpenFile.TabIndex = 1;
            this.button1_OpenFile.Text = "打开文件";
            this.button1_OpenFile.UseVisualStyleBackColor = true;
            this.button1_OpenFile.Click += new System.EventHandler(this.button1_OpenFile_Click);
            // 
            // button2_SaveFile
            // 
            this.button2_SaveFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2_SaveFile.Location = new System.Drawing.Point(93, 384);
            this.button2_SaveFile.Name = "button2_SaveFile";
            this.button2_SaveFile.Size = new System.Drawing.Size(65, 30);
            this.button2_SaveFile.TabIndex = 2;
            this.button2_SaveFile.Text = "保存文件";
            this.button2_SaveFile.UseVisualStyleBackColor = true;
            this.button2_SaveFile.Click += new System.EventHandler(this.button2_SaveFile_Click);
            // 
            // button3_Font
            // 
            this.button3_Font.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3_Font.Location = new System.Drawing.Point(174, 384);
            this.button3_Font.Name = "button3_Font";
            this.button3_Font.Size = new System.Drawing.Size(65, 30);
            this.button3_Font.TabIndex = 3;
            this.button3_Font.Text = "字体";
            this.button3_Font.UseVisualStyleBackColor = true;
            this.button3_Font.Click += new System.EventHandler(this.button3_Font_Click);
            // 
            // button4_Undo
            // 
            this.button4_Undo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4_Undo.Location = new System.Drawing.Point(255, 384);
            this.button4_Undo.Name = "button4_Undo";
            this.button4_Undo.Size = new System.Drawing.Size(65, 30);
            this.button4_Undo.TabIndex = 4;
            this.button4_Undo.Text = "撤销";
            this.button4_Undo.UseVisualStyleBackColor = true;
            this.button4_Undo.Click += new System.EventHandler(this.button4_Undo_Click);
            // 
            // button5_Redo
            // 
            this.button5_Redo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5_Redo.Location = new System.Drawing.Point(336, 384);
            this.button5_Redo.Name = "button5_Redo";
            this.button5_Redo.Size = new System.Drawing.Size(65, 30);
            this.button5_Redo.TabIndex = 5;
            this.button5_Redo.Text = "重做";
            this.button5_Redo.UseVisualStyleBackColor = true;
            this.button5_Redo.Click += new System.EventHandler(this.button5_Redo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(417, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "复制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7_Cut
            // 
            this.button7_Cut.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7_Cut.Location = new System.Drawing.Point(498, 384);
            this.button7_Cut.Name = "button7_Cut";
            this.button7_Cut.Size = new System.Drawing.Size(65, 30);
            this.button7_Cut.TabIndex = 7;
            this.button7_Cut.Text = "剪切";
            this.button7_Cut.UseVisualStyleBackColor = true;
            this.button7_Cut.Click += new System.EventHandler(this.button7_Cut_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(579, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "粘贴";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1tablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7_Cut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5_Redo);
            this.Controls.Add(this.button4_Undo);
            this.Controls.Add(this.button3_Font);
            this.Controls.Add(this.button2_SaveFile);
            this.Controls.Add(this.button1_OpenFile);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1tablet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "写字板";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1_OpenFile;
        private System.Windows.Forms.Button button2_SaveFile;
        private System.Windows.Forms.Button button3_Font;
        private System.Windows.Forms.Button button4_Undo;
        private System.Windows.Forms.Button button5_Redo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7_Cut;
        private System.Windows.Forms.Button button2;
    }
}

