using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SystemEvents.DisplaySettingsChanged += new EventHandler(DisplaySettingsChanged);
            SystemEvents.DisplaySettingsChanging +=new EventHandler(DisplaySettingsChanging);
            SystemEvents.TimeChanged += new EventHandler(SystemEvents_TimeChanged);
        }

        void DisplaySettingsChanged(object obj, EventArgs ea)
        {
            MessageBox.Show("Вы изменили разрешение экрана");
        }

        void DisplaySettingsChanging(object obj, EventArgs ea)
        {
            MessageBox.Show("Разрешение экрана изменилось");
        }

        void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            this.Text = "Вы зачем поменяли системное время?";
        }



    }
}