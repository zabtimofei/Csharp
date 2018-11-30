using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program 
    {
        static void Main(string[] args)
        {
            // понял замечание)) числа вводятся а не цифры!!! а я сделал для цифр))
            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. Как я понял задание, числа должны, вводися, пока не введут ноль, если , да кму я то объясняю?? никто же не проитает
            Console.WriteLine("Начинайте вводить числа, через Enter");
            int a;
            int sum = 0;
            string b;
            string numbers = "";
            
            do
            {
                b = Console.ReadLine();
                a = StringTryParseToInt(b);
               
                    if (a > 0 && (a % 2) != 0)
                    {
                        sum += a;
                        numbers += a.ToString() + ";";

                    }
                
            }
            while (b != "0");
            Console.WriteLine("\n Введенные положительные нечетные числа: " + numbers + 
                "\nСумма нечетных положтельных чисел равна " + sum); //не очень понял как используя TryParse выводить числа и сумму на экран
            Console.ReadLine();
        }
        /// <summary>Обработка исключительных ситуаций </summary>
        /// <param name="b">Входная переменная типа String</param>
        /// <returns>При возможности преобразования строковой переменной в эквивалентное ему 32-битовое целое значение, возвращает преобразованное значение, при невозможности возвращает 0 </returns>
        public static int StringTryParseToInt(string b)
        {
            int a;
            if (int.TryParse(b, out a))
            {
                return a;
            }
            else
            {
                a = 0;
                Console.WriteLine("Число введено некорректно");
                return a;
               
            }
        }
    }
}
// что то меня тут смущает, но не могу понять что.
