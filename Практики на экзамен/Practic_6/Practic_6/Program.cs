using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Файл находится в папке bin\Debug\array.txt

/* В файле находится неизвестное кол-во чисел и строк, перемешанных между собой.
 Считайте все числа в один список, а строки в другой. Выведите на экран размер полученных списков.*/
namespace Practic_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = File.ReadAllLines("array.txt");
            List<string> lines = new List<string>();
            List<int> numbers = new List<int>();

            foreach (var e in array)
            {
                if (int.TryParse(e, out int n))
                    numbers.Add(n);
                else
                    lines.Add(e);
            }
            Console.WriteLine($"Количество фраз: {lines.Count}");
            Console.WriteLine($"Количество чисел: {numbers.Count}");
        }
    }
}
