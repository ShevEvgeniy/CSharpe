// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] numbers = CreateRandomArray (12); 
PrintArray (numbers);
Console.WriteLine($" Сумма положительных = {CalcPositivesSum (numbers)}, сумма отрицательных = {CalcNegativesSum (numbers)}");

void PrintArray (int [] numbers)
{
    foreach (int number in numbers)
    System.Console.Write($"{number} ");
}

int [] CreateRandomArray (int size) 
{
    int[] numbers = new int [size];

for (int i = 0; i < size; i++)
    {
    numbers[i] = new Random ().Next (-9, 10); // правая граница не включается
    } 
    return numbers;
}


int CalcPositivesSum (int [] numbers)
{
    int sum = 0;
    // для каждого числа number из массива чисел numbers
    foreach (int number in numbers)
    {
        if (number > 0)
        sum += number;
    }
    return sum;
}

int CalcNegativesSum (int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
     if (number < 0)
    sum += number;
    }
    return sum;
} 