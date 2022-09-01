using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var value = GetNumber();
            PrintSquares(value);
            FindSquare(value);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static void FindSquare(int num)
        {
            var acccum = 0;
            for (int i = 1; i<=num;i++)
            {
                acccum+=(i*2-1);
                Console.Write(acccum + " ");
            }
        }

        static void PrintSquares(int number) => Console.WriteLine(string.Join(" ",Enumerable.Range(1,number).Select(n=>n*n)));
        
    }
}