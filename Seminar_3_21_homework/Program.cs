// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
Console.WriteLine ("Введите X1 Y1 Z1 через пробел:");
string xyz = Console.ReadLine ()!;  
string[] parts = xyz.Split (' ');
int x1 = int.Parse (parts[0]);
int y1 = int.Parse (parts[1]);
int z1 = int.Parse (parts[2]);

Console.WriteLine ("Введите X2 Y2 Z2 через пробел:");
xyz = Console.ReadLine ()!;  
parts = xyz.Split (' ');
int x2 = int.Parse (parts[0]);
int y2 = int.Parse (parts[1]);
int z2 = int.Parse (parts[2]);


double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
             
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segment =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segment}");

