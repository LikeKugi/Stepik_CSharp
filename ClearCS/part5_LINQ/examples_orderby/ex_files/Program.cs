using System;
using System.Linq;
using System.IO;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\System32");
            var files = from n in dir.GetFiles()
                        where n.Length>32568000
                        orderby n.Length //сортировка по размеру файла
                        select n;
            foreach (var x in files)
            {
                Console.WriteLine("{0}", x.Name);
            }

        }
    }
}