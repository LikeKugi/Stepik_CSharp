using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] Boyare()
        {
            var peoples = new int[20];
            for (int i = 0; i < peoples.Length; i++)
                peoples[i] = GetNumber();
            return peoples;
        }
        static int CountHigher(int[] peoples) => peoples.Aggregate(0, (a,x) => a += (x>160)? 1 : 0);
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var peoples = Boyare();
            Console.WriteLine(CountHigher(peoples));


        }
    }
}