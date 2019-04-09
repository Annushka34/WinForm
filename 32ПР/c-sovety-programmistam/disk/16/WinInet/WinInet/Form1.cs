using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        static extern bool InternetGetConnectedState(
            ref InternetConnectionState  lpdwFlags, int dwReserved);


        [Flags]
        enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        } 


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InternetConnectionState flags = 0;
            bool checkStatus = InternetGetConnectedState(ref flags, 0);
            MessageBox.Show(checkStatus.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string remoteUri = "http://rusproject.narod.ru/image/";
            string fileName = "ruspro.gif", myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            textBox1.Text = "Загружаем файл " + fileName + " из " + myStringWebResource + "\r\n";
            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(myStringWebResource, "c:\\" + fileName);
            textBox1.Text += "Файл " + fileName + " из " + myStringWebResource + " успешно загружен" +"\r\n";
            textBox1.Text += "Загруженный файл сохранен на диске C:";
        }
    }
}