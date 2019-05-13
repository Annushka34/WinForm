using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_UserControlComboBox
{
    public partial class ComboBoxWithImg : UserControl
    {
        MyImgComboBox comboBox = null;
        string pictureFileName = "";
        public ComboBoxWithImg()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureFileName = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(pictureFileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyComboBoxItem newItem = new MyComboBoxItem(Image.FromFile(pictureFileName), textBox1.Text);
            comboBox.Items.Add(newItem);
        }

        private void ComboBoxWithImg_Load(object sender, EventArgs e)
        {
            comboBox = new MyImgComboBox();
            comboBox.SetBounds(2, 2, 200, 50);
            comboBox.ItemHeight = 50;
            this.Controls.Add(comboBox);
            Image img = new Bitmap(this.GetType(), "1.jpg");
            MyComboBoxItem firstItem = new MyComboBoxItem(img, "Semen");
            comboBox.Items.Add(firstItem);
            comboBox.SelectedIndex = 0;
        }


        class MyImgComboBox : ComboBox
        {
            public MyImgComboBox()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
                DropDownStyle = ComboBoxStyle.DropDownList;
            }

            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                var drawenItem = (MyComboBoxItem)Items[e.Index];
                e.Graphics.DrawImage(drawenItem.Img, e.Bounds.Left+1, e.Bounds.Top+1);
                e.Graphics.DrawString(drawenItem.Text, 
                    new Font(FontFamily.GenericMonospace, 14), 
                    new SolidBrush(Color.Red), 
                    new Point(e.Bounds.Left + drawenItem.Img.Width+1, e.Bounds.Top + 1));
                base.OnDrawItem(e);
            }
        }

        public class MyComboBoxItem
        {
            public Image Img { get; set; }
            public string Text { get; set; }
            public MyComboBoxItem(Image img, string text)
            {
                Image smallImg = new Bitmap(img, new Size(40, 40));
                Img = smallImg;               
                Text = text;
            }
        }
    }
}
