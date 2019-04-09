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
            // ... � ��� �����
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
            txtLinesCount.Text += "� ��������� ��� �������;";
            txtLinesCount.Text += "������ ���� �� ���� ���: � ���� � ����� ��� ������"; 
            txtLinesCount.Text += "��� ����� �� ���� ������";
            //
            txtLinesCount.Text = "���\r\n���\r\n���";
            // ��������� ����������� ����
            txtLinesCount.ContextMenu = new ContextMenu();
            // ������� ������ �����
            //string[] strWeekDay = { "�����������", "�������", "�����" };
            //txtLinesCount.Multiline = true;
            //txtLinesCount.Lines = strWeekDay;

            txtLinesCount.Text = "������ ����:" + Environment.NewLine + "�������" + Environment.NewLine + "������...";
        }

        private void butCount_Click(object sender, EventArgs e)
        {
            int LineCount;
            LineCount = SendMessage(txtLinesCount.Handle, EM_GETLINECOUNT, 0, 0);
            MessageBox.Show("����� �����: " + LineCount);
            textBox1.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
                SendKeys.Send("{TAB}"); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // ��������� ����� �� ��������� ������� ���������� ����� ����� 7 ��������
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
            //��������� ������������ WM_PASTE
            if (m.Msg == WM_PASTE)
                return;
            base.WndProc(ref m);
        }
    }
}