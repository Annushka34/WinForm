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

namespace _05_FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:/";
            openFileDialog1.Filter = "txt|*.txt|rtf|*.rtf";
            var res =  openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    txtText.Text = sr.ReadToEnd();
                }                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // saveFileDialog1.InitialDirectory = @"D:/";
          //  saveFileDialog1.Filter = "txt|*.txt|rtf|*.rtf";
         //   var result = saveFileDialog1.ShowDialog();
         //   if (result == DialogResult.OK)
         if (openFileDialog1.FileName != "openFileDialog1")
            {
                MessageBox.Show("Save to "+openFileDialog1.FileName);
                using (StreamWriter sw = new StreamWriter(openFileDialog1.FileName))
                {
                    sw.WriteLine(txtText.Text);
                    MessageBox.Show("Saved");
                    txtText.Clear();
                }
            }
            else
            {
                btnSaveAs_Click(sender, e);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:/";
            saveFileDialog1.Filter = "txt|*.txt|rtf|*.rtf";
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(txtText.Text);
                    MessageBox.Show("Saved");
                    txtText.Clear();
                }
            }
        }
    }
}
