using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C#.НародныеСоветы.Консольная программа";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Цветной текст");

            if (Console.CapsLock)
                Console.WriteLine("Caps Lock включен");
            else
                Console.WriteLine("Caps Lock выключен");

            Console.WindowHeight = 20;
            Console.WindowWidth = 40;
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
