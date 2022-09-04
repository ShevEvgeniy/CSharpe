// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

using System;

int number = new Random().Next(10, 100); // number = число
Console.WriteLine(number);

int digit1 = number / 10;    // digit = цифра
int digit2 = number % 10;

if (digit1 >=digit2)
Console.WriteLine(digit1);
else
Console.WriteLine(digit2);

