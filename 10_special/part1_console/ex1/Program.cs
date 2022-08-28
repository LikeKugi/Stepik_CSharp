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

            var numbers = GetNumbers();
            Console.WriteLine(GetSum(numbers));

        }

        static int[] GetNumbers() => (Console.ReadLine()!).Split(' ').Select(Int32.Parse).ToArray();

        static int GetSum(int[] numbers) => numbers.Aggregate(0,(a,x)=>a+=x);
    }
}