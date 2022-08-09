using System;

namespace MyProgram
{
    class Program
    {
        // just example
        //----------------------------------
        private static int Summ(int a, int b)
        {
            return a + b;
        }
        private static void Ex1() 
        {
            int testValue = 24;
            int s = Summ(testValue, 13);
            Console.WriteLine(Summ(s,s));
        }
        //-----------------------------------

        // 1 task
        // find english letters in text
        private static void FindEnLetters() 
        {
            string? courseWork = Console.ReadLine();
            if (courseWork == null) {
                courseWork = "ad wio1 2en lkfd sbw";
            }
            if (IsTextIncludesChar(courseWork))
            {
                Console.WriteLine("В тексте присутствуют латинские символы!");
            }
            else
            {
                Console.WriteLine("Латинские символы отсутствуют");
            }    
        }
        public static bool IsTextIncludesChar(string text) 
        {   
            // Одной строчкой Contains()
            // return text.Contains('e');

            char[] textOfChar = text.ToCharArray();
            foreach (char el in textOfChar) {
                if (el == 'e') {
                    return true;
                }
            }
            return false;
        }
        //-------------------------------------

        // 2 task
        // factorize of number
        private static void FactorizeRunner(){
            string? inpt_number = Console.ReadLine();
            if (inpt_number == null) {
                inpt_number = "1215";
            }
            int value = int.Parse(inpt_number);
            Factorize(value);
        }
        private static void Factorize (int value) {
            for (int i = 1; (i * i) <= value; i++) {
                if (value % i == 0) {
                    Console.WriteLine($"{value} = {i} * {value/i}");
                }
            }
        }


        //*************************************
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            //Ex1();
            //FindEnLetters();
            FactorizeRunner();

        }
    }
}