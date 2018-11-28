using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double z = 6;
            double y = 6;
            double max = MaxFrom3(x, y, z);
            Console.WriteLine("max=" + NumberOfDigits(834554.2345326));
            Console.ReadLine();
        }
        /// <summary>Возвращает максимальное из трех чисел</summary>

        private static double MaxFrom3(double x, double y, double z)
        {
            //    return a < b ? a : b;
            if (x > y && x > z) return x;
            else if (y > z) return y;
            else return z;
        }
        /// <summary> Возвращает количество цифр числа типа double </summary>
        private static double NumberOfDigits(double x)
        {
            string a = x.ToString();
            int i = 0;
            foreach(char c in a)
            {
                if (c == ',' || c == '.') continue;
                else i++;
            }
            return i;
        }
    }
}
