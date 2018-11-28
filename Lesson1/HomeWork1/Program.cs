using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Form
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Заполните, пожалуйста, анкету");

            Console.WriteLine("Введите свое имя:");

            string name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию:");

            string family = Console.ReadLine();

            Console.WriteLine("Введите свой возраст:");

            float age = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой рост в сантиметрах");

            float growth = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой вес в кг");

            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Имя: " + name + "; Фамилия: " + family + "; Возраст: " + age + "; Рост: " + growth + "; Вес: " + weight);

            Console.WriteLine("Имя: {0}; Фамилия: {1}; Возраст: {2}; Рост: {3}; Вес: {4}", name, family, age, growth, weight);
            Console.WriteLine($"Имя: {name}; Фамилия: {family}; Возраст: {age}; Рост: {growth}; Вес: {weight}");
            float imt = weight / (growth * growth) * 10000;
            Console.WriteLine("индекс массы тела: " + imt);

            Console.ReadLine();

        }
    }
}
