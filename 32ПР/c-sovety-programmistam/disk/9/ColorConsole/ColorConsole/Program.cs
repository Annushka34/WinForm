using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C#.��������������.���������� ���������";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("������� �����");

            if (Console.CapsLock)
                Console.WriteLine("Caps Lock �������");
            else
                Console.WriteLine("Caps Lock ��������");

            Console.WindowHeight = 20;
            Console.WindowWidth = 40;
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
