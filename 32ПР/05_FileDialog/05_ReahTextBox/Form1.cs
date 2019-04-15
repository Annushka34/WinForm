using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ReahTextBox
{
    public partial class Form1 : Form
    {
        RichTextBoxStreamType type;
        //----1 - add posibility open and save diff files (txt and rtf)
        //----2---add text alignment
        //----3---add close on X
        //----4---add +/- buttons for font size
        //----5---open at first only for reading/ Posibility for change only after pressing Edit
        //----NEXT LESSON----------
        //----5---drag and drop
        //----6---context menu---
        //----7---menu----
        //----8---tool tip----
        string copyText = "";
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:/";
            openFileDialog1.Filter = "*.rtf|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:/";
            saveFileDialog1.Filter = "*.rtf|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selColor = colorDialog1.Color;
                txtColor.Text = selColor.Name;
                if (richTextBox1.SelectedText != "")
                    richTextBox1.SelectionColor = selColor;
                else
                    richTextBox1.ForeColor = selColor;
            }
        }


        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                var font = fontDialog1.Font;
                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionFont = font;
                }
                else
                {
                    richTextBox1.Font = font;
                }
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Font oldFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(oldFont, FontStyle.Bold);
            }
            else
            {
                Font oldFont = richTextBox1.Font;
                richTextBox1.Font = new Font(oldFont, FontStyle.Bold);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Font oldFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(oldFont, FontStyle.Italic);
            }
            else
            {
                Font oldFont = richTextBox1.Font;
                richTextBox1.Font = new Font(oldFont, FontStyle.Italic);
            }
        }

        private void btnLined_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Font oldFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(oldFont, FontStyle.Underline);
            }
            else
            {
                Font oldFont = richTextBox1.Font;
                richTextBox1.Font = new Font(oldFont, FontStyle.Underline);
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selColor = colorDialog1.Color;
                txtBackColor.Text = selColor.Name;

                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionBackColor = selColor;
                }
                else
                    richTextBox1.BackColor = selColor;
            }
        }

        private void cmbSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Font oldFont = richTextBox1.SelectionFont;
                float size = float.Parse(cmbSize.SelectedItem.ToString());
                richTextBox1.SelectionFont = new Font(oldFont.FontFamily, size, oldFont.Style);
            }
            else
            {
                Font oldFont = richTextBox1.Font;
                float size = float.Parse(cmbSize.SelectedItem.ToString());
                richTextBox1.Font = new Font(oldFont.FontFamily, size, oldFont.Style);
            }
        }  
    }
}
