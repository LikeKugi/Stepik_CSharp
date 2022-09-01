using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var range  = GetNumber();
            var start = range[0];
            var end = range[1];
            PrintNumbers(GetEvenNumbers(start,end));

        }
        static int[] GetNumber() => Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        static int[] GetEvenNumbers(int start, int end) => Enumerable.Range((start+1),(end-start-1)).Where(n=>n%2==1).Select(n=>n).ToArray();
        static void PrintNumbers(int[] arr) => Console.WriteLine(string.Join(" ",arr.Select(n=>n)) + " " + arr.Length);
    }
}