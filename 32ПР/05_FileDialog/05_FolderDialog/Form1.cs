using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_FolderDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           var res =  folderBrowserDialog1.ShowDialog();
            var mask = textBox1.Text;
            if(res == DialogResult.OK)
            {
                var folderName = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dirs = new DirectoryInfo(folderName);
                try
                {

                    var files = dirs.GetFiles(mask, SearchOption.TopDirectoryOnly);
                    foreach (var item in files)
                    {
                        try
                        {
                            listBox1.Items.Add(item.Name);
                        }
                        catch
                        {

                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
