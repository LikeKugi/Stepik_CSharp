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
    //TODO: rewrite!!!
        public static void CheckPairs(string line, char open, char close)
        {
            var counter = 0;
            foreach (char el in line)
            {
                if (el == open)
                {
                    counter++;
                }   else if (el == close)
                    {
                        counter--;
                    }
                if (counter < 0)
                {
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Все в порядке");
            }   else
                {
                    Console.WriteLine("Найдены ошибки");
                }
            
        }
    }
}