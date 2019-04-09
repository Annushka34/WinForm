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
        // ��������� ����������, ������� �������� ����� ��������������
        private bool bDragStatus;

        // ������ ���������� �������� ��� ������ �����
        private Point clickPoint;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // �������� ����� ��������������
                // � ��������� ���������� ����
                bDragStatus = true;
                clickPoint = new Point(e.X, e.Y);
            }
            else
            {
                bDragStatus = false;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDragStatus)
            {
                Point pointMoveTo;
                // ������� ������� ���������� ���� � �������� �����������
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                // �������� ������� �� �������� clickPoint
                pointMoveTo.Offset(-clickPoint.X, -clickPoint.Y);
                // ���������� �����
                this.Location = pointMoveTo;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            // ��������� ����� ��������������
            bDragStatus = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}