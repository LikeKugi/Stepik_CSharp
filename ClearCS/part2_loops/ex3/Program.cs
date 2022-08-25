using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            int starts = GetNumber();
            int ends = GetNumber();
            string str = string.Join(" ", Enumerable.Range(starts, ends-starts+1).Where(x => x % 2 == 0).Select(x => x * x));
            Console.WriteLine(str);
        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
    }
}

// )