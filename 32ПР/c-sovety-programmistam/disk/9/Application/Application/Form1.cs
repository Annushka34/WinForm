using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butExePath_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;
            // Выводим полный путь к файлу
            MessageBox.Show(appPath);
        }

        private void butBaseDirectory_Click(object sender, EventArgs e)
        {
            // Выводим путь к папке, откуда запущено приложение
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);

            MessageBox.Show(Application.StartupPath);
        }

        private void butRunNotepad_Click(object sender, EventArgs e)
        {
            // создаем новый процесс
            Process proc = new Process();
            // Запускаем Блокнот
            proc.StartInfo.FileName = @"Notepad.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();

        }

        private void butRunIE_Click(object sender, EventArgs e)
        {
            // Запускаем Блокнот с файлом test.txt
            //Process.Start("notepad.exe", "test.txt");

            // Запускаем браузер Internet Explorer с заданным адресом
            Process.Start("iexplore.exe", "netsources.narod.ru");
        }

        private void butProcCount_Click(object sender, EventArgs e)
        {
            int am = Process.GetCurrentProcess().ProcessorAffinity.ToInt32();

            int processorCount = 0;

            while (am != 0)
            {
                processorCount++;
                am &= (am - 1);
            }

            MessageBox.Show(processorCount.ToString());
        }

        private void butRunNotepad2_Click(object sender, EventArgs e)
        {
            // Устанавливаем информацию
            ProcessStartInfo start_info = new ProcessStartInfo
                (@"C:\windows\system32\notepad.exe");

            start_info.UseShellExecute = false;
            start_info.CreateNoWindow = true;
            // создаем новый процесс
            Process proc = new Process();
            proc.StartInfo = start_info;
            // Запускаем процесс
            proc.Start();

            // Ждем, пока Блокнот запущен
            proc.WaitForExit();

            MessageBox.Show("Код завершения: " + proc.ExitCode, "Завершение " +
                "Код", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected Process[] procs;

        private void butCloseNotepad_Click(object sender, EventArgs e)
        {
            procs = Process.GetProcessesByName("Notepad");
            int i = 0;
            while (i != procs.Length)
            {
                procs[i].Kill();
                i++;
                MessageBox.Show("Всего : " + i.ToString());
            }
        }

        private void butProcCount2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                String.Format(
                "Число процессоров:  {0}", Environment.ProcessorCount.ToString()));
        }
    }
}