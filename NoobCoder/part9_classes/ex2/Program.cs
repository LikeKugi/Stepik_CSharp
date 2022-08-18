using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static string GetLine()
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = "hello world!";
            return line;
        }
        static void Main(string[] args)
        {
            
            Console.Clear();

            string line = GetLine();
            var myS = new MyString();
            myS.line = line;

            Console.WriteLine(myS.Reverse());
            Console.WriteLine(myS.UcFirst());
            Console.WriteLine(myS.UcWords());


        }
    }

    class MyString
    {
        public string? line;

        public string Reverse() => new string(line.Reverse().ToArray());
        public string UcFirst() => (string.IsNullOrEmpty(line)) ? line : (line[0].ToString().ToUpper() + line.Substring(1));
        

        public string UcWords() 
        {
            if (string.IsNullOrWhiteSpace(line))
            {   
                //Console.WriteLine("empty");
                return line;
            }
            string returned = "";
            var words = line.Trim().Split(' ');
            foreach (string word in words)
            {
                returned += (word[0].ToString().ToUpper() + word.Substring(1)) + " ";
            }
            return returned;
        }

    }

}