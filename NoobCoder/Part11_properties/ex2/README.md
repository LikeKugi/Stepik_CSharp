Некий Василий (возможно, наш общий знакомый?) хочет создать класс **Vasya**, принимающий при инициализации 2 параметра: имя и возраст. Но на этом он не успокоился.  

Не важно, какое имя передаст пользователь при создании экземпляра, оно всегда будет содержать “Василия”.  
 
В частности - если пользователя на самом деле зовут **Василий**, то с именем ничего не произойдет, а если его зовут, например, Максим, то оно преобразуется в “**Я не Максим, а Василий!**”.  

Помогите Василию с его непростой задачей, ведь он ещё не проходил курс NoobCoder`s и не знает как это сделать.  

От себя мы внесли некоторые правки которые Василий не предусмотрел:  

- Свойство Name - для имени;
- Свойство Age - для возраста;
- Конструктор Vasya(string name, int age);
- Если пользователь указывает возраст меньше 0, в поле возраст записывается 0;
- Проведя масштабные научные исследования (загуглив звучит не так эпично), мы выяснили что мировой рекорд долгожительства установила француженка Жанна Кальман. Она родилась в 1875 году и умерла в 1997-м, прожив 122 полных года. Отсюда следует второе ограничение на возраст: если пользователь указывает возраст больше 122, в поле возраст записывается 122;
- После получения всех данных программа выводит сообщение: 
```
{Имя}
Мне {Возраст} лет
```
обратите внимание слово лет из данного примера **должно корректно склоняться** в зависимости от возраста пользователя;  

В данном задании есть хитрое обязательное условие:

**В методе** Main() **после** всего вашего кода должна быть строка:

**Surprise.RunMe();**

И менее хитрое условие:

Для корректной работы тестов не нужно ничего выводить в конструкторе класса.
___
Sample Input:
```
Василий 10
```
Sample Output:
```
Василий
Мне 10 лет
```