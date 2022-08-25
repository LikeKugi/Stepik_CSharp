using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var path = 1000.0;
            var dayPath = 150.0;
            var day = 1;
            while (path >=0 )
            {
                dayPath *= 1.1;
                path -= dayPath;
                day++;
            }
            Console.WriteLine(day);

        }
    }
}