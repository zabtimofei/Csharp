using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class ArrayWrapper
    {
        public static void Test()
        {
            var int_elements = new int[40];

            ArrayWrapper array_wrapper = new ArrayWrapper(int_elements);
            int_elements[4] = 6;


            array_wrapper.InitializeWithRandomNumbers(-70, 70);
            array_wrapper.SortArraStandert();
            array_wrapper = new ArrayWrapper(new int[30]);
            array_wrapper.InitializeWithRandomNumbers(-20, 20);
            array_wrapper.SortArrayBubble();

            Console.WriteLine(array_wrapper[5]);
            // array_wrapper = new ArrayWrapper(null);

            array_wrapper.SaveToFile("data.txt");
            try
            {
                var array_wrapper2 = ArrayWrapper.LoadFromFile("data.txt");

            }
            catch (Exception error)
            {
                Console.WriteLine("Произошла ошибка!" + error.Message);
            }



        }
        private int[] _Elements;

        public int ElementsCount
        {
            get
            {
                return _Elements.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Индекс меньше 0!");
                if (index >= _Elements.Length)
                    throw new IndexOutOfRangeException("Индекс больше числа элементов массива");

                return _Elements[index];
            }
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Индекс меньше 0!");
                if (index >= _Elements.Length)
                    throw new IndexOutOfRangeException("Индекс больше числа элементов массива");

                _Elements[index] = value;
            }
        }

        public int Min
        {
            get
            {
                if (_Elements.Length == 0)
                    throw new InvalidOperationException("Невозможно найти минимальный элемент в пустом массиве");
                var min = int.MaxValue;
                for (var i = 0; i < _Elements.Length; i++)
                {
                    if (_Elements[i] < min)
                        min = _Elements[i];
                    
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                if (_Elements.Length == 0)
                    throw new InvalidOperationException("Невозможно найти максимальный элемент в пустом массиве");

                var max = int.MinValue;
                for (var i = 0; i < _Elements.Length; i++)
                {
                    if (_Elements[i] > max)
                        max = _Elements[i];
                    
                }
                return max;
            }
        }
        public double Average
        {
            get
            {
                if (_Elements.Length == 0)
                    return double.NaN;
                   // throw new InvalidOperationException("Невозможно найти среднее значение  всех элементов массива в пустом массиве");

                var sum = 0;
                for (var i = 0; i <_Elements.Length; i++)
                {
                    sum += _Elements[i];
                    
                }
                return (double)sum / ElementsCount;
            }
        }

        public ArrayWrapper(int[] Elements)
        {
            if (Elements == null) throw new NullReferenceException("Указана пустая ссылка на массив");
            _Elements = Elements;
        }

        public void InitializeWithRandomNumbers(int Min = -50, int Max = 50)
        {
            ArrayTest.InitializeArray(_Elements, Min, Max);
        }

        public void SortArraStandert()
        {
            Array.Sort(_Elements);
        }

        public void SortArrayBubble()
        {
            var do_work = true;

            while (do_work)
            {
                do_work = false;

                for (var i = 1; i < _Elements.Length; i++)
                {
                    var last = _Elements[i - 1];
                    var current = _Elements[i];

                    if (last > current)
                    {
                        do_work = true;
                        _Elements[i - 1] = current;
                        _Elements[i] = last;
                    }
                }
            }
        }


        public void SaveToFile(string FilePath)
        {
            if (string.IsNullOrWhiteSpace(FilePath))
                throw new ArgumentException("Неверный путь к файлу", nameof(FilePath));

            var file_stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            // file_stream.Write();
            var writer = new StreamWriter(file_stream);

            for (var i = 0; i < _Elements.Length; i++)
            {
                writer.WriteLine(_Elements[i]);
            }
            writer.Close();
            file_stream.Close();


        }

        public static ArrayWrapper LoadFromFile(string FilePath)
        {
            if (string.IsNullOrWhiteSpace(FilePath))
                throw new ArgumentException("Плохой путь к файлу", nameof(FilePath));

            #region Неправильная работа с фалом
            //var file_stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            //var reader = new StreamReader(file_stream);

            //var list = new List<int>();

            //while (!reader.EndOfStream)
            //{
            //    var line = reader.ReadLine();

            //    var value = int.Parse(line);

            //    list.Add(value);
            //}
            //reader.Close();
            //file_stream.Close(); 
            #endregion
            var list = new List<int>();

            #region Развернутый способ работы с файлом
            //FileStream file_stream = null;
            //StreamReader reader;

            //try
            //{
            //    file_stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            //    reader = new StreamReader(file_stream);


            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var value = int.Parse(line);
            //        list.Add(value);
            //    }
            //}
            //catch (Exception error)
            //{
            //    Trace.TraceError(error.ToString());
            //    throw error; // throw;
            //}
            //finally
            //{
            //    if (reader != null)
            //        reader.Close();
            //    if (file_stream != null)
            //        file_stream.Close();
            //}
            #endregion

            using (var file_stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(file_stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var value = int.Parse(line);
                    list.Add(value);
                }
            }
            return new ArrayWrapper(list.ToArray());

        }

    }
}
