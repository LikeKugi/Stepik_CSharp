Напиши функцию PrintAsterisks, которая должна выводить в консоль строку из звездочек. Количество звездочек она получает параметром
```
using System;

class Program {
  static void Main(string[] args) {
    Task.PrintAsterisks(10);
  }
}
```
___
Sample Input 1:
```
10
```
Sample Output 1:
```
**********
```
___
Sample Input 2:
```
5
```
Sample Output 2:
```
*****
```

___
___
Используя функцию PrintAsterisks из предыдущей задачи, напиши функцию PrintAsteriskBox. Эта функция должна выводить прямоугольник, заполненный звездочками. Ширина и высота прямоугольника передаются в функцию в виде параметров

 
```
using System;

class Program {
  static void Main(string[] args) {
    Task.PrintAsteriskBox(5, 3);
  }
}
```
___
Sample Input 1:
```
5
3
```
Sample Output 1:
```
*****
*****
*****
```
___
Sample Input 2:
```
3
5
```
Sample Output 2:
```
***
***
***
***
***
```