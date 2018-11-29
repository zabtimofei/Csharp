using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Заполните, пожалуйста, анкету");
             
            Console.WriteLine("Введите свой рост в сантиметрах");

            float growth = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой вес в кг");

            float weight = float.Parse(Console.ReadLine());
            float imt = weight / (growth * growth) * 10000;
            Console.WriteLine("индекс массы тела: " + imt);
            

            Console.ReadLine();
        }
    }
}
