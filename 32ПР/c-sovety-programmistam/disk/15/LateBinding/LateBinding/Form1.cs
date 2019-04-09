using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

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
            object objApp_Late;
            object objBook_Late;
            object objBooks_Late;
            object objSheets_Late;
            object objSheet_Late;
            object objRange_Late;
            object[] Parameters;

            try
            {
                // Получение типа класса и создание экземпляра Excel.
                Type objClassType;
                objClassType = Type.GetTypeFromProgID("Excel.Application");
                objApp_Late = Activator.CreateInstance(objClassType);

                //Получение коллекции рабочих книг.
                objBooks_Late = objApp_Late.GetType().InvokeMember("Workbooks",
                BindingFlags.GetProperty, null, objApp_Late, null);

                //Добавление новой рабочей книги.
                objBook_Late = objBooks_Late.GetType().InvokeMember("Add",
                    BindingFlags.InvokeMethod, null, objBooks_Late, null);

                //Получение коллекции рабочих листов.
                objSheets_Late = objBook_Late.GetType().InvokeMember("Worksheets",
                    BindingFlags.GetProperty, null, objBook_Late, null);

                //Получение первого рабочего листа.
                Parameters = new Object[1];
                Parameters[0] = 1;
                objSheet_Late = objSheets_Late.GetType().InvokeMember("Item",
                    BindingFlags.GetProperty, null, objSheets_Late, Parameters);

                //Получение объекта диапазона, содержащего ячейку A1.
                Parameters = new Object[2];
                Parameters[0] = "A1";
                Parameters[1] = Missing.Value;
                objRange_Late = objSheet_Late.GetType().InvokeMember("Range",
                    BindingFlags.GetProperty, null, objSheet_Late, Parameters);

                //Написать "C#.Народные советы" в ячейке A1.
                Parameters = new Object[1];
                Parameters[0] = "C#.Народные советы";
                objRange_Late.GetType().InvokeMember("Value", BindingFlags.SetProperty,
                    null, objRange_Late, Parameters);

                //Возвращение контроля над Excel пользователю.
                Parameters = new Object[1];
                Parameters[0] = true;
                objApp_Late.GetType().InvokeMember("Visible", BindingFlags.SetProperty,
                    null, objApp_Late, Parameters);
                objApp_Late.GetType().InvokeMember("UserControl", BindingFlags.SetProperty,
                    null, objApp_Late, Parameters);
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Ошибка: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Строка: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Ошибка");
            }

        }
    }
}