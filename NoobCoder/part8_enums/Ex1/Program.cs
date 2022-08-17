


internal class Program
{
    private static void Main(string[] args)
    {
        var tomPet = Cat;
        Pets bobPet = 4;
        tomPet = bobPet;
        var johnPet = Pets.tomPet;
        Console.WriteLine((int)johnPet);
    }
}

enum Pets
{
    Cat,
    Dog,
    Rabbit,
    Snake,
    Raccoon,
    Spider,
}