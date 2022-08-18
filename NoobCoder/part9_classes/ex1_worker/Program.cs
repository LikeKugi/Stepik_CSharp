using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            
            var person = new Worker();

            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = "Иванов Иван 120 30";
            List<string> workerData = line.Split(' ').ToList();
            person.surname = workerData[0];
            person.name = workerData[1];
            person.rate = int.Parse(workerData[2]);
            person.days = int.Parse(workerData[3]);

            Console.WriteLine(person.GetSalary());
            person.GetFullName();

            
            
        }
    }
    class Worker
    {
        public string? name;
        public string? surname;
        public int rate;
        public int days;

        public void GetFullName()
        {
            Console.WriteLine($"Фамилия сотрудника: {surname}");
            Console.WriteLine($"Имя сотрудника: {name}");
        }
        public int GetSalary()
        {
            
            return rate * days;
        }

    }
}