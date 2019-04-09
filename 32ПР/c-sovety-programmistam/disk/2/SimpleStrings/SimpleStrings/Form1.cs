using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            string partBookTitle = "C#.������";
            string insertText = "�������� ";
            string bookTitle = partBookTitle.Insert(3, insertText);
            MessageBox.Show(bookTitle);
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.�������� ������";
            // ������� ��������� � ������� �������
            bookTitle = bookTitle.Remove(2);
            MessageBox.Show(bookTitle);
        }

        private void butSubstring_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.�������� ������";
            // ��������� ��������� � ������ ������� � �������� � ��� �������
            bookTitle = bookTitle.Substring(5, 3);
            MessageBox.Show(bookTitle);
        }

        private void butIndexOf_Click(object sender, EventArgs e)
        {
            string str1 = "���";
            string str2 = "����-�������";
            int i = str2.IndexOf(str1);
            // ���������, ������ �� ������ ��� � ����� ����-�������
            if (i >= 0) MessageBox.Show(str1 + " ������ � ������ " + str2);
        }

        private void butConvert_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // ������� 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString();  // ������� 5
        }

        private void butSpecial_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();

            // Unicode-��� ��� �������� �����
            charCode = 0x00AE;
            specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void butRepeat_Click(object sender, EventArgs e)
        {
            // ������� ������ �� 5 ���������
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void butColorName_Click(object sender, EventArgs e)
        {
            // ������ ����
            Color clr = Color.Blue;
            // ������� ��� ���������� �����
            textBox1.Text = (TypeDescriptor.GetConverter(clr).ConvertToString(clr));

            // �������� ������. ������������ �������� ����� Green � ������ Color
            clr = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString("Green");
            // ����������� ����� � ��������� ����
            this.BackColor = clr;

        }

        public void SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            MessageBox.Show(string.Concat("Hello, ", name));
        }

       
        private void butReverseVB_Click(object sender, EventArgs e)
        {
            string myString = textBox1.Text;
            // ���������� ���������� ������� Visual Basic
            textBox1.Text = Strings.StrReverse(myString);
        }

        public static string ReverseString(string str)
        {
            // �������� �� ������������� ������.
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            // �������� ������ StringBuilder � ������ ������.
            StringBuilder revStr = new StringBuilder(str.Length);
            // ���������� � ����� ��� �������
            // � ������������ ������ ������ � StringBuilder
            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            // ���������� ������������ ������
            return revStr.ToString();
        }

        private void butReverseCS_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);

                        
        }

        private void butFormatStr_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            textBox1.Text = 
                String.Format("��������� {0} ����� {1:0.0;c}", AutoName, 12000);
        }
       
    }
}