using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        static void SetRule(string filePath, string account,
            FileSystemRights rights, AccessControlType controlType)
        {
            // Получим объект FileSecurity, который устанавливает
            // текущие настройки безопасности
            FileSecurity fSecurity = File.GetAccessControl(filePath);
            // Добавим FileSystemAccessRule к настройкам безопасности
            fSecurity.ResetAccessRule(new FileSystemAccessRule(account,
            rights, controlType));
            // Устанавливаем новые настройки доступа
            File.SetAccessControl(filePath, fSecurity);
        }

        private void butAllowAccess_Click(object sender, EventArgs e)
        {
            // Разрешить доступ к файлу пользователю alexander
            SetRule(@"d:\test.txt", "alexander",
            FileSystemRights.Read, AccessControlType.Allow);
        }

        private void butDenyAccess_Click(object sender, EventArgs e)
        {
            // Отказать в доступе пользователю alexander
            SetRule(@"d:\test.txt", "alexander",
            FileSystemRights.Read, AccessControlType.Deny);
        }



        

    }
}