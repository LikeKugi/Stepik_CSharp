using System;
using System.Collections.Generic;
using System.Linq;  // donno how to use it ^_^

public class MainClass
{   
    // output number = a * b + c
    // where a, b, c contains only [2, 3, 7]
    private static int GetInputNumber() 
    {
        string? inptNm = Console.ReadLine();
        if (inptNm == null) {
            inptNm = "12";
        }
        int number = int.Parse(inptNm);
        return number;
    }

    public static void VasyaStyle(int number){
        int a, b, c;
        List<int> ArrA = new List<int>();
        for (a = 2; a < Math.Sqrt(number); a++) {
            if (ValidCheck(a)){
                ArrA.Add(a);
                for (b = 2; b <= (number / a); b++) {
                    if (ValidCheck(b)) {
                        c = number - (a * b);
                        if (ValidCheck(c) && ValCheckB(b, ArrA)) {
                            Console.WriteLine($"{number} = {a} * {b} + {c}");
                        }
                    }
                }
            }
        }
        
    }

    private static bool ValidCheck(int value)
    {
        List<int> valArr = new List<int>();
        while (value > 9) {
            valArr.Add(value % 10);
            value /= 10;
        }
        valArr.Add(value);
        for (int i = 0; i < valArr.Count; i++){
            switch (valArr[i]){
                case 1:
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                case 0:
                    return false;
                case 2:
                case 3:
                case 7:
                    continue;
            }
        }
        return true;
    }

    private static bool ValCheckB (int number, List<int> arrOfA) {
        foreach (int el in arrOfA) {
            if (el == number) {
                return false;
            }
        }
        
        return true;
    }

    public static void Main()
    {   
        Console.Clear();
        int number = GetInputNumber();
        VasyaStyle(number);        
    }
}