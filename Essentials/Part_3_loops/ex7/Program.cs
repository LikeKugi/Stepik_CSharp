using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static List<int> GetNumbersArray()
        {
            var numbers = new List<int>();
            int value;
            while (true)
            {
                value = GetNumber();
                if (value < 10)
                    continue;
                    else if (value > 100)
                        break;
                        else
                            numbers.Add(value);
            }
            return numbers;
        }
        static void PrintArray(List<int> numbers)
        {
            foreach (int number in numbers)
                Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var numbers = GetNumbersArray();
            PrintArray(numbers);

        }
    }
}