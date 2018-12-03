using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class ArrayTest
    {
        public static void Run()
        {
            int[] x = null; // == null
            x = new int[10];
            x[3] = 4;
            if (x[3] == 4)
                Console.WriteLine("В ячейке с индексом 3 находится значение {0}", x[3]);
            x[0] = 15;

            x = new int[] { 1, 3, 5, 6, 7 };
            x = new[] { 1, 3, 5, 6, 7 };

            int[] y = { 1, 2, 3, 4 };

            var array_of_int = new int[40];

            InitializeArray(array_of_int, -50, 50);

            //Program p = new Program();
            //Program[] pp = new Program[25];
            //pp[4] = p;

            //Array arr = array_of_int;

            Console.WriteLine("Размер массива {0}", array_of_int.Length);
            Console.WriteLine("Число измерений массива {0}", array_of_int.Rank);

            double[,] matrix = new double[40, 40];
            double[,] matrix2 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,,,,,,,,,] arra10D = new double[1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            Array.Clear(array_of_int, 0, array_of_int.Length);

            int[] array_of_int2 = (int[])array_of_int.Clone();

            Console.WriteLine("Матрица имеет {0} строк и {1} столбцов", matrix.GetLength(0), matrix.GetLength(1));

            Array.Sort(array_of_int);

            var index_of_5 = Array.IndexOf(x, 5);

            if (index_of_5 == -1) Console.WriteLine("Элемент отсутствует");

            else Console.WriteLine("Элемент 5 в массиве находится по индексу");

            var index_of_5_2 = Array.BinarySearch(x, 5);

            var rnd = new Random();

            int[][] XX = new int[30][]; // массив массивов

            for (var i = 0; i < XX.Length; i++)
            {
                XX[i] = new int[rnd.Next(3, 21)];
                InitializeArray(XX[i], -50, 50);
            }





        }

        public static void InitializeArray(int[] array, int min, int max)
        {
            var rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

        }
    }
}
