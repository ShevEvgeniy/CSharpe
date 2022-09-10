// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

while (true) // Зацикливание программы
{
    Console.WriteLine();
    Console.WriteLine("Введите число или нажмите *q* для выхода");
    ConsoleKeyInfo digit = Console.ReadKey(); // в задаче говориться про цифру, а не число, решил сделать через ReadKey
    Console.WriteLine();

    int iDigit = digit.KeyChar - '0';

    double[] arrey = new double[iDigit + 1];
    if (iDigit > 0 && iDigit < 10)
    {
        /* for (int step = 1; step <= iDigit; step++)
         {
             arrey[step] = Math.Pow(step, 2);
             Console.Write($"{arrey[step]}");
             if (step < iDigit);
             Console.Write(", ");
         }
         */
        for (int step = 1; step <= iDigit; step++)
            arrey[step - 1] = step * step; // поправка step -1, потому что нумерация с 0
        for (int step = 0; step < iDigit; step++)
        {
            Console.Write(arrey[step]);
            if (step < iDigit);
            Console.Write(", ");
        }
    }
    else if (digit.KeyChar == 'q') // выход из while
    {
        Console.WriteLine("Приходите еще");
        break;
    }
    else { Console.WriteLine("Ошибочка"); }
}
