using System;
using System.Text;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var line = GetLine();
            var lookingLength = GetLength();
            
            PrintWordOfLength(lookingLength,line);

        }

        static int GetLength() => Convert.ToInt32(Console.ReadLine());

        static string[] GetLine()
        {
            var input = new StringBuilder(Console.ReadLine());
            for (int i = 0; i< input.Length;)
            {
                if (char.IsPunctuation(input[i]))
                    input.Remove(i,1);
                else
                    ++i;
            }
            var line = input.ToString().Split(' ');
            return line;
        }

        static void PrintWordOfLength(int length, string[] words)
        {
            foreach (string word in words)
                {
                    if (word.Length == length)
                        Console.WriteLine(word);
                }
        }
    }
}