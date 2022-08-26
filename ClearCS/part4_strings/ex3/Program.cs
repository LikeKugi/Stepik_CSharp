using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = " ";
            Console.WriteLine(ChangeCase(line));
        }

        static string ChangeCase(string str) => string.Join("",str.ToCharArray().Select(x=>char.IsLower(x)?char.ToUpper(x):char.ToLower(x)));
    }
}