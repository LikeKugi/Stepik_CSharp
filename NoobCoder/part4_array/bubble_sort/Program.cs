using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            // input and moving inpt_str to an integer array
            string? inpt_str = Console.ReadLine();
            if (inpt_str == null) {
                inpt_str = "1 8 5 61 5";
            }
            string[] inpt_arr = inpt_str.Split(" ");
            int[] arr_to_sort = new int[inpt_arr.Length];
            for (int i = 0; i < inpt_arr.Length; i++) {
                arr_to_sort[i] = int.Parse(inpt_arr[i]);
            }

            //TODO: while loop
            int len_sort = arr_to_sort.Length;
            int temp = 0;

            while (len_sort > 0) {
                //temp = arr_to_sort[0];
                for (int i = 1; i < len_sort; i++) {
                    if (arr_to_sort[i] < arr_to_sort[i-1]) {
                        temp = arr_to_sort[i];
                        arr_to_sort[i] = arr_to_sort [i-1];
                        arr_to_sort[i-1] = temp;
                    }
                }
                len_sort--;
            }

            // output
            foreach(int el in arr_to_sort) {
                Console.Write($"{el} ");
            }
        }
    }
}