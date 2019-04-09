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
        public static string TestString = "";

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string EASTER_EGG = "ТЕЩА";

            TestString = TestString + e.KeyChar.ToString().ToUpper();
            this.Text = TestString;
            if (EASTER_EGG.Substring(0, TestString.Length) != TestString)
            {
                TestString = "";
            }

            else
            {
                if (EASTER_EGG == TestString)
                {
                    MessageBox.Show("Возьми с полки пирожок");
                    TestString = "";
                }
            }

        }


    }
}