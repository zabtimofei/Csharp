using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Complex
    {
        private double _Re;
        private double _Im;
        #region get/set
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
        #endregion

        /// <summary> Модул компексного числа </summary>
        public double Abs
        {
            get
            {
                return Math.Sqrt(_Re * _Re + _Im * _Im);
            }
        }

        /// <summary> Аргумент комплксного числа </summary>
        public double Arg
        {
            get
            {
                return Math.Atan2(_Im, _Re);
            }
        }

        /// <summary> Консруктор по умолчани </summary>
        public Complex() { }


        /// <summary> Параметричесий консруктор </summary>
        /// <param name="Re">Действитльная часть</param>
        /// <param name="Im">Мнимая часть</param>
        public Complex(double Re, double Im)
        {
            _Re = Re;
            _Im = Im;
        }
        #region доступ к приватым полям класса
        public double GetRe() // получить значение поля
        {
            return _Re;
        }
        public void SetRe(double value) // установить значение поля
        {
            _Re = value;
        }
        public double GetIm()
        {
            return _Im;
        }
        public void SetIm(double value)
        {
            _Im = value;
        }
        #endregion

        public override string ToString()
        {
            return $"{_Re}+i{_Im} -- "; //+ Program.RND.NextDouble(); //так и не понял зачем RND тут
        }
        #region Простые операторы класса
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a._Re + b._Re, a._Im + b._Im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a._Re - b._Re, a._Im - b._Im);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a._Re * b._Re - a._Im * b._Im, a._Re * b._Im + a._Im * b._Re);
        }
        public static Complex operator /(Complex a, Complex b)
        {
           if (b._Re*b._Re - b._Im * b._Im == 0)
            {
                throw new DivideByZeroException("Ошибка деления на нуль");
            }
            return new Complex((a._Re * b._Re + a._Im * b._Im) / (b._Re * b._Re + b._Im * b._Im), (a._Im * b._Re - a._Re * b._Im) / (b._Re * b._Re + b._Im * b._Im));
        }
        #endregion
    }
}
