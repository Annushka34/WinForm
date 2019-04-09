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
                // ������� ��� ��������
                textBox1.Text = "�������: " + printerName +"\r\n";
                // �������� ��������� ��������
                PrinterSettings printer = new PrinterSettings();
                printer.PrinterName = printerName;
                // ���������, ������������ �� �������
                
                if (printer.IsValid)
                {
                    // ������� ������ �������������� ����������
                    textBox1.Text += "�������������� ����������:" + "\r\n";
                    foreach (PrinterResolution resolution in
                    printer.PrinterResolutions)
                    {
                        textBox1.Text += resolution + "\r\n";
                    }

                    // ������� ������ ��������� �������� ������
                    textBox1.Text += "�������������� ������� ������:" + "\r\n";
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
            // ������� �������� � ����������� � ���� ���������� �������
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;

            // ������������ ����� �������� ������� � ��� �������� �����
            // ����������� ���������� ����
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;

            // ���� ������� ������ OK, �� �������� ��������
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // ������ �����
            using (Font font = new Font("Arial", 30))
            {
                // ���������� ������� ��� ������ ������
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                
                float lineHeight = font.GetHeight(e.Graphics);
                
                // �������� ���� ������� ������
                for (int i = 1; i <= 5; i++)
                {
                    e.Graphics.DrawString("��� ������� ����� " + i.ToString(),
                       font, Brushes.Black, x, y);
                    // ��������� ���� ��� ��������� �������
                    y += lineHeight;
                }

                y += lineHeight;

                // ������ �������� �� �����
                //e.Graphics.DrawImage(Image.FromFile(Path.Combine(Application.StartupPath,
                    //"test.jpg")), x, y);
             }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            // ������� �������� � ����������� � ���� ���������� �������
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += this.Doc_PrintPage;

            PrintPreviewDialog dlgPreview = new PrintPreviewDialog();
            dlgPreview.Document = doc;
            dlgPreview.Show();
        }
    }
}