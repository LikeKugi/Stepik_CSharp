using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {   
        // get line to encrypt
        static List<char> GetLine()
        {
            string? inptLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inptLine))
                inptLine = "купиновуюрулетку";
            var words = new List<char>();
            words = inptLine.ToCharArray().ToList();
            return words;
        }
        // array of chars - code of encryption
        static char[] GetCodeEncrypt()
        {
            char[] letters = Enumerable.Range('а', 'я' - 'а' + 1).Select(c => (char) c).ToArray();
            foreach(char letter in letters)
                Console.Write(letter + " ");
            return letters;
        }
        static void GetEncryption(List<char> line, char[] letters)
        {
            var indexOfChar = new List<int>();
            foreach (char letter in letters)
            {
                indexOfChar.Clear();
                for (int i = 0; i < line.Count; i++)
                {
                    if (letter == line[i])
                    {
                        indexOfChar.Add(i);
                    }
                }
                if (indexOfChar.Count > 0)
                {
                    Console.Write(letter + " ");
                    foreach (int CPos in indexOfChar)
                        Console.Write(CPos + " ");
                        {
                            
                        }
                }
            }
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            char[] code = GetCodeEncrypt();
            List<char> words = GetLine();
            GetEncryption(words,code);
        }
    }
}