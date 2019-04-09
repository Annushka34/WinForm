using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Watcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �������� ������ FileSystemWatcher � ��������� ��� ��������
            FileSystemWatcher watcher = new FileSystemWatcher();
            // ���������� �� ������ WUTEMP
            watcher.Path = @"C:\wutemp\";
            // ������ �� ����������� �� ���������� �������,
            // ������� ������ � �������������� ������ ��� �����
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // ��������� ������ ����� TXT
            watcher.Filter = "*.txt";

            // ��������� ����������� �������
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // �������� ����������
            watcher.EnableRaisingEvents = true;
        }

           // �������
           private static void OnChanged(object source, FileSystemEventArgs e)
           {
               // ��� ���������, �������� ��� �������� ����� ������� ���������
               MessageBox.Show("����: " +  e.FullPath + " " + e.ChangeType);
           }

           private static void OnRenamed(object source, RenamedEventArgs e)
           {
               // ��� �������������� ����� ���� ������� ���������
               MessageBox.Show("����: " + e.OldFullPath+ " ������������ � " + e.FullPath);
           }
     }
}
