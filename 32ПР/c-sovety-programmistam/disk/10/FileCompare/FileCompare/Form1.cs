using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ����� ��� ��������� ������
        // � �������� ���������� ������������ ��� ������,
        // ���������� ������ ���� � ������������ ������.
        // ������������ 0, ���� ���������� ������ ���������.
        // ���� ������������ ��������, �������� �� 0, �� ���������� ������ �� ���������
        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // ���� ���� ������ ���������
            if (file1 == file2)
            {
                // ���������� true, ��� ��� ������������ ���� � ��� �� ����.
                return true;
            }

            // ��������� ��� �����.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // ��������� ������� �����. ���� ������� ����������, 
            // �� ����� �� ���������.
            if (fs1.Length != fs2.Length)
            {
                // ��������� �����
                fs1.Close();
                fs2.Close();

                // ���������� false, ��� ��� ����� �� ���������
                return false;
            }

            // ������ � ���������� ���� ������� �����
            // ���� �� �������� ������������� ����
            // ��� ���� �� ����� ��������� ����� �����.
            do
            {
                // ��������� ���� ���� � ������ �������.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // ��������� �����.
            fs1.Close();
            fs2.Close();

            // ������������ true � ������ ��������� ��������� ���� ������.  
            // file1byte ����� file2byte, ���� ���������� ������ ��������� ���������.
            return ((file1byte - file2byte) == 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���������� ��� �����. ���� � ������ ������ � ��������� �����.
            if (FileCompare(this.textBox1.Text, this.textBox2.Text))
            {
                MessageBox.Show("����� ���������.");
            }
            else
            {
                MessageBox.Show("����� �� ���������.");
            }  
        }

    }
}