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
            string? inpt_chr = Console.ReadLine();
            if (inpt_chr == null)
            {
                inpt_chr = "а";
            }
            char letter = Convert.ToChar(inpt_chr);

            //Тут мог быть ваш код, но его пока нет.

            switch (letter)
            {
                case 'а':
                    Console.WriteLine("гласная");
                break;
                case 'у':
                    Console.WriteLine("гласная");
                break;
                case 'е':
                    Console.WriteLine("гласная");
                break;
                case 'ё':
                    Console.WriteLine("гласная");
                break;
                case 'ы':
                    Console.WriteLine("гласная");
                break;
                case 'о':
                    Console.WriteLine("гласная");
                break;
                case 'э':
                    Console.WriteLine("гласная");
                break;
                case 'я':
                    Console.WriteLine("гласная");
                break;
                case 'и':
                    Console.WriteLine("гласная");
                break;
                case 'ю':
                    Console.WriteLine("гласная");
                break;
            }

            // 2 task
            string? inpt_day = Console.ReadLine();
            if (inpt_day == null)
            {
                inpt_day = "5";
            }
            int dayNumber = Convert.ToInt32(inpt_day);
            //----------------------------------------
            dayNumber = dayNumber % 7;

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                break;
                case 2:
                    Console.WriteLine("Вторник");
                break;
                case 3:
                    Console.WriteLine("Среда");
                break;
                case 4:
                    Console.WriteLine("Четверг");
                break;
                case 5:
                    Console.WriteLine("Пятница");
                break;
                case 6:
                    Console.WriteLine("Суббота");
                break;
                case 0:
                    Console.WriteLine("Воскресенье");
                break;
            }

            // 3 task
            string? inpt_opr = Console.ReadLine();
            if (inpt_opr == null)
            {
                inpt_opr = "5";
            }
            int operation3 = Convert.ToInt32(inpt_opr);
            //----------------------------------------
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            switch (operation3)
            {
                case 1:
                    Console.WriteLine("Сложение");
                break;
                case 2:
                    Console.WriteLine("Вычитание");
                break;
                case 3:
                    Console.WriteLine("Умножение");
                break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                break;
            }

            // 4 task
            string? line = Console.ReadLine();
            if (line == null)
            {
                line = "1 2 3";
            }
            string[] splitString = line.Split(' ');

            int operation = Convert.ToInt32(splitString[0]);
            double a = Convert.ToDouble(splitString[1]);
            double b = Convert.ToDouble(splitString[2]);
            double result = 0;
            //-----------------------------------------------
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            switch (operation)
            {
                case 1:
                    {
                    result = a + b;
                    Console.WriteLine($"Результат операции {result}");
                    }
                break;
                case 2:
                    {
                    result = a - b;
                    Console.WriteLine($"Результат операции {result}");
                    }
                break;
                case 3:
                    {
                    result = a * b;
                    Console.WriteLine($"Результат операции {result}");
                    }                
                break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                break;
            }

            /* OPERATOR '?' EXAMPLE */
            int x = 5;
            int y = 3;
            int z = x < y ? (x + y) : (x - y);
            /*
            *   if (x < y)
            *   {
            *    z = x + y
            *   }
            *   else z = x - y
            *
            *   IF (term) --> (smth);
            *   ELSE --> (smth)
            */

            // 5 task
            string? num_odd_even = Console.ReadLine();
            if (num_odd_even == null)
            {
                num_odd_even = "2";
            }
            int num = Int32.Parse(num_odd_even); // Запрашиваем ввод из консоли и вытягиваем из него число
            //Пишите тут.                
            string answer = (num % 2 != 0) ? "ODD" : "EVEN"; 
            Console.WriteLine(answer);

            // 6 task
            Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
            string? line6 = Console.ReadLine();
            if (line6 == null)
            {
                line6 = "12 13";
            }
            string[] splitString6 = line6.Split(' ');
            double length = Convert.ToDouble(splitString6[0]); // длина
            double width = Convert.ToDouble(splitString6[1]); // ширина
            double landArea = 0;                             // переменная для площади
            //Тут будет Ваш код

            int times_length = (int)Math.Ceiling(length / 5);
            int times_width = (int)Math.Ceiling(width / 5);
            //Console.WriteLine($"length = {length} times = {times_length}");
            //Console.WriteLine($"width = {width} times = {times_width}");
            length -= times_length * 0.2;
            width -= times_width * 0.2;

            landArea = Math.Round((length * width), 2);


            Console.WriteLine($"Площадь участка: {landArea}");
        }
    }
}