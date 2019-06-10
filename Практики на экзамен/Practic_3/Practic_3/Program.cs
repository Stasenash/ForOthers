using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Файл в папке bin\Debug\lines.txt

/* Считайте из файла массив строк. Найдите самую длинную строку и выведите на экран ее в обратном порядке.*/

namespace Practic_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("lines.txt");
            var line = lines.OrderByDescending(e=>e.Length).First();
            var newline = "";
            for (int i = line.Length - 1; i >= 0; i--)
                newline += line[i];
            Console.WriteLine(newline);
        }
    }
}
