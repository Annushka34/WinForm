using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemInformationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Получим системную информацию для локальной машины.
            AddSysInfoItem("ComputerName", SystemInformation.ComputerName.ToString());
            AddSysInfoItem("UserDomainName", SystemInformation.UserDomainName.ToString());
            AddSysInfoItem("UserName", SystemInformation.UserName.ToString());
            AddSysInfoItem("Network", SystemInformation.Network.ToString());
            AddSysInfoItem("Secure", SystemInformation.Secure.ToString());
            AddSysInfoItem("Monitor Count", SystemInformation.MonitorCount.ToString());
            AddSysInfoItem("MousePresent", SystemInformation.MousePresent.ToString());
            AddSysInfoItem("MouseButtons", SystemInformation.MouseButtons.ToString());
            AddSysInfoItem("MouseButtonsSwapped", SystemInformation.MouseButtonsSwapped.ToString());
            AddSysInfoItem("Mouse Wheel", SystemInformation.MouseWheelPresent.ToString());
            AddSysInfoItem("UserInteractive", SystemInformation.UserInteractive.ToString()); 
        }

        /// <summary>
        /// Получаем пару строковых значений
        /// </summary>
        /// <param name="property">Свойство</param>
        /// <param name="propertyvalue">Значение свойства</param>
        private void AddSysInfoItem(string property, string propertyvalue)
        {
            ListViewItem lvt;
            lvt = listView1.Items.Add(property);
            lvt.SubItems.Add(propertyvalue);
        }
    }
}