using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ComboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.Font = new Font("Arial", 16);
            // Устанавливаем желаемую высоту
            SendMessage(comboBox1.Handle, CB_SETITEMHEIGHT, -1, 40);

            mycomboBox cboNotDrop = new mycomboBox();
            cboNotDrop.Parent = this;
            cboNotDrop.Width = 140;
            cboNotDrop.Height = 60;
            cboNotDrop.Items.Add("One");
            cboNotDrop.Items.Add("Two");
            // ... и так далее

        }

        const int CB_SETITEMHEIGHT = 0x0153;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, 
            UInt32 Msg, Int32 wParam, UInt32 lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = comboBox1.CreateGraphics();
            float maxWidth = 0f;
            foreach (object o in comboBox1.Items)
            {
                float w = g.MeasureString(o.ToString(), comboBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
            }
            g.Dispose();
            // 28 - учитываем ширину кнопки в поле со списком
            comboBox1.Width = (int)maxWidth + 28; 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
            else
                base.OnKeyPress(e); 
        }
    }

    public class mycomboBox : ComboBox
    {

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // константы для левой кнопки мыши 
            const int WM_LBUTTONDOWN = 0x201;
            const int WM_LBUTTONDBLCLK = 0x203;

            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_LBUTTONDBLCLK)
                return;
            base.WndProc(ref m);
        }
    }
}