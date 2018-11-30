using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Drob
    {
        private double _Nominator;
        private double _Denominator;

        public Drob(double Nominator, double Denominator)
        {
            if (Denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель дроби равен нулю");
            }
            _Nominator = Nominator;
            _Denominator = Denominator;
        }
        public double GetValue(double Nominator, double Denominator)
        {

        }
    }
}
