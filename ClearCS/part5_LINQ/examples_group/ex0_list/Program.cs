using System;
using System.Linq;
using System.Collections.Generic;
namespace Example
{
    class Demo
    {
        class Student
        {
            public string? Name { get; set; }
            public int GroupID { get; set; }
        }
        static void Main()
        {
            //создали источник данных
            List<Student> students = new List<Student>()
                                        {
                                        new Student{Name="Иванов", GroupID=001},
                                        new Student{Name="Петров", GroupID=002},
                                        new Student{Name="Сидоров", GroupID=002},
                                        new Student{Name="Смирнов", GroupID=002},
                                        new Student{Name="Ткачев", GroupID=003},
                                        new Student{Name="Цукерман", GroupID=003},
                                        new Student{Name="Токарев", GroupID=001},
                                        new Student{Name="Оганесян", GroupID=002},
                                        };
            //создали запрос
            var query =
            from student in students
            group student by student.GroupID;
            //выполнили запрос
            foreach (var items in query)
            {
                Console.Write("Группа {0}: ", items.Key);
                foreach (var item in items)
                {
                    Console.Write("{0} ", item.Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}