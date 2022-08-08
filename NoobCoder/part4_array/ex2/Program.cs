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

        }
    }
}