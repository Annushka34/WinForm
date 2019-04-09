using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices; 

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("mscoree.dll")]
        private static extern void GetCORSystemDirectory(
        [MarshalAs(UnmanagedType.LPTStr)] 
        System.Text.StringBuilder Buffer,
        int BufferLength, ref int Length); 


        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(260);
            int size = 0;

            GetCORSystemDirectory(sb, sb.Capacity, ref size);

            // Выводим на экран что-то типа 
            // "C:\WINDOWS\Microsoft .NET\Framework\v2.0.50727\" 
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
