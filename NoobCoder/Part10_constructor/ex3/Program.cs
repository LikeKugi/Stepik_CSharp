using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var seq1 = new Sequence(5);
            var seq2 = new Sequence(5,10);
            var seq3 = new Sequence('t');
            var seq4 = new Sequence('f','p');

        }
    }
    class Sequence
    {
        public Sequence(int n)
        {
            Console.WriteLine(string.Join(" ", System.Linq.Enumerable.Range(0,n+1).Select(x=>x)));
        }
        public Sequence(int start, int end)
        {
            Console.WriteLine(string.Join(" ", System.Linq.Enumerable.Range(start,end-start+1).Select(x=>x)));
        }
        public Sequence(char c)
        {
            Console.WriteLine(string.Join(" ", System.Linq.Enumerable.Range('a', c-'a'+1).Select(x=>(char)x)));
        }
        public Sequence(char st, char end)
        {
            Console.WriteLine(string.Join(" ", System.Linq.Enumerable.Range(st, end-st+1).Select(x=>(char)x)));
        }
    }
}