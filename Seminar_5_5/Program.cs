﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


const int Size =123;

int[] array = CreateArray (Size, 10, 123); //опишем функцию так, чтобы числа описывали диапазон включительно
PrintArray(array);
int x = CountDesignated(array);
Console.WriteLine($"В данном массиве {x} чисел, лежащих в пределах от 10 до 99 включительно");

//Остается проверить программе, в глазах рябит от 123 случайных чисел.

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] CreateArray(int size, int smallest, int biggest)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(smallest,biggest+1);
    }
    return numbers;
}

bool IsDesignated(int number)
{
    return (number <= 99 && number >= 10 );
}

int CountDesignated(int[] arr)
{
    int counter = 0;
    foreach (int element in arr)
    {
        if (IsDesignated(element))
        counter++;
    }
    return counter;
}
