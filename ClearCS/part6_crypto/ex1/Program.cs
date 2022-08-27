using System;
using System.Text;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            string small = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", big = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; //Текст кодирования
            int x;
            Console.WriteLine("Введите строку для шифрования:");   
            string? a = Console.ReadLine();
            Console.WriteLine("Введите ключ кодирования");
            int key = Convert.ToInt32(Console.ReadLine()); //Вводим с клавиатуры ключ кодирования   
            StringBuilder b = new StringBuilder(100); //Создаем изменяемую строку 
            b.Append(a); //Вносим в нее строку a
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j <= 32; j++)
                {
                    x = (j + key) % 33;
                    if (b[i] == small[j])
                    {
                        b[i] = small[x];
                        goto link1;
                    }
                    if (b[i] == big[j])
                    {
                        b[i] = big[x];
                        goto link1;
                    }
                }
                link1:;
            }
            Console.WriteLine("Закодированная фраза:{0}",b);
        }
    }
}