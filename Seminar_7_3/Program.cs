// Общее обсуждение
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int height = EnterInt ("Enter height: ");
int width = EnterInt ("Enter width: ");

int[ , ] numbers = new int[height, width];

Fill2DArray (numbers, height, width);
Print2DArray (numbers, height, width);
Change2DArray (numbers, height, width);
Console.WriteLine ();
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
        numbers[i, j] = new Random ().Next (-10, 11);
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

void Change2DArray (int[, ] numbers, int height, int width) 
{
     for (int i = 0; i < height; i+=2)
    {
        for (int j = 0; j < width; j+=2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
}