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

        private void Form1_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // �������� ����� ��� �������� �����
            // � ������� ���� MdiClient.
            foreach (Control ctl in this.Controls)
            {
                // �������� �������� ������� � ���� MdiClient
                ctlMDI = (MdiClient)ctl;

                // ������������� ���� BackColor �������� MdiClient
                ctlMDI.BackColor = this.BackColor;   
            }

            // ������� �������� ����� � ���� ������������ MDI-�����
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}