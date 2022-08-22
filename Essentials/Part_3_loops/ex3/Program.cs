using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static List<int> GetArray()
        {
            var numbers = new List<int>();
            do
            {
                numbers.Add(GetNumber());
            }
            while (numbers[numbers.Count-1] != 0);
            return numbers;
        }
            
        static void PrintArray(List<int> numbers)
        {
            var counter = 0;
            foreach (int number in numbers)
            {
                if (number != 0)
                    counter++;
                else
                    break;
            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            PrintArray(GetArray());

        }
    }
}