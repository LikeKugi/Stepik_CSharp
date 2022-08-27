using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            // получение источника данных
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            // создание запроса
            // var!!!
            var lowNums =
                from n in number
                where n <= 3 || n > 8 // можно несколько булевых запросов
                select n;
            // выполнение запроса
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }

        }
    }
}