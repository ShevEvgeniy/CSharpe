## Задача
Написать программу, которая из имещюегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполенения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## ["hello", "2", "world", ":)"]->["2", ":)"]
## ["1234", "1567", "-2", "computer scence"] ->["-2"]
## ["Russia", "Denmark", "Kazan"]->[]

## Решение задачи:
Согласно условию задачи, первоначальный массив либо вводится с клавиатуры, либо задается на старте.
Задаём 2 массива, первый (array1) и второй такой же длинны(array2). Дальше создаем метод и внутри цикла выполняем проверку условия (длина строк <=3), если условие выполняется, элемент первого массива заносим в "count" элемент второго массива. Предварительно вводим переменную "count" чтобы была возможность поочередно записывать элементы из первого массива во второй. Дальше, после присвоение, увеличиваем "count" на 1 и возвращаемся к циклу, в котором увеличиваем i на 1 (i++). 
В итоге с помощью "PrintArray" - выводим на печать массив строк, длина которых <=3 
