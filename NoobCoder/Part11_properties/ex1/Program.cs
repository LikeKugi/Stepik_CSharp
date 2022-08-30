using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var tree1 = new Tree("сосна", -6);
            var tree2 = new Tree("береза", 80);

        }
    }

    class Tree
    {
        private string? _name;
        private int _height;
        public string Name
        {
            get { return this._name!; }
            set { this._name = value; }
        }
        public int Height
        {
            get { return this._height; }
            set { this._height = value > 0 ? value : 0; }
        }
        public Tree(string name, int height)
        {
            this.Name = name;
            this.Height = height;
            Console.WriteLine("Вы создали дерево \"{0}\" высотой {1} см",this.Name,this.Height);
        }
    }
}