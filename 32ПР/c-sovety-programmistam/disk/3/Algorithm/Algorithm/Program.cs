using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            
            int x;
            int y;
            int z;
            byte su;

            //Console.Write("Введите первое число: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //z = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Наибольшее число из трех: " + FindMax3(x, y, z));
            //Console.WriteLine("Наименьшее число из трех: " + FindMin3(x, y, z));
            //Console.ReadLine();

            //String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
            //// Выводим 12 элемент массива
            //Console.WriteLine(s[11]);
            //Console.ReadLine();

            //Console.Write("Введите число от 1 до 125");
            //Console.WriteLine();
            //su = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine(SumAll(su));
            //Console.ReadLine();

            // Выводим список простых чисел
            Console.Write("Введите число от 2 до 100000");
            Console.WriteLine();
            x = Convert.ToInt32(Console.ReadLine());
            int[] Array = GetSimpleNumbers(x);
            //вывод чисел в консоль
            for (int i = 0; i < Array.Length; i++)
                Console.Write("{0} ", Array[i]);
            Console.ReadLine();
        }

        // Метод для нахождения наибольшего значения из трех заданных чисел
        public static int FindMax3(int a, int b, int c)
        {
            int max;
            max = Math.Max(a, Math.Max(b, c));
            return max;
        }

        // Метод для нахождения наименьшего значения из трех заданных чисел
        public static int FindMin3(int a, int b, int c)
        {
            int min;
            min = Math.Min(a, Math.Min(b, c));
            return min;
        }

        // Конвертируем градусы в радианы
        public static double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return radians;
        }

        // Проверка на четность
        public static bool IsEven(int intValue)
        {
            return ((intValue % 2) == 0); // четное число
        }

        // перегруженная версия, работающая с числами типа long
        public static bool IsEven(long lValue)
        {
            return ((lValue % 2) == 0);
        }

        // Проверка на нечетность
        public static bool IsOdd(int intValue)
        {
            return ((intValue % 2) == 1); // нечетное число
        }

        // Получения старшего слова
        public static int GetHighWord(int intValue)
        {
            return (intValue & (0xFFFF << 16));
        }

        // Получение младшего слова
        public static int GetLowWord(int intValue)
        {
            return (intValue & 0x0000FFFF);
        }

        // Конвертируем градусы Фаренгейта в градусы Цельсия
        public static double FtoC(double Fahrenheit)
        {
            return ((5.0 / 9.0) * (Fahrenheit - 32));
        }

        // Конвертируем градусы Цельсия в градусы Фаренгейта
        public static double CtoF(double Celsius)
        {
            return (((9.0 / 5.0) * Celsius) + 32);
        }

        // Подсчет суммы целых чисел из заданного диапазона
        public static int SumAll(byte Value)
        {
            int sum;
            sum = 0;

            for (int i = 1; i <= Value; i++)
                sum = sum + i;

            return sum;
        }

        // нахождение простых чисел
        static int[] GetSimpleNumbers(int Value)
        {
            if (Value < 2)
            {
                int[] A = new int[0];
                return A;
            }
            else
            {
                int[] T = new int[Value];
                T[0] = 2;
                int K = 1, I = 3;
                bool B = true;
                while (I <= Value)
                {
                    B = true;
                    for (int J = 0; J < K; J++)
                        if (I % T[J] == 0)
                        {
                            B = false;
                            break;
                        }
                    if (B) T[K++] = I;
                    I += 2;
                }
                int[] A = new int[K];
                for (int J = 0; J < A.Length; J++)
                    A[J] = T[J];
                return A;
            }
        }

    }
}
