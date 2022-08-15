using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        // получить строку
        static string GetLine()
        {   
            string? inptLn = Console.ReadLine();
            if (string.IsNullOrEmpty(inptLn))
                inptLn = "1 2 3 4 5 6";
            return inptLn;
        }

        // получить массив из строки
        static List<int> GetArray()
        {
            string line = GetLine();
            string[] arr = line.Split(' ');
            var arrRet = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                arrRet.Add(int.Parse(arr[i]));
            }
            return arrRet;
        }

        // получить начало и конец диапазона между 0
        // GetValuesInRange();
        static void GetStartEnd(List<int> numbers, out int start, out int end)
        {
            start = numbers.IndexOf(0);
            end = numbers.LastIndexOf(0);
        }

        // получить массив между 0
        static List<int> GetValuesInRange()
        {
            // original array
            var numbers = GetArray();
            // array between 0 & 0
            var rangeArr = new List<int>(numbers.Count);
            GetStartEnd(numbers, out int start, out int end);
            for (int i = start + 1; i < end; i++)
            {
                rangeArr.Add(numbers[i]);
            }
            return rangeArr;
        }

        // отсортировать массив
        static List<int> GetSorted()
        {   
            // получить массив для сортировки
            var arrToSort = GetValuesInRange();
            // массив куда сортировать
            var sortedArr = new List<int>(arrToSort.Count);
            foreach (int el in arrToSort)
                sortedArr.Add(el);
            sortedArr.Sort();
            sortedArr.Reverse();
            return sortedArr;
        }

        // напечатать массив
        static void PrintArray()
        {   
            var numbers = new List<int>();
            numbers = GetSorted();
            foreach(int el in numbers) {
                Console.Write(el + " ");
            }
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            PrintArray();
            
            
        }
    }
}