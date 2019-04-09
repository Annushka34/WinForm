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
         /// Конструктор класса Firefox.
         /// </summary>
         public Firefox()
         {
             firefoxPath =
                 string.Format(@"{0}\Mozilla Firefox\firefox.exe",
                 Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
         }
 
         /// <summary>
         /// Открывает Firefox, если он доступен
         /// </summary>
         /// <param name="arguments">веб-адрес (url)</param>
         private void Open(string arguments)
         {
             if (!IsFirefoxAvailable())
                 throw new Exception("Firefox не установлен.");
             else
                 Process.Start(firefoxPath, arguments);
         }
 
         /// <summary>
         /// Определяет наличие установленного Firefox.
         /// </summary>
         /// <returns>
         /// true если Firefox установлен; false - если не установлен.
         /// </returns>
         public bool IsFirefoxAvailable()
         {
             FileInfo fiFirefox = new FileInfo(firefoxPath);
             return fiFirefox.Exists;
         }
 
         /// <summary>
         /// Запускает Firefox.
         /// </summary>
         public void OpenFirefox()
         {
             Open(string.Empty);
         }
 
         /// <summary>
         /// Запускает Firefox c заданнам url.
         /// </summary>
         /// <param name="url">url</param>
         public void OpenFirefox(string url)
         {
             Open(url);
         }
 
         /// <summary>
         /// Запускает Firefox в безопасном режиме (save mode).
         /// </summary>
         public void OpenFirefoxInSaveMode()
         {
             Open("-safe-mode");
         }
 
         /// <summary>
         /// Открывает Firefox в новом окне.
         /// </summary>
         /// <param name="url">url</param>
         public void OpenFirefoxInNewWindow(string url)
         {
             Open(string.Format("-new-window {0}", url));
         }
 
         /// <summary>
         /// Открывает Firefox в новой вкладке.
         /// </summary>
         /// <param name="url">url</param>
         public void OpenFirefoxInNewTab(string url)
         {
             Open(string.Format("-new-tab {0}", url));
         }
 
         /// <summary>
         /// Открывает русскую страницу Firefox.
         /// </summary>
         public void OpenMozillaWebsite()
         {
             Process.Start("http://www.mozilla.ru");
         }
     }
}