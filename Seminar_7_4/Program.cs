//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int height = EnterInt ("Enter height: ");
int width = EnterInt ("Enter width: ");

int[ , ] numbers = new int[height, width];

Fill2DArray (numbers, height, width);
Print2DArray (numbers, height, width);
Console.WriteLine($"Сумма элементов главной диагонали: {FindMainDiagonalSums(numbers, height, width)}");

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
int FindMainDiagonalSums (int[, ] numbers, int height, int width) 
{
     int sum = 0;
     for (int i = 0; i < height; i++) 
    {
    for (int j = 0; j < width; j++) 
    {
        if (i == j)
        sum += numbers[i, j];
    }
    }
    return sum;
}