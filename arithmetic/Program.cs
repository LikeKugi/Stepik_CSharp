using System;

namespace arithmetic
{
    public class Program{

        public static void Main() {

            // 1 task
            int a = 45, b = 78;
            int result = a * b;
            Console.WriteLine(result);

            // 2 task
            string? inNum = Console.ReadLine();
            double fNum = Convert.ToDouble(inNum);
            inNum = Console.ReadLine();
            double sNum = Convert.ToDouble(inNum);
            Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
            Console.WriteLine("1 число: " + fNum);
            Console.WriteLine("2 число: " + sNum);
            Console.WriteLine(fNum / sNum);

        }

    }

}