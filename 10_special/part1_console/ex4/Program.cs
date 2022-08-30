using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Printer(GetNumbers());

        }
        static int[] GetNumbers() => Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        static void Printer(int[] n) => Console.WriteLine((n[0]>n[1])?"1":(n[0]<n[1])?"2":"3");
    }
}