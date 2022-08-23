using System;

namespace MyProgram
{
    class Program
    {
        static double GetLength() => Convert.ToDouble(Console.ReadLine());
        static void FindDays(double x, double goal)
        {
            int n = 1;
            while (x < goal)
            {
                x *= 1.1;
                n++;
            }
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            double x = GetLength();
            double goal = GetLength();
            FindDays(x, goal);

            
        }
    }
}