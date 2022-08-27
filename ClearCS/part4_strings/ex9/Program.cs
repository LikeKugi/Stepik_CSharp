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
            GetLine();
        }

        static void GetLine()
        {
            var input = new StringBuilder(Console.ReadLine());
            for (int i = 0; i< input.Length;)
            {
                var puncState = char.IsPunctuation(input[i]);
                var digitState = char.IsDigit(input[i]);
                var spaceState = char.IsWhiteSpace(input[i]);
                var startState = i==0;
                var endState = i==input.Length-1;
                var previousState = i>0&&char.IsWhiteSpace(input[i-1]);
                if (puncState||digitState||spaceState&&(startState||endState||previousState))
                    input.Remove(i,1);
                else
                    ++i;
            }
            
            Console.WriteLine(input);
        }
    }
}