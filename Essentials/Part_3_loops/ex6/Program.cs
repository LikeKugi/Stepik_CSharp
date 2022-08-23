using System;

namespace MyProgram
{
    class Program
    {
        
    // task with some loops
        static void FirstLoop()
        {
            for (int i = 0; i < 10; i++) {
                if (i % 3 == 1) {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
        static void SecondLoop()
        {
            for (int i = 0; i < 10; i++) {
                Console.Write(i + " ");
                if (i % 3 == 1) {
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            FirstLoop();
            Console.WriteLine();
            Console.WriteLine("================");
            SecondLoop();

        }
    }
}