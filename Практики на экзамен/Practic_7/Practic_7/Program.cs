using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//файл лежит в bin\Debug\array.txt

/*Считайте из файла массив чисел. Выведите на экран все простые числа из файла.*/

namespace Practic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = File.ReadAllText("array.txt").Split(' ');
            List<int> nums = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                for (int j = 2; j < int.Parse(array[i]); j++)
                {
                    if (int.Parse(array[i]) % j == 0)
                        flag = false;
                }
                if (flag)
                    nums.Add(int.Parse(array[i]));
            }
            foreach (var num in nums)
                Console.WriteLine(num);
        }
    }
}
