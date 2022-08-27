using System;
using System.Linq;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            List<Student> list = new List<Student>{ new Student("Иванов", 1),
                                    new Student("Петров", 8), new Student("Сидоров", 6),new Student("Ткачев", 3),
                                    new Student("Смирнов", 9), new Student("Цукерман", 2)};
            var students =  from n in list
                            orderby n.Name descending
                            select n;
            foreach (var x in students)
            {
                Console.WriteLine("{0} {1}", x.Name, x.ID);
            }
            Console.WriteLine();
            PrintStudentsID(list);
        }
        //Задание. Измените запрос так, чтобы на экран выводились, данные о студентах, отсортированные по возрастанию поля ID.
        static void PrintStudentsID(List<Student>students)
        {
            var sortStudents = from n in students
                                orderby n.ID 
                                select n;
            Console.WriteLine("{0,-4}| {1,-10}", "ID", "Name");
            Console.WriteLine("____|__________");
            foreach (var x in sortStudents)
            {
                Console.WriteLine("{0,-4}| {1,-10}", x.ID, x.Name);
            }
        }
    }
    class Student
    {
        public string Name;
        public int ID;
        public Student(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}