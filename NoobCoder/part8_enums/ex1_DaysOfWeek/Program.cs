internal class Program
{
    private static void Main(string[] args)
    {
        var day = DaysOfTheWeek.Воскресенье;
        Console.WriteLine(day);
    }
}

enum DaysOfTheWeek
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье,
}

