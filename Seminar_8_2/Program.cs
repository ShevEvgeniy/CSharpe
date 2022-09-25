// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int height = EnterInt ("Введите количество строк: ");
int width = EnterInt ("Введите количество столбцов: ");


double[ , ] numbers = new double [height, width];
Fill2DArray (numbers, height, width);
Print2DArray (numbers, height, width);
Console.WriteLine ();
ChangeRowColumn (numbers, height, width);
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

void ChangeRowColumn(double[,] numbers, int height, int width)
{   
    if (height == width)
    {
         for (int i = 0; i < height; i++)
        {
            //for (int j = 0; j < width; j++)
            for (int j = i; j < width; j++)

                {
                    Swap(ref numbers[i, j], ref numbers[j, i]);
                   
                }
             
        }
    }
    else
        Console.WriteLine("Невозможно поменять строки и столбцы местами");           
        
}

static void Swap(ref double a, ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}