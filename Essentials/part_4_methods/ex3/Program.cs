using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Task.PrintAsterisks(10);
            Task.PrintAsteriskBox(5,3);

        }
    }

    class Task 
    {
	// пиши код метода PrintAsterisks здесь
        public static void PrintAsterisks(int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        public static void PrintAsteriskBox(int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
                
        }
    }
}