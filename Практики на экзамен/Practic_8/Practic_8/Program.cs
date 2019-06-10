using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//файл лежит в bin\Debug\cesar.txt

/* Считайте из файла текст и число. Зашифруйте считанный текст по шифру цезаря, использую считанное число, как основание шифра. 
 * Если основание шифра равно 2, то буква А -> В, Б -> Г и т.д.
 п.с. она у меня пока что не идет по кругу, то есть после Я идет всякая хрень(*/

namespace Practic_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var cesar = File.ReadAllLines("cesar.txt");
            var lines = new List<string>();
            int step = int.Parse(cesar[cesar.Length - 1]);
            for (int i = 0; i < cesar.Length - 1; i++)
            {
                var line = cesar[i];
                var newline = "";
                for (int j = 0; j < line.Length; j++)
                    newline += (char)(line[j] + step);
                lines.Add(newline);
            }
            lines.Add(step.ToString());
            File.WriteAllLines("cesar.txt", lines);
        }
    }
}
