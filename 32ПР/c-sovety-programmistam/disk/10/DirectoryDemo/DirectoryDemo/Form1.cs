using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DirectoryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ������ ������
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"d:\");
            foreach(string folder in astrFolders)
                listBox1.Items.Add(folder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ������� ������ �����, ��� ����������� ����� pro
            listBox1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"d:\");
            System.IO.DirectoryInfo[] folders = di.GetDirectories("*pro*");
            foreach (System.IO.DirectoryInfo maskdirs in folders)
                listBox1.Items.Add(maskdirs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
        {
            // ���������� ������� ����� C:\WUTEMP
            System.IO.Directory.Delete(@"c:\wutemp");
            MessageBox.Show("����� �������.");
        } 
        catch (Exception) 
        {
            MessageBox.Show("������ ������� �����, ������� �������� ����� � �����.");
        } 
        finally {}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ������� ���������� � ��������� �����
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\wutemp");
            listBox1.Items.Clear();
            listBox1.Items.Add("�������� �����: " + dir.Name);
            listBox1.Items.Add("������������ �����: " + dir.Parent.Name);
            listBox1.Items.Add("����� ����������: ");
            listBox1.Items.Add(dir.Exists.ToString());
            if (dir.Exists)
            {
                listBox1.Items.Add("����� �������: ");
                listBox1.Items.Add(dir.CreationTime.ToString());
                listBox1.Items.Add("����� ��������: ");
                listBox1.Items.Add(dir.LastWriteTime.ToString());
                listBox1.Items.Add("����� ���������� �������: ");
                listBox1.Items.Add(dir.LastAccessTime.ToString());
                listBox1.Items.Add("�������� �����: ");
                listBox1.Items.Add(dir.Attributes.ToString());
                listBox1.Items.Add("����� ��������: " +
                dir.GetFiles().Length.ToString() + " �����");
            }
        }

        private void butFolderExist_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\windows"))
                label1.Text = "����� " + @"C:\Windows" + " ����������";
            else
                label1.Text = "����� �� ����������";
        }

        private void butRenameFolder_Click(object sender, EventArgs e)
        {
            // ��������������� ����� MyFolder � NewFolder
            string oldPathString = @"C:\MyFoder";
            string newPathString = @"C:\NewFolder";
            Directory.Move(oldPathString, newPathString);
        }

        private void butBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // ������ ����� �������� ������
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            // ��������� � ���������� ����
            fbd.Description = "�������� �����";
            // �� ������� ������ ����� �����
            fbd.ShowNewFolderButton = false;
            // �������� �����, ��������� �������������
            if (fbd.ShowDialog() == DialogResult.OK)
                this.Text = fbd.SelectedPath;
        }

        private void butMyDoc_Click(object sender, EventArgs e)
        {
            // ������� ���� � ����� ��� ���������
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        static long GetDirectorySize(System.IO.DirectoryInfo directory, bool includeSubdir)
        {
            long totalSize = 0;
            // ������� ��� �����
            System.IO.FileInfo[] files = directory.GetFiles();
            foreach (System.IO.FileInfo file in files)
            {
                totalSize += file.Length;
            }
            // ������� ��� ��������
            if (includeSubdir)
            {
                System.IO.DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (System.IO.DirectoryInfo dir in dirs)
                {
                    totalSize += GetDirectorySize(dir, true);
                }
            }
            return totalSize;
        }

        private void butFolderSize_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"d:\help");
            textBox1.Text = "����� ������: " +
            GetDirectorySize(dir, true).ToString() + " ����.";
            this.Cursor = Cursors.Default;
        }

    }
}