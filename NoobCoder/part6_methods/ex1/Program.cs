using System;

namespace MyProgram
{
    class Program
    {
        static int Do(int a, int b) => a * b;
        static int Do(double a, int b) => (int)(a / b);

        private static int GetGrade(int input)
        {
            if (100 >= input && input > 80)
                return 5;
            else if (input > 60)
                return 4;
            else if (input > 40)
                return 3;
            else if (input <= 40)
                return 2;
            return 0;
        }

        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            float a = 231;
            int b = '2'; // (char => int) ( +48 ) but if u need (char => int) do ('c' - '0')
            Console.WriteLine(b);
            Console.WriteLine(Do(a,b));

            int grade = GetGrade(40);
            Console.WriteLine(grade);

        }
    }
}