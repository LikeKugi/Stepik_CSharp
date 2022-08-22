using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int CheckDividers(int number)
        {
            if (number % 2 == 0)
            {
                return 2;
            }    
            else if (number % 3 == 0)
                {
                    return 3;
                }
                else 
                {
                    for (int i = 1; (6 * i - 1) <= (int)Math.Sqrt(number); i++)
                    {
                        if (number % (6 * i - 1)  == 0)
                        {
                            return ((6 * i) - 1);
                        } else if (number % (6 * i + 1) == 0)
                            {
                                return (6 * i + 1);
                            }
                    }
                }
            return number;
        }
        static void Main(string[] args)
        {

            // Main starts here
            Console.Clear();

            Console.WriteLine(CheckDividers(GetNumber()));


        }
    }
}