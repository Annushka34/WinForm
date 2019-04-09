using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Excel.Application objApp;
        Excel._Workbook objBook;

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Workbooks objBooks;
            Excel.Sheets objSheets;
            Excel._Worksheet objSheet;
            Excel.Range range;

            try
            {
                // Создание экземпляра Excel и запуск новой рабочей книги
                objApp = new Excel.Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add(Missing.Value);
                objSheets = objBook.Worksheets;
                objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                //Get the range where the starting cell has the address
                //m_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
                range = objSheet.get_Range("A1", Missing.Value);
                range = range.get_Resize(5, 5);

                if (this.FillWithStrings.Checked == false)
                {
                    // Создаем массив
                    double[,] saRet = new double[5, 5];

                    // Заполняем массив
                    for (long iRow = 0; iRow < 5; iRow++)
                    {
                        for (long iCol = 0; iCol < 5; iCol++)
                        {
                            //Put a counter in the cell.
                            saRet[iRow, iCol] = iRow * iCol;
                        }
                    }

                    //Set the range value to the array.
                    range.set_Value(Missing.Value, saRet);
                }

                else
                {
                    // Создаем массив
                    string[,] saRet = new string[5, 5];

                    // Заполняем массив
                    for (long iRow = 0; iRow < 5; iRow++)
                    {
                        for (long iCol = 0; iCol < 5; iCol++)
                        {
                            //Put the row and column address in the cell.
                            saRet[iRow, iCol] = iRow.ToString() + "|" + iCol.ToString();
                        }
                    }

                    //Set the range value to the array.
                    range.set_Value(Missing.Value, saRet);
                }

                // Возвращаем контроль над Excel пользователю
                objApp.Visible = true;
                objApp.UserControl = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Sheets objSheets;
            Excel._Worksheet objSheet;
            Excel.Range range;

            try
            {
                try
                {
                    //Get a reference to the first sheet of the workbook.
                    objSheets = objBook.Worksheets;
                    objSheet = (Excel._Worksheet)objSheets.get_Item(1);
                }

                catch (Exception theException)
                {
                    String errorMessage;
                    errorMessage = "Can't find the Excel workbook.  Try clicking Button1 " +
                       "to create an Excel workbook with data before running Button2.";

                    MessageBox.Show(errorMessage, "Missing Workbook?");

                    //You can't automate Excel if you can't find the data you created, so 
                    //leave the subroutine.
                    return;
                }

                //Get a range of data.
                range = objSheet.get_Range("A1", "E5");

                //Retrieve the data from the range.
                Object[,] saRet;
                saRet = (System.Object[,])range.get_Value(Missing.Value);

                //Determine the dimensions of the array.
                long iRows;
                long iCols;
                iRows = saRet.GetUpperBound(0);
                iCols = saRet.GetUpperBound(1);

                //Build a string that contains the data of the array.
                String valueString;
                valueString = "Array Data\n";

                for (long rowCounter = 1; rowCounter <= iRows; rowCounter++)
                {
                    for (long colCounter = 1; colCounter <= iCols; colCounter++)
                    {

                        //Write the next value into the string.
                        valueString = String.Concat(valueString,
                           saRet[rowCounter, colCounter].ToString() + ", ");
                    }

                    //Write in a new line.
                    valueString = String.Concat(valueString, "\n");
                }

                //Report the value of the array.
                MessageBox.Show(valueString, "Array Values");
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