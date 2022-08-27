using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var studentsHeight = GetHeight();
            Console.WriteLine(SelectStudents(studentsHeight));

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static List<int> GetHeight()
        {
            var studentsHeight = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                studentsHeight.Add(GetNumber());
            }
            return studentsHeight;
        }

        static string SelectStudents (List<int> students)
        {
            return string.Join(" ", students.Where(n=>n>176).Select(n=>n));
        }
    }
}