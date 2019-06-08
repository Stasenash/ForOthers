using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StackRepeat
{
    class Program
    {
        private static Stack<string> messages= new Stack<string>();
        private int Limit = 10;

        static void Main(string[] args)
        {
            ParseMsgs();
            foreach (var m in messages)
            {
                Console.WriteLine(m);
                Thread.Sleep(500);
            }
        }
        static void ParseMsgs()
        {
            var msgs = FilesLoader.LoadMessages();
            //for(......)
            //messages.Push(msgs[i])
            //removeoverflowing()
        }

        static void RemoveOverflowing()
        {
            //убрать переполнение стека
        }

    }
}
