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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"c:\windows\media\tada.wav";
            player.Play();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}