// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

using System;

Console.WriteLine("Введите через пробел координаты X и Y точки А");
string xy = Console.ReadLine()!;
string[] parts = xy.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);

Console.WriteLine("Введите через пробел координаты X и Y точки B");
xy = Console.ReadLine()!;
parts = xy.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));

Console.WriteLine($"Расстояние между этими двумя точками равно {distance:F3} единиц");


