// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.);

int[,] table = new int[6, 6];
FillRandom(table);
PrintArray(table);
Console.WriteLine();
NumberSumElements(table);


void NumberSumElements(int[,] array)
{
    int minNumber = 0;
    int minSumNambers = 0;
    int sumNambers = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minNumber += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumNambers += table[i, j];
        if (sumNambers < minNumber)
        {
            minNumber = sumNambers;
            minSumNambers = i;
        }
        sumNambers = 0;
    }
    Console.Write($"{minSumNambers + 1} строка с наименьшей суммой элементов");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}