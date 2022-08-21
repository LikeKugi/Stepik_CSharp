using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] GetValues()
        {
            var values = new int[3];
            for (int i = 0; i< values.Length;i++)
            {
                values[i] = GetNumber();
            }
            return values;
        }
        static string CheckTriangle(int[] values)
        {
            return (values.Max() >= (Enumerable.Aggregate(values, (a,x)=> a+=x))-values.Max()) ? "no" : "yes";
        }

        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            
            var length = GetValues();
            Console.WriteLine(CheckTriangle(length));

        }
    }
}