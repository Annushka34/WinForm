using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_ChildForm
{
    public partial class FormChild : Form
    {
        string _text;
      //  DialogResult result;
        public FormChild()
        {
            InitializeComponent();
        }

        public FormChild(string text)
        {
            InitializeComponent();
            _text = text;
        }

        public DialogResult ShowDialog (string text)
        {
            _text = text;
            this.ShowDialog();
            return this.DialogResult;
        }

        public void SetText (string text)
        {
                this._text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = _text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
