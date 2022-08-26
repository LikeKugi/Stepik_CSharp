using System;
using System.Text.RegularExpressions;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var inptStr = Console.ReadLine();
            if (string.IsNullOrEmpty(inptStr))
                inptStr = " ";

            CountLetters(inptStr, out int vowels, out int consonants);

            Console.WriteLine("Гласных {0}\nСогласных {1}",vowels,consonants);
        }

        static void CountLetters(string line, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    switch (c)
                    {
                        case 'у':
                        case 'е':
                        case 'ы':
                        case 'а':
                        case 'о':
                        case 'э':
                        case 'я':
                        case 'и':
                        case 'ю':
                            vowels++;
                        break;
                        default:
                            consonants++;
                        break;
                    }
                }
            }
        }
    }
}