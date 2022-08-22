using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            string? inpt;
            Console.WriteLine("Введите имя:");
            inpt = Console.ReadLine();
            string? name = inpt;
            Console.WriteLine("Имя ученика: " + name);
            Console.WriteLine("Введите возраст:");
            inpt = Console.ReadLine();
            byte age = Convert.ToByte(inpt);
            Console.WriteLine("Возраст ученика: " + age);
            Console.WriteLine("Введите балл по русскому языку:");
            inpt = Console.ReadLine();
            int RusPoint = Convert.ToInt32(inpt);
            Console.WriteLine("Введите балл по математике:");
            inpt = Console.ReadLine();
            int MathPoint = Convert.ToInt32(inpt);
            Console.WriteLine("Введите балл по информатике:");
            inpt = Console.ReadLine();
            int CSPoint = Convert.ToInt32(inpt);
            Console.WriteLine("Средний балл ученика: " + (RusPoint + MathPoint + CSPoint) / 3);
        }
    }
}