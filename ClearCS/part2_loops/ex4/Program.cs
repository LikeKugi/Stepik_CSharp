using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var countEnemies = GetIntNumber();
            var countHeads = GetIntNumber();
            var sum = countEnemies*countHeads;
            var days = 0;
            for (int i = 0; i < sum; i+=3)
            {
                
                days++;
            }
            Console.WriteLine(days + " дня");

        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
    }
}