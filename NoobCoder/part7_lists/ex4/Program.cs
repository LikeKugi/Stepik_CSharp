using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        // 1 task
        // random dynamic list of n items
        //----------------------------------------------
        static List<dynamic> GetList(int n)
        {
            var list = new List<dynamic>(n);
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rd.Next());
            }

            return list;
        }
        static void DynamicRandom()
        {
            string? inptLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inptLine))
                inptLine = "3";
            int n = int.Parse(inptLine);
            List<dynamic> list = GetList(n);
            foreach (var el in list)
                Console.WriteLine(el);
        }
        //------------------------------------------------

        // 2 task
        // Get Syracusa Sequence
        // a % 2 == 0 => a / 2
        // a % 2 != 0 => a * 3 + 1
        //------------------------------------------------
        static void PrintSyracusa()
        {   
            string? inptLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inptLine))
                inptLine = "3";
            int number = int.Parse(inptLine);
            foreach (var x in GetSyracusaSequence(number))
                Console.Write($"{x} ");
        }
        static List<int> GetSyracusaSequence(int value)
        {
            var list = new List<int>();
            list.Add(value);
            
            while (value != 1)
            {
                value = (value % 2 == 0) ? value / 2 : (value * 3) + 1;
                
                list.Add(value);
            }
            
            return list;
        }
        //------------------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            DynamicRandom();
            PrintSyracusa();
        }
    }
}