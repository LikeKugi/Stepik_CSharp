using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            /* EXAMPLE OF WHILE LOOP*/

            int count_number = 0;

            while (count_number < 5)
                {
                    count_number ++;
                    Console.WriteLine(count_number);
                }

            // 1 task
            string? in_num = Console.ReadLine();
            byte num_of_count = Convert.ToByte(in_num), count = 0;

            while (count < num_of_count)
            {
                Console.WriteLine(++count);
            }

            /* DO WHILE LOOP EXAMPLE */

            do // from last task. just for example
            {

                --count;
                Console.WriteLine(count);

            } while (count > 0);

            /* FOR LOOP EXAMPLE */
            /* instead of while loop var "i" can only be modificated in for-loop */

            for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }

            // 2 task 
            string? inp_err = Console.ReadLine();
            byte num_of_err = Convert.ToByte(inp_err);
            for (int i = 0; i < num_of_err; i++)
            {
                Console.WriteLine("Ошибка!");
            }

            // 3 task
            string? inp_nm = Console.ReadLine();
            int for_cntr = Convert.ToInt32(inp_nm);
            inp_nm = Console.ReadLine();
            int nm_of_mult = Convert.ToInt32(inp_nm);
            
            Console.WriteLine("Введите число 1:");
            Console.WriteLine("Введите число 2:");
            for (int i = 0; i < for_cntr; i++)
            {   
                Console.WriteLine((nm_of_mult) + " * 2 = " + (nm_of_mult++ * 2));
                //nm_of_mult++;
            }

            /* EXAMPLE OF SEVERAL CONDITIONS IN FOR LOOP */

            for(int i = 0, j = 0; i < 5 && j < 10; i++, j++)
            {
                Console.WriteLine("Привет!");
            }

            string? if_exit;
            for (int i = -100; i < 100; i++)
            {
                Console.WriteLine("Для остановки введите 'exit':");
                if_exit = Console.ReadLine();
                if (if_exit == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            /* CONTINUE IN LOOP EXAMPLE */

            for (int i = 0; i < 5; i++)
            {
                if ( i == 2)
                {
                    continue;
                }    
            Console.WriteLine(i);
            }

        }
    }
}