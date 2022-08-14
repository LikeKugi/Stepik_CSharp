using System;

namespace MyProgram
{
    class Program
    {
        // 1 task
        // return array of even values
        // 0 is even
        //-------------------------------------------------
        static void ArrayToEven()
        {
            int[] array = {7,14,3,2,5,9,0,11,8};   
            ToEven (ref array);
            foreach (var x in array)
                Console.Write($"{x} ");
        }
        static void ToEven(ref int[] array)
        {
            int[] evenArray = Array.FindAll(array, x =>
                                            x % 2 == 0);
            array = evenArray;
        }
        //----------------------------------------------------

        // 2 task
        // from one array get 2 arrays
        // 1: min -> max
        // 2: max -> min
        //----------------------------------------------------
        public static void GetArrayMinMax()
        {
            int[] array = {1,3,2,4,6,8,5,7};     
            ArraySort(array, out int[] arr1, out int[] arr2);
            foreach (var x in arr1)
                Console.Write(x + " ");    
            foreach (var x in arr2)
                Console.Write(x + " ");
        }

        public static void ArraySort(int[] array, out int[] arr1, out int[] arr2)
        {
            arr1 = new int[array.Length];
            arr2 = new int[array.Length];
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++) {
                arr1[i] = array[i];
                arr2[arr2.Length - 1 - i] = array[i];
            }
            
        }
        //----------------------------------------------------

        // 3 task
        // delta encrypt
        // array[array.Length]: array[0] == array[0]
        // deltaCode == array[i] - array[i-1], 0 < i < array.Length
        //----------------------------------------------------
        static void GetDeltaCodding()
        {
            int[] array = {-5,14,2,74,10,0,61};       
            Delta (array);
        }
        static void Delta (int[] arr)
        {
            Console.Write(arr[0] + " ");
            for (int i = 1; i < arr.Length; i++) {
                Console.Write((arr[i] - arr[i-1]) + " ");
            }
        }
        //----------------------------------------------------

        // 4 task
        // delta decrypt
        //----------------------------------------------------
        static void GetDeltaDecodding()
        {
            int[] deltaArray = {8,25,-48,15,19,-36};
            DeltaDecoding (deltaArray);
        }
        static void DeltaDecoding(int[] arr) 
        {
            int x = arr[0];
            for (int i = 0; i < arr.Length-1; i++) {
                Console.Write(x + " ");
                x += arr[i + 1];
            }
            Console.Write(x+ " ");
        }
        //----------------------------------------------------
        //----------------------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            ArrayToEven();
            GetArrayMinMax();
            GetDeltaCodding();
            GetDeltaDecodding();

        }
    }
}