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
            UriBuilder ubuild = new UriBuilder(@"http:\\rusproject.narod.ru:80");
            MessageBox.Show(ubuild.Host);
            MessageBox.Show(ubuild.Port.ToString());
            MessageBox.Show(ubuild.Scheme);
            MessageBox.Show(ubuild.Uri.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UriBuilder builder = new UriBuilder("http://rusproject.narod.ru/");
            builder.Path = "index.htm";
            builder.Fragment = "main";

            Uri myUri = builder.Uri;

            MessageBox.Show(builder.ToString());
        }
    }
}