using System;
using System.Collections.Generic;

public class MainClass
{   
    // write an array of numbers divided by 7 
    // arr[index]: index += 2
    public static int GetNumbers(){
        int number;
        string? inpt_num = Console.ReadLine();
        if (inpt_num == null) {
            inpt_num = "0";
        }
        number = int.Parse(inpt_num);
        return number;
    }

    public static List<int> GetMultiple(int start, int end) {
        List<int> arrFull = new List<int>();
        int firstValue;
        firstValue = (start % 7 == 0) ? start : start + Math.Abs(start % 7);
        
        int value = firstValue;
        while (value < end) {
            if (value != 0)
                arrFull.Add(value);
            value += 7;
        }
        return arrFull; 
    }

    public static void PrintEven (List<int> arrOutpt) {
        for (int i = 1; i < arrOutpt.Count; i += 2){
            Console.Write(arrOutpt[i] + " ");
        }

    }
    public static void Main()
    {   

        int startValue = GetNumbers();
        int endValue = GetNumbers();
        PrintEven(GetMultiple(startValue, endValue));   
    }
}