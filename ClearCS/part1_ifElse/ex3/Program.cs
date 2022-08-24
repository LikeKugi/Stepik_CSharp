using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var x = GetIntNumber();

            Console.WriteLine(FindY(x));

        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());

        static int FindY(int x) => (x >= 0) ? 2 * x - 10 : 2 * Math.Abs(x) - 1;
    }
}