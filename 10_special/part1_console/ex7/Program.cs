using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var day = GetDay();
            day = (day+3) % 7;
            var dayOfWeek = new Days();
            dayOfWeek = (Days)day;
            Console.WriteLine(dayOfWeek);

        }
        static int GetDay() => Convert.ToInt32(Console.ReadLine());
    }
    enum Days
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг = 4,
        Пятница = 5,
        Суббота = 6,
        Воскресенье = 0,
    }
}