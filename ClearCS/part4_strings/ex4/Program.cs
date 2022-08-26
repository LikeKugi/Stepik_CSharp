using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var line = GetLine();
            PrintPalindromWords(CreateArray(line));

        }

        static string GetLine()
        {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = "Джим собрался на коток";
            return line;
        }

        static string[] CreateArray(string line)
        {
            char[] div = { ' ', ',', '.' };
            string[] words = line.Split(div, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        static void PrintPalindromWords(string[] words)
        {
            foreach (string word in words)
                if (CheckPalindrom(word))
                    Console.WriteLine(word);
        }

        static bool CheckPalindrom(string word)
        {
            for (int i = 0; i <= word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            return true;
        }
    }
}