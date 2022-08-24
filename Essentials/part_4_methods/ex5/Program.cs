using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            string mostWidespread = Task.GetMostWidespread(new[] {"Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin"});
            Console.WriteLine(mostWidespread);
        }
    }
    class Task 
    {
	// пиши код метода GetMostWidespread здесь
        // ебаный говнокод...
        public static string GetMostWidespread(string[] names)
        {
            var countEmp = 0; 
            var countMac = 0;
            var countLit = 0;

            foreach (string name in names)
            {
                if (name == "Emperor Penguin")
                    countEmp++;
                    else if (name == "Macaroni Penguin")
                        countMac++;
                        else if (name == "Little Penguin")
                            countLit++;
            }

            if (countEmp >= countMac && countEmp > countLit)
                return ("Emperor Penguin");
                else if (countMac > countEmp && countMac >= countLit)
                    return("Macaroni Penguin");
                    else if (countLit >= countEmp && countLit > countMac)
                        return("Little Penguin");
            return ("Emperor Penguin");

            
        }

            // function in normal way
        public static string GetAnswer(string[] penguin)
        {
            string name = penguin.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            return name;
        }
    }
}