using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._3
{
    class Program
    {
        private static double Distance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {

            int x1 = 7;
            int x2 = 5;
            int y1 = 10;
            int y2 = 15;

            Console.WriteLine("r={0:0.00}", Distance(x1, x2, y1, y2));
            Console.ReadLine();
        }
    }
}
