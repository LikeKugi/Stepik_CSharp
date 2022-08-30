using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var inptline = Console.ReadLine().Split(' ').ToArray();;
            var man = new Vasya(inptline[0], Convert.ToInt32(inptline[1]));
            var a = new Vasya("Василий",123);
            var b = new Vasya("Василий",12);
            var c = new Vasya("Василий",-60);
            var d = new Vasya("Misha",51);
            var e = new Vasya("Misha",72);
            //
            //Surprise.RunMe();
            //
        }
    }

    class Vasya
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return this._name; }
            init { this._name = (value == "Василий") ? "Василий" : string.Concat("Я не ", value, ", а Василий!"); }
        }
        public int Age
        {
            get { 
                return this._age; 
                }
            init { this._age = (value < 0) ? 0 : (value > 122) ? 122 : value; }
        }
        public Vasya(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Print();
        }
        private void Print()
        {
            Console.WriteLine(this.Name);
            var years = "";
            var yearsNumber = this._age;
            var yearsL = (yearsNumber % 10 >= 5 || yearsNumber % 10 == 0);
            var yearsLTeen = (yearsNumber % 100 > 9 && yearsNumber % 100 < 20);
            var yearsGOne = (yearsNumber % 10 == 1);
            var yearsGSeveral = (yearsNumber % 10 > 1 && yearsNumber % 10 < 5);
            if (yearsL || yearsLTeen)
                years = "лет";
            else
                    if (yearsGOne)
                years = "год";
            else
                            if (yearsGSeveral)
                years = "года";
            Console.WriteLine("Мне {0} {1}", this.Age, years);
        }
    }
}