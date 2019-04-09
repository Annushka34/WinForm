using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод для сравнения файлов
        // В качестве параметров используются две строки,
        // содержащие полные пути к сравниваемым файлам.
        // Возвращается 0, если содержание файлов одинаково.
        // Если возвращается значение, отличное от 0, то содержимое файлов не одинаково
        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Если пути файлов совпадают
            if (file1 == file2)
            {
                // Возвращаем true, так как сравнивается один и тот же файл.
                return true;
            }

            // Открываем два файла.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // Проверяем размеры файла. Если размеры отличаются, 
            // то файлы не одинаковы.
            if (fs1.Length != fs2.Length)
            {
                // Закрываем файлы
                fs1.Close();
                fs2.Close();

                // Возвращаем false, так как файлы не одинаковы
                return false;
            }

            // Читаем и сравниваем байт каждого файла
            // пока не встретим несовпадающий байт
            // или пока не будет достигнут конец файла.
            do
            {
                // Считываем один байт с каждой строчки.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Закрываем файлы.
            fs1.Close();
            fs2.Close();

            // Возвращается true в случае успешного сравнения всех байтов.  
            // file1byte равен file2byte, если содержимое файлов полностью совпадают.
            return ((file1byte - file2byte) == 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Сравниваем два файла. Путь к файлам указан в текстовых полях.
            if (FileCompare(this.textBox1.Text, this.textBox2.Text))
            {
                MessageBox.Show("Файлы одинаковы.");
            }
            else
            {
                MessageBox.Show("Файлы не одинаковы.");
            }  
        }

    }
}