using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace WindowsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool oneonly;
            Mutex m = new Mutex(true, "My prog", out oneonly);

            if (oneonly)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Это приложение уже запущено.");
            }
        }
    }
}