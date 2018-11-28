using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    static class LoopTest
    {
        public static void DigitsCount()
        {
            //var value = Program.GetIntValueFromConsole("Введите целое число");

            //Console.WriteLine($"Число разрядов числа {value} = {GetDigitsCount(value < 0 ? -value : value)}");

            //var cursor_top = Console.CursorTop;
            //var cursor_left = Console.CursorLeft;
            //for (var i = 0; i < 80; i++)
            //{
            //    for (var j = 0; j < 24; j++)
            //    {
            //        Console.SetCursorPosition(i, j);
            //        System.Threading.Thread.Sleep(2);

            //        Console.Write("*");
            //        Console.Title = $"i =  {i}, j = {j}";
            //    }
            //}
            //Console.SetCursorPosition(cursor_left, cursor_top);


            var str = "Hello World!\r\n123456\r\n ?? Здравствуй Мир!";

            foreach (char c in str)
            {
                if (c == '?') break;
                if (char.IsDigit(c)) continue;
                if (char.IsLetter(c))

                {
                    Console.WriteLine("Буква: {0}", c);
                }
                else if (char.IsDigit(c))
                {
                    Console.WriteLine("Цифра: {0}", c);
                }
                else
                {
                    Console.WriteLine("Символ: {0:x2}", (byte)c);
                }
            }

            Console.ReadLine();
        }

        //private static int GetDigitsCount(int x)
        //{
        //    var count = 0;

        //    //count = (int)Math.Log10(x) + 1;
        //    while (x != 0)
        //    {
        //        count++;
        //        x /= 10;
        //    }


        //    return count;
        //}

        private static long Factorial_Loop(int n)
        {
            long result = 1;


            //System.Numerics.BigInteger

            //while(n-- > 0)
            //{
            //    result *= n;
            //}
            while (n > 0)
            {
                result = result * n;
                n--;
            }


            return result;
        }
        private static long Factorial_Recursive(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial_Recursive(n - 1);
        }
        private static long DigitCount_Recursive(int n)
        {
            if (n == 1) return 0;
            return (n % 10) + DigitCount_Recursive(n / 10);
        }
    }
}
