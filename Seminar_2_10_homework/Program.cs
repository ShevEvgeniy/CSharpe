﻿
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int numberA = new Random().Next(100, 1000);
Console.WriteLine(numberA);
Console.WriteLine($"{(numberA / 10) % 10}");