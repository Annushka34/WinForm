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

        private void button1_Click(object sender, EventArgs e)
        {
            // ������������� �� ������ ������� ��� ������ SelectedTab
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ������������� �� ������ ������� ��� ������ SelectedIndex
            this.tabControl1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �� ��������
            this.button1.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // ��������
            this.button1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ��������� ����� ������� 
            tabControl1.Controls.Add(new TabPage("����� �������"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ������� ��������� ������� 
            tabControl1.Controls.Remove(tabControl1.SelectedTab); 
        }


        /// <summary>
        /// ��������� �������� � �������� �������
        /// </summary>
        /// <param name="tabNumber">����� �������</param>
        /// <param name="tabControl">������� TabControl</param>
        private void InsertTab(int tabNumber, ref TabControl tabControl)
        {
            int counter = tabControl.Controls.Count;
            if (tabNumber < 0 || tabNumber > counter)
            {
                tabControl.Controls.Add(new TabPage("�������"));
                return;
            }

            int target = tabControl.SelectedIndex;

            // ��������� ������������ ������� � ������� �������� 
            Control[] c = new Control[counter];
            tabControl.Controls.CopyTo(c, 0);
            tabControl.Controls.Clear();

            // ��������� ������� �� ������������ �������� 
            for (int i = 0; i < target; ++i)
                tabControl.Controls.Add(c[i]);
            // ��������� ���� ������� 
            tabControl.Controls.Add(new TabPage("����������� �������"));

            // ��������� ������� ����� ������������ �������� 
            for (int i = target; i < counter; ++i)
                tabControl.Controls.Add(c[i]);

            // �������� ����������� ������� 
            tabControl.SelectedIndex = target;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ��������� ������� �� ������ �������
            InsertTab(2, ref tabControl1);
        }

    }
}