using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            // 60*(n+1)/11
            string? inpt_tms = Console.ReadLine();
            if (inpt_tms == null) {
                inpt_tms = "5";
            }
            int n = int.Parse(inpt_tms);

            //Ваш код

            int minutes_left;
            minutes_left = 12 * 60 + 30;
            int minutes_past = 60 * (n + 1) / 11;
            int current_time = minutes_left + minutes_past;
            int current_hours = current_time / 60;
            int current_minutes = current_time % 60;

            Console.WriteLine($"{current_hours}:{current_minutes}");
        }
    }
}