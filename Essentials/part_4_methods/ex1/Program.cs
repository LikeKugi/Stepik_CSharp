using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            // Применим наш метод, чтобы вывести строки красного и желтого цвета.
            // Аналогично проверь, что метод работает для других цветов и текста
            Task.PrintColoredText("This text should be red", ConsoleColor.Red);
            Task.PrintColoredText("This text should be yellow", ConsoleColor.Yellow);

        }
    }
    class Task {
        public static void PrintColoredText(string text, ConsoleColor color) {
            // пиши код здесь
            ConsoleColor currentForeground = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = currentForeground;
        }
        
    }
}