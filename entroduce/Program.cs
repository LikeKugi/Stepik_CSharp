using System;

public class MainClass
{
    public static void Main()
    {

        // 1 task
        Console.WriteLine("Hello world!");

        // 2 task
        Console.WriteLine("! № 12 34 56 90");

        // 3 task
        Console.WriteLine("!");
        Console.WriteLine();
        Console.WriteLine("№");
        Console.WriteLine("12");
        Console.WriteLine("34");
        Console.WriteLine("56");
        Console.WriteLine("90");

        /* SOME RULES */

        Console.WriteLine("Введите свое имя:");
        var name1 = Console.ReadLine(); //var musthave in this task.
        // but can use 'string?' instead of 'var'
        Console.WriteLine($"Здравствуй, {name1} ");

        // 4 task
        Console.WriteLine("Введите своё имя:");
        var name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");

        // 5 task
        Console.WriteLine("А как вы считаете, какой фильм можно назвать лучшим за 2021 год?");
        var movie = Console.ReadLine();
        Console.WriteLine($"Лучший фильм 2021 года - {movie}");
        
        // 6 task
        char rnd = '$';
        Console.WriteLine(rnd);

        string fname = "Билл", lname = "Гейтс", job = "Предприниматель";
        byte date = 28;
        short age = 1955;
        Console.WriteLine(fname + " " + lname + " " + job + ". Родился " + date + " октября " + age + " года.");

        /* ANOTHER EXAMPLE OF USING CONVERT*/

        string variable = "34";
        int number = Convert.ToInt32(variable); //convert to another type of data
        Console.WriteLine(number);
        
        // 7 task
        byte bnum = 254;
        long lnum = Convert.ToInt64(bnum);
        Console.WriteLine(lnum);

        // 8 task
        Console.WriteLine("Законодательство США допускало отправку детей по почте до 1913 года");
        Console.WriteLine("Ответь на данный факт true или false");
        string? answer = Console.ReadLine();
        bool bans = Convert.ToBoolean(answer);
        Console.WriteLine("Ответ: "+bans);

        /* ONE MORE EXAMPLE OF USING PARSE*/

        string variable1 = "34";    
        int number12 = int.Parse(variable1); //PARSE only convert from string
        Console.WriteLine(number12);
        int a = int.Parse(Console.ReadLine()); //PARSE from console input
        // But it makes warning
        Console.WriteLine("input = " + a);

        // 9 task
        string asking = "?";
        char sign = char.Parse(asking);
        Console.WriteLine(sign);

        /* EXAMPLE WITH PARSE AND DIFFERENT 
        GLOBALIZATION NUMBER FORMAT */

        string aFrom = "1.5";
        System.Globalization.NumberFormatInfo numberFormatInfo1 = new System.Globalization.NumberFormatInfo()
        {
        NumberDecimalSeparator = ".",
        };
        double bTo = double.Parse(aFrom, numberFormatInfo1); // numberFormatInfo - musthave attribute
        Console.WriteLine(bTo);

        // 10 task
        string strToFlo = "5.25";
        System.Globalization.NumberFormatInfo numberFormatInfo = new System.Globalization.NumberFormatInfo()
        {
        NumberDecimalSeparator = ".",
        };
        float floFromStr = float.Parse(strToFlo, numberFormatInfo);
        Console.WriteLine(floFromStr);

    }
}