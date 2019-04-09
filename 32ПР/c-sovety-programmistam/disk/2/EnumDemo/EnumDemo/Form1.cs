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

        enum Cats { ����� = 3, ������ = 5, ������, ������, ����� };

        private void button1_Click(object sender, EventArgs e)
        {
            // ����������� ��� �������� ������������
            string[] catNames = Enum.GetNames(typeof(Cats));

            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }

            // ����������� ��� �������� ������������
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));

            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }

            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �������� ������ �����, ���������� ��� ����� � �������
            string[] allcolors = Enum.GetNames(typeof(System.Drawing.KnownColor));

            listBox1.Items.Clear();

            // ������� ��� ����� � ������
            listBox1.Items.AddRange(allcolors);

            // ������ �������
            //foreach (string s in allcolors)
            //{                
            //    listBox1.Items.Add(s);
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = System.Enum.Parse(typeof(KnownColor),listBox1.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            this.BackColor = System.Drawing.Color.FromKnownColor(SelectedColor);
        }
    }
}