using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace FormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Снимите комментарий, если хотите развернуть окно на весь экран
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //MaximumSize = new Size(400, 400);
            MinimumSize = new Size(250, 250);
            this.Text = "Тема XP: " + IsThemeActive().ToString();

        }

        [DllImport("uxtheme.dll")]
        static extern bool IsThemeActive();
               

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 secondform = new Form2();
            secondform.Show();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Свернем форму программно
            WindowState = FormWindowState.Minimized;          
        }

        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_RESTORE = 0xF120;
        const int WM_NCLBUTTONDBLCLK = 0x00A3;
        const int HTCAPTION = 2;
        public string strInfo;

        const int WM_THEMECHANGED = 0x031A;
        
        protected override void WndProc(ref Message msg)
        {
            bool isStateChanging = false;
            
            switch (msg.Msg)
            {
                case WM_SYSCOMMAND:
                    switch (msg.WParam.ToInt32())
                    {
                        case SC_MINIMIZE:
                            isStateChanging = true;
                            strInfo = "Сворачиваемся";
                            break;
                        case SC_MAXIMIZE:
                            strInfo = "Разворачиваемся";
                            isStateChanging = true;
                            break;
                        case SC_RESTORE:
                            strInfo = "Восстанавливаемся";
                            isStateChanging = true;
                            break;
                    }
                    break;
                case WM_NCLBUTTONDBLCLK:
                    if (msg.WParam.ToInt32() == HTCAPTION)
                    {
                        isStateChanging = true;
                        if (WindowState == FormWindowState.Maximized)
                            strInfo = "Восстанавливаемся";
                        else
                            strInfo = "Разворачиваемся";
                    }
                    break;
                case WM_THEMECHANGED:
                    MessageBox.Show("Стиль изменился!");
                    break;
            }
            if (isStateChanging)
                MessageBox.Show(strInfo);
            base.WndProc(ref msg);
        }
         
        public static string TestString = "";
        


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string EASTER_EGG = "ТЕЩА";

            TestString = TestString + e.KeyChar.ToString().ToUpper();
            this.Text = TestString;
            if (EASTER_EGG.Substring(0, TestString.Length) != TestString)
            {
                TestString = "";
            }
            
            else
            {
                if (EASTER_EGG == TestString)
                {
                    MessageBox.Show("Возьми с полки пирожок");
                    TestString = "";

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("Не положено!");
                e.Cancel = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Выводим форму в центре экрана
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Все равно не закроется!
            this.Close();
        }

    }
}