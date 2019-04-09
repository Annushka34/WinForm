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
            // Создаем коллекцию шрифтов
            using (InstalledFontCollection fontFamilies =
               new InstalledFontCollection())
            {
                 int offset = 10;

                // Проходим через все шрифты
                foreach (FontFamily family in fontFamilies.Families)
                {
                    try
                    {
                        // Создаем метку, которая будет отображать текст
                        // c выбранным шрифтом
                        Label lblFont = new Label();
                        lblFont.Text = family.Name;
                        lblFont.Font = new Font(family, 14);
                        lblFont.Left = 10;
                        lblFont.Top = offset;
                        // Добавляем Label на форму
                        this.Controls.Add(lblFont);
                        offset += 35;
                    }
                    catch
                    {
                        // Если выбранный шрифт не имеет стиль Обычный
                        // (используется по умолчанию при создании объекта Font),
                        // то может возникнуть ошибка. Игнорируем эту ошибку
                        // при помощи конструкции try-catch
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

            // Добавим свой шрифт в приложение.
            privateFontCollection.AddFontFile(Application.StartupPath
                + "\\" + "pussyfoo.ttf");
            
            // Получим массив объектов FontFamily
            fontFamilies = privateFontCollection.Families;

            // Получим число объектов в массиве fontFamilies
            count = fontFamilies.Length;
 
            // Получим имя первого элемента из коллекции
            familyName = fontFamilies[0].Name;

            FontFamily ff = new FontFamily(familyName, privateFontCollection);
            Font f = new Font(ff, 56, FontStyle.Regular);

            Graphics g = CreateGraphics();
            // Выводим строку на экран
            g.DrawString("I LOVE C#", f, solidBrush, pointF);
            g.Dispose();
        }
    }
}