using System;

namespace MyProgram
{
    
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] GetValues()
        {
            var values = new int[3];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = GetNumber();
            }
            return values;
        }
        static string CheckAvaiable(int[] coords)
        {
            bool dimensions = (coords[0] * coords[1]) >= coords[2];
            bool numbers = (coords[2] % coords[0]) == 0 || (coords[2] % coords[1]) == 0;
            return (numbers && dimensions)  ? "yes" : "no";
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine(CheckAvaiable(GetValues()));

        }
    }
}