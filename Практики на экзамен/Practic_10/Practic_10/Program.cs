using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//файл находится в bin\Debug\words.txt

/*Считайте из файла массив слов. Создайте словарь списков слов, где ключом будет первая буква каждого слова.*/
namespace Practic_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").ToLower().Split(' ');
            var dict = new Dictionary<char, List<string>>();
            foreach (var word in words)
                if (!dict.ContainsKey(word[0]))
                    dict.Add(word[0], new List<string>() { word });
                else
                    dict[word[0]].Add(word);
        }
    }
}
