using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("alibaba@mail.ru", "Ali Baba");
            MailAddress to = new MailAddress("alladin@rambler.ru");

            MailMessage message = new MailMessage(from, to);
            message.Subject = txtSubject.Text;
            message.Body = txtBody.Text;

            // ������ �������� ������� �����
            //MailAddress copy = new MailAddress("cat@cat.com");
            //message.CC.Add(copy);

            SmtpClient client = new SmtpClient("smtp.mail.ru");
            client.Timeout = 2000;

            // �������� �������� ����������� ������������, ���� ����� ������� ������. 2 �������
            client.Credentials = CredentialCache.DefaultNetworkCredentials;  // 1 ������
            //client.UseDefaultCredentials = true;  // ����� ������������ ��������� �� ���������

            // �������� ������
            client.Send(message);
        }
    }
}