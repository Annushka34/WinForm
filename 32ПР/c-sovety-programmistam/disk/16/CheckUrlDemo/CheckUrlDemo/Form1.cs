using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool CheckUrl(string url)
        {
            bool rt = false;
            if (url.ToLower().StartsWith("www."))
            {
                url = "http://" + url;
            }

            HttpWebResponse myResponse = null;
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
                myResponse = (HttpWebResponse)myRequest.GetResponse();
                //code = myResponse.StatusCode;
                rt = true;
            }
            catch (WebException err)
            {
                rt = false;
            }
            finally
            {
                if (!(myResponse == null))
                {
                    myResponse.Close();
                }
            }
            return rt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CheckUrl(textBox1.Text).ToString());
        }
  

    }
}