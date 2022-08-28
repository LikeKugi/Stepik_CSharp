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
            foreach(double number in numbers)
                Console.WriteLine(number);
            FindPath(numbers);

        }

        static double[] GetNumbers() => Console.ReadLine()!.Split(' ').Select(x=>Convert.ToDouble(x)).ToArray();

        static void FindPath(double[] numbers)
        {
            numbers[1] /= 60;

            var firstPart = numbers.Aggregate(1.0, (a,b)=> a*=b);

            Console.WriteLine("{0}", Math.Round(firstPart*3,3,MidpointRounding.AwayFromZero)  );

        }
    
    }
}