using System;

namespace MyProgram
{
    class Program
    {
        static void AhShitHereWeGoAgain(int[] arr, int minValue)
        {
            int[] sortArr = new int[arr.Length + 1];
            Array.Copy(arr, 0, sortArr, 1, sortArr.Length-1);
            foreach (int el in sortArr){
                Console.Write(el + " ");
            }
            //Console.WriteLine();
            for (int i = 1; i < sortArr.Length; i++) {
                sortArr[i] += sortArr[i-1];
            }
            foreach (int el in sortArr){
                Console.Write(el + " ");
            }
            //Console.WriteLine();
            int min = System.Linq.Enumerable.Min(sortArr);
            //Console.WriteLine(min);
            
            for (int i = 0; i < sortArr.Length; i++) {
                sortArr[i] += minValue - min;
            }
            foreach (int el in sortArr){
                Console.Write(el + " ");
            }
        }
        static int GetDecrypt(int val, int min, int minVal)
        {
            return val += minVal - min;
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            int hourHandAmount = 1468;        
            int[] vasyaArray = {27,-15,2,22,12,-55,11};        
            AhShitHereWeGoAgain (vasyaArray, hourHandAmount);
        }
    }
}