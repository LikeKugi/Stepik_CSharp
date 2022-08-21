using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var age = GetNumber();

            string output = (age < 18) ? "ребёнок" : (age >= 70) ? "старик" : "взрослый";
            Console.WriteLine(output);

        }
    }
}