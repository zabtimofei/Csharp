using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Complex
    {
        private double _Re;
        private double _Im;

        public double Re
        {
            get
            {
                return _Re;
            }
            set
            {
                _Re = value;
            }
        }
        public double Im
        {
            get
            {
                return _Im;
            }
            set
            {
                _Im = value;
            }
        }

        public Complex()
        {

        }

        public Complex(double Re, double Im)
        {
            _Re = Re;
            _Im = Im;
        }
        public double SetRe(double value)
        {
            _Re = value;
        }
        public double GetRe()
        {
            return _Re;
        }
        public double SetIm(double value)
        {
            _Im = value;
        }
        public double GetIm()
        {
            return _Im;
        }

        public Complex Add(Complex z)
        {
            return new Complex(_Re)
        }

        public override string ToString()
        {
            return $"{_Re}+i{_Im}";
        }
        public double Abs
        {
            get
            {
                return Math.Sqrt(_Re * _Re + _Im * _Im);
            }
        }
        public double Arg
        {
            get
            {

            }
        }
    }
}
