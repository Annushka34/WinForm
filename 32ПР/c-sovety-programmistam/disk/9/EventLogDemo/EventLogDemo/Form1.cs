using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

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
            EventLog[] eventLogs;
            // Получим список журналов событий для локального компьютера
            eventLogs = EventLog.GetEventLogs(System.Environment.MachineName);
            this.Text = "Число журналов событий: " + eventLogs.Length;

            for (int i = 0; i < eventLogs.Length; i++)
            {
                listBox1.Items.Add(eventLogs[i].Log);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //logType может быть Application, Security, System или собственный журнал событий
            string logType = "MyNewLog";

            EventLog ev = new EventLog(logType, System.Environment.MachineName);
            int LastLogToShow = ev.Entries.Count;
            if (LastLogToShow <= 0)
                MessageBox.Show("Нет записей в журнале событий: " + logType);
            else
            {
                // Read the last 2 records in the specified log. 
                int i;
                for (i = ev.Entries.Count - 1; i >= LastLogToShow - 2; i--)
                {
                    EventLogEntry CurrentEntry = ev.Entries[i];
                    listBox1.Items.Add("Event ID : " + CurrentEntry.InstanceId);
                    listBox1.Items.Add("Entry Type : " + CurrentEntry.EntryType.ToString());
                    listBox1.Items.Add("Message :  " + CurrentEntry.Message);
                }
                ev.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создадим источник, если он не существует
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
            }

            EventLog myLog = new EventLog();
            myLog.Source = "MySource";

            // Делаем запись в журнал событий    
            myLog.WriteEntry("Сделана запись.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Создаем источник, если он еще не существует
            if (!(EventLog.SourceExists("MySour", System.Environment.MachineName)))
            {
                EventSourceCreationData mySourceData = new EventSourceCreationData("MySour", "myLog");
                EventLog.CreateEventSource(mySourceData);

                MessageBox.Show("CreatingEventSource");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string logName = "MyLog";
            if (EventLog.SourceExists("MyOldSource", System.Environment.MachineName))
            {
                logName = EventLog.LogNameFromSourceName("MySour", System.Environment.MachineName);
                EventLog.DeleteEventSource("MySour", System.Environment.MachineName);
                EventLog.Delete(logName, System.Environment.MachineName);
                MessageBox.Show(logName + " удален.");
            }    

        }


    }
}