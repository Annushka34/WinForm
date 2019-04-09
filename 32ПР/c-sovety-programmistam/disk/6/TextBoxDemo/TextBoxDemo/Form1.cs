using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxEx txtNotPaste = new TextBoxEx();
            txtNotPaste.Parent = this;
            txtNotPaste.Multiline = true;
            txtNotPaste.Height = 60;
            // ... и так далее
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, 
            UInt32 Msg, UInt32 wParam, UInt32 lParam);

        const int EM_GETLINECOUNT = 0x00BA;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLinesCount.Multiline = true;
            txtLinesCount.WordWrap = true;
            txtLinesCount.Height = 98;
            txtLinesCount.Text += "У Лукоморья дуб зеленый;";
            txtLinesCount.Text += "Златая цепь на дубе том: И днем и ночью кот ученый"; 
            txtLinesCount.Text += "Все ходит по цепи кругом";
            //
            txtLinesCount.Text = "Раз\r\nДва\r\nТри";
            // Блокируем контекстное меню
            txtLinesCount.ContextMenu = new ContextMenu();
            // создаем массив строк
            //string[] strWeekDay = { "Понедельник", "Вторник", "Среда" };
            //txtLinesCount.Multiline = true;
            //txtLinesCount.Lines = strWeekDay;

            txtLinesCount.Text = "Месяцы года:" + Environment.NewLine + "Декабрь" + Environment.NewLine + "Январь...";
        }

        private void butCount_Click(object sender, EventArgs e)
        {
            int LineCount;
            LineCount = SendMessage(txtLinesCount.Handle, EM_GETLINECOUNT, 0, 0);
            MessageBox.Show("Число строк: " + LineCount);
            textBox1.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
                SendKeys.Send("{TAB}"); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Переводим фокус на следующий элемент управления после ввода 7 символов
            const int MAX_LENGTH = 7;
            if (textBox2.Text.Length == MAX_LENGTH)
                this.SelectNextControl(textBox2, true, true, false, false); 
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == textBox1.MaxLength && textBox1.SelectedText == "")
            {
                textBox1.SelectionLength = 1;
            } 

        }
    }

    class TextBoxEx : TextBox
    {
        const int WM_PASTE = 0x0302;
        protected override void WndProc(ref Message m)
        {
            //Запрещаем обрабатывать WM_PASTE
            if (m.Msg == WM_PASTE)
                return;
            base.WndProc(ref m);
        }
    }
}