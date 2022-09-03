// Семинар 1 задача 6
//Является ли число чётным?
//Напишите программу, которая на вход принимает число и выдаёт, является ли оно чётным

Console.WriteLine("Введите целое число, я напишу четное оно или нет");
int number=int.Parse(Console.ReadLine());
if (number==0)
{
    Console.WriteLine("Вы ввели ноль, попытайтесь ввести число еще раз");
}
else
{
    if(number % 2 ==0)
    {
        Console.WriteLine($"Число {number} является четным");
    }
else
 {
    Console.WriteLine($"Число {number} не является четным");
 }
}