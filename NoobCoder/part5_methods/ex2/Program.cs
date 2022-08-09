using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {

            // 1 task
            // output sum of cubes in range [start,...,end]
        private static int InpNum() {
            // input numbers
            int n = 0;
            Console.WriteLine("input number: ");
            string? inpt_num = Console.ReadLine();
            if (inpt_num == null) {
                inpt_num = "132";
            }
            n = int.Parse(inpt_num);
            return n;
        }
        private static List<int> FullingArray() {
            // array creating
            //------------------------------
            int firstValue = InpNum();
            int lastValue = InpNum();
            //
            List<int> arrNum = new List<int>();
            for (int i = firstValue; i <= lastValue; i++) {
                arrNum.Add((int)Math.Pow(i,3));
            }
            return arrNum;
        }
        private static int GetCubes () {    //int start, int end
            int cubes = 0;
            List<int> ArrToSum = FullingArray();
            foreach (int el in ArrToSum) {
                cubes += el;
            }
            Console.WriteLine(cubes);
            return cubes;
        } 

        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            GetCubes();

        }
    }
}