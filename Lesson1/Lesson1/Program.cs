using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    /// <summary>
    /// Класс главной программы
    /// </summary>
    /// <remarks>
    /// В данном классе описан метод Main (Дополнительный развернутый комментарий)
    /// </remarks>
    //[Obsolete("Пользуйтесь другой программой", true)]
    class Program
    {

        private static double Function(double x)
        {
            return x * x;
        }
        private static double Function(double x, double y)
        {
            return x + y;
        }
        /// <summary>
        /// Точка входа в программу (Системный комментарий)
        /// </summary>
        /// <param name="args">Массив аргументов командной строки</param>
        static void Main(string[] args)
        {
            #region Блок комментария
            /* 
             * Многострочный комментарий
             * Ctrl+K,D Быстрое форматирование кода в читаемый вид
             */
            #endregion
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            char c = 'a'; // Символ -> byte
            byte b; // Хранит целое число от 0 до 255
            sbyte sb; // Хранит +-, целые числа [-174;175]
            short sh; // Тип с объемом памяти в 2 байта, целочисленные
            ushort ush; // +
            uint ui; // 4 байта, +
            int i; // 4 байта со знаком +- 2 миллиарда, целочисленные
            long l; // 8 байтов, +-, целочисленное
            ulong ul;// 8 байтов, +, целочисленное

            float fl; // 4 байта - эквивалент int, с плавающей точкой, вещественное число
            double db; // 8 байт - эквивалент long(основной), с плавающей точкой, вещественное число

            decimal dc; // медленный, не теряет хвосты чисел

            // Sysrem.Int32 i32;// int

            Console.WriteLine("Ползователь ввел строку:" + str);
            string str1 = str[0] + str[1] + "qwe";

            int i2 = 2 + 2 * 2;

            double d2 = 2.0 + 2.0 * 2.0;

            d2 = i2; //неявное преобразование типа данных
            i2 = (int)d2; // явное преобрзование типа данных


            str = "3.14159265358979";

            d2 = double.Parse(str);

            bool result = double.TryParse(str, out d2); // если успешно преобразуется, то в д2 запишется стр как число, а не как строка, и в резалт запишется true, если нет то в резалте фолс

            bool b1 = true, b2 = false;

            bool b3 = b1 && b2;
            bool b4 = b1 || b2; // если хотя бы 1 из б1 и б2 true, то б4 true
            bool b5 = !(b1 && b2); // переворачивает значение

            bool b6 = d2 > 0; // >, >=, <=< !=, ==
            var x = 0;// определяет сам тип переменной

            object obj = 42;
            obj = "Hello";
            obj = true;

            b6 = (bool)obj; // если захотим присвоить значение переменной типа object, то необходимо применять явное преобразование

            Console.WriteLine("pi = {0:f4}"), pi / 7);//форматированный вывод, {0}, значит выводим pi/7 (первый параметр) , :f4 - выводим до 4 знака после запятой
            Console.WriteLine("pi = {0:0.00##"}, pi/7);// выводит до 2 знака, плюс еще два, если они отличны от нуля

            var data_char = Console.ReadKey();// позволяет считать

        var data_char1 = (char)Console.Read();// позволяет считать символ, лучше сразу преобразовать в символ

        Console.ReadLine();

            var i = Math. // класс Math позволяет выбрать математические функции
        }
}
}
