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
            // Получим список файлов
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"d:\");
            foreach(string folder in astrFolders)
                listBox1.Items.Add(folder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получим список папок, где встречается слово pro
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
            // Попытаемся удалить папку C:\WUTEMP
            System.IO.Directory.Delete(@"c:\wutemp");
            MessageBox.Show("Папка удалена.");
        } 
        catch (Exception) 
        {
            MessageBox.Show("Нельзя удалить папку, которая содержит папки и файлы.");
        } 
        finally {}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Получим информацию о свойствах папки
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\wutemp");
            listBox1.Items.Clear();
            listBox1.Items.Add("Проверка папки: " + dir.Name);
            listBox1.Items.Add("Родительская папка: " + dir.Parent.Name);
            listBox1.Items.Add("Папка существует: ");
            listBox1.Items.Add(dir.Exists.ToString());
            if (dir.Exists)
            {
                listBox1.Items.Add("Папка создана: ");
                listBox1.Items.Add(dir.CreationTime.ToString());
                listBox1.Items.Add("Папка изменена: ");
                listBox1.Items.Add(dir.LastWriteTime.ToString());
                listBox1.Items.Add("Время последнего доступа: ");
                listBox1.Items.Add(dir.LastAccessTime.ToString());
                listBox1.Items.Add("Атрибуты папки: ");
                listBox1.Items.Add(dir.Attributes.ToString());
                listBox1.Items.Add("Папка содержит: " +
                dir.GetFiles().Length.ToString() + " файла");
            }
        }

        private void butFolderExist_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\windows"))
                label1.Text = "Папка " + @"C:\Windows" + " существует";
            else
                label1.Text = "Папка не существует";
        }

        private void butRenameFolder_Click(object sender, EventArgs e)
        {
            // Переименовываем папку MyFolder в NewFolder
            string oldPathString = @"C:\MyFoder";
            string newPathString = @"C:\NewFolder";
            Directory.Move(oldPathString, newPathString);
        }

        private void butBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // задаем папку верхнего уровня
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            // Заголовок в диалоговом окне
            fbd.Description = "Выберите папку";
            // Не выводим кнопку Новая папка
            fbd.ShowNewFolderButton = false;
            // Получаем папку, выбранную пользователем
            if (fbd.ShowDialog() == DialogResult.OK)
                this.Text = fbd.SelectedPath;
        }

        private void butMyDoc_Click(object sender, EventArgs e)
        {
            // Получим путь к папке Мои документы
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        static long GetDirectorySize(System.IO.DirectoryInfo directory, bool includeSubdir)
        {
            long totalSize = 0;
            // Считаем все файлы
            System.IO.FileInfo[] files = directory.GetFiles();
            foreach (System.IO.FileInfo file in files)
            {
                totalSize += file.Length;
            }
            // Считаем все подпапки
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
            textBox1.Text = "Общий размер: " +
            GetDirectorySize(dir, true).ToString() + " байт.";
            this.Cursor = Cursors.Default;
        }

    }
}