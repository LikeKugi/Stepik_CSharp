using System;
using System.Linq;

namespace MainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string? fwd = Console.ReadLine();
            if (string.IsNullOrEmpty(fwd))
                fwd = " ";
            string rvs = Reverse(fwd);
            Console.WriteLine(rvs);
            Console.ReadKey();

        }

        private static string Reverse(string fwd) => string.Join("", fwd.ToCharArray().Reverse());
        /*
        {
            char[] carr = fwd.ToCharArray();
            char temp;
            for (int i = 0; i < carr.Length; i+2)
            {
                temp = carr[carr.Length - 1 - i];
                carr[carr.Length - 1 - i] = carr[i];
            }
            return new string(carr);
        }
        */
    }
}