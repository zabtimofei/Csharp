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
        }
    }
    struct Complex
    {
        public double _Re;
        public double _Im;

        public Complex(double Re, double Im)
        {
            _Re = Re;
            _Im = Im;
        }
        public Complex Plus(Complex x)
        {
            Complex y;
            y._Re=_Re + x._Re;
            y._Im =_Im+ x._Im;
            return y;
        }

        public Complex Multi (Complex x)
        {
            Complex y;
            y._Re = _Re * x._Re - _Im * x._Im;
            y._Im = _Re * x._Im + _Im * x._Re;
            return y;
        }

        public Complex Minus (Complex x)
        {
            Complex y;
            y._Re = _Re - x._Re;
            y._Im = _Im - x._Im;
            return y;
        }



    }



}

