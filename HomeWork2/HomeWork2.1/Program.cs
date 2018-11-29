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
           bool aut =  Autorization("root", "GeekBrains");
            if (aut == false) return;
            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.WriteLine("\n"+"Начинайте вводить число");
            int a;
            int sum = 0;
            char b;
            do
            {
                b = Console.ReadKey().KeyChar;
                a = int.Parse(b.ToString());
                if (a > 0 && (a % 2) != 0)
                {
                    sum += a;
                }
            }
            while (b != '0');
            Console.WriteLine("\nСумма нечетных положтельных чисел равна " + sum);
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
            foreach (char c in a)
            {
                if (c == ',' || c == '.') continue;
                else i++;
            }
            return i;
        }

        private static bool Autorization(string login, string password)
        {
            bool a;
            int i = 0;
            do { 
            Console.WriteLine("Введите логин: ");
            string perslogin = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string persPass = Console.ReadLine();
            

                if (perslogin == login && persPass == password)
                {
                    a = true;
                    Console.WriteLine("Авторизация прошла успешно");
              
                    return a;
                }
                else
                {
                    a = false;
                    if (i < 3) Console.WriteLine("Введен неверный логин и/или пароль. Повторите попытку");
                    else Console.WriteLine("Неверный логин и пароль. До свидания");
                    i++;
                    
                 }
            }
            while (i < 3);
            return a;
        }
    }
}
