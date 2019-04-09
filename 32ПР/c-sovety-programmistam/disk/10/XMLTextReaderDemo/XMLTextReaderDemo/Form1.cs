using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace XMLTextReaderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlTextReader reader = new XmlTextReader("bhvbooks.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // Узел является элементом.
                        listBox1.Items.Add("<" + reader.Name);

                        while (reader.MoveToNextAttribute()) // Чтение атрибутов.
                            listBox1.Items.Add(" " + reader.Name + "='" + reader.Value + "'");
                        listBox1.Items.Add(">");
                        break;
                    case XmlNodeType.Text: // Вывести текст в каждом элементе.
                        listBox1.Items.Add(reader.Value);
                        break;
                    case XmlNodeType.EndElement: // Вывести конец элемента.
                        listBox1.Items.Add("</" + reader.Name + ">");
                        break;
                }
            }
        }
    }
}