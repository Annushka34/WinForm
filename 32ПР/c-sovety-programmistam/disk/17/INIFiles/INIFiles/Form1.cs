using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string AppName,
        string KeyName, string lpString, string FileName);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string AppName,
        string KeyName, string lpDefault, StringBuilder ReturnedString,
        int Size, string FileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(string AppName,
        string KeyName, int nDefault, string FileName);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ������������� �������� ����� Width � Height � ������� [Form] �����
            // C:\config.ini � ������������ � ��������� �����
            WritePrivateProfileString("Form", 
                "Width", this.Width.ToString(), @"C:\config.ini");
            WritePrivateProfileString("Form",
                "Height", this.Height.ToString(), @"C:\config.ini");

            // ���������� ����� � ��������� ���� � ������� [Text] �����
            // C:\config.ini
            WritePrivateProfileString("TextBox1",
                "Text", textBox1.Text, @"C:\config.ini");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������ �������� "Text" � ������ [TextBox1] 
            // INI-����� config.ini
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString("TextBox1", "Text",
                "C#.�������� ������", sb, sb.Capacity, @"C:\config.ini");

            textBox1.Text = sb.ToString();

            // ������ �������� Width �� ����� [Form]
            // ����� INI file C:\CONFIG.INI
            this.Width = GetPrivateProfileInt("Form", "Width", 200, @"C:\config.ini");

            // ������ �������� Height �� ����� [Form]
            // ����� INI file C:\CONFIG.INI
            this.Height = GetPrivateProfileInt("Form", "Height", 200, @"C:\config.ini");
        }
    }
}