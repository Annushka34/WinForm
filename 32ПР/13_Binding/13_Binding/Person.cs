using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Binding
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Worker_type { get; set; }
        public int Salary { get; set; }
        public string Color { get; set; }
        public Button btn { get; set; }

        public Person(string n, string s, string w, string col)
        {
            Random r = new Random();
            Thread.Sleep(5);
            Salary = r.Next(5000, 10000);
            Name = n;
            Surname = s;
            Worker_type = w;
            Color = col;
            btn = new Button { Text = "111" };
        }

        public override string ToString()
        {
            return Name + "   " + Surname;
        }
    }
}
