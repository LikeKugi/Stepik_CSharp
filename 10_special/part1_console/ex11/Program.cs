using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var numbers = GetNumbers();
            FindMaxSum(numbers);

        }
        static int[] GetNumbers() => Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        static void FindMaxSum(int[] arr)
        {
            var index = 0;
            var sum = int.MinValue;
            var len = arr[0];
            for (int i = 1; i < len-1; i++)
            {
                if (arr[i]+arr[i+1]>sum)
                {
                    sum = arr[i]+arr[i+1];
                    index = i;
                }
            }
            Console.WriteLine("{0} {1} {2}", sum, index, index+1);
        }
    }
}