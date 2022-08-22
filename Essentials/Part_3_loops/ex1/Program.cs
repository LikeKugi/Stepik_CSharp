using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void PrintTable(int n)
        {
            for (int i = 1; i < 10; i++)
                Console.WriteLine("{0} * {1} = {2}", i, n, i * n);
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            int number = GetNumber();
            PrintTable(number);
        }
    }
}