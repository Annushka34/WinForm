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
                // ��������� ���� ������ � �������� ���������� Excel.
                Type objClassType;
                objClassType = Type.GetTypeFromProgID("Excel.Application");
                objApp_Late = Activator.CreateInstance(objClassType);

                //��������� ��������� ������� ����.
                objBooks_Late = objApp_Late.GetType().InvokeMember("Workbooks",
                BindingFlags.GetProperty, null, objApp_Late, null);

                //���������� ����� ������� �����.
                objBook_Late = objBooks_Late.GetType().InvokeMember("Add",
                    BindingFlags.InvokeMethod, null, objBooks_Late, null);

                //��������� ��������� ������� ������.
                objSheets_Late = objBook_Late.GetType().InvokeMember("Worksheets",
                    BindingFlags.GetProperty, null, objBook_Late, null);

                //��������� ������� �������� �����.
                Parameters = new Object[1];
                Parameters[0] = 1;
                objSheet_Late = objSheets_Late.GetType().InvokeMember("Item",
                    BindingFlags.GetProperty, null, objSheets_Late, Parameters);

                //��������� ������� ���������, ����������� ������ A1.
                Parameters = new Object[2];
                Parameters[0] = "A1";
                Parameters[1] = Missing.Value;
                objRange_Late = objSheet_Late.GetType().InvokeMember("Range",
                    BindingFlags.GetProperty, null, objSheet_Late, Parameters);

                //�������� "C#.�������� ������" � ������ A1.
                Parameters = new Object[1];
                Parameters[0] = "C#.�������� ������";
                objRange_Late.GetType().InvokeMember("Value", BindingFlags.SetProperty,
                    null, objRange_Late, Parameters);

                //����������� �������� ��� Excel ������������.
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
                errorMessage = "������: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " ������: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "������");
            }

        }
    }
}