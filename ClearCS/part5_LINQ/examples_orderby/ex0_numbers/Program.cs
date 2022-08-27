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
            int[] number = { 14, 0, 23, -3, 10, 19, 45 };
            var sortedNums = from n in number
                            where n % 2 != 0 //можно комбинировать
                            orderby n 
                            select n;
            foreach (var x in sortedNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
            SortNums(number);
        }

        // Задание. Измените запрос так, чтобы на экран выводились только положительные числа массива, отсортированные по убыванию.

        static void SortNums(int[] numbers)
        {
            var positHigher = from n in numbers
                                where n > 0
                                orderby n descending // descending - от большего к меньшему (не обязательный параметр)
                                select n;
            Console.WriteLine(string.Join(" ", positHigher.Select(n=>n)));
        }
    }
}