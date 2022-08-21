using System;

namespace MyProgram
{
    class Program
    {   
        static int GetInt() => Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            int a = GetInt();
            int b = GetInt();

            Console.WriteLine(a*b);

        }
    }
}