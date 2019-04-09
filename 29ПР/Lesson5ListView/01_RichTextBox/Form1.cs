using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_RichTextBox
{
    public partial class Form1 : Form
    {
        string fileName = "";
        RichTextBoxStreamType type;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.Filter = "text(*.txt)|*.txt|rtf(*.rtf)|*.rtf";

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                if (TypeRecognize())
                {
                    richTextBox1.LoadFile(fileName, type);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(fileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                richTextBox1.SaveFile(fileName, type);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt|rtf(*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                if (TypeRecognize())
                {
                    richTextBox1.SaveFile(fileName, type);
                }
            }
        }

        bool TypeRecognize()
        {
            FileInfo file = new FileInfo(fileName);
            if (file.Extension == ".rtf")
            {
                type = RichTextBoxStreamType.RichText;
            }
            else if (file.Extension == ".txt")
            {
                type = RichTextBoxStreamType.PlainText;
            }
            else { MessageBox.Show("unknown format"); return false; }
            return true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "";
            richTextBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }
    }
}
