using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            /* SWITCH EXAMPLE */

            string? a = Console.ReadLine();

            switch (a)
                {
                    case "1": // "" - for string
                        Console.WriteLine("Вы ввели 1");
                    break;
                    case "2":
                        Console.WriteLine("Вы ввели 2");
                    break;
                    case "3":
                        Console.WriteLine("Вы ввели 3");
                    break;
                    case "4":
                        Console.WriteLine("Вы ввели 4");
                    break;
                    case "5": case "6": // severin cases
                        Console.WriteLine("Вы ввели 5 или 6");
                    break;
                    case "+": // '+' - for char if indeed
                        Console.WriteLine("Вы ввели +");
                    break;
                    // MUSTHAVE FOR ANY SWITCH
                    default: // default - if no case
                        Console.WriteLine("Вы ввели неизвестное мне значение!");
                    break;
                }

            // 1 task

            string? what_to_do = Console.ReadLine();

            switch(what_to_do)
            {
                case "1":
                    Console.WriteLine("Персонаж применяет аптечку");
                break;
                case "2":
                    Console.WriteLine("Персонаж пьет зелье");
                break;
                case "e":
                    Console.WriteLine("Персонаж открывает дверь");
                break;
            }

        }
    }
}