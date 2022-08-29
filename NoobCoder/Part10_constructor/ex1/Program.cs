using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var myWatch = new Watch("Casio", "electronic", 15.99M);
            myWatch.Print();
        }
    }

    class Watch
    {
        public Watch(string name, string type, decimal price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public void Print()
        {
            Console.WriteLine("Часы {0}, тип: {1}, цена: {2}$", this.name, this.type, this.price);
        }
        private string name;
        private string type;
        private decimal price;
    }
}