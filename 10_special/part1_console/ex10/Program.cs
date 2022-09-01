using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var numbers = GetNumbers();
            PrintAnswer(CheckNumbers(numbers));

        }

        static int[] GetNumbers() => Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        static bool CheckNumbers(int[] numbers)
        {
            for (int i = 0;i<numbers.Length-1;i++)
            {
                if (i%2==0&&numbers[i]!=1 || i%2==1&&numbers[i]!=2)
                    return false;
            }
            return true;
        }

        static void PrintAnswer(bool ans) => Console.WriteLine(ans?"да":"нет");
    }
}