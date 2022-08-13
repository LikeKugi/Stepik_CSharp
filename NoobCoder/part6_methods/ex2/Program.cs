using System;

namespace MyProgram
{
    class Program
    {   
        // 1 task
        // output type of var using methods
        static void PolyLambda() 
        {
            Console.WriteLine("enter string:");
            string? str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)){
                str = "adgjwr32";
            }
            Random rndInt = new Random();
            int a = rndInt.Next(1, 100);
            double b = (double)a;
            char c = str[0];
            Console.WriteLine(GetTypeInfo(str));
            Console.WriteLine(GetTypeInfo(a));
            Console.WriteLine(GetTypeInfo(b));
            Console.WriteLine(GetTypeInfo(c));
        }
        static string GetTypeInfo(string str) => "Переменная является строкой";
        static string GetTypeInfo(int a) => "Переменная целочисленного типа";
        static string GetTypeInfo(double b) => "Переменная - число с плавающей точкой";
        static string GetTypeInfo(char c) => "Переменная является символом";
        //-----------------------------------------------------------------------------

        // 2 task
        // output string of amount symbols
        static void PrintResults()
        {
            Console.WriteLine("enter symbol:");
            string? symbol = Console.ReadLine();
            if (string.IsNullOrEmpty(symbol)){
                symbol = "adgjwr32";
            }
            Console.WriteLine("enter amount:");
            string? amount = Console.ReadLine(); 
            if (string.IsNullOrEmpty(amount)){
                amount = "2";
            }  
            Print (symbol, amount, out string result);
            Console.WriteLine(result);
        }
        static void Print(string value, string times, out string result) 
        {   
            result = "";
            int i = int.Parse(times);
            while (i > 0){
                result += value;
                i--;
            }
        }
        //--------------------------------------------------------------

        // 3 task
        // change sign in every value of an array
        static void PrintArray() {
            int[] array = { 93, -9, 15, 16, -3, 0, 18 };
            Opposite(array);
            foreach (var x in array)
                Console.Write($"{x} ");
        }
        static void Opposite(int[] arrChange) 
        {
            for (int i = 0; i < arrChange.Length; i++) {
                arrChange[i] *= -1;
            }
        }
        //-----------------------------------------------------

        // 4 task
        // get new array which is sum of the elements of 2 arrays
        static void GetArray(){
            int[] array1 = {1,2,3,4,5,6,7,8};
            int[] array2 = {9,8,7,6,5,4,3,2};
            foreach (var x in ArraySum(array1, array2))
                Console.Write($"{x} ");
        }

        // это такой ебаный говнокод...
        static int[] ArraySum(int[] arr1, int[] arr2)
        {   
            int len = (arr1.Length >= arr2.Length) ? arr1.Length : arr2.Length;
            int[] resArr = new int[len];
            for (int i = 0; i < len; i++) {
                resArr[i] = (arr1.Length >= arr2.Length) ? arr1[i] : arr2[i];
            }
            len = (arr1.Length <= arr2.Length) ? arr1.Length : arr2.Length;
            for (int i = 0; i < len; i++) {
                resArr[i] += (len == arr2.Length) ? arr2[i] : arr1[i];
            }
            return resArr;
        }

        // 5 task
        // average geometric from some numbers
        // AG - average geometric
        // AG(a, b, c) == (a * b * c) ** (1/n), n - count of numbers
        // for (a, b, c) n == 3;
        static void GetGeometric(){
            Console.WriteLine(GeometricMean(5, 25, 1, 0));
            Console.WriteLine(GeometricMean(7, 7));
            Console.WriteLine(GeometricMean(1, 1, 27));
            Console.WriteLine(GeometricMean(2,4,1));
        } 
        static double GeometricMean(params int[] numbers)
        {   
            double backValue = 1;
            for (int i = 0; i < numbers.Length; i++) {
                backValue *= numbers[i];
            }
            Console.WriteLine("multiply = " + backValue);
            backValue = Math.Pow(backValue, 1.0/numbers.Length);
            Console.WriteLine("Geom = " + backValue);
            return backValue;
        }
        //-------------------------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            //PolyLambda();
            //PrintResults();
            //PrintArray();
            //GetArray();
            GetGeometric();
        }
    }
}