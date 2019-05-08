using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---name for saving our signing
        string fileSaveSoundName = @"D://mySound.wav";
        // WaveIn - stream for sounds
        WaveIn waveIn;
        // stream for saving to file
        WaveFileWriter writer;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                player.settings.autoStart = false;
                player.URL = openFileDialog1.FileName;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Start Recording");
                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += WaveIn_DataAvailable; ;
              //  waveIn.RecordingStopped += WaveIn_RecordingStopped; ; 
                waveIn.WaveFormat = new WaveFormat(8000, 1);
                writer = new WaveFileWriter(fileSaveSoundName, waveIn.WaveFormat);
                waveIn.StartRecording();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        //private void WaveIn_RecordingStopped(object sender, EventArgs e)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.BeginInvoke(new EventHandler(WaveIn_RecordingStopped), sender, e);
        //    }
        //    else
        //    {
        //        waveIn.Dispose();
        //        waveIn = null;
        //        writer.Close();
        //        writer = null;
        //    }
        //}

      

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable), sender, e);
            }
            else
            {
                //Записываем данные из буфера в файл
                writer.WriteData(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveIn != null)
            {
                MessageBox.Show("StopRecording");
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
                writer.Close();
                writer = null;
            }
        }
    }
}
