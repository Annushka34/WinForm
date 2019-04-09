using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������� ��������� �������
            using (InstalledFontCollection fontFamilies =
               new InstalledFontCollection())
            {
                 int offset = 10;

                // �������� ����� ��� ������
                foreach (FontFamily family in fontFamilies.Families)
                {
                    try
                    {
                        // ������� �����, ������� ����� ���������� �����
                        // c ��������� �������
                        Label lblFont = new Label();
                        lblFont.Text = family.Name;
                        lblFont.Font = new Font(family, 14);
                        lblFont.Left = 10;
                        lblFont.Top = offset;
                        // ��������� Label �� �����
                        this.Controls.Add(lblFont);
                        offset += 35;
                    }
                    catch
                    {
                        // ���� ��������� ����� �� ����� ����� �������
                        // (������������ �� ��������� ��� �������� ������� Font),
                        // �� ����� ���������� ������. ���������� ��� ������
                        // ��� ������ ����������� try-catch
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF pointF = new PointF(310, 30);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            int count = 0;
            string familyName = "";
            
            FontFamily[] fontFamilies;

            PrivateFontCollection privateFontCollection = new PrivateFontCollection();

            // ������� ���� ����� � ����������.
            privateFontCollection.AddFontFile(Application.StartupPath
                + "\\" + "pussyfoo.ttf");
            
            // ������� ������ �������� FontFamily
            fontFamilies = privateFontCollection.Families;

            // ������� ����� �������� � ������� fontFamilies
            count = fontFamilies.Length;
 
            // ������� ��� ������� �������� �� ���������
            familyName = fontFamilies[0].Name;

            FontFamily ff = new FontFamily(familyName, privateFontCollection);
            Font f = new Font(ff, 56, FontStyle.Regular);

            Graphics g = CreateGraphics();
            // ������� ������ �� �����
            g.DrawString("I LOVE C#", f, solidBrush, pointF);
            g.Dispose();
        }
    }
}