using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QueryPerformanceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceCounter(ref long lpPerformanceCount);
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceFrequency(ref long lpFrequency);

        private void Form1_Load(object sender, EventArgs e)
        {
            long ctr1 = 0, ctr2 = 0, freq = 0;
            int acc = 0, i = 0;
            
            if (QueryPerformanceCounter(ref ctr1) != 0)	// Начинаем отчет времени
            {
                for (i = 0; i < 1000; i++) acc++;		// выполняем действия
                QueryPerformanceCounter(ref ctr2);	// заканчиваем отчет времени.
                lblInfo.Text = "Начало: " + ctr1 + Environment.NewLine;
                lblInfo.Text = lblInfo.Text + "Конец: " + ctr2 + Environment.NewLine;
                QueryPerformanceFrequency(ref freq);
                lblInfo.Text = lblInfo.Text + "Минимальное разрешение QueryPerformanceCounter: 1/" + freq + " сек." + Environment.NewLine;
                lblInfo.Text = lblInfo.Text + "Время инкрементирования до 1000: " + (ctr2 - ctr1) * 1.0 / freq + " сек.";
            }
            else
                lblInfo.Text = "Счетчик высокой точности не поддерживается.";
        }
    }
}