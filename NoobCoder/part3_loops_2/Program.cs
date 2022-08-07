using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            
            string? inpt_nmbrs = Console.ReadLine();
            if (inpt_nmbrs == null) {
                inpt_nmbrs = "1";
            }
            int firstNumber = int.Parse(inpt_nmbrs);
            inpt_nmbrs = Console.ReadLine();
            if (inpt_nmbrs == null) {
                inpt_nmbrs = "1";
            }
            int secondNumber = int.Parse(inpt_nmbrs);

            // Ваш код 
            int counter = 0; // счетчик вхождений цифры в 1 число
            int number_checking1; // цифра, которую проверяем
            int number_checking_with; // цифра с которой проверяем
            int accum1; // оставшиеся цифры в 1 числе
            int accum2; // оставшиеся цифры во 2 числе
            bool flag = false; // флаг проверки входит цифра во 2 число или нет
            //---------------------------------------------------------
            accum1 = firstNumber;
            accum2 = secondNumber;
            number_checking1 = accum1 % 10;
            //-------поиск цифры из 1 числа во 2 числе----------------
            Console.WriteLine("=========start==========");
            while (accum1 > 1) {
                number_checking1 = accum1 % 10;

                Console.WriteLine($"first number = {accum1}");

                while (accum2 >= 1) {

                    Console.WriteLine($"wait to compare = {accum2}");

                    if (accum2 >= 10){
                        number_checking_with = accum2 % 10;
                    }
                    else {
                        number_checking_with = accum2;
                    }
                    
                    Console.WriteLine($"checking {number_checking1} ? {number_checking_with}");

                    if (number_checking1 == number_checking_with) {
                        flag = true;
                        accum2 = firstNumber;
                        Console.WriteLine(number_checking1);
                        Console.ReadKey();
                        break;
                    }
                    //--------------------
                    accum2 /= 10;
                    Console.ReadKey();
                }
                if (flag) {
                    break;
                }
                accum2 = secondNumber;
                //----------------------------
                accum1 /=10; // условие выхода
            }
            //-------------------------------------------------------
            while (accum2 > 1) {
                    
                Console.WriteLine($"wait to compare = {accum2}");

                if (accum2 >= 10){
                    number_checking_with = accum2 % 10;
                }
                else {
                    number_checking_with = accum2;
                }
                    
                Console.WriteLine($"checking {number_checking1} ? {number_checking_with}");

                if (number_checking1 == number_checking_with) {
                    counter++;
                    Console.WriteLine(number_checking1);
                    Console.ReadKey();
                }
                //--------------------
                accum2 /= 10;
                Console.ReadKey();
            }

            for (int i = 0; i < counter; i++){
                Console.Write($"{number_checking1} ");
            }
            

        }
    }
}