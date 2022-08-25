using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var length = GetNumber();
            var A = GetArray(length);
            PrintArray(A);
            var B = ModifyArray(A);
            PrintArray(B);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static float[] GetArray(int n) => Enumerable.Range(1,n).Select(x=>(float)x).ToArray();
        static float[] ModifyArray(float[] arr) => arr.Select(x=>x*3).ToArray();
        static void PrintArray(float[] arr) => Console.WriteLine(string.Join("\n", arr.Select(x=>x)));
    }
}

