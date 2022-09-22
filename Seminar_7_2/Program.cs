// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int height = EnterInt ("Enter height: ");
int width = EnterInt ("Enter width: ");

int[ , ] numbers = new int[height, width];

Fill2DArray (numbers, height, width);
Print2DArray (numbers, height, width);


int EnterInt (string prompt) 
{
    Console.Write (prompt);
    return int.Parse (Console.ReadLine ()!);
}


void Fill2DArray (int[, ] numbers, int height, int width) {
     for (int i = 0; i < height; i++)
    {
    for (int j = 0; j < width; j++)
        {
        numbers[i, j] = i + j;
        }
    }
}

void Print2DArray (int[, ] numbers, int height, int width) {
     for (int i = 0; i < height; i++) // для каждой строки
    {
    for (int j = 0; j < width; j++) // внутри этой строки для каждого столбца
    {
        Console.Write ($"{numbers[i, j],3} ");
    }
    Console.WriteLine ();
    }
}