using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Файл в папке bin\Debug\matrix.txt

/* Считайте из файла две матрицы чисел. Найдите среднее арифметическое всех элементов для каждой матрицы.
  Найдите разницу этих двух средних арифметических.*/

namespace Practic_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum1 = 0;
            double sum2 = 0;
            int lines = 0;
            var arr = File.ReadAllLines("matrix.txt");
            var k = arr[0].Split(' ').Length;
            var m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var line = arr[i].Split(' ');
                if (line[0] == "") break;
                lines++;
                for (int j = 0; j < line.Length; j++)
                    sum1+= int.Parse(line[j]);
            }

            for (int i = arr.Length - lines + 1; i < arr.Length; i++)
            {
                var line = arr[i].Split(' ');
                m = line.Length;
                for (int j = 0; j < line.Length; j++)
                {
                    sum2 += int.Parse(line[j]);
                }
            }

            Console.WriteLine($"Разница м/у средними арифметическими: {sum1/(lines*k) - sum2/((arr.Length-lines-1)*m)}");
        }
    }
}
