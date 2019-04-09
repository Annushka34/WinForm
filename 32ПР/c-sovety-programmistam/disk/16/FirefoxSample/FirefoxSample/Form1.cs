using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private Firefox fox;

        public Form1()
        {
            InitializeComponent();
            fox = new Firefox();                   
        }

        private void butOpenFirefox_Click(object sender, EventArgs e)
        {
            fox.OpenFirefox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fox.OpenFirefox("http://www.bhv.ru");
        }

        private void butTab_Click(object sender, EventArgs e)
        {
            fox.OpenFirefoxInNewTab("http://netsources.narod.ru");

        }

        private void butMozillaSite_Click(object sender, EventArgs e)
        {
            fox.OpenMozillaWebsite();
        }
    }

    class Firefox
    {
         private string firefoxPath;
 
         /// <summary>
         /// ����������� ������ Firefox.
         /// </summary>
         public Firefox()
         {
             firefoxPath =
                 string.Format(@"{0}\Mozilla Firefox\firefox.exe",
                 Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
         }
 
         /// <summary>
         /// ��������� Firefox, ���� �� ��������
         /// </summary>
         /// <param name="arguments">���-����� (url)</param>
         private void Open(string arguments)
         {
             if (!IsFirefoxAvailable())
                 throw new Exception("Firefox �� ����������.");
             else
                 Process.Start(firefoxPath, arguments);
         }
 
         /// <summary>
         /// ���������� ������� �������������� Firefox.
         /// </summary>
         /// <returns>
         /// true ���� Firefox ����������; false - ���� �� ����������.
         /// </returns>
         public bool IsFirefoxAvailable()
         {
             FileInfo fiFirefox = new FileInfo(firefoxPath);
             return fiFirefox.Exists;
         }
 
         /// <summary>
         /// ��������� Firefox.
         /// </summary>
         public void OpenFirefox()
         {
             Open(string.Empty);
         }
 
         /// <summary>
         /// ��������� Firefox c �������� url.
         /// </summary>
         /// <param name="url">url</param>
         public void OpenFirefox(string url)
         {
             Open(url);
         }
 
         /// <summary>
         /// ��������� Firefox � ���������� ������ (save mode).
         /// </summary>
         public void OpenFirefoxInSaveMode()
         {
             Open("-safe-mode");
         }
 
         /// <summary>
         /// ��������� Firefox � ����� ����.
         /// </summary>
         /// <param name="url">url</param>
         public void OpenFirefoxInNewWindow(string url)
         {
             Open(string.Format("-new-window {0}", url));
         }
 
         /// <summary>
         /// ��������� Firefox � ����� �������.
         /// </summary>
         /// <param name="url">url</param>
         public void OpenFirefoxInNewTab(string url)
         {
             Open(string.Format("-new-tab {0}", url));
         }
 
         /// <summary>
         /// ��������� ������� �������� Firefox.
         /// </summary>
         public void OpenMozillaWebsite()
         {
             Process.Start("http://www.mozilla.ru");
         }
     }
}