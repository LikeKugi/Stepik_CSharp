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
            CheckTriangle(numbers,FindMax(numbers));
        }
        static int[] GetNumbers() => Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        static int FindMax(int[] numbers)
        {
            var maxIndex = 0;
            for (int i =1;i<numbers.Length;i++)
            {
                if (numbers[i]>numbers[maxIndex])
                    maxIndex = i;
            }
            
            return maxIndex;
        }
        static void CheckTriangle(int[]numb, int maxInd) => Console.WriteLine(((numb.Aggregate(0,(a,x)=>a+=x)-numb[maxInd]>numb[maxInd])?"yes":"no")); 
    }
}