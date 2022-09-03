//Семинар 1 задача 2
//Какое число большее?
//Напишите программу, которая на вход принимает два числа и выдаёт, какое из них большее, а какое меньшее.


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