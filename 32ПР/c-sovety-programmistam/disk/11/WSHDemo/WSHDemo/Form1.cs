using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using IWshRuntimeLibrary;

namespace WSHDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butNetworkDrives_Click(object sender, EventArgs e)
        {
            WshNetwork network = new WshNetwork();
            foreach (IEnumerable driver in network.EnumNetworkDrives())
            {
                MessageBox.Show(driver.ToString());
            }
        }

        private void butCreateShortcut_Click(object sender, EventArgs e)
        {
            // �������� ����� �� ������� �����
            object shortDesktop = (object)"Desktop";

            WshShell shell = new WshShell();
            // ���� � ������
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shortDesktop) + @"\���������.lnk";

            // ������� ������ ������
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);

            // ������ �������� ��� ������
            // �������� ������ � ����������� ���������
            shortcut.Description = "����� ��� ���������� ���������";
            // ������� �������
            shortcut.Hotkey = "Ctrl+Shift+N";
            // ���� � ����� ��������� �������
            shortcut.TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\notepad.exe";

            // ��� ������. ����� ��������� �����
            shortcut.Save();
        }

        private void butGetPrinters_Click(object sender, EventArgs e)
        {
            WshNetwork network = new WshNetwork();

            foreach (IEnumerable printer in network.EnumPrinterConnections())
            {
                listBox1.Items.Add(printer);
            }
        }

        private void butSetDefaultPrinter_Click(object sender, EventArgs e)
        {
            WshNetwork network = new WshNetwork();

            // ������� ������ ���������
            IWshCollection Printers = network.EnumPrinterConnections();

            if (Printers.Count() > 0)
            {
                // �������� ������ ���������������� ��������
                object index = (object)"1";
                // ������������� ��������� ������� ��� ������� �� ���������
                network.SetDefaultPrinter((string)Printers.Item(ref index));
            }
        }
    }
}