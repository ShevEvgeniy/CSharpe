﻿//Семинар 1 Задача 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число, я напишу все четные числа от 1 до введенного числа");
int number=int.Parse(Console.ReadLine());
if(number<2)
{
    Console.WriteLine("Данное число не подходит, перезапустите программу и введите другое число");
}
else
{
    for(int i=2; i<=number; i=i+2)
    {
        Console.WriteLine(i);
    }
}
