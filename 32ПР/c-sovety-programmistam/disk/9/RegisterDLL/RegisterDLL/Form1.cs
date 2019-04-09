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

        // �������� ����� ��� �������� ������ ������ ��������
        private void createproc(string fname, string arg)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fname;
            proc.StartInfo.Arguments = arg;
            proc.Start();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            // ������ � ������� ����� ������ ����� �������������� dll ��� ocx
            //fname � ��� ��������� ��� ����������� ������
            //arg � ������ ��������� ��� ����� �����
            createproc("RegSvr32", " /s \"C:\\WINDOWS\\system32\\shdocvw.dll\"");
            // ������ ���� ������������ ���� shdocvw.dll ��� ������ ���������
            // �� ������������ ������ ���� �����, �� ����� ���� �������� ������,
            // ���� ���� ��������� � ����� ����� � �����������
            createproc("RegSvr32", " /s \"" + Application.StartupPath + "\\myappdll.dll\"");
            // ��� ������ ���������, ������������ regsvr32:
            // optional values []
            // regsvr32 [/u] [/s] [/n] [/i[:cmdline]  ] dllname
            // /u = ����� ����������� �����
            // /s = silent (��� ������ ���������)
            // /i = call dllinstall pasing it an optional [cmdline] (when used with /u calls dll uninstall)
            // /n = do not call dllregisterserver (this option must be used with /i 

        }

    }
}