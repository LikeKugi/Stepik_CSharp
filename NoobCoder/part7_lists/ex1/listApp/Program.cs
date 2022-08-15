using System;
using System.Collections.Generic;

using System;



internal class Program
{
    private static void Main(string[] args)
    {
        //GetCountCapacity();
        //GetArgInList();
        GetindexOfChar();

    }

    private static void GetindexOfChar()
    {
        string? inptStr = Console.ReadLine();

        List<char> chars = new List<char>(inptStr.Length);
        foreach (char c in inptStr)
        {
            chars.Add(c);
        }
        
        Console.WriteLine(chars.IndexOf('O'));

    }
    private static void GetArgInList()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        Console.WriteLine(numbers[1]);
    }

    private static void GetCountCapacity()
    {
        var list0 = new List<double>(1);
        Console.WriteLine("list0 cap  " + list0.Capacity + " count = " + list0.Count);
        Console.WriteLine("------------------------------");

        var list1 = new List<int>() { 1, 2, 3, 4, 5 };
        Console.WriteLine("list1 cap  " + list1.Capacity + " count = " + list1.Count);
        Console.WriteLine("------------------------------");

        var list2 = new List<char>() { 'q', 'r' };
        Console.WriteLine("list2 cap  " + list2.Capacity + " count = " + list2.Count);
        Console.WriteLine("------------------------------");

        var erray = new string[] { "Миша", "Витя", "Паша" };
        var list3 = new List<string>(erray);
        Console.WriteLine("list3 cap  " + list3.Capacity + " count = " + list3.Count);
        Console.WriteLine("------------------------------");

        var array = new string[] { "Миша", "Витя", "Паша" };
        var list4 = new List<string>(array);
        list4.Clear();
        Console.WriteLine("list4 cap  " + list4.Capacity + " count = " + list4.Count);
        Console.WriteLine("------------------------------");

        var list5 = new List<int>();
        Console.WriteLine("list5 cap  " + list5.Capacity + " count = " + list5.Count);
        Console.WriteLine("------------------------------");

        var list6 = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            list6.Add(i);
        }
        Console.WriteLine("list6 cap  " + list6.Capacity + " count = " + list6.Count);
        Console.WriteLine("------------------------------");

        var list7 = new List<int>(5) { 1, 2, 3 };
        list7.RemoveAt(0);
        Console.WriteLine("list7 cap  " + list7.Capacity + " count = " + list7.Count);
        Console.WriteLine("------------------------------");
    }

}