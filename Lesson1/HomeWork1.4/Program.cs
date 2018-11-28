using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            int z = x;
            x = y;
            y = z;

            int a = 10;
            int b = 5;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a=" + a +" b=" + b);
            Console.ReadLine();


            
        }
    }
}
