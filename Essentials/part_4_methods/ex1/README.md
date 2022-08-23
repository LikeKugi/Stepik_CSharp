Дан код. Тебе нужно написать код метода **PrintColoredText**, который должен выводить в консоль переданный ему текст указанным цветом

О том, как установить цвет текста, можешь прочитать в документации
```
using System;

class Program {
    static void Main() {
        // Применим наш метод, чтобы вывести строки красного и желтого цвета.
        // Аналогично проверь, что метод работает для других цветов и текста
        Task.PrintColoredText("This text should be red", ConsoleColor.Red);
        Task.PrintColoredText("This text should be yellow", ConsoleColor.Yellow);
    }
}
```
PS: Частая ошибка связана с неправильным использованием метода Console.WriteLine(). В документации можно изучить, какие параметры он может принимать