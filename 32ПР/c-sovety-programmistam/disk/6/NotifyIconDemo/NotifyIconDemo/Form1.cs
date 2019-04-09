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

        private bool m_CloseOK = false;


        // Массив, содержащий серию значков для создания анимации
        private Icon[] aIcons = new Icon[8];

        // текущий значок
        int curIcon = 0;

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //if (notifyIcon1.Visible)
            //    notifyIcon1.Visible = false;
            //else
            //    notifyIcon1.Visible = true;

            notifyIcon1.Icon = aIcons[curIcon];
            curIcon++;
            if (curIcon > 7) curIcon = 0;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            notifyIcon1.Visible = true;
            //MessageBox.Show("Мигание приостановлено");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // загружаем серию значков
            aIcons[0] = new Icon("moon01.ico");
            aIcons[1] = new Icon("moon02.ico");
            aIcons[2] = new Icon("moon03.ico");
            aIcons[3] = new Icon("moon04.ico");
            aIcons[4] = new Icon("moon05.ico");
            aIcons[5] = new Icon("moon06.ico");
            aIcons[6] = new Icon("moon07.ico");
            aIcons[7] = new Icon("moon08.ico");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Пользователь выходит из программы не через контекстное меню
            if (m_CloseOK == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // выходим из программы по-настоящему
            m_CloseOK = true;
            this.Close();
        }
    }
}