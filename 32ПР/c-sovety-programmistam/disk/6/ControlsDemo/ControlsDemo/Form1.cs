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

            MyButton btn = new MyButton();
            btn.Width = 90;
            btn.Height = 50;
            btn.Left = 100;
            btn.Top = 10;
            btn.Text = "Я новая кнопка";
            btn.Visible = true;
            this.Controls.Add(btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                // Работаем только с текстовыми полями
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "Народные советы";
            }

        }

        private void IterateControls(Control ctrl)
        {
            // Работаем только с текстовыми полями
            if (ctrl.GetType() == typeof(TextBox))
            {
                ctrl.Text = "Народные советы";
            }

            // Проходим через элементы рекурсивно,
            // чтобы не пропустить элементы, которые находятся в контейнерах
            foreach (Control ctrlChild in ctrl.Controls)
            {
                IterateControls(ctrlChild);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IterateControls(this);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 3);


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(CheckBox))
                {
                    g.DrawRectangle(p, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }
        }


    }

    public class MyButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = Color.Green;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
                ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }

}