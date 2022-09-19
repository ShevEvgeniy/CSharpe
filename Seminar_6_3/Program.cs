// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

PrintArray(getFibonacci(N));

int[] getFibonacci(int N)
{
    int[] fibs = new int[N];
    fibs[0] = 0;
    fibs[1] = 1;
    for (int i = 2; i < N; i++)
    fibs[i] = fibs[i - 2] + fibs[i - 1];
    return fibs;
}

void PrintArray(int[] fibs)
{
    foreach (int fib in fibs)
    {
        Console.Write($"{fib} ");
    }
    Console.WriteLine();
}