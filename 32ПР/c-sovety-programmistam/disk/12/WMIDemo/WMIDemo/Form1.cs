using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace WMIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void butOS_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленной машиной
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"domen\admin";
            //options.Password = "pass";

            ManagementScope scope = new ManagementScope("\\\\boss\\root\\cimv2");
            scope.Connect();


            // Запрашиваем информацию об операционной системе
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // Выводим информацию в текстовое поле

                string nl = Environment.NewLine;

                textBox1.Text = "Имя машины : " + m["CSName"] + nl;
                textBox1.Text += "Операционная система: " + m["Caption"] + nl;
                textBox1.Text += "Версия ОС: " + m["Version"] + nl;
                textBox1.Text += "Язык операционной системы: " + m["OSLanguage"] + nl;
                textBox1.Text += "Зарегистрированный пользователь: " + m["RegisteredUser"] + nl;
                textBox1.Text += "Серийный номер продукта: " + m["SerialNumber"] + nl;
                textBox1.Text += "Время установки: " + ManagementDateTimeConverter.ToDateTime(m["InstallDate"].ToString()) + nl;
                textBox1.Text += "Папка Windows: " + m["WindowsDirectory"] + nl;
                textBox1.Text += "Системная папка: " + m["SystemDirectory"] + nl;
                textBox1.Text += "Производитель: " + m["Manufacturer"] + nl;
                textBox1.Text += "Доступная физическая память: " + m["FreePhysicalMemory"] + nl;
                textBox1.Text += "Текущее число процессов: " + m["NumberOfProcesses"] + nl;
            }

        }

        private void butComputer_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленной машиной
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"domen\admin";
            //options.Password = "pass";

            ManagementScope scope = new ManagementScope("\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Запрашиваем информацию о компьютере
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_ComputerSystem");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // Выводим информацию
                string nl = Environment.NewLine;

                textBox1.Text = "Домен: " + m["Domain"] + nl;
                textBox1.Text += "Изготовитель: " + m["Manufacturer"] + nl;
                textBox1.Text += "Модель: " + m["Model"] + nl;
            }

        }

        private void butProduct_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленной машиной
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"domen\admin";
            //options.Password = "pass";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_ComputerSystemProduct");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // Display the remote computer information

                string nl = Environment.NewLine;

                textBox1.Text = "Описание : " + m["Description"] + nl;
                textBox1.Text += "Серийный номер : " + m["IdentifyingNumber"] + nl;
                textBox1.Text += "Имя : " + m["Name"] + nl;
                textBox1.Text += "Идентификатор продукта : " + m["UUID"] + nl;
                textBox1.Text += "Производитель : " + m["Vendor"] + nl;
            }

        }

        private void butProc_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленной машиной 
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"gamma\admin";
            //options.Password = "mypass";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Делаем запрос к удаленной машине  
            WqlObjectQuery query = new WqlObjectQuery("Select * from Win32_Processor");

            ManagementObjectSearcher find = new ManagementObjectSearcher(query);
            string nl = Environment.NewLine;
            int i = 0;

            foreach (ManagementObject mo in find.Get())
            {

                textBox1.Text += ("-------------- Processor #" + i + " --------------") + nl;
                textBox1.Text += ("Processor address width in bits.............." + mo["AddressWidth"]) + nl;
                textBox1.Text += ("Caption......................................" + mo["Caption"]) + nl;
                textBox1.Text += ("Processor address width in bits.............." + mo["AddressWidth"]) + nl;
                textBox1.Text += ("Current clock speed (in MHz)................." + mo["CurrentClockSpeed"]) + nl;
                textBox1.Text += ("Processor data width........................." + mo["DataWidth"]) + nl;
                textBox1.Text += ("Unique string identification................." + mo["DeviceID"]) + nl;
                textBox1.Text += ("External clock frequency....................." + mo["ExtClock"]) + nl;
                textBox1.Text += ("Processor data width........................." + mo["DataWidth"]) + nl;
                textBox1.Text += ("L2 cache size................................" + mo["L2CacheSize"]) + nl;
                textBox1.Text += ("L2 cache speed..............................." + mo["L2CacheSpeed"]) + nl;
                textBox1.Text += ("Load percentage (average value for second)..." + mo["LoadPercentage"]) + nl;
                textBox1.Text += ("Manufacturer................................." + mo["Manufacturer"]) + nl;
                textBox1.Text += ("Maximum speed (in MHz)......................." + mo["MaxClockSpeed"]) + nl;
                textBox1.Text += ("Name........................................." + mo["Name"]) + nl;
                textBox1.Text += ("Support for power management................." + mo["PowerManagementSupported"]) + nl;
                textBox1.Text += ("Unique identificator describing processor...." + mo["ProcessorId"]) + nl;
                textBox1.Text += ("Role (CPU/math).............................." + mo["Role"]) + nl;
                textBox1.Text += ("Socket designation..........................." + mo["SocketDesignation"]) + nl;
                textBox1.Text += ("Status......................................." + mo["Status"]) + nl;
                textBox1.Text += ("Processor version............................" + mo["Version"]) + nl;
                textBox1.Text += ("Socket voltage..............................." + mo["VoltageCaps"]) + nl;
                i++;
            }

        }

        private void butVideo_Click(object sender, EventArgs e)
        {
            //ConnectionOptions options = new ConnectionOptions();
            //// ваш домен и учетная запись
            //options.Username = @"domen\administrator";
            //// ваш пароль
            //options.Password = "yourpassword";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Запрашиваем информацию о видеоконтроллере
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_VideoController");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // Выводим информацию в текстовое поле
                string nl = Environment.NewLine;

                textBox1.Text = "Имя : " + m["Name"] + nl;
                textBox1.Text += "Процессор : " + m["VideoProcessor"] + nl;
                textBox1.Text += "Видеопамять: " + m["AdapterRam"] + nl;
                textBox1.Text += "Разрешение: " + m["VideoModeDescription"] + nl;
                textBox1.Text += "Частота обновления : " + m["CurrentRefreshRate"];
            }
        }

        private void butCDRom_Click(object sender, EventArgs e)
        {
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"gamma\admin";
            //options.Password = "mypass";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Запрашиваем информацию о приводах компакт-дисков
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_CDROMDrive");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // Выводим информацию с удаленного компьютера
                textBox1.Text = "Описание : " + mo["Description"] + nl;
                textBox1.Text += "Диск: " + mo["Drive"] + nl;
                textBox1.Text += "Тип: " + mo["MediaType"] + nl;
                textBox1.Text += "Статус: " + mo["Status"] + nl;
            }

        }

        private void butAdapter_Click(object sender, EventArgs e)
        {
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"gamma\admin";
            //options.Password = "password";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Запрашиваем информацию о сетевом адаптере
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // Выводим информацию с удаленного компьютера
                textBox1.Text = "Производитель : " + mo["Manufacturer"] + nl;
                textBox1.Text += "MACAddress: " + mo["MACAddress"] + nl;
                textBox1.Text += "ProductName: " + mo["ProductName"] + nl;
                textBox1.Text += "AdapterType: " + mo["AdapterType"] + nl;
                textBox1.Text += "CreationClassName: " + mo["CreationClassName"] + nl;
            }
        }

        private void butMonitor_Click(object sender, EventArgs e)
        {
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"gamma\admin";
            //options.Password = "password";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Запрашиваем информацию о мониторе
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_DesktopMonitor");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // Выводим информацию с удаленного компьютера
                textBox1.Text = "Описание : " + mo["Description"] + nl;
                textBox1.Text += "Тип монитора: " + mo["MonitorType"] + nl;
            }
        }

        private void butBoard_Click(object sender, EventArgs e)
        {
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"gamma\admin";
            //options.Password = "password";

            //ManagementScope scope =
            //   new ManagementScope(
            //       "\\\\smena01\\root\\cimv2", options);

            // для локальной машины
            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Запрашиваем информацию о материнской плате
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_BaseBoard");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // Выводим информацию с удаленного компьютера
                textBox1.Text = "Manufacturer : " + mo["Manufacturer"] + nl;
                textBox1.Text += "Name: " + mo["Name"] + nl;
            }
        }

        private void butShare_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленной машиной 
            ConnectionOptions options = new ConnectionOptions();
            options.Username = @"gamma\admin";
            options.Password = "password";

            //ManagementScope scope =
            //   new ManagementScope(
            //       "\\\\mymachine\\root\\cimv2", options);

            // для локальной машины
            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Делаем запрос к удаленной машине  
            System.Management.ObjectQuery oq = new System.Management.ObjectQuery("SELECT * FROM Win32_Share");

            ManagementObjectSearcher find = new ManagementObjectSearcher(scope, oq);

            string nl = Environment.NewLine;

            foreach (ManagementObject mo in find.Get())
            {
                textBox1.Text = ("Список общих ресурсов = " + mo["Name"]) + nl;
            }
        }

        private void butLogDisk_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленной машиной 
            ConnectionOptions options = new ConnectionOptions();
            options.Username = @"gamma\admin";
            options.Password = "password";

            //ManagementScope scope =
            //   new ManagementScope(
            //       "\\\\support\\root\\cimv2", options);

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // Делаем запрос к удаленной машине  
            string cmiPath = @"\root\cimv2:Win32_LogicalDisk.DeviceID='C:'";

            ManagementObject mo = new ManagementObject(cmiPath);

            // Выводим информацию
            string nl = Environment.NewLine;
            textBox1.Text = "Описание: " + mo["Description"] + nl;

            textBox1.Text += "Файловая система: " + mo["FileSystem"] + nl;
            textBox1.Text += "Свободно: " + mo["FreeSpace"] + nl;
            textBox1.Text += "Размер диска: " + mo["Size"] + nl;       

        }

        private void butReboot_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленным компьюетром 
            ConnectionOptions options = new ConnectionOptions();
            options.Username = @"domen\admin";
            options.Password = "password";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\machine\\root\\cimv2", options);
            scope.Connect();

            // Делаем запрос к удаленной машине 
            System.Management.ObjectQuery oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher query1 = new ManagementObjectSearcher(scope, oq);
            ManagementObjectCollection queryCollection1 = query1.Get();

            foreach (ManagementObject mo in queryCollection1)
            {
                string[] ss ={ "" };
                mo.InvokeMethod("Reboot", ss);
                this.Text = mo.ToString();
            }
        }
    }
}