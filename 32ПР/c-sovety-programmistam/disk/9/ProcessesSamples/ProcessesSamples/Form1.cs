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

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(p.ToString());
        }

        private void butProcessIE_Click(object sender, EventArgs e)
        {
            // ������� ������
            listBox1.Items.Clear();
            // ������� ������ ���������, ��������� � Internet Explorer
            foreach (Process p in Process.GetProcessesByName("iexplore"))
                listBox1.Items.Add(p.ToString());
        }

        private void butRemoteProcess_Click(object sender, EventArgs e)
        {
            // ������� ������
            listBox1.Items.Clear();
            // ������� ������ ��������� notepad �� ��������� ������ skynet
            foreach (Process p in Process.GetProcessesByName("notepad", "skynet"))
                listBox1.Items.Add(p.ToString());
        }

        private void butWindowProcess_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Process p in Process.GetProcesses(System.Environment.MachineName))
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    // ������� ����������
                    listBox1.Items.Add(p.ToString());
                }
            }
        }

        private void butSendMail_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "mailto:rusproject@mail.ru,email@address2.com?subject=Hello&cc=email@address3.com&bcc=email@address4.com&body=Happy New Year" ;
            process.Start();

        }
    }
}