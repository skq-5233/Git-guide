using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eg3_3
{
    public partial class Form1tablet : Form
    {
        public Form1tablet()
        {
            InitializeComponent();
        }

        private void button1_OpenFile_Click(object sender, EventArgs e)
        {
            //打开文件；
            OpenFileDialog ofddlg = new OpenFileDialog();
            ofddlg.DefaultExt = "*.rtf";
            ofddlg.Filter = "rtf文件(*.rtf)|*.rtf|所有文件(*.*)|*.*";
            if(ofddlg.ShowDialog()==DialogResult.OK && ofddlg.FileName.Length>0)
            {
                richTextBox1.LoadFile(ofddlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button2_SaveFile_Click(object sender, EventArgs e)
        {
            //保存文件；
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "保存";
            sfdlg.FileName = "*.rtf";
            sfdlg.Filter = "rtf文件(*.rtf)|*.rtf|所有文件(*.*)|*.*";
            sfdlg.DefaultExt = "*.rtf";
            if(sfdlg.ShowDialog()==DialogResult.OK && sfdlg.FileName.Length>0)
            {
                richTextBox1.SaveFile(sfdlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button3_Font_Click(object sender, EventArgs e)
        {
            //字体；
            FontDialog fdlg = new FontDialog();
            fdlg.ShowColor = true;
            if(fdlg.ShowDialog()!=DialogResult.Cancel)
            {
                richTextBox1.SelectionFont = fdlg.Font;
                richTextBox1.SelectionColor = fdlg.Color;
            }

        }

        private void button4_Undo_Click(object sender, EventArgs e)
        {
            //撤销；
            richTextBox1.Undo();
        }

        private void button5_Redo_Click(object sender, EventArgs e)
        {
            //重做；
            richTextBox1.Redo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //复制；
            richTextBox1.Copy();
        }

        private void button7_Cut_Click(object sender, EventArgs e)
        {
            //剪切；
            richTextBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //粘贴；
            richTextBox1.Paste();
        }
    }
}
