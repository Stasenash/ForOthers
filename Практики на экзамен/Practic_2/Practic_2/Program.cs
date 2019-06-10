using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//файл в папке bin\Debug\matrix.txt

/* Считайте из файла матрицу чисел и найдите среднее арифметические чисел, лежащих на главной даигонали.
 */

namespace Practic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            var arr = File.ReadAllLines("matrix.txt");
            var k = arr[0].Split(' ').Length;
            var matrix = new int[arr.Length, k];
            for (int i = 0; i < arr.Length; i++)
            {
                var line = arr[i].Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }   
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
                sum += matrix[i, i];
            Console.WriteLine($"Среднее арифметическое на диагонали: {sum / matrix.GetLength(0)}");
        }
    }
}
