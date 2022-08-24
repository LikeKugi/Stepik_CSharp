using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var x = GetIntNumber();
            var y = GetIntNumber();

            Console.WriteLine((Math.Abs(x)<40&&Math.Abs(y)<40)? "Да" : "Нет");

        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
    }
}