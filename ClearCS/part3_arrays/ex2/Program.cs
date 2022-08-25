using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var dimensions = GetNumber();
            var array = GetArray(dimensions);
            PrintArray(FindMax(array));

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static int[,] GetArray(int n)
        {
            var array = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    array[i,j] = GetNumber();
            return array;
        }
        static int[] FindMax(int[,] arr)
        {
            var n = (int)Math.Sqrt(arr.Length);
            var maxArr = new int[n];
            for (int i = 0;i<n;i++)
            {
                maxArr[i] = arr[i,0];
                for (int j=1;j<n;j++)
                {
                    if (arr[i,j]>maxArr[i])
                        maxArr[i] = arr[i,j];
                }
                
            }
            return maxArr;
        }
        static void PrintArray(int[] arr) => Console.WriteLine(string.Join(" ", arr.Select(x=>x)));

    }
}