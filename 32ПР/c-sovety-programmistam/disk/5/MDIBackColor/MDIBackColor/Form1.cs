using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            MdiClient ctlMDI;

            // Проходим через все элементы формы
            // в поисках типа MdiClient.
            foreach (Control ctl in this.Controls)
            {
                // Пытаемся привести элемент к типу MdiClient
                ctlMDI = (MdiClient)ctl;

                // Устанавливаем цвет BackColor элемента MdiClient
                ctlMDI.BackColor = this.BackColor;   
            }

            // Выводим дочернюю форму в окне родительской MDI-формы
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}