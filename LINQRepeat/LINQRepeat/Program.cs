using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQRepeat
{
    class Program
    {
        private static List<string> messages = FilesLoader.LoadMessages();

        static void Main(string[] args)
        {
            foreach (var m in messages)
                Console.WriteLine(m);
        }

        static void SortMessages()
        {
            //с помощью Линку отсортировать сообщения по алфавиту, но от Я до А
            //оставить только первое
            //проверить что выведется на экран
        }
    }
}
