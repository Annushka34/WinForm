using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace AdvancedMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "SwapMouseButton")]
        internal extern static int SwapMouseButton(int bSwap);

        private void butSwapMouse_Click(object sender, EventArgs e)
        {
            // Меняем кнопки мыши местами
            SwapMouseButton(1);
        }

        private void butRestoreMouse_Click(object sender, EventArgs e)
        {
            // Восстанавливаем настройки мыши
            SwapMouseButton(0);
        } 

    }
}