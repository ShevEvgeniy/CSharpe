// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int height = EnterInt ("Введите количество строк: ");
int width = EnterInt ("Введите количество столбцов: ");


double[ , ] numbers = new double [height, width];
Fill2DArray (numbers, height, width);
Print2DArray (numbers, height, width);
Console.WriteLine ();
ChangeFirstEndRows(numbers, height, width);
Print2DArray (numbers, height, width);

 int EnterInt (string prompt) 
 {
     Console.Write (prompt);
     return int.Parse (Console.ReadLine ()!);
 }



void Fill2DArray (double[, ] numbers, int height, int width) {
     for (int i = 0; i < height; i++)
    {
    for (int j = 0; j < width; j++)
        {
        numbers[i, j] = Math.Round(new Random ().NextDouble () * 100, 2, MidpointRounding.AwayFromZero);
        }
    }
}

void Print2DArray (double[, ] numbers, int height, int width) 
{
     for (int i = 0; i < height; i++) // для каждой строки
    {
    for (int j = 0; j < width; j++) // внутри этой строки для каждого столбца
    {
        Console.Write ($"{numbers[i, j],6} ");
    }
    Console.WriteLine ();
    }
}


void ChangeFirstEndRows(double[,] numbers, int height, int width)
{
     for (int j = 0; j < width; j++)
        {
            (numbers[0, j], numbers[height - 1, j]) = (numbers[height - 1, j], numbers[0, j]);
        }
}
