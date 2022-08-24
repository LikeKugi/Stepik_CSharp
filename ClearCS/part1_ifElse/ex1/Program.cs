using System;

namespace MainClass
{
    class Program
    {


        static void Main(string[] args)
        {
            //var age = GetAge();
            Console.WriteLine(PrintAges(GetAge()));
        }
        static int GetAge() => Convert.ToInt32(Console.ReadLine());

        static string PrintAges(int age) => (age <= 3) ? "Ребёнок" : (age >= 70) ? "Старик" : "Взрослый";

    }
}