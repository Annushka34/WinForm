using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butTestMouse_MouseEnter(object sender, EventArgs e)
        {
            // ������ ������, ����� �� ��������� ��� �������
            Cursor.Hide();
        }

        private void butTestMouse_MouseLeave(object sender, EventArgs e)
        {
            // ������� ������, ����� �� ������� �� ������� ������
            Cursor.Show();
        }

        private void butTestMouse_Click(object sender, EventArgs e)
        {
            // ������� ������ ���� �� 30 ����� ����
            Point pt = Cursor.Position;
            pt.Y += 30;
            Cursor.Position = pt;
        }

        private void lblTrapMouse_MouseEnter(object sender, EventArgs e)
        {
            // ����� ���������� ���� �� ���������,
            // ����������� ���������� ������ Ctrl+Alt+Del
            Cursor.Clip = RectangleToScreen(new Rectangle(lblTrapMouse.Location, lblTrapMouse.Size));
            lblTrapMouse.Text = "�������, ������� �������!";
        }
    }
}