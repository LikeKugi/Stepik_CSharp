using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] GetValues()
        {
            var values = new int[4];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = GetNumber();
            }
            return values;
        }
        static string CheckAvaiable(int[] coords)
        {
            bool forward = Math.Abs(coords[0] - coords[2]) == 2 && Math.Abs(coords[1] - coords[3]) == 1;
            bool side = Math.Abs(coords[0] - coords[2]) == 1 && Math.Abs(coords[1] - coords[3]) == 2;
            return (side || forward) ? "yes" : "no";
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            Console.WriteLine(CheckAvaiable(GetValues()));

        }
    }
}