using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ���������� ���� � ������ �������
        int x_md, y_md;
        // ����� �������� ����� ������ ����� � �������� 3 �������
        Pen p = new Pen(Color.Blue, 3);
        // ����������� ������� ������, ����� �����
        // ����� ������������ ����������� ��������
        bool bPaint;
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // �������� ��������
            bPaint = true;
            // ���������� ���� � ������ �������
            x_md = e.X;
            y_md = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bPaint)
            {
                // �������� ������ Graphics ��� ���������
                Graphics g = CreateGraphics();

                // ���������� ���������� ���� ��� �����������
                int x_mm = e.X;
                int y_mm = e.Y;
                // ������
                g.DrawLine(p, x_md, y_md, x_mm, y_mm);

                // �������� ���������� ���� � ���������� ������
                x_md = x_mm;
                y_md = y_mm;
                g.Dispose();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bPaint = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // ������� ����� �� ����� ��������� ��� ������� ������ ������ ����
            if (e.Button == MouseButtons.Right)
            {
                Graphics g = CreateGraphics();
                g.Clear(this.BackColor);
                g.Dispose();
            }
        }

    }
}