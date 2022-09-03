Console.WriteLine("Введите число a");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int number2=int.Parse(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"Число a = {number1} больше");
}
else if (number1<number2)
{
    Console.WriteLine($"Число b = {number2} больше");
}
else
{
    Console.WriteLine("Числа a и b равны");
}