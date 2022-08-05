using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            
            /*
            *   byte -> short -> int -> long -> decimal
            *   int -> double
            *   short -> float -> double
            *   char -> int 
            */

            // some data

            double a = 4.52;
            int b = (int)a; // явное преобразование
            double c = b;
            Console.WriteLine(c);

            short x = 150;
            byte y = (byte) (x + x);
            Console.WriteLine(y);

            string text = "input";

            string newLine = "Вы ввели: " +  text; //конкатенация строк

            Console.WriteLine(newLine);

            Console.Clear();

            // numbers

            Console.WriteLine("Введите два целых числа через пробел"); 
            string? line = " ";
            line = Console.ReadLine();
            if (line == null)
            {
                line = " ";
            }
            string[] splitString = line.Split(' ');

            int x1 = Convert.ToInt32(splitString[0]);
            int x2 = Convert.ToInt32(splitString[1]);

            int sum = x1 + x2; // Запишите тут Ваш код для вычисления суммы значений x1 и x2
            int difference = x1 - x2; // Запишите тут Ваш код для вычисления разности значений x1 и x2
            int multiply = x1 * x2; // Запишите тут Ваш код для вычисления произведения значений x1 и x2
            Console.WriteLine($"{sum} {difference} {multiply}");

            // num task with area
            Console.WriteLine("Введите два числа через пробел: длина и ширина стола");
            line = Console.ReadLine();
            if (line == null)
            {
                line = " ";
            }
            splitString = line.Split(' ');

            double length = Convert.ToDouble(splitString[0]); // длина
            double width = Convert.ToDouble(splitString[1]); // ширина

            //Тут будет Ваш код

            length -= 0.2;
            width -= 0.2;

            Console.WriteLine($"Площадь стола: {length * width}"); 

            // 10 --> 16
            line = Console.ReadLine(); // ввод числа в десятеричной системе 
            if (line == null)
            {
                line = " ";
            }
            int xInp = int.Parse(line);

            string answer;

            //Запишите тут Ваш код
            answer = xInp.ToString("x"); //метод строки перевод в 16
            // если нужно, чтобы буквы были заглавными, то
            // ToString("X")

            Console.WriteLine(answer);

            int sys = 16, mod, div;
            answer = "";

            do
            {
                div = xInp / sys;
                mod = xInp % sys;
                switch (mod)
                {
                    case 1:
                        answer += "1";
                    break;
                    case 2:
                        answer += "2";
                    break;
                    case 3:
                        answer += "3";
                    break;
                    case 4:
                        answer += "4";
                    break;
                    case 5:
                        answer += "5";
                    break;
                    case 6:
                        answer += "6";
                    break;
                    case 7:
                        answer += "7";
                    break;
                    case 8:
                        answer += "8";
                    break;
                    case 9:
                        answer += "9";
                    break;
                    case 10:
                        answer += "a";
                    break;
                    case 11:
                        answer += "b";
                    break;
                    case 12:
                        answer += "c";
                    break;
                    case 13:
                        answer += "d";
                    break;
                    case 14:
                        answer += "e";
                    break;
                    case 15:
                        answer += "f";
                    break;
                }
                xInp = div;
                if (sys > div) 
                {
                    switch (div)
                {
                    case 1:
                        answer += "1";
                    break;
                    case 2:
                        answer += "2";
                    break;
                    case 3:
                        answer += "3";
                    break;
                    case 4:
                        answer += "4";
                    break;
                    case 5:
                        answer += "5";
                    break;
                    case 6:
                        answer += "6";
                    break;
                    case 7:
                        answer += "7";
                    break;
                    case 8:
                        answer += "8";
                    break;
                    case 9:
                        answer += "9";
                    break;
                    case 10:
                        answer += "a";
                    break;
                    case 11:
                        answer += "b";
                    break;
                    case 12:
                        answer += "c";
                    break;
                    case 13:
                        answer += "d";
                    break;
                    case 14:
                        answer += "e";
                    break;
                    case 15:
                        answer += "f";
                    break;
                }
                }
            } while(xInp > sys);
            char[] chars = answer.ToCharArray();
            Array.Reverse(chars);
            answer = new String(chars);

            Console.WriteLine(answer);
        }
    }
}