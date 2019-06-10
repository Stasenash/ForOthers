using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //подключили библиотеку работы с файлами

//файл с текстом находится в папке bin\Debug

/*
 Считайте из файла текст. Разбейте его по предложениям. Каждое предложение
 разбейте на слова. Подсчитайте кол-во всех предложений, всех слов и 
 выведите на экран список уникальных слов в тексте
  */

namespace Practic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentences = File.ReadAllText("array.txt").Split('.');
            for (int i = 0; i < sentences.Length; i++)
                sentences[i] = sentences[i].Trim();
            sentences = sentences.Where(x => x!=string.Empty).ToArray();
            var words = File.ReadAllText("array.txt").Split(' ');
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].Replace(",","").Replace("—", "").Replace(".","").Replace("?","").Replace("!","").ToLower().Trim();
            Console.WriteLine($"Кол-во предложений: {sentences.Length}");
            Console.WriteLine($"Кол-во слов: {words.Length}");
            words = words.Where(x => x != string.Empty).Distinct().ToArray();
            Console.WriteLine($"Кол-во уникальных слов: {words.Length}");
            Console.WriteLine("Список уникальных слов:");
            foreach (var word in words)
                Console.WriteLine(word);
        }
    }
}
