
internal class Program
{
    enum Variants
    {
        One,
        Two,
        Three,
    }

    enum Fingers
    {
        Thumb,
        Index,
        Middle,
        Ring,
        Little,
    }

    private static void Main(string[] args)
    {
        var finger = Fingers.Ring;
        Console.WriteLine(finger);
        Console.WriteLine(typeof(Fingers));

        var str = "Hello";

        var t = (Variants)3;
        Console.WriteLine(t);

        var value = NameEnum.option1;
        int i = (int)value;
        value = (NameEnum)2;
        Console.WriteLine($"{value} {i}");

        var infoMusic = KindMusic.Blues | KindMusic.Country |
            KindMusic.GoodMusic;
        bool Blues = true;
        bool Country = true;
        bool Electronic = false;
        bool HipHop = false;
        bool Jazz = false;
        bool Pop = true;
        bool Rock = false;
        bool Rap = true;

        Console.WriteLine(infoMusic.ToString());
        Console.WriteLine(KindMusic.GoodMusic.ToString());
    }
    enum NameEnum
    {
        option0,
        option1,
        option2,
        option3,
        option4,
    }
}


[Flags]
enum KindMusic
{
    Nothing = 0b_0000_0000,
    Blues = 0b_0000_0001,
    Country = 0b_0000_0010,
    Electronic = 0b_0000_0100,
    HipHop = 0b_0000_1000,
    Jazz = 0b_0001_0000,
    Pop = 0b_0010_0000,
    Rock = 0b_0100_0000,
    Rap = 0b_1000_0000,
    GoodMusic = Rap | Pop,
    VeryGoodMusic = Rock | Blues | HipHop,
}