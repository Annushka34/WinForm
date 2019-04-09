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

        private void butStringToColor_Click(object sender, EventArgs e)
        {
            string htmlColor = "Blue";
            // ����������� ���� htmlColor � ��������� GDI+ Color
            Color myColor = ColorTranslator.FromHtml(htmlColor);
            butStringToColor.BackColor = myColor;

            // ��� ���
            Color myColor2 = ColorTranslator.FromHtml("#AFFFFF");
            butStringToColor.BackColor = myColor2;
        }

        private void butColorToString_Click(object sender, EventArgs e)
        {
            // ����������� ��������� Color � ������
            Color myColor = Color.Blue;
            string htmlColor = ColorTranslator.ToHtml(myColor);
            // ������� ���� ��������� � ���������� ���������
            MessageBox.Show(htmlColor);
        }

        private void butColorToInt_Click(object sender, EventArgs e)
        {
            int iBlueColor = Color.Blue.ToArgb();
            Color myColor = Color.FromArgb(0x7800FF00);
        }

        private void butSetPixel_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);

            pictureBox1.Image = bm;
            for (int i = 0; i < 400; i++)
            {
                bm.SetPixel(i, i, Color.Red);
            }

            pictureBox1.Update();
        }

        private void butDrawPoint_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            // ������ ��� ������� �����
            for (int i = 0; i < 100; i += 5)
                g.FillRectangle(new SolidBrush(Color.Red), i, 10, 1, 1);
            g.Dispose();
        }
    }
}