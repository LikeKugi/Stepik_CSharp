Тебе наверняка часто встречались ошибки, когда программа не запускалась из-за того, что ты забыл закрыть круглую или фигурную скобку. В этой задаче ты реализуешь аналогичную функциональность поиска непарных скобок или других символов.

Напиши функцию CheckPairs, которая принимает три параметра: строку с исходным текстом и пару открывающий/закрывающий символы. Функция выводит в консоль текст Все в порядке, если каждому открывающему символу есть пара и они расставлены в правильном порядке. И текст Найдены ошибки в противном случае.  
Обрати внимание, что в переданной строке следует искать именно те символы, которые переданы вторым и третьим аргументами
```
using System;

class Program {
  static void Main(string[] args) {
    // пример вызова метода
    Task.CheckPairs("Console.ReadLine();", '(', ')'); /* Все в порядке */
  }
}
```
___
Sample Input 1:
```
Console.ReadLine();
(
)
```
Sample Output 1:
```
Все в порядке
```
___
Sample Input 2:
```
static void Main(string[] args) {]
{
}
```
Sample Output 2:
```
Найдены ошибки
```
___
Sample Input 3:
```
string][ fruits = {"Яблоко", "Апельсин", "Слива"};
[
]
```
Sample Output 3:
```
Найдены ошибки
```