using System;

namespace arithmetic
{
    public class Program{

        public static void Main() {

            // 1 task
            int a = 45, b = 78;
            int result = a * b;
            Console.WriteLine(result);

            // 2 task
            Console.WriteLine("enter 2 numbers");
            //------------------------------------------
            string? inNum = Console.ReadLine();
            double fNum = Convert.ToDouble(inNum);
            inNum = Console.ReadLine();
            double sNum = Convert.ToDouble(inNum);
            Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
            Console.WriteLine("1 число: " + fNum);
            Console.WriteLine("2 число: " + sNum);
            Console.WriteLine(fNum / sNum);

            /* SOME ARITHMETIC EXAMPLES */

            int resOfAr = 2 + 2 * 2;
            Console.WriteLine(resOfAr);
            int anotResOfAr = (2 + 2) * 2;
            Console.WriteLine(anotResOfAr);
            int modResult = 7 % 5 % 3;
            Console.WriteLine(modResult);

            // 3 task
            string? inOfFourNum = Console.ReadLine();
            int num45 = Convert.ToInt32(inOfFourNum);
            inOfFourNum = Console.ReadLine();
            int num56 = Convert.ToInt32(inOfFourNum);
            inOfFourNum = Console.ReadLine();
            int num13 = Convert.ToInt32(inOfFourNum);
            inOfFourNum = Console.ReadLine();
            int num34 = Convert.ToInt32(inOfFourNum);
            Console.WriteLine((num56 + num34) / num45 + num13);

            /* INCREMENT AND DECREMENT*/

            int aPostInc = 0;
            Console.WriteLine(aPostInc++); // first output then increment
            int aPreInc = 0;
            Console.WriteLine(++aPreInc);  // first increment then output

            /* EXAMPLES WITH PRE AND POST INCREMENT*/

            int aPreExample = 1;
            aPreExample = ++aPreExample * aPreExample;
            // aPreExample == 1 
            // then aPreExmple = 2
            // then aPreExample = (2 * 2) == 4
            Console.WriteLine(aPreExample);
            int aPostExample = 1;
            aPostExample = aPostExample++ * aPostExample;
            // aPostExample == 1
            // then goes *
            // then aPostExample = 2
            // then aPostExample = (1 * 2) == 2
            Console.WriteLine(aPostExample);

            // 4 task
            string? inpNumToInc = Console.ReadLine();
            int numToInc = Convert.ToInt32(inpNumToInc);
            Console.WriteLine("Введите любое число от 1 до 10:");
            Console.WriteLine("Измененное число:" + ++numToInc);

            // 5 task
            string? inpNumOfTwo = Console.ReadLine();
            int numOf0 = Convert.ToInt32(inpNumOfTwo);
            inpNumOfTwo = Console.ReadLine();
            int numOf4 = Convert.ToInt32(inpNumOfTwo);
            Console.WriteLine(--numOf0 - --numOf4);

            /* EXAMPLES OF COMPARE */

            int aOfCompare = 5;
            int bOfCompare = 5;
            bool resOfCompare = aOfCompare == bOfCompare;
            Console.WriteLine(resOfCompare);

            // 6 task
            string? inptOfCompare = Console.ReadLine();
            int first_of_LessOrEqual = Convert.ToInt32(inptOfCompare);
            inptOfCompare = Console.ReadLine();
            int second_of_LessOrEqual = Convert.ToInt32(inptOfCompare);
            bool res_of_LessOrEqual = first_of_LessOrEqual <= second_of_LessOrEqual;
            Console.WriteLine("Введите число 1:");
            Console.WriteLine("Введите число 2:");
            Console.WriteLine("{0} меньше или равно {1} - {2}", first_of_LessOrEqual, second_of_LessOrEqual, res_of_LessOrEqual);

            /* EXAMPLES OF RANDOM */

            Random rndToX = new Random();
            int xOfRand = rndToX.Next(3); // can be of [0, 1, 2]
            Console.WriteLine("Получено значение x = " + xOfRand);

            Random rndToXWithMin = new Random();
            int xWithMin = rndToXWithMin.Next(1, 5); // can be [1, 2, 3, 4, 5]
            Console.WriteLine("Получено значение x = " + xWithMin);

            // 7 task
            //бред, не работает
            Random randOfTwo = new Random();
            double aOfRand = randOfTwo.Next(31);
            double bOfRand = randOfTwo.Next(31);
            double xOfab = aOfRand + bOfRand;
            Console.WriteLine("Сумма = " + xOfab);

            // (aOfDR && bOfDR > 0) && (aOfDR && bOfDR < 30) 
            double aOfDR = randOfTwo.NextDouble() * 29 + 1;
            double bOfDR = randOfTwo.NextDouble() * 29 + 1;
            double xOfabDR = aOfDR + bOfDR;
            Console.WriteLine(xOfabDR);


        }

    }

}