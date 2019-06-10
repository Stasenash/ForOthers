using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//файл в папке bin\Debug\text.txt
/* Считайте из файла текст. Найдите самую часто встречающуюся букву в этом тексте. */
namespace Practic_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("text.txt").ToLower().Replace(" ","");
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var e in text)
            {
                if (!dict.ContainsKey(e))
                    dict.Add(e, 1);
                else
                    dict[e]++;
            }
            var max = dict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine(max);
        }
    }
}
