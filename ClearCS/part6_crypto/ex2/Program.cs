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
            Console.WriteLine("enter line: ");
            var originalLine = Console.ReadLine();
            Console.WriteLine("enter key: ");
            var key = GetNumber();
            Console.WriteLine("__________________________");
            var decodedLine = DecodeLine(originalLine!,key);
            Console.WriteLine(decodedLine);

            var encodedLine = EncodeLine(originalLine!, key);
            Console.WriteLine(encodedLine);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static string DecodeLine(string lineToDecode, int key)
        {
            var line = new StringBuilder();
            line.Append(lineToDecode);
            var keyLine = new Code(key);

            for (int i = 0; i<line.Length;i++)
            {
                line[i] = keyLine.DecodeChar(line[i]);
            }
            return line.ToString();
        }
        static string EncodeLine(string lineToDecode, int key)
        {
            var line = new StringBuilder();
            line.Append(lineToDecode);
            var keyLine = new Code(key);

            for (int i = 0; i<line.Length;i++)
            {
                line[i] = keyLine.EncodeChar(line[i]);
            }
            return line.ToString();
        }
    }

    class Code
    {
        public Code(int key)
        {
            this.big = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            this.small = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            this.key = key;
        }
        public char DecodeChar(char c)
        {
            //-----------------------------------------
            var indexOut = 0;
            char outPut = c;
            //-----------------------------------------
            if (this.small.Contains(outPut))
            {
                indexOut = this.small.IndexOf(c) - this.key;
                if (indexOut<0)
                        indexOut = this.small.Length + indexOut;
                if (indexOut > this.small.Length)
                    indexOut = indexOut - this.small.Length;
                outPut = this.small[indexOut];
            }
            if (this.big.Contains(outPut))
            {
                indexOut = this.big.IndexOf(c) - this.key;
                if (indexOut<0)
                    indexOut = this.big.Length + indexOut;
                if (indexOut > this.big.Length)
                    indexOut = this.big.Length  - indexOut;
                outPut = this.big[indexOut];
            }
            return outPut;
        }
        public char EncodeChar(char c)
        {
            //-----------------------------------------------
            var indexOut = 0;
            char outPut = ' ';
            //-----------------------------------------------
            if (this.small.Contains(c))
            {
                indexOut = this.small.IndexOf(c) + this.key;
                if (indexOut<0)
                        indexOut = this.small.Length + indexOut;
                if (indexOut > this.small.Length)
                    indexOut = indexOut - this.small.Length;
                outPut = this.small[indexOut];
            }
            if (this.big.Contains(c))
            {
                indexOut = this.big.IndexOf(c) + this.key;
                if (indexOut<0)
                        indexOut = this.big.Length + indexOut;
                if (indexOut > this.big.Length)
                    indexOut = indexOut - this.big.Length;
                outPut = this.big[indexOut];
            }
            return outPut;
        }
        private string small;
        private string big;
        private int key;

    }
}