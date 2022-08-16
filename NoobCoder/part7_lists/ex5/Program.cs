using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        // get input line
        static string InptLine()
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = "1 3 4 7 8 10";
            return line;
        }

        // get array from line
        static List<int> ListNumbers(string line)
        {
            var numbers = new List<int>();
            numbers = line.Split(' ').Select(Int32.Parse).ToList();
            return numbers;
        }

        static void PrintNumbers(List<int> numbers)
        {   
            int value = numbers[0];
            //int stop = numbers[1];
            for (int i = numbers[0]; i < numbers.Last(); i++)
                if (!numbers.Contains(i))
                    Console.Write(i + " ");

        }

        //-----------------------------------------------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            string line = InptLine();
            PrintNumbers(ListNumbers(line));

        }
    }
}