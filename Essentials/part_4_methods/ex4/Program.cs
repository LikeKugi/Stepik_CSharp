using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Task.CheckPairs("Console.ReadLine();", '(', ')');

        }
    }
    class Task 
    {
	// пиши код метода CheckPairs здесь
        public static void CheckPairs(string line, char open, char close)
        {
            if (line.IndexOf(open) >= line.Substring(line.IndexOf(open)).LastIndexOf(close))
                Console.WriteLine("Найдены ошибки");
            else
                Console.WriteLine("Все в порядке");
        }
    }
}