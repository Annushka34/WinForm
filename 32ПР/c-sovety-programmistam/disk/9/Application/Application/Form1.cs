using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butExePath_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;
            // ������� ������ ���� � �����
            MessageBox.Show(appPath);
        }

        private void butBaseDirectory_Click(object sender, EventArgs e)
        {
            // ������� ���� � �����, ������ �������� ����������
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);

            MessageBox.Show(Application.StartupPath);
        }

        private void butRunNotepad_Click(object sender, EventArgs e)
        {
            // ������� ����� �������
            Process proc = new Process();
            // ��������� �������
            proc.StartInfo.FileName = @"Notepad.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();

        }

        private void butRunIE_Click(object sender, EventArgs e)
        {
            // ��������� ������� � ������ test.txt
            //Process.Start("notepad.exe", "test.txt");

            // ��������� ������� Internet Explorer � �������� �������
            Process.Start("iexplore.exe", "netsources.narod.ru");
        }

        private void butProcCount_Click(object sender, EventArgs e)
        {
            int am = Process.GetCurrentProcess().ProcessorAffinity.ToInt32();

            int processorCount = 0;

            while (am != 0)
            {
                processorCount++;
                am &= (am - 1);
            }

            MessageBox.Show(processorCount.ToString());
        }

        private void butRunNotepad2_Click(object sender, EventArgs e)
        {
            // ������������� ����������
            ProcessStartInfo start_info = new ProcessStartInfo
                (@"C:\windows\system32\notepad.exe");

            start_info.UseShellExecute = false;
            start_info.CreateNoWindow = true;
            // ������� ����� �������
            Process proc = new Process();
            proc.StartInfo = start_info;
            // ��������� �������
            proc.Start();

            // ����, ���� ������� �������
            proc.WaitForExit();

            MessageBox.Show("��� ����������: " + proc.ExitCode, "���������� " +
                "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected Process[] procs;

        private void butCloseNotepad_Click(object sender, EventArgs e)
        {
            procs = Process.GetProcessesByName("Notepad");
            int i = 0;
            while (i != procs.Length)
            {
                procs[i].Kill();
                i++;
                MessageBox.Show("����� : " + i.ToString());
            }
        }

        private void butProcCount2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                String.Format(
                "����� �����������:  {0}", Environment.ProcessorCount.ToString()));
        }
    }
}