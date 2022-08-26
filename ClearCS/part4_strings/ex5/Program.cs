using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var words = Console.ReadLine()!.Split(new char[]{',', ' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            string? find = Console.ReadLine();
            var counter = 0;
            foreach (string word in words!)
            {
                if (word==find)
                    counter++;
            }
            Console.WriteLine(counter);
        }

    }
}