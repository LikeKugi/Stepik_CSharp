using System;

namespace MyProgram
{
    class Program
    {
        static string GetLine()
        {
            string? inptLn = Console.ReadLine();
            if (string.IsNullOrEmpty(inptLn))
                inptLn = "1 2 3";
            return inptLn;
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            //используйте эти массивы строк для инициализации объектов мухи и паука
            var s1 = GetLine().Split(' ');
            var s2 = GetLine().Split(' ');

            var fly = new Insect();
            var spider = new Insect();

            fly.x = int.Parse(s1[0]);
            fly.y = int.Parse(s1[1]);
            fly.z = int.Parse(s1[2]);

            spider.x = int.Parse(s2[0]);
            spider.y = int.Parse(s2[1]);
            spider.z = int.Parse(s2[2]);

            PrintAnswer(fly, spider);

        }
        static void PrintAnswer(Insect fly, Insect spider)
        {
            if (fly.z != 0)
            {
                Console.WriteLine("Муха должна быть на полу!");
                return;
            }
            //Вывод ответа
            Console.WriteLine("Расстояние: " + GetRange(spider,fly));
            Console.WriteLine("Путь: " + GetPath(spider,fly));
        }
        static double GetRange(Insect a, Insect b)
        {
            return Math.Round(Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2) + Math.Pow((a.z - b.z), 2)), 5);
        }
        static double GetPath(Insect moving, Insect point)
        {
            double path = (double)(moving.z - point.z + Math.Round(Math.Sqrt(Math.Pow((moving.x - point.x), 2) + Math.Pow((moving.y - point.y), 2)), 5));
            return path;
        }
    }
    class Insect
    {
        public int x;
        public int y;
        public int z;
    }
}