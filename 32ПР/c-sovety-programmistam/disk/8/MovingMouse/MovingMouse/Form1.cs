using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace MovingMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �����, ����������� ���������� ��������� ����
        /// �� �������� ���������� (��������, ����� ����������)
        /// </summary>
        /// <param name="times">���������� ��������</param>
        public void MoveMouse(int times)
        {
            GraphicsPath gp = new GraphicsPath();
            // ������� ������
            Rectangle screensize = Screen.GetBounds(new Point(0, 0));
            // ������� ������������ ������������� � ������� ������
            Rectangle rect = new Rectangle((int)screensize.Width/2-100,
                (int)screensize.Height/2-100, 200, 200);
            // ������� � ���������� ����������
            gp.AddEllipse(rect);
            // �������� ���������� �� ����� �����
            gp.Flatten();

            // ���� ���������� �������� ��������� ����
            for (int repeat = 0; repeat <= times - 1; repeat++)
            {
                // �������� ����� ��� ����� ����������
                for(int i=0; i <= gp.PathData.Points.Length-1; i++)
                {
                    // ���������� ��������� ��������
                    System.Threading.Thread.Sleep(10);
                    // ������� � ��������� ����� ����� ������
                    this.Text = (repeat+1).ToString();
                    // ���������� ��������� ����
                    Cursor.Position = new Point((int)gp.PathData.Points[i].X, (int)gp.PathData.Points[i].Y);
                }
            }
            gp.Dispose();
        }

        public void MoveAroundForm()
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddLine(this.DesktopLocation.X + 2,
                this.DesktopLocation.Y + 2,
                this.DesktopLocation.X + this.Size.Width - 2,
                this.DesktopLocation.Y - 2);

            gp.AddLine(this.DesktopLocation.X + this.Size.Width - 2,
                this.DesktopLocation.Y - 2,
                this.DesktopLocation.X + this.Size.Width - 2,
                this.DesktopLocation.Y + this.Size.Height - 2);

            gp.AddLine(this.DesktopLocation.X + this.Size.Width - 2,
                this.DesktopLocation.Y + this.Size.Height - 2,
                this.DesktopLocation.X + 2,
                this.DesktopLocation.Y + this.Size.Height + 2);

            gp.AddLine(this.DesktopLocation.X + 2,
                this.DesktopLocation.Y + this.Size.Height + 2,
                this.DesktopLocation.X + 2,
                this.DesktopLocation.Y + 2);

            int i;
            for (i = 0; i <= gp.PathData.Points.Length - 1; i++)
            {
                System.Threading.Thread.Sleep(1000);

                Cursor.Position = new Point((int)gp.PathData.Points[i].X,
                    (int)gp.PathData.Points[i].Y);
            }
            gp.Dispose();

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            MoveMouse(5);
        }

        private void butShowBorderForm_Click(object sender, EventArgs e)
        {
            MoveAroundForm();
        }
    }
}