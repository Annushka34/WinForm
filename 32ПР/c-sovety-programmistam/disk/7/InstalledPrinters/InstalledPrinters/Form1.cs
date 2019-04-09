using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


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
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                // Выводим имя принтера
                textBox1.Text = "Принтер: " + printerName +"\r\n";
                // Получаем настройки принтера
                PrinterSettings printer = new PrinterSettings();
                printer.PrinterName = printerName;
                // Проверяем, действителен ли принтер
                
                if (printer.IsValid)
                {
                    // Выводим список поддерживаемых разрешений
                    textBox1.Text += "Поддерживаемые разрешения:" + "\r\n";
                    foreach (PrinterResolution resolution in
                    printer.PrinterResolutions)
                    {
                        textBox1.Text += resolution + "\r\n";
                    }

                    // Выводим список доступных размеров бумаги
                    textBox1.Text += "Поддерживаемые размеры бумаги:" + "\r\n";
                    foreach (PaperSize size in printer.PaperSizes)
                    {
                        if (Enum.IsDefined(size.Kind.GetType(), size.Kind))
                        {
                            textBox1.Text += size + "\r\n";
                        }
                    }
                }
            }
        }

        


        private void butPrint_Click(object sender, EventArgs e)
        {
            // Создаем документ и прикрепляем к нему обработчик события
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;

            // Пользователь может выбирать принтер и его свойства через
            // стандартное диалоговое окно
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;

            // Если выбрана кнопка OK, то печатаем документ
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Задаем шрифт
            using (Font font = new Font("Arial", 30))
            {
                // Определяем позиции для печати данных
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                
                float lineHeight = font.GetHeight(e.Graphics);
                
                // Печатаем пять строчек текста
                for (int i = 1; i <= 5; i++)
                {
                    e.Graphics.DrawString("Это строчка номер " + i.ToString(),
                       font, Brushes.Black, x, y);
                    // Смещаемся вниз для следующей строчки
                    y += lineHeight;
                }

                y += lineHeight;

                // Рисуем картинку из файла
                //e.Graphics.DrawImage(Image.FromFile(Path.Combine(Application.StartupPath,
                    //"test.jpg")), x, y);
             }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            // Создаем документ и прикрепляем к нему обработчик события
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += this.Doc_PrintPage;

            PrintPreviewDialog dlgPreview = new PrintPreviewDialog();
            dlgPreview.Document = doc;
            dlgPreview.Show();
        }
    }
}