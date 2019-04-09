using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QueryPerformanceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceCounter(ref long lpPerformanceCount);
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceFrequency(ref long lpFrequency);

        private void Form1_Load(object sender, EventArgs e)
        {
            long ctr1 = 0, ctr2 = 0, freq = 0;
            int acc = 0, i = 0;
            
            if (QueryPerformanceCounter(ref ctr1) != 0)	// �������� ����� �������
            {
                for (i = 0; i < 1000; i++) acc++;		// ��������� ��������
                QueryPerformanceCounter(ref ctr2);	// ����������� ����� �������.
                lblInfo.Text = "������: " + ctr1 + Environment.NewLine;
                lblInfo.Text = lblInfo.Text + "�����: " + ctr2 + Environment.NewLine;
                QueryPerformanceFrequency(ref freq);
                lblInfo.Text = lblInfo.Text + "����������� ���������� QueryPerformanceCounter: 1/" + freq + " ���." + Environment.NewLine;
                lblInfo.Text = lblInfo.Text + "����� ����������������� �� 1000: " + (ctr2 - ctr1) * 1.0 / freq + " ���.";
            }
            else
                lblInfo.Text = "������� ������� �������� �� ��������������.";
        }
    }
}