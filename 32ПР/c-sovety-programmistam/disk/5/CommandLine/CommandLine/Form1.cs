using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

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
            String[] arguments = Environment.GetCommandLineArgs();
            textBox1.Text = arguments[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {   // если есть аргумент командной строки
                if (Environment.GetCommandLineArgs()[1] == "csharp")
                { // если первый аргумент оканчивается на csharp
                    this.Text = "Зарегистрированный пользователь";
                }
                else
                {
                    MessageBox.Show("У вас нет прав для запуска программы");
                    this.Close();
                }
            }
            else
            {
                // Запретить запуск программы
                MessageBox.Show("У вас нет прав для запуска программы");
                this.Close();
            }     
        }
    }
}
 
