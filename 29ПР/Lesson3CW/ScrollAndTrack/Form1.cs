using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollAndTrack
{
    public partial class Form1 : Form
    {
        string buffer = "";
        public Form1()
        {
            InitializeComponent();
            trackBar1.SmallChange = 3;
            trackBar1.Maximum = 100;
            textBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            button1.Location = new Point(button1.Location.X, vScrollBar1.Value*4);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += buffer;
        }
    }
}
