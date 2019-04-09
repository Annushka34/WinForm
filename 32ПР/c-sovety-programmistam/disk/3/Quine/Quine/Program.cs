using System;
class A
{
    static void Main()
    {
        string s = "using System;class A{{static void Main(){{string s={0}{1}{0};char q='{0}';Console.Write(s,q,s);}}}}";
        char q = '"'; Console.Write(s, q, s);
    }
}

