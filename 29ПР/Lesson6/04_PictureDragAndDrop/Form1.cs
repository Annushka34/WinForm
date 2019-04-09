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

namespace _04_PictureDragAndDrop
{
    public partial class Form1 : Form
    {
        PictureBox picture;
        
        public Form1()
        {
            InitializeComponent();
            ((Control)pictureBox2).AllowDrop = true;
            ((Control)pictureBox2).DragDrop += Form1_DragDrop1;
            ((Control)pictureBox2).DragEnter += Form1_DragEnter1;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_DragEnter1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop1(object sender, DragEventArgs e)
        {
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            picture = new PictureBox();
            ((Control)picture).AllowDrop = true;
            picture.SetBounds(10, 10, 100, 100);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(picture);

            //Image img = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            object file = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo f = new FileInfo(((string[])file)[0]);
            Image img = new Bitmap(f.FullName);
            label1.Text = f.FullName;
            picture.Image = img;
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }
    }
}
