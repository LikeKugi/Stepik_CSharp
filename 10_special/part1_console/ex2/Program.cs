using System;
using System.Linq;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var numbers = GetNumbers();
            PrintNumbers(GetDigits(numbers));
        }
        static int[] GetNumbers() => Console.ReadLine()!.Split(' ').Select(Int32.Parse).ToArray();

        static List<int> GetDigits(int[] numbers)
        {
            var digits = new List<int>();
            foreach (int number in numbers)
            {
                var adding = number;
                digits.Add(adding/10);
                digits.Add(adding%10);
            }
            Console.WriteLine(string.Join(" ", digits.Select(x=>x)));
            return digits;
        }

        static void PrintNumbers(List<int>digits) => Console.WriteLine("{0}{1} {2}{3}",digits[1],digits[2],digits[3],digits[0]);
    }
}