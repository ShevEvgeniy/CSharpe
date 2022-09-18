// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 9
//[6 7 3 6] -> 36 21



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

int[] MultiplyPair(int[] arr)
{
    int[] multpliedVector = new int[(arr.Length + 1)/2];
    for (int i = 0; i < (arr.Length +1) /2; i++) 
    {
        multpliedVector[i] = arr[i] * arr[arr.Length - i- 1];
    }
    return multpliedVector;
}
const int Size =20;

int[] array = CreateArray (Size, 1, 100); //опишем функцию так, чтобы числа описывали диапазон включительно
Console.WriteLine("Было:");
PrintArray(array);
Console.WriteLine("Стало:");
PrintArray(MultiplyPair(array));