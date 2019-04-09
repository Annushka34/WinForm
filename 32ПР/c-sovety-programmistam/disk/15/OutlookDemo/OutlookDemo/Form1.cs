using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;

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
            // Create the Outlook application.
            // in-line initialization
            Outlook.Application oApp = new Outlook.Application();

            // Get the MAPI namespace.
            Outlook.NameSpace oNS = oApp.GetNamespace("mapi");

            // Log on by using the default profile or existing session (no dialog box).
            oNS.Logon(Missing.Value, Missing.Value, false, true);

            // Alternate logon method that uses a specific profile name.
            // TODO: If you use this logon method, specify the correct profile name
            // and comment the previous Logon line.
            //oNS.Logon("profilename",Missing.Value,false,true);

            //Get the Inbox folder.
            Outlook.MAPIFolder oInbox =
                    oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

            //Get the Items collection in the Inbox folder.
            Outlook.Items oItems = oInbox.Items;

            // Get the first message.
            // Because the Items folder may contain different item types,
            // use explicit typecasting with the assignment.
            Outlook.MailItem oMsg = (Outlook.MailItem)oItems.GetFirst();

            //Output some common properties.
            textBox1.Text = (oMsg.Subject);
            textBox1.Text += textBox1.Text + oMsg.SenderName;
            textBox1.Text += textBox1.Text + oMsg.ReceivedTime;
            textBox1.Text += textBox1.Text + oMsg.Body;

            //Check for attachments.
            int AttachCnt = oMsg.Attachments.Count;
            textBox1.Text += textBox1.Text + ("Attachments: " + AttachCnt.ToString());

            //TO DO: If you use the Microsoft Outlook 11.0 Object Library, uncomment the following lines.
            if (AttachCnt > 0) 
            {
                for (int i = 1; i <= AttachCnt; i++)
                    textBox1.Text += textBox1.Text + (i.ToString() + "-" + oMsg.Attachments[i].DisplayName);
            }


            //Display the message.
            oMsg.Display(false);  //modal

            //Log off.
            oNS.Logoff();

            //Explicitly release objects.
            oMsg = null;
            oItems = null;
            oInbox = null;
            oNS = null;
            oApp = null;
 		}
    }
}