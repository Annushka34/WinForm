using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            // Выводим окно в нижнем правом углу
            this.SetBounds(Screen.GetWorkingArea(this).Width - this.Width,
                Screen.GetWorkingArea(this).Height - this.Height,
                this.Width, this.Height);

        }

        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }

        private const int CS_DROPSHADOW = 0x00020000;

        // Переопределяем свойства CreateParams
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 161;
            const int WM_SYSCOMMAND = 274;
            const int HTCAPTION = 2;
            const int SC_MOVE = 61456;

            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
            {
                return;
            }

            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION))
            {
                return;
            }

            base.WndProc(ref m);
        } 

    }
}