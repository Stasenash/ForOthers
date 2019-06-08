using System;
using System.IO;
using System.Text;

namespace StackRepeat
{
    public class FilesLoader
    {
        public static string[] LoadMessages() => File.ReadAllLines("Resources/Messages.txt");
    }
}
