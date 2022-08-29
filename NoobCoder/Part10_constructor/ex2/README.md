Напишите класс Barrel, который бы имел поля material и volume и его метод/методы ToChange для изменения этих полей, так чтобы следующий код заработал.
```c#
public static void Main()
{
    var barrel = new Barrel();
    barrel.material = "oak";
    barrel.volume = 200;
    barrel.ToChange(100);
    barrel.ToChange("beech");
    Console.WriteLine($"{barrel.material}, {barrel.volume}");
}
```
___
Sample Input:
```
```

Sample Output:
```
beech, 100
```