using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var x = GetNumber();
            var y = GetNumber();

            switch (FindAnswer(x * y))
            {
                case 1:
                    Console.WriteLine(FindPLusS(x, y)); 
                    break;
                case 0:
                    Console.WriteLine(FindZeroS(x, y)); 
                    break;
                case -1:
                    Console.WriteLine(FindMinusS(x, y)); 
                    break;
            }

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int FindAnswer(int a) => (a > 0) ? 1 : (a < 0) ? -1 : 0;
        static int FindPLusS(int x, int y) => 2 * x + y;
        static int FindZeroS(int x, int y) => 0;
        static int FindMinusS(int x, int y) => 2 * Math.Abs(x) - y;
    }
}