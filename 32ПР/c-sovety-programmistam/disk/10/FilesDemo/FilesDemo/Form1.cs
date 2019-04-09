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

        // константы для SHFileOperation
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
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);

            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\","*.in?");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);

            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Полный путь к файлу
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Имя файла с расширением
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            // Имя файла без расширения
            listBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Полный путь к файлу
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Получим расширение файла
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Удаляем файл в корзину
            MoveToRecycleBin(@"C:\Test.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Создаем временный файл
            listBox1.Items.Add(System.IO.Path.GetTempFileName());
        }

        public static int MoveToRecycleBin(string path)
        {
            SHFILEOPSTRUCT fop = new SHFILEOPSTRUCT();
            fop.wFunc = FO_DELETE;
            fop.pFrom = path + "\0"; // без дополнительного \0 не работает
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
            // Путь к тестовому файлу
            string path = @"c:\WUTEMP\test.txt";

            // Если файлы имел атрибут Скрытый
            if ((System.IO.File.GetAttributes(path) & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden)
            {
                // То устанавливаем атрибут Normal
                System.IO.File.SetAttributes(path, System.IO.FileAttributes.Normal);
                MessageBox.Show("Файл больше не является скрытым", path);

            }
            else // Если файл не был скрытым
            {
                // То ставим у файла атрибут Скрытый
                System.IO.File.SetAttributes(path, System.IO.File.GetAttributes(path) | System.IO.FileAttributes.Hidden);
                MessageBox.Show("Файл стал скрытым", path);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\test.bin";
            // Создадим новый пустой файл
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Указанный файл уже существует!", fileName);
                return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.CreateNew);
            // Запишем данные в файл
            System.IO.BinaryWriter w = new System.IO.BinaryWriter(fs);
            
            for (int i = 0; i < 11; i++)
            {
                w.Write((int)i);
            }
            w.Close();
            fs.Close();

            // Попытаемся прочитать записанное
            fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binread = new System.IO.BinaryReader(fs);
            // считываем данные из test.bin
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
                MessageBox.Show("Указанный файл уже существует.", fileName);
                return;
            }

            System.IO.StreamWriter sr = System.IO.File.CreateText(fileName);
            sr.WriteLine("Раз, два, три, четыре, пять");
            sr.WriteLine("1, 2, 3. 9 1/2 и так далее");
            sr.WriteLine("Я изучаю {0} и {1}.", "C#", "Visual Basic");
            sr.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\wutemp\text.txt";

            // Добавляем одну строчку в текстовый файл
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(fileName))
            {
                sw.WriteLine("Добавили еще одну строчку");
            }

            // Прочитаем текст из файла
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
            
                // Создадим экземпляр StreamReader для чтения из файла
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"c:\wutemp\text.txt"))
                {
                    String line;
                    // Читаем каждую строку, пока не достигнем конца файла 
                    while ((line = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(line);
                    }
                }
         }

        private void button13_Click(object sender, EventArgs e)
        {
            int index = 2;
            //номер строки, с которой начинать
            string path = @"c:\wutemp\text.txt";  //путь к файлу
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
            // Выводим информацию о файле.
            System.IO.FileInfo file = new System.IO.FileInfo(@"c:\wutemp\text.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
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
