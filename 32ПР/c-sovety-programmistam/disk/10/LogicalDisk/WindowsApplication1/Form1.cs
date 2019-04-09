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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.Environment.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void butDiskProperty_Click(object sender, EventArgs e)
        {
            // ������� ���������� � �����
            System.IO.DriveInfo drv = new System.IO.DriveInfo(@"d:\");
            listBox1.Items.Clear();
            listBox1.Items.Add("����: " + drv.Name);

            if (drv.IsReady)
            {
                listBox1.Items.Add("��� �����: " + drv.DriveType.ToString());
                listBox1.Items.Add("�������� �������: " + drv.DriveFormat.ToString());
                listBox1.Items.Add("��������� ����� �� �����: " +
                drv.AvailableFreeSpace.ToString());
            }

        }
    }
}