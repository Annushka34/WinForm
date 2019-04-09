using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop.Outlook;
using OutLookApp = Microsoft.Office.Interop.Outlook.Application;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void outLookApp_NewMailEx(string EntryIDCollection)
        {
            MessageBox.Show("Вы получили новое письмо, чей EntryIDCollection: \n" + 
                EntryIDCollection,
                "Новое письмо", MessageBoxButtons.OK);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Создадим объект Outlook
            ApplicationClass outLookApp = new ApplicationClass();

            // Обработчик события для поступления новых писем
            outLookApp.NewMailEx += new ApplicationEvents_11_NewMailExEventHandler(
                outLookApp_NewMailEx);
            this.Text = "Ждем новых писем...";
        }
    }
}