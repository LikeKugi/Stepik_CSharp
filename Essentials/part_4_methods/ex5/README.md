Программист Денис с детства мечтал побывать в Антарктиде, но почему-то регулярных рейсов туда нет. Поэтому Денис все лето изучал Антарктиду с помощью соседнего кинотеатра. Теперь он знает, что в Антарктиде водится несколько видов пингвинов:

- Императорские пингвины (Emperor Penguins) — любители петь
- Малые пингвины (Little Penguins) — любители потанцевать
- Золотоволосые пингвины (Macaroni Penguins) — любители сёрфинга  

К сожалению, в мультфильмах не было сказано, какой вид пингвинов самый многочисленный. Денис решил выяснить это: он посмотрел эти мультфильмы еще раз, и каждый раз, когда видел пингвина, записывал в блокнот название его вида. Сейчас Денис дал вам блокнот с просьбой выяснить, какой вид пингвинов самый многочисленный

Напиши код функции GetMostWidespread, которая принимает параметром массив строк. Каждый элемент массива — это один вид пингвинов. Среди видов встречаются только «Emperor Penguin», «Little Penguin» и «Macaroni Penguin». Функция должна возвращать самый популярный вид пингвинов из переданных в функцию
Если самых популярных видов несколько, то верни любой из них
```
using System;

class Program {
  static void Main() {
    string mostWidespread = Task.GetMostWidespread(new[] {"Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin"});
    Console.WriteLine(mostWidespread); // Emperor Penguin
  }
}
```
___
Sample Input 1:
```
Emperor Penguin, Macaroni Penguin, Emperor Penguin, Little Penguin
```
Sample Output 1:
```
Emperor Penguin
```
___
Sample Input 2:
```
Emperor Penguin, Macaroni Penguin, Little Penguin, Emperor Penguin, Macaroni Penguin, Macaroni Penguin, Little Penguin
```
Sample Output 2:
```
Macaroni Penguin
```