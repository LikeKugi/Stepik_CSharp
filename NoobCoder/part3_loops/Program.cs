using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            // 1 task
            string? inpt_num = Console.ReadLine();
            if (inpt_num == null) {
                inpt_num = "1";
            }
            int num = int.Parse(inpt_num);

            int i1 = 0, sum_don = 0;

            while (sum_don < num) {
                Console.WriteLine(i1);
                sum_don += ++i1;
            }

            // 2 task 
            // ебаный говнокод (6j-1)||(6j+1) пиздец СЛОЖНА проверить!
            // StackOverflow onelove <3
            string? inpt_value = Console.ReadLine();
            if (inpt_value == null) {
                inpt_value = "1";
            }
            int startValue = int.Parse(inpt_value);
            inpt_value = Console.ReadLine();
            if (inpt_value == null) {
                inpt_value = "1";
            }
            int endValue = int.Parse(inpt_value);
            // Ваш код
            int sum = 0;
            bool flag;
            for (int i = startValue; i <= endValue; i++){
                flag = true;
                if (i > 1) {
                    for (int j = 2; j < i; j++) 
                    {
                        if (i % j == 0) {
                            flag = false;
                            break;
                        }
                        Console.WriteLine($"i = {i}; j = {j}; flag = {flag}; mod = {i % j}");

                    }
                    if ((flag == true) && (i > 0)) {
                        sum += i;
                    }
                }
            }
            Console.WriteLine($"Сумма простых чисел = {sum}");

        }
    }
}