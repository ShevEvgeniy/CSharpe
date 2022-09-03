// Семинар1 задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите целое число а");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int number2=int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число c");
int number3=int.Parse(Console.ReadLine());
if(number1>number2)
{
    if (number1>number3)
    {
        Console.WriteLine($"Число {number1} самое большое");
    }
    else
    {
        Console.WriteLine($"Число {number3} самое большое");
    }  
}
else
{
    if (number2>number3)
    {
        Console.WriteLine($"Число {number2} самое большое");
    }
    else
    {
        Console.WriteLine($"Число {number3} самое большое");
    }
}