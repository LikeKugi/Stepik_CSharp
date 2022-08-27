using System;
using System.Linq;
using System.Collections.Generic;
namespace Example
{
    class Student
    {
        public string Name;
        public int ID;
        public Student(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }
    }
    class Program
    {
        static void Main()
        {
            // источник данных – список студентов
            List<Student> list = new List<Student> {new Student("Иванов", 1),
                                                    new Student("Петров", 8),
                                                    new Student("Сидоров", 6),
                                                    new Student("Ткачев", 3),
                                                    new Student("Смирнов", 9),
                                                    new Student("Цукерман", 2)};
            // создаем запрос по номеру студента
            var students =  from n in list
                            where n.ID <= 5
                            select n;
            // выполняем запрос
            foreach (var x in students)
            {
                Console.WriteLine("{0} {1}", x.Name, x.ID);
            }
        }
    }
}