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
            // input string to vertical output
            //----------------------------------
            string? inpt_txt = Console.ReadLine();
            if(inpt_txt == null){
                inpt_txt = "hello";
            }
            char[] app_inpt = inpt_txt.ToCharArray(); //разбить по символам
            foreach(char el in app_inpt){
                Console.WriteLine(el);
            }

            // 2 task
            // compare 2 input numbers in each digit
            //------------------------------------------------
            string? num1_2 = Console.ReadLine();
            if (num1_2 == null){
                num1_2 = "123";
            }
            string? num2_2 = Console.ReadLine();
            if (num2_2 == null){
                num2_2 = "123";
            }

            // Ваш код 
            char[] num_1_arr = num1_2.ToCharArray();
            
            char[] num_2_arr = num2_2.ToCharArray();
            
            byte n = 0;
            for (byte i = 0; i < num_1_arr.Length; i++) {
                if (num_1_arr[i] == num_2_arr[i]) {
                    n++;
                }
            }
            Console.WriteLine($"Совпадение {n} элементов");

            // 3 task
            // find unique digits in 1st number of 2 input numbers
            //---------------------------------------------------
            string? num1 = Console.ReadLine();
            if (num1 == null) {
                num1 = "123";
            }
            string? num2 = Console.ReadLine();
            if (num2 == null) {
                num2 = "123";
            }
            // Ваш код 

            char[] num_1_arr3 = num1.ToCharArray();
            char[] num_2_arr3 = num2.ToCharArray();
            int res = 0;
            bool flag;

            for(int i = 0; i < num_1_arr3.Length; i++){
                //Console.WriteLine(i);
                flag = false;
                for(int j = 0; j < num_2_arr3.Length; j++){
                    //Console.WriteLine($"i = {i}; j = {j}");
                    if (num_1_arr3[i] == num_2_arr3[j]) {
                        break;
                    }
                    //Console.WriteLine($"nobreak: i = {i}; j = {j}");
                    if (j == (num_2_arr3.Length - 1)){
                        res = i;
                        flag = true;
                    } 
                }
                if (flag == true) {
                    for (int index = 0; index < num_1_arr3.Length; index++){
                        if (index == res) {
                            continue;
                        }
                        if (num_1_arr3[res] == num_1_arr3[index]) {
                        break;
                        }
                        if (index == (num_1_arr3.Length - 1))  {
                            Console.WriteLine($"Уникально число {num_1_arr3[res]}");
                        }
                    }
                }    
            }
        }
    }
}