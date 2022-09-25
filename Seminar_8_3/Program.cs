// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] matrix = InterfaceCollectsMarix(); // пустая матрица
FillMatrixRandom(matrix); // заполняем числами от 0 до 10
Console.WriteLine ($"Исходная матрица");
PrintMatrix(matrix); // выводим на экран

ElementCounter(matrix, WhatElements(matrix)); //Теперь эти две функции

 int [,] InterfaceCollectsMarix () 
 {
     Console.WriteLine ("Введите высоту матрицы.");
     int height = int.Parse(Console.ReadLine ()!);
     Console.WriteLine ("Введите ширину матрицы.");
     int width = int.Parse(Console.ReadLine ()!);
     return new int[height, width];
 }



int[,] FillMatrixRandom (int[, ] matrix) 
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = new Random ().Next (0, 10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix) 
{
     for (int i = 0; i < matrix.GetLength(0); i++) // для каждой строки
    {
    for (int j = 0; j < matrix.GetLength(1); j++) // внутри этой строки для каждого столбца
    {
        Console.Write ($"{matrix[i, j],3} ");
    }
    Console.WriteLine ();
    }
}

List<int> WhatElements(int[,] matrix) // пробегается по матрице и вписывает в лист встречающиеся значения
{
    List<int> @checked = new List<int>(); 
    for (int i = 0; i < matrix.GetLength(0); i++) // для каждой строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // внутри этой строки для каждого столбца
        {
            if(!@checked.Contains(matrix[i, j])) // если не содержится элемент то добавляем
            {
                @checked.Add(matrix[i, j]);
            }
        }
    }
    return @checked; // собака тут нужна для экранирования зарезирвированого имени
}

void ElementCounter (int[,] matrix, List<int> @checked) // теперь просим пройтись по матрице и сравнить с листом
{
     foreach (int element in @checked) // для каждого уникального элемента в листе
    {
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // внутри этой строки для каждого столбца
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (element == matrix[i, j]) 
            {
                counter++; // если встречает элемент, то считаем его
            }
        }   
    }
    Console.WriteLine ($"Элементов, равных {element} в данной матрице: {counter}.");
    }
}  // O (n^3)