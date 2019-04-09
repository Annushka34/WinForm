using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();
            // ������� ���������  ListViewColumnSorter  � ��������� ��� � ListView 
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter; 
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������������ ��� �������� ����������
            ColumnHeader columnheader;
            // ������������ ��� �������� ��������� � ListView
            ListViewItem listviewitem;

            // ������������� ������ ��� 
            listView1.View = View.Details;

            // ������� ��������� ���������, ���������� ����� � ������� 
            listviewitem = new ListViewItem("���������");
            listviewitem.SubItems.Add("�������");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("��������");
            listviewitem.SubItems.Add("��������");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("������");
            listviewitem.SubItems.Add("�������");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("����");
            listviewitem.SubItems.Add("������");
            this.listView1.Items.Add(listviewitem);

            // ������� ������� 
            columnheader = new ColumnHeader();
            columnheader.Text = "���";
            this.listView1.Columns.Add(columnheader);
            columnheader = new ColumnHeader();
            columnheader.Text = "�������";
            this.listView1.Columns.Add(columnheader);

            // �������� ����� ��� �������� � ������������� ������ ������� ��������� �������
            // ������ ������
            foreach (ColumnHeader ch in this.listView1.Columns) { ch.Width = -2; } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add("����");
            listView1.Items.Add("�����");

            listView1.Items[0].UseItemStyleForSubItems = false; 
            listView1.Items[0].SubItems.Add("��������", Color.Pink, Color.Yellow, Font);
            listView1.Items[1].UseItemStyleForSubItems = false;
            listView1.Items[1].SubItems.Add("������", Color.Teal, Color.Violet, Font);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ����������, ���� �������, �� ������� ��������, ��� �������� ��������������� ��������
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // �������������� ����������� ����������
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // ������������� ����� ������� ��� ����������
                // �� ��������� ���������� �� �����������
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // ��������� � ������ �����������
            this.listView1.Sort();
        }
    }
}