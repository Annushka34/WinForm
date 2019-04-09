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
            // Создадим объект FileSystemWatcher и установим его свойства
            FileSystemWatcher watcher = new FileSystemWatcher();
            // Наблюдение за папкой WUTEMP
            watcher.Path = @"C:\wutemp\";
            // Следим за изменениями по последнему доступу,
            // времени записи и переименования файлов или папки
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Наблюдаем только файлы TXT
            watcher.Filter = "*.txt";

            // Добавляем обработчики событий
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Начинаем наблюдение
            watcher.EnableRaisingEvents = true;
        }

           // События
           private static void OnChanged(object source, FileSystemEventArgs e)
           {
               // При изменении, создания или удаления файла выводим сообщение
               MessageBox.Show("Файл: " +  e.FullPath + " " + e.ChangeType);
           }

           private static void OnRenamed(object source, RenamedEventArgs e)
           {
               // При переименовании файла тоже выводим сообщение
               MessageBox.Show("Файл: " + e.OldFullPath+ " переименован в " + e.FullPath);
           }
     }
}
