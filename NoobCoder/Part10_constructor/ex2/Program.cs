using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var barrel = new Barrel();
            barrel.material = "oak";
            barrel.volume = 200;
            barrel.ToChange(100);
            barrel.ToChange("beech");
            Console.WriteLine($"{barrel.material}, {barrel.volume}");
        }
    }
    class Barrel
    {
        public void ToChange(int number)
        {
            this.volume = number;
        }
        public void ToChange(string str)
        {
            this.material = str;
        }
        public string? material;
        public int volume;
    }
}