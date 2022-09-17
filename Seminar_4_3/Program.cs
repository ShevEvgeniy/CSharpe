//Решение в группах задач:
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int FindNumLength(int num) // Считает сколько раз нужно поделить на 10, тем самым узнаем ее длину
{
    int numMulti = 1;
    for (int i = 1; i <= num; i++)
    {
        numMulti = numMulti * i;
        Console.Write($"{numMulti} ");
    }
    return numMulti;
}
Console.Write("Пожалуйста введите число N: ");
bool numBool = false;
int num = 0;
while (!numBool)
{
    Console.WriteLine("Число должно быть целым");
    numBool = int.TryParse(Console.ReadLine()!, out num);
}

Console.WriteLine($"Факториал {num} -> {FindNumLength(num)}");
