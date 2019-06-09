using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQRepeat
{
    public class FilesLoader
    {
        public static List<string> LoadMessages() => File.ReadAllLines("../../Resources/Messages.txt").ToList();
    }
}
