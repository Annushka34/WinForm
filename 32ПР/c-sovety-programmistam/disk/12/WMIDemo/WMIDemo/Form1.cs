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
            // ����������� � ��������� �������
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"domen\admin";
            //options.Password = "pass";

            ManagementScope scope = new ManagementScope("\\\\boss\\root\\cimv2");
            scope.Connect();


            // ����������� ���������� �� ������������ �������
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // ������� ���������� � ��������� ����

                string nl = Environment.NewLine;

                textBox1.Text = "��� ������ : " + m["CSName"] + nl;
                textBox1.Text += "������������ �������: " + m["Caption"] + nl;
                textBox1.Text += "������ ��: " + m["Version"] + nl;
                textBox1.Text += "���� ������������ �������: " + m["OSLanguage"] + nl;
                textBox1.Text += "������������������ ������������: " + m["RegisteredUser"] + nl;
                textBox1.Text += "�������� ����� ��������: " + m["SerialNumber"] + nl;
                textBox1.Text += "����� ���������: " + ManagementDateTimeConverter.ToDateTime(m["InstallDate"].ToString()) + nl;
                textBox1.Text += "����� Windows: " + m["WindowsDirectory"] + nl;
                textBox1.Text += "��������� �����: " + m["SystemDirectory"] + nl;
                textBox1.Text += "�������������: " + m["Manufacturer"] + nl;
                textBox1.Text += "��������� ���������� ������: " + m["FreePhysicalMemory"] + nl;
                textBox1.Text += "������� ����� ���������: " + m["NumberOfProcesses"] + nl;
            }

        }

        private void butComputer_Click(object sender, EventArgs e)
        {
            // ����������� � ��������� �������
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"domen\admin";
            //options.Password = "pass";

            ManagementScope scope = new ManagementScope("\\\\localhost\\root\\cimv2");
            scope.Connect();

            // ����������� ���������� � ����������
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_ComputerSystem");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // ������� ����������
                string nl = Environment.NewLine;

                textBox1.Text = "�����: " + m["Domain"] + nl;
                textBox1.Text += "������������: " + m["Manufacturer"] + nl;
                textBox1.Text += "������: " + m["Model"] + nl;
            }

        }

        private void butProduct_Click(object sender, EventArgs e)
        {
            // ����������� � ��������� �������
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

                textBox1.Text = "�������� : " + m["Description"] + nl;
                textBox1.Text += "�������� ����� : " + m["IdentifyingNumber"] + nl;
                textBox1.Text += "��� : " + m["Name"] + nl;
                textBox1.Text += "������������� �������� : " + m["UUID"] + nl;
                textBox1.Text += "������������� : " + m["Vendor"] + nl;
            }

        }

        private void butProc_Click(object sender, EventArgs e)
        {
            // ����������� � ��������� ������� 
            //ConnectionOptions options = new ConnectionOptions();
            //options.Username = @"gamma\admin";
            //options.Password = "mypass";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // ������ ������ � ��������� ������  
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
            //// ��� ����� � ������� ������
            //options.Username = @"domen\administrator";
            //// ��� ������
            //options.Password = "yourpassword";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // ����������� ���������� � ����������������
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_VideoController");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // ������� ���������� � ��������� ����
                string nl = Environment.NewLine;

                textBox1.Text = "��� : " + m["Name"] + nl;
                textBox1.Text += "��������� : " + m["VideoProcessor"] + nl;
                textBox1.Text += "�����������: " + m["AdapterRam"] + nl;
                textBox1.Text += "����������: " + m["VideoModeDescription"] + nl;
                textBox1.Text += "������� ���������� : " + m["CurrentRefreshRate"];
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

            // ����������� ���������� � �������� �������-������
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_CDROMDrive");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // ������� ���������� � ���������� ����������
                textBox1.Text = "�������� : " + mo["Description"] + nl;
                textBox1.Text += "����: " + mo["Drive"] + nl;
                textBox1.Text += "���: " + mo["MediaType"] + nl;
                textBox1.Text += "������: " + mo["Status"] + nl;
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

            // ����������� ���������� � ������� ��������
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // ������� ���������� � ���������� ����������
                textBox1.Text = "������������� : " + mo["Manufacturer"] + nl;
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

            // ����������� ���������� � ��������
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_DesktopMonitor");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // ������� ���������� � ���������� ����������
                textBox1.Text = "�������� : " + mo["Description"] + nl;
                textBox1.Text += "��� ��������: " + mo["MonitorType"] + nl;
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

            // ��� ��������� ������
            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // ����������� ���������� � ����������� �����
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_BaseBoard");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                string nl = Environment.NewLine;
                // ������� ���������� � ���������� ����������
                textBox1.Text = "Manufacturer : " + mo["Manufacturer"] + nl;
                textBox1.Text += "Name: " + mo["Name"] + nl;
            }
        }

        private void butShare_Click(object sender, EventArgs e)
        {
            // ����������� � ��������� ������� 
            ConnectionOptions options = new ConnectionOptions();
            options.Username = @"gamma\admin";
            options.Password = "password";

            //ManagementScope scope =
            //   new ManagementScope(
            //       "\\\\mymachine\\root\\cimv2", options);

            // ��� ��������� ������
            ManagementScope scope =
               new ManagementScope(
                   "\\\\localhost\\root\\cimv2");
            scope.Connect();

            // ������ ������ � ��������� ������  
            System.Management.ObjectQuery oq = new System.Management.ObjectQuery("SELECT * FROM Win32_Share");

            ManagementObjectSearcher find = new ManagementObjectSearcher(scope, oq);

            string nl = Environment.NewLine;

            foreach (ManagementObject mo in find.Get())
            {
                textBox1.Text = ("������ ����� �������� = " + mo["Name"]) + nl;
            }
        }

        private void butLogDisk_Click(object sender, EventArgs e)
        {
            // ����������� � ��������� ������� 
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

            // ������ ������ � ��������� ������  
            string cmiPath = @"\root\cimv2:Win32_LogicalDisk.DeviceID='C:'";

            ManagementObject mo = new ManagementObject(cmiPath);

            // ������� ����������
            string nl = Environment.NewLine;
            textBox1.Text = "��������: " + mo["Description"] + nl;

            textBox1.Text += "�������� �������: " + mo["FileSystem"] + nl;
            textBox1.Text += "��������: " + mo["FreeSpace"] + nl;
            textBox1.Text += "������ �����: " + mo["Size"] + nl;       

        }

        private void butReboot_Click(object sender, EventArgs e)
        {
            // ����������� � ��������� ����������� 
            ConnectionOptions options = new ConnectionOptions();
            options.Username = @"domen\admin";
            options.Password = "password";

            ManagementScope scope =
               new ManagementScope(
                   "\\\\machine\\root\\cimv2", options);
            scope.Connect();

            // ������ ������ � ��������� ������ 
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