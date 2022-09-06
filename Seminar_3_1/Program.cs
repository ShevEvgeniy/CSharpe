using System;

// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine ("Введите X Y:");
string xy = Console.ReadLine ()!;  // "5 7"
string[] parts = xy.Split (' ');
int x = int.Parse (parts[0]);
int y = int.Parse (parts[1]);

// if else if else if else if
if (x > 0 && y > 0) {
    Console.WriteLine ("1-я четверть");
}
else if (x < 0 && y > 0) {
    Console.WriteLine ("2-я четверть");
}
else if (x < 0 && y < 0) {
    Console.WriteLine ("3-я четверть");
}
else if (x > 0 && y < 0){
    Console.WriteLine ("4-я четверть");
}
else
    Console.WriteLine ("Неправильная точка! Не соответствует условию задачи");

