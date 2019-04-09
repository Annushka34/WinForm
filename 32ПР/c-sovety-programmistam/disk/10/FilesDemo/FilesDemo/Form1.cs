using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.IO;

namespace FilesDemo
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
        private struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.U4)]
            public int wFunc;
            public string pFrom;
            public string pTo;
            public short fFlags;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            public string lpszProgressTitle;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int SHFileOperation(ref SHFILEOPSTRUCT fileOp);

        // ��������� ��� SHFileOperation
        private const int FO_DELETE = 3;
        private const int FOF_ALLOWUNDO = 64;
        private const int FOF_NOCONFIRMATION = 16;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
        [MarshalAs(UnmanagedType.LPTStr)] string path,
        [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
        int shortPathLength
        );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetLongPathName(
        [MarshalAs(UnmanagedType.LPTStr)] string path,
        [MarshalAs(UnmanagedType.LPTStr)] StringBuilder longPath,
        int longPathLength
        );


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\");
            listBox1.Items.Add("����� ������: " + astrFiles.Length);

            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\","*.in?");
            listBox1.Items.Add("����� ������: " + astrFiles.Length);

            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ������ ���� � �����
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // ��� ����� � �����������
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            // ��� ����� ��� ����������
            listBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ������ ���� � �����
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // ������� ���������� �����
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ������� ���� � �������
            MoveToRecycleBin(@"C:\Test.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // ������� ��������� ����
            listBox1.Items.Add(System.IO.Path.GetTempFileName());
        }

        public static int MoveToRecycleBin(string path)
        {
            SHFILEOPSTRUCT fop = new SHFILEOPSTRUCT();
            fop.wFunc = FO_DELETE;
            fop.pFrom = path + "\0"; // ��� ��������������� \0 �� ��������
            fop.fFlags = FOF_ALLOWUNDO | FOF_NOCONFIRMATION;

            return SHFileOperation(ref fop);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] directoryEntries =
                    System.IO.Directory.GetFileSystemEntries(@"c:\windows");

            foreach (string str in directoryEntries)
            {
                listBox1.Items.Add(str);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // ���� � ��������� �����
            string path = @"c:\WUTEMP\test.txt";

            // ���� ����� ���� ������� �������
            if ((System.IO.File.GetAttributes(path) & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden)
            {
                // �� ������������� ������� Normal
                System.IO.File.SetAttributes(path, System.IO.FileAttributes.Normal);
                MessageBox.Show("���� ������ �� �������� �������", path);

            }
            else // ���� ���� �� ��� �������
            {
                // �� ������ � ����� ������� �������
                System.IO.File.SetAttributes(path, System.IO.File.GetAttributes(path) | System.IO.FileAttributes.Hidden);
                MessageBox.Show("���� ���� �������", path);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\test.bin";
            // �������� ����� ������ ����
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("��������� ���� ��� ����������!", fileName);
                return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.CreateNew);
            // ������� ������ � ����
            System.IO.BinaryWriter w = new System.IO.BinaryWriter(fs);
            
            for (int i = 0; i < 11; i++)
            {
                w.Write((int)i);
            }
            w.Close();
            fs.Close();

            // ���������� ��������� ����������
            fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binread = new System.IO.BinaryReader(fs);
            // ��������� ������ �� test.bin
            for (int i = 0; i < 11; i++)
            {
                MessageBox.Show(binread.ReadInt32().ToString());
            }
            w.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\text.txt";

            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("��������� ���� ��� ����������.", fileName);
                return;
            }

            System.IO.StreamWriter sr = System.IO.File.CreateText(fileName);
            sr.WriteLine("���, ���, ���, ������, ����");
            sr.WriteLine("1, 2, 3. 9 1/2 � ��� �����");
            sr.WriteLine("� ������ {0} � {1}.", "C#", "Visual Basic");
            sr.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\text.txt";

            // ��������� ���� ������� � ��������� ����
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(fileName))
            {
                sw.WriteLine("�������� ��� ���� �������");
            }

            // ��������� ����� �� �����
            using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    MessageBox.Show(s);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
                // �������� ��������� StreamReader ��� ������ �� �����
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"c:\wutemp\text.txt"))
                {
                    String line;
                    // ������ ������ ������, ���� �� ��������� ����� ����� 
                    while ((line = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(line);
                    }
                }
         }

        private void button13_Click(object sender, EventArgs e)
        {
            int index = 2;
            //����� ������, � ������� ��������
            string path = @"c:\wutemp\text.txt";  //���� � �����
            string[] allLines = System.IO.File.ReadAllLines(path);
            for (int i = index; i < allLines.Length - 1; i++)
            {                
                listBox1.Items.Add(allLines[i]);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            StringBuilder shortPath = new StringBuilder(1024);
            GetShortPathName(@"C:\Program Files\Microsoft Silverlight\Microsoft.Scripting.Silverlight.dll", shortPath, shortPath.Capacity);
            this.Text = shortPath.ToString();

            StringBuilder longPath = new StringBuilder(1024);
            GetLongPathName(this.Text, longPath, longPath.Capacity);
            listBox1.Items.Clear();
            listBox1.Items.Add(longPath.ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // ������� ���������� � �����.
            System.IO.FileInfo file = new System.IO.FileInfo(@"c:\wutemp\text.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("�������� ��� �����: " + file.Name);
            listBox1.Items.Add("������� �����: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("����� �������� �����: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("��������� ��������� �����: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("���� ��� ������ � ��������� ���: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("������ ����� (� ������): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("�������� �����: ");
                listBox1.Items.Add(file.Attributes.ToString());
            }
        }

        private void CreateInternetShortcut(string filename, string URL)
        {
            System.IO.StreamWriter sr = System.IO.File.CreateText(filename);
            sr.WriteLine("[InternetShortcut]");
            sr.WriteLine("URL=" + URL);
            sr.Close();
        }

        private void butCreateURLShortcut_Click(object sender, EventArgs e)
        {
            CreateInternetShortcut(@"d:\rusproject.url", "http://rusproject.narod.ru");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string randomFile = System.IO.Path.GetRandomFileName();
            MessageBox.Show(randomFile);

            string tempText = System.IO.Path.ChangeExtension(System.IO.Path.GetRandomFileName(), ".txt");
            MessageBox.Show(tempText);
        }

        private void butDelRecycleVB_Click(object sender, EventArgs e)
        {
            FileSystem.DeleteFile(
                "c:/temp.txt", UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
        }
    }
}
