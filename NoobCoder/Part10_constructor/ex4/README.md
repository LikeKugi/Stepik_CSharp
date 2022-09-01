Описать класс денежных сумм, заданных в виде количества рублей и копеек. Для данной задачи мы с вами условимся что знак рубля "р." (р - кириллический символ), знак копеек - "коп." (тоже кириллица).

### **Определить в нём:**

1. Конструктор, принимающий количество рублей или копеек в формате строк ("10", "р.") или ("25", "коп.")

2. Конструктор, принимающий рубли и копейки одновременно в формате строк ( "10", "р.", "25", "коп.")

### Конструкторы должны корректно обрабатывать следующие ситуации:

    - значения копеек > 99 (например "101 коп." == "1 р. 1 коп.")
    - в случае когда рубли вводятся после копеек "10 коп. 5 р." - вывести сообщение "Рубли и копейки перепутаны местами!".
    - в случае когда введено отрицательное число - вывести сообщение "Не может быть отрицательным!"

3. Операции сложения и вычитания - методы static Sum(Money a, Money b) и static Difference(Money a, Money b), которые возвращают новый объект того же класса Money.

4. Метод Print() - вывод на консоль всей суммы.

### Метод должен корректно обрабатывать следующие ситуации:

    - Если количество рублей в сумме 0 - выводить рубли не нужно.
    - Во всех остальных случаях ожидается полный вывод.

5. Метод PrintTransferCost() принимающий аргументом вещественное число - величину комиссии за перевод (например 0.05). Метод выводит в консоль полную стоимость перевода с комиссией округленную до копеек (пример для суммы 10 р. 15 коп. и величины комиссии 5% полная стоимость составит 10 р. 66 коп.)
___
Sample Input:
```
2 р. 15 коп.
```
Sample Output:
```
2 р. 15 коп.
```