using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // —оздадим метод дл€ создани€ нашего нового процесса
        private void createproc(string fname, string arg)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fname;
            proc.StartInfo.Arguments = arg;
            proc.Start();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            // “еперь с помощью этого метода будем регистрировать dll или ocx
            //fname Ц им€ программы дл€ регистрации файлов
            //arg Ц задает аргументы дл€ этого файла
            createproc("RegSvr32", " /s \"C:\\WINDOWS\\system32\\shdocvw.dll\"");
            // пример выше регистрирует файл shdocvw.dll без вывода сообщени€
            // мы использовали полный путь файла, но можно чуть изменить пример,
            // если файл находитс€ в одной папке с приложением
            createproc("RegSvr32", " /s \"" + Application.StartupPath + "\\myappdll.dll\"");
            // вот другие параметры, используемые regsvr32:
            // optional values []
            // regsvr32 [/u] [/s] [/n] [/i[:cmdline]  ] dllname
            // /u = сн€ть регистрацию файла
            // /s = silent (без вывода сообщени€)
            // /i = call dllinstall pasing it an optional [cmdline] (when used with /u calls dll uninstall)
            // /n = do not call dllregisterserver (this option must be used with /i 

        }

    }
}