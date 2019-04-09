using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA",
        CharSet = CharSet.Ansi)]
        public static extern int mciSendString(string strCommand,
        StringBuilder strReturnString, int cchReturn, IntPtr hwndCallback);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

            this.Text = WMP.versionInfo;
            // Укажите собственный путь к файлу
            WMP.URL = @"C:\Documents and Settings\All Users\Documents\My Music\music.wma";
            WMP.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\MyBook\FunVB\15\PlaySound\town.MID";
            //  Открываем устройство с файлом town.MID
            //  player является идентификатором device_id.
            mciSendString("open " + fileName + " type sequencer alias player", null, 0, IntPtr.Zero);
            mciSendString("play player", null, 0, IntPtr.Zero);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Закрываем файл TOWN.MID и устройство
            mciSendString("close player", null, 0, IntPtr.Zero);
        }
    }
}