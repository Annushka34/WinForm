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

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(
            System.Text.StringBuilder pszOut, 
            string pszSrc, 
            Int32 cchMax, 
            Int32 dwFlags);

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ���� � �����
            string strPathFile = "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);

            // ��������� 20 ��������, ��������� �������� �����������
            bool b = PathCompactPathEx(sb, strPathFile, 20+1, 0);

            // ������� ��������� � ��������� ����
            textBox1.Text = sb.ToString();
        } 

    }
}