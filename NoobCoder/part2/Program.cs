using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            // IF-ELSE exercises

            int result = 10;
            if(result <= 8)
            {
                result += 5;
            } 
            else
            {
                result -= 3;
            }
            Console.WriteLine(result);

            // 1 task
            string? input_num = Console.ReadLine();
            if (input_num == null)
            {
                input_num = "1";
            }
            int num = Int32.Parse(input_num); // Запрашиваем ввод из консоли и вытягиваем из него число
            
            //-----------------------------------------
            if (num % 2 == 0) // Напишите свой код вместо "..." слева
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }

            // 2 task
            int a1 = 0, b1 = 0;
            string? line1 = Console.ReadLine();
            if (line1 == null)
            {
                line1 = "1 1 1";
            }
            string[] splitString = line1.Split(' ');
            a1 = Convert.ToInt32(splitString[0]);
            b1 = Convert.ToInt32(splitString[1]);
            //--------------------------------------
            if (a1 == b1)
            {
                Console.WriteLine($"{a1} = {b1}");
            } 
            else if (a1 > b1)
            {
                Console.WriteLine($"{a1} > {b1}");
            } else 
                Console.WriteLine($"{a1} < {b1}");

            // 3 task
            int a2 = 0, b2 = 0, c2 = 0; //костыли, зато VSCode не ругается ^_^
            string? line2 = Console.ReadLine();
            // тоже костыли с пустой строкой
            if (line2 == null)   
            {
                line2 = "1 1 1";
            }
            string[] splitString2 = line2.Split(' ');
            a2 = Convert.ToInt32(splitString2[0]);
            b2 = Convert.ToInt32(splitString2[1]);
            c2 = Convert.ToInt32(splitString2[2]);
            //--------------------------------------
            int minValue2 = 0;
            //Тут будет Ваш код
            minValue2 = a2;
            if (minValue2 > b2)
            {
                minValue2 = b2;
            } 
            if (minValue2 > c2)
            {
                minValue2 = c2;
            }
            Console.WriteLine(minValue2);
            
            // 4 task
            string? line3 = Console.ReadLine();
            if (line3 == null)
                {
                    line3 = "1 1 1 1";
                }
            string[] splitString3 = line3.Split(' ');
            int a3 = Convert.ToInt32(splitString3[0]);
            int b3 = Convert.ToInt32(splitString3[1]);
            int c3 = Convert.ToInt32(splitString3[2]);
            int d3 = Convert.ToInt32(splitString3[3]);
            int minValue3 = 0;
            int maxValue3 = 0;
            //Тут будет Ваш код
            minValue3 = a3;
            maxValue3 = a3;            
            if (minValue3 > b3)
            {
                minValue3 = b3;
            } 
            if (minValue3 > c3)
            {
                minValue3 = c3;
            }
            if (minValue3 > d3)
            {
                minValue3 = d3;
            }
            //---------------
            if (maxValue3 < b3)
            {
                maxValue3 = b3;
            } 
            if (maxValue3 < c3)
            {
                maxValue3 = c3;
            }
            if (maxValue3 < d3)
            {
                maxValue3 = d3;
            }
            Console.WriteLine($"Наименьшее число - {minValue3}");
            Console.WriteLine($"Наибольшее число - {maxValue3}");

            // 5 task
            double bankDeposit = Convert.ToDouble(Console.ReadLine());
            double sum = 0.0;
            //Тут будет Ваш код
            if (bankDeposit > 200)
            {
                sum = bankDeposit * 1.1;
            }
            else if ((bankDeposit <= 200) && (bankDeposit >= 100))
            {
                sum = bankDeposit * 1.07;
            }
            else sum = bankDeposit * 1.05;

            Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");

        }
    }
}