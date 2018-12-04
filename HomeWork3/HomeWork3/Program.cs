using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {

        static void Main(string[] args)
        {
            #region проверка работы структуры ComplexStr
            ComplexStr y = new ComplexStr(5, 12);
            ComplexStr x = new ComplexStr(7, 25);
            ComplexStr z = x + y;
            Console.WriteLine($"x+y={z._Re}+i{z._Im}");
            z = x * y;
            Console.WriteLine($"x*y={z._Re}+i{z._Im}");
            z = x - y;
            Console.WriteLine($"x-y={z._Re}+i{z._Im}");
            Console.ReadLine();
            #endregion
            #region проверка работы класса Complex
            Complex a = new Complex(5, 12);
            Complex b = new Complex(1, 3);
            Complex c = a + b;
            Console.WriteLine($"a+b={c.GetRe()}+i{c.GetIm()}");
            c = a - b;
            Console.WriteLine($"a-b={c.GetRe()}+i{c.GetIm()}");
            c = a * b;
            Console.WriteLine($"a*b={c.GetRe()}+i{c.GetIm()}");
            c = a / b;
            Console.WriteLine($"a/b={c.ToString()}");
            Console.ReadLine();

            #endregion
        }
    }
    /// <summary>Стурктура ComplexStr</summary>
    struct ComplexStr
    {
        public double _Re;
        public double _Im;

        public ComplexStr(double Re, double Im)
        {
            _Re = Re;
            _Im = Im;
        }
        public static ComplexStr operator +(ComplexStr x, ComplexStr y)
        {
            return new ComplexStr(x._Re + y._Re, x._Im + y._Im);
        }

        public static ComplexStr operator *(ComplexStr x, ComplexStr y)
        {
            return new ComplexStr(x._Re * y._Re - x._Im * y._Im, x._Re * y._Im + x._Im * y._Re);
        }

        public static ComplexStr operator -(ComplexStr x, ComplexStr y)
        {
            return new ComplexStr(x._Re - y._Re, x._Im - y._Im);
        }

    }



}

