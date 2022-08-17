internal class Program
{
    private static void Main(string[] args)
    {
        var inptMnth = Console.ReadLine();

        var isValidMonth = Enum.TryParse(inptMnth, true, out Months month);

        if (isValidMonth)
        {
            var days = (int)month;
            Console.WriteLine(days);
        }
        else
        {
            Console.WriteLine("введено некорректное название месяца");
        }
    }
   
}

enum Months
{
    Январь = 31,
    Февраль = 28,
    Март = 31,
    Апрель = 30,
    Май = 31,
    Июнь = 30,
    Июль = 31,
    Август = 31,
    Сентябрь = 30,
    Октябрь = 31,
    Ноябрь = 30,
    Декабрь = 31,
}