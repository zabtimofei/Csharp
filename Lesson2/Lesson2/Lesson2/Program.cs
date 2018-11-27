using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.Write("Введите значение а>");
        //    double a = double.Parse(Console.ReadLine());

        //    Console.Write("Введите значение b>");
        //    double b = double.Parse(Console.ReadLine());


        //    if (a > b)
        //    {
        //        Console.WriteLine("Введенное значение a={0} больше чем b={1}", a, b);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Введенное значение b={1} больше чем a={0}", a, b);
        //    }

        //    Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
        //    Console.ReadLine();

        //    double abs_b = b > 0 ? b : -b;
        //    abs_b = a > 0 && a < 10 ? (b > 0 ? -b : b) : (a < 0 ? -a : a);
        //    DateTime now = DateTime.Now;
        //    int month = now.Month;
        //    Season season;
        //    Season named_season = (Season)3;
        //    Console.WriteLine(named_season);
        //    switch (month)
        //    {
        //        default:
        //            Console.WriteLine("Ошибочные данные в переменной month");
        //            break;
        //        case 1:
        //        case 12:
        //        case 2:
        //            season = Season.Winter;
        //            Console.WriteLine("Сейчас зима");
        //            //goto case 5;
        //            break;

        //        case 3:
        //        case 4:
        //        case 5:
        //            season = Season.Spring;
        //            Console.WriteLine("Сейчас весна");
        //            break;
        //        case 6:
        //        case 7:
        //        case 8:
        //            season = Season.Summer;
        //            Console.WriteLine("Сейчас лето");
        //            break;
        //        case 9:
        //        case 10:
        //        case 11:
        //            season = Season.Autumn;
        //            Console.WriteLine("Сейчас осень");
        //            break;


        //    }
        //    for (int i = 0; y < N, i++)
        //    {

        //    }
        //    while (true)
        //    {

        //    }

        //    do
        //    {

        //    } while (true);
        //    using (System.IO.StreamReader reader = System.IO.File.OpenText("file_name.txt"))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            Console.WriteLine(line);
        //        }
        //    }

        //    var c = ++N; // c==33 N = 33
        //    // var c = N++; // c== 32 N = 33
        //    // i++
        //    // i--
        //    // ++i
        //    //--i
        //    // i += 5
        //    // i -= 5
        //    // i /= 5
        //    // i *= 5

        //    switch (named_season);
        //    {
        //        case Season.Autumn:
        //        Console.WriteLine("Зима близко");
        //        break;
        //        default:
        //        Console.WriteLine("Гасим соседей");
        //        break;
        //    }


        //}
        ////private static double GetMin(double a, double b)
        ////{
        ////    if (a > b) return a;
        ////    else return b;
        ////}

        private static double GetMin(double a, double b)
        {
            return a < b ? a : b;

            // если выполняется условие то после оператора ? возвращается первый блок а, если ложно то второй - б
        }
        private static double GetValueFromConsole(string msg)
        {
            Console.Write(msg);
            var input = Console.ReadLine();
            double result;
            while(!double.TryParse(input, out result))
            {
                Console.WriteLine("Ошибка вводе вещественного числа.");
                Console.Write(msg);
                input = Console.ReadLine();
            }
            return result;
        }
    }
    //enum Season
    //{
    //    Winter = 1,
    //    Spring = 2,
    //    Summer = 3,
    //    Autumn = 4
    //}
}
