/*
На формі діалогу знаходиться Label з текстом "Злови мене". 
Коли до нього підвести мишу -- він тікає від неї, не виходячи за межі діалогу. 
Якщо ж миша потрапляє всередину Label'а -- текст у ньому змінюється на "Ви виграли". 
А через 10 секунд -- знову змінюється на "Злови мене".

на 10: Label стрибає від миші: коли миша наближаться до static'а 
( на 5, 10 чи 15 пікселів -- оберіть самі) він "перестрибує" 
у випадкове місце діалогового вікна (але не під вказівник миші)

на 12: Label"плавно" втікає від миші, зберігаючи якусь відстань 
(не меншу 5, 10 чи 15 пікселів -- оберіть самі). Якщо Label таким чином притиснувя до межі -- він "перестрибує" 
у випадкове місце діалогу. Зверніть увагу, щоби у Label'а не було "сліпих" зон на продовженнях діагоналей. 

Поради:

Увімкніть властивість BorderStyle -- тоді буде добре видно межі label'а.

Потрапляння миші у Label (і сторожовий прямокутник ) перевіряйте за допомогою метода Contains класу Rectangle.
Для перевірки наближення миші до Label'а створіть RECT більший від Rectangle на кілька пікселів 
( на 5, 10 чи 15 пікселів -- оберіть самі), але зпозиціонований концентрично зі Label'ом і перевіряйте, 
чи потрапляє миша у цей прямокутник.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.TransparencyKey = Color.Gold;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rec = new Rectangle(new Point(lbl_catch.Location.X - 5, lbl_catch.Location.Y - 5),
                                          new Size(lbl_catch.Size.Width + 10, lbl_catch.Size.Height + 10));
            Point Position = new Point(e.X, e.Y);

            this.Text = "X = " + Position.X + " Y = " + Position.Y;

            if (rec.Contains(Position))
            {
                if (rec.Y + 5 >= Position.Y)
                    lbl_catch.Top += 5;
                else if (rec.X + 5 >= Position.X)
                    lbl_catch.Left += 5;
                else if (rec.Y + rec.Height - 5 <= Position.Y)
                    lbl_catch.Top -= 5;
                else if (rec.X + rec.Width - 5 <= Position.X)
                    lbl_catch.Left -= 5;

                if (rec.Location.X <= 0)
                    lbl_catch.Left = ClientSize.Width - lbl_catch.Width - 5;
                if (rec.Location.Y <= 0)
                    lbl_catch.Top = ClientSize.Height - lbl_catch.Height - 5;
                if (rec.Location.X + rec.Width >= ClientSize.Width)
                    lbl_catch.Left = 10;
                if (rec.Location.Y + rec.Height >= ClientSize.Height)
                    lbl_catch.Top = 10;
            }
        }

        private void lbl_catch_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_catch.Text = "Ви виграли";
            lbl_catch.Enabled = false;
            this.Enabled = false;
            tTimer.Start();
        }

        private void tTimer_Tick(object sender, EventArgs e)
        {
            lbl_catch.Text = "Злови мене";
            this.Enabled = true;
            lbl_catch.Enabled = true;
            tTimer.Stop();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.Gold);
            //e.Graphics.FillPolygon(Brushes.Aquamarine, new PointF[] 
            //{
            //    new Point(this.ClientRectangle.Width/2,0),
            //    new Point(this.ClientRectangle.Width, this.ClientRectangle.Height/2),
            //    new Point(this.ClientRectangle.Width/2,this.ClientRectangle.Height),
            //    new Point(0, this.ClientRectangle.Height/2)

            //});
            //Font f = new Font(this.Font.Name, 20);
            //e.Graphics.DrawString("C#!!!!", f, Brushes.Black, 20, (this.ClientRectangle.Height / 2) - (f.Height / 2));
        }
    }
}
