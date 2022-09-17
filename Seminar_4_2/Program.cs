//Решение в группах задач:
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//Console.WriteLine("Пожалуйста введите число N: ");
//int n = int.Parse(Console.ReadLine()!); // 12345

//while (n > 0) // n ==1234
//{
   // int digit = n % 10; // последняя цифра
  //  Console.WriteLine(digit);
 //   n = n / 10; // оставить все кроме последней цифры
//}

int FindNumLength(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;
        sum++;
    }
    return sum;
}
Console.Write("Пожалуйста введите число N: ");
bool numB = false;
int num = 0;
while (!numB)
{
    Console.WriteLine("Число должно быть целым");
    numB = int.TryParse(Console.ReadLine()!, out num);
}
Console.WriteLine($"Количество цифр в {num} -> {FindNumLength(num)}");