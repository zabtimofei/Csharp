using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 13;
            int y = 42;
            SetNumber(out x);
            Swap(ref x, ref y);
            Increment(ref x);
            Console.WriteLine($"x = {x}; y = {y}");

            Vector2D v1;
            v1.x = 10;
            v1.y = 20;
            Vector2D v2;
            v2.x = 15;
            v2.y = 30;
            var r1 = Vector2D.Length(v1.x, v2.x, v1.y, v2.y);
            var r2 = v2.GetLength();
            Console.ReadLine();

            //double x;
            //while (!double.TryParse(Console.ReadLine(), out x)) ;
            //{
            //    Console.WriteLine("Error, Введите вещ число");
            //}

            //int int_value = (int)x;
            //double float_value = x - int_value;

            //var int_digits_count = (int)Math.Log10(int_value) + 1;

            //int float_digits_count = -(int)Math.Log10(float_value);
        }
        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        private static void Increment(ref int i)
        {
            i++;
        }
        public static void SetNumber(out int n)
        {
            n = 100;
        }
    }

    struct Vector2D
    {
        public double x, y;
        public static double Length(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        public double GetLength()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
