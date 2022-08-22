using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            // 1 calc of 3
            Console.WriteLine("Нажмите 1 если хотите выполнить сложение");
            Console.WriteLine("Нажмите 2 если хотите выполнить вычитание");
            Console.WriteLine("Нажмите 3 если хотите выполнить умножение");
            Console.WriteLine("Нажмите 4 если хотите выполнить деление");
            Console.WriteLine("Нажмите 5 если хотите найти остаток от деления");
            string? inpt = Console.ReadLine();
            byte operation = Convert.ToByte(inpt);
            if ((operation > 0) && (operation < 6))
            {
                Console.WriteLine("Введите число 1:");
                inpt = Console.ReadLine();
                int FirstNumber = Convert.ToInt32(inpt);
                Console.WriteLine("Введите число 2:");
                inpt = Console.ReadLine();
                int SecondNumber = Convert.ToInt32(inpt);

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Сумма чисел = " + (FirstNumber + SecondNumber));
                    break;
                    case 2:
                        Console.WriteLine("Разность чисел = " + (FirstNumber - SecondNumber));
                    break;
                    case 3:
                        Console.WriteLine("Произведение чисел = " + (FirstNumber * SecondNumber));
                    break;
                    case 4:
                        Console.WriteLine("Частное чисел = " + (FirstNumber / SecondNumber));
                    break;
                    case 5:
                        Console.WriteLine("Остаток от деления = " + (FirstNumber % SecondNumber));
                    break;
                }
            }   else 
                {
                    Console.WriteLine("Значение некорректно");
                } 

            // 2 and 3 calc of 3
            // diff: 2nd without do-while loop
            string? answer;
            do 
            {
                Console.WriteLine("Введите число 1:");
                string? inptCalc = Console.ReadLine();
                int FiNm = Convert.ToInt32(inptCalc);
                Console.WriteLine("Введите число 2:");
                inptCalc = Console.ReadLine();
                int SeNm = Convert.ToInt32(inptCalc);
                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                inptCalc = Console.ReadLine();

                switch (inptCalc)
                {
                    case "+":
                        Console.WriteLine("Сумма чисел = " + (FiNm + SeNm));
                    break;
                    case "-":
                        Console.WriteLine("Разность чисел = " + (FiNm - SeNm));
                    break;
                    case "*":
                        Console.WriteLine("Произведение чисел = " + (FiNm * SeNm));
                    break;
                    case "/":
                        Console.WriteLine("Частное чисел = " + (FiNm / SeNm));
                    break;
                    default:
                        Console.WriteLine("Попробуйте еще раз..");
                    break;
                }
                Console.WriteLine("Хотите продолжить выполнение программы?");
                Console.WriteLine("ДА - 1. НЕТ - 2.");
                answer = Console.ReadLine();
            } while (answer == "1");
        }
    }
}