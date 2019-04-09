using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TwoButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butNo_MouseMove(object sender, MouseEventArgs e)
        {
            Point myPoint = butYes.PointToScreen(new Point(0, 0));
            myPoint.X += butYes.Width / 2;
            myPoint.Y += butYes.Height / 2;
            Cursor.Position = myPoint;
        }

        public void JumpToControl(Control ctrl)
        {
            // Перемещаем курсор мыши в нижнюю часть середины элемента
            Point objPoint = ctrl.PointToScreen(new Point(0, 0));
            objPoint.X += ctrl.Width / 2;
            objPoint.Y += (ctrl.Height / 4) * 3;
            Cursor.Position = objPoint;
        }

        private void butYes_Click(object sender, EventArgs e)
        {
            JumpToControl(lnkSite);
        }
    }
}