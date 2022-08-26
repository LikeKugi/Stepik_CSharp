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
            //ExamplesBuilder();
            CombineStrWithBuilder();
        }
        static void CombineStrWithBuilder()
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < a.Length;) //удаляем из строк все знаки пунктуации
            {
                if (char.IsPunctuation(a[i]))
                {
                    a.Remove(i, 1);
                }
                else ++i; // потому что пустое поле в цикле на изменение переменной!!!
            }
            //преобразуем объект StringBuilder к типу string, и разбиваем его на массив слов
            string[] s = a.ToString().Split(' ');
            Console.WriteLine("Искомые слова: ");
            //перебираем все слова в массиве слов и выводим на экран те, которые начинаются и
            //заканчиваются на одну и туже букву
            foreach (string str in s)
            {
                if (str[0] == str[str.Length - 1])
                {
                    Console.WriteLine(str);
                }
            }
        }
            static void ExamplesBuilder()
            {
                StringBuilder str = new StringBuilder("Площадь");
                Console.WriteLine("Максимальный объем буфера: {0} \n ", str.MaxCapacity);
                Print(str);
                str.Append(" треугольника равна");
                Print(str);
                str.AppendFormat(" {0:f2} см ", 123.456);
                Print(str);
                str.Insert(8, "данного ");
                Print(str);
                str.Remove(7, 21);
                Print(str);
                str.Replace("а", "…");
                Print(str);
                str.Length = 0;
                Print(str);
            }
            static void Print(StringBuilder a)
            {
                Console.WriteLine("Строка: {0} ", a);
                Console.WriteLine("Текущая длина строки: {0} ", a.Length);
                Console.WriteLine("Объем буфера: {0} ", a.Capacity);
                Console.WriteLine();
            }
        }
    }