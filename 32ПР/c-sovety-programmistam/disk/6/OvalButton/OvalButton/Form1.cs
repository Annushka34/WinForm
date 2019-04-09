using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();

            // �������� ����� ������������� � ��������� ������
            Rectangle smallRectangle = button1.ClientRectangle;
            
            // �������� ������� ��������������
            smallRectangle.Inflate(-3, -3);

            // �������� ������, ��������� ���������� �������
            gp.AddEllipse(smallRectangle);
            button1.Region = new Region(gp);
            button1.BackColor = Color.FromArgb(255, 100, 100);
            this.TransparencyKey = Color.FromArgb(255, 100, 100);
            // ������ ���������� ��� ������� ������
            g.DrawEllipse(new Pen(Color.Gray, 2), 
                button1.Left + 1, 
                button1.Top + 1, 
                button1.Width - 5, 
                button1.Height - 5);

            // ����������� �������
            g.Dispose();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}