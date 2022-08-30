using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var number = GetNumber();
            var reverseNumber = GetReverseNumber(number);

            PrintBigger(number,reverseNumber);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int GetReverseNumber(int n) => Convert.ToInt32(string.Join("",n.ToString().ToCharArray().Reverse().Select(n=>n)));
        static void PrintBigger(int a, int b) => Console.WriteLine("{0} {1}",b , (a>b)?"1":(a<b)?"2":"3");
    }
}