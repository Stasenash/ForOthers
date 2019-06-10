using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//файл в папке bin\Debug\lines.txt
/*Считайте из файла массив строк. Отсортируйте строки по длине по возрастанию и запишите в другой файл.*/

namespace Practic_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("lines.txt");
            lines = lines.OrderBy(e => e.Length).ToArray();
            File.WriteAllLines( "finallines.txt",lines);
        }
    }
}
