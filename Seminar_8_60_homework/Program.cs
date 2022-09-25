// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


void PrintIndex(int[,,] index)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] element)
{
    int count = 10;
    for (int i = 0; i < element.GetLength(0); i++)
    {
        for (int j = 0; j < element.GetLength(1); j++)
        {
            for (int k = 0; k < element.GetLength(2); k++)
            {
                element[k, i, j] += count;
                count += 3;
            }
        }
    }
}