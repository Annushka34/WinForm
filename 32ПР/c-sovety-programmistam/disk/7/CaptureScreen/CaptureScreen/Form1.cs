using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butScreenCapture_Click(object sender, EventArgs e)
        {
            // Вычисляем размеры экрана
            Bitmap screenPicture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                 Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(screenPicture))
            {
                // копируем изображение всего экрана
                g.CopyFromScreen(0, 0, 0, 0, screenPicture.Size);
            }
            pictureBox1.Image = screenPicture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(new Point(0, 0), this.Size));
            // сохраняем в файл
            bitmap.Save("c:\\t.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}