using System;
using System.Linq;
namespace Example
{
    class Program
    {
        static void Main()
        {
            string[] strings = {"один два три",
                                "четыре пять шесть",
                                "семь восемь девять десять"};
            var query = from line in strings
                        let words = line.Split(' ') //создали новую переменную диапазона и
                        from word in words // организовали к ней запрос
                        where word[0] == 'д'
                        select word;
            foreach (var x in query)
            {
                Console.Write("{0} ", x);
            }
        }
    }
}