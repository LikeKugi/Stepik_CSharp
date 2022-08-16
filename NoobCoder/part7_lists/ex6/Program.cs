using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {   
        static string GetText()
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = "Упади сем1ь 1раз 1и1 восемь раз по1днимись11";
            //System.Console.WriteLine(line);
            return line;
        }
        static List<string> GetArrayFromLine(string line)
        {
            List<string> words = new List<string>();
            words = line.Split(' ').ToList();
            return words;
        }
        static List<string> ClearList(List<string> words)
        {
            var valuesRemoving = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Contains('1'))
                {
                    valuesRemoving.Add(words[i]);
                    Console.WriteLine(words[i]);
                }
            }
            foreach (string value in valuesRemoving)
                words.Remove(value);
            return words;
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            List<string> words = ClearList(GetArrayFromLine(GetText()));
            foreach(string word in words)
                Console.Write(word + " ");
        }
    }
}