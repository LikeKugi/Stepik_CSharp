using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            // task 1
            // count grades
            string? grades = Console.ReadLine();
            if (grades == null) {
                grades = "1,2,3,4,5";
            }
            string[] grade_str = grades.Split(",");
            int[] grade_num_arr = new int [grade_str.Length];
            for (int i = 0; i < grade_str.Length; i++) {
                grade_num_arr[i] = Convert.ToInt32(grade_str[i]);
            }

            int num_2 = 0, num_3 = 0, num_4 = 0, num_5 = 0;

            foreach (int grade in grade_num_arr) {
                switch (grade){
                    case 2:
                        num_2++;
                    break;
                    case 3:
                        num_3++;
                    break;
                    case 4:
                        num_4++;
                    break;
                    case 5:
                        num_5++;
                    break;
                }
            }
            if (num_2 != 0) {
                Console.WriteLine("Ну что, студент, пора долг Родине отдать");
            } else if (num_3 != 0) {
                Console.WriteLine("Прощай стипендия!");
            } else if (num_5 == grade_num_arr.Length) {
                Console.WriteLine("О, отличник появился! На олимпиаду пойдешь" );
            } else
            Console.WriteLine("Живи пока, через полгода увидимся");

            // 2 task
            // find min/max and reverse
            string? cardNumber = Console.ReadLine();
            if (cardNumber == null) {
                cardNumber = "13452546";
            }
            char[] cd_nmdr = cardNumber.ToCharArray();
            int[] card_array = new int[cd_nmdr.Length];

            for (int i = 0; i < cd_nmdr.Length; i++) {
                card_array[i] = (int)(cd_nmdr[i] - '0'); // char to int
                Console.Write($"{card_array[i]} <== {cd_nmdr[i]}; ");
            }
            Console.WriteLine();
            int max = card_array[0];
            int min = card_array[0];

            foreach (int el in card_array) {
                if (el > max) {
                    max = el;
                } else if (el < min) {
                    min = el;
                }
            }

            int[] outpt_card_number = new int[card_array.Length+2];
            for (int i = 0; i < card_array.Length; i ++) {
                outpt_card_number[i] = card_array[card_array.Length-1-i];
            }
            outpt_card_number[card_array.Length] = max;
            outpt_card_number[card_array.Length + 1] = min;

            foreach(int el in outpt_card_number) {
                Console.Write(el);
            }

        }
    }
}