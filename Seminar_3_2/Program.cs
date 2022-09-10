using System;

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine ("Введите номер четверти ");
int quarter = int.Parse (Console.ReadLine()!);

if (quarter ==1) {
    Console.WriteLine ("Х > 0 и Y > 0");
}
else if (quarter ==2) {
    Console.WriteLine ("Х < 0 и Y > 0");
}
else if (quarter ==3) {
    Console.WriteLine ("Х < 0 и Y < 0");
}
else if (quarter ==4){
    Console.WriteLine ("Х > 0 и Y < 0");
}
else
    Console.WriteLine ("Такой четверти не существует");


