//Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.WriteLine("введите 8 чисел через пробел");
string abcdefgh = Console.ReadLine()!;
string[] parts = abcdefgh.Split(' ');

int[] array = new int[8]; // {0, 0, 0, 0, 0, 0, 0, 0, }
for (int i =0; i < 8; i++) // сделать 8 раз (для i от 0 до 7)
    array[i] = int.Parse(parts[i]);

    Console.Write($"[{string.Join(", ", array)}]");