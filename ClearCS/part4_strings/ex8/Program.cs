using System;
using System.Text;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var line = GetLine();
            CheckRepeat(line);

        }

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

        static void CheckRepeat(string[]words)
        {   

            var flag = false;
            for (int i = 0; i < words.Length;i++)
            {
                var check = i;
                flag = false;
                for (int j = 0; j< words.Length;j++)
                {
                    
                    if (words[j]==words[check]&&j!=check)
                        {
                            Console.WriteLine("checking {0} with {1}",words[check], words[j]);
                            Console.WriteLine("j = {0} ; check = {1} ",j,check);
                            flag = true;
                        }
                }
                //Console.WriteLine(words[i]);
                if (!flag)
                    Console.WriteLine(words[check]);
            }
            
        }
    }
}