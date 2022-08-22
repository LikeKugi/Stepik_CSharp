using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here

             /* EXAMPLE OF IF-ELSE STATE */

            Console.Clear();

            Random rnd_generator = new Random();
            int generator_of_rana = rnd_generator.Next(1,50);
            bool rana;

            if (generator_of_rana > 25)
            {
                rana = true;
            }
            else
            {
                rana = false;
            }

            if (rana)
            {
                Console.WriteLine("Персонаж ранен! Используй аптечку!");
            }
            else
            {
                Console.WriteLine("Ранений не обнаружено.");
            }

            // 1 task
            string? input_of_goal = Console.ReadLine();
            bool goal = Convert.ToBoolean(input_of_goal);

            if (goal)
            {
                Console.WriteLine("Попадание!");
            }
            else
            {
                Console.WriteLine("Промах!");
            }

            // 2 task
            string? input_even_or_odd = Console.ReadLine();
            int even_or_odd = Convert.ToInt32(input_even_or_odd);
            Console.WriteLine("Введите число:");
            if (even_or_odd % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }

            /* | || & && */

            /*
            *   | checks all the terms in (a | b | ...)
            *   || checks until first true in (a || b || ...)
            *   & checks all the terms in (a & b & ...)
            *   && checks until first false in (a && b && ...)
            */

            // 3 task
            string? input_condition = Console.ReadLine();
            bool virus = Convert.ToBoolean(input_condition);
            input_condition = Console.ReadLine();
            bool HighTemperature = Convert.ToBoolean(input_condition);
            input_condition = Console.ReadLine();
            bool NoCooling = Convert.ToBoolean(input_condition);

            if (virus && HighTemperature || NoCooling)
            {
                Console.WriteLine("Угроза повреждения системы!");
            }
            else if (virus || HighTemperature)
            {
                Console.WriteLine("Обнаружены незначительные угрозы.");
            }

        }
    }
}