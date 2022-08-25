class Program
{
    static void Main()
    {
        PrintChars();
        SomeChars();
    }

    static void SomeChars()
    {
        char[] a = { 'm', 'a', 'Х', 'i', 'M', 'u', 'S', '!', '!', '!' };
        Console.WriteLine("Исходный массив а:");
        Print(a);
        for (int x = 0; x < a.Length; x++)
        {
            if (char.IsLower(a[x]))
            {
                a[x] = char.ToUpper(a[x]);
            }
        }
        Console.WriteLine("Измененный массив а:");
        Print(a);
        Console.WriteLine();
        char[] b = "кол около колокола".ToCharArray(); //преобразование строки в массив символов
        Console.WriteLine("Исходный массив b:");
        Print(b);
        Array.Reverse(b);
        Console.WriteLine("Измененный массив b:");
        Print(b);
    }

    static void Print(char[] a)
    {
        foreach (char elem in a)
        {
            Console.Write(elem);
        }
        Console.WriteLine();
    }
    static void PrintChars()
    {
        Console.WriteLine("{0,5} {1,8} {2,15}", "код", "символ", "назначение");
        for (ushort i = 0; i < 255; i++) // реальной верхней границей для i является значение 65535
        {
            char a = (char)i;
            Console.Write("\n{0,5} {1,8}", i, a);
            if (char.IsLetter(a)) Console.Write("{0,20}", "Буква");
            if (char.IsUpper(a)) Console.Write("{0,20}", "Верхний регистр");
            if (char.IsLower(a)) Console.Write("{0,20}", "Нижний регистр");
            if (char.IsControl(a)) Console.Write("{0,20}", "Управляющий символ");
            if (char.IsNumber(a)) Console.Write("{0,20}", "Число");
            if (char.IsPunctuation(a)) Console.Write("{0,20}", "Знак препинания");
            if (char.IsDigit(a)) Console.Write("{0,20}", "Цифра");
            if (char.IsSeparator(a)) Console.Write("{0,20}", "Разделитель");
            if (char.IsWhiteSpace(a)) Console.Write("{0,20}", "Пробельный символ");
        }
    }
}