using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static List<int> FindDividers(int start, int end)
        {
            var numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i%3==0)
                    numbers.Add(i);
            }
            return numbers;
        }
        static double FindAverage(List<int>numbers) => numbers.Aggregate(0.0,(a,x)=> a+=x)/numbers.Count;
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var startValue = GetNumber();
            var endValue = GetNumber();
            var numbers = FindDividers(startValue, endValue);
            Console.WriteLine(FindAverage(numbers));

        }
    }
}