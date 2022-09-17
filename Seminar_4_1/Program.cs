// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.WriteLine("Пожалуйста введите число N: ");
int max = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = 1; i <= max; i++) // 1 2 3 4 5
    sum = sum + i;
Console.WriteLine(sum);
