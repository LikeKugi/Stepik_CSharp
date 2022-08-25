using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            int startValue = GetNumber();
            int endValue = GetNumber();

            PrintRange(startValue,endValue);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void PrintRange(int start, int end)
        {
            do
            {
                
                if (start % 2 != 0 && start % 5 == 0)
                    Console.Write(start + " ");

                start++;
            }
            while(start <= end);
            
            
        }
    }
}