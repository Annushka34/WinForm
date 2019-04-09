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

namespace _03_DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            RichTextBox textBox = new RichTextBox();
            textBox.Location = new Point(10, 10);
            textBox.Size = new Size(200, 200);
            this.Controls.Add(textBox);

            object file = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo f = new FileInfo(((string[])file)[0]);
            textBox.LoadFile(f.FullName, RichTextBoxStreamType.PlainText);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
