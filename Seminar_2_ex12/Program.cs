// Напишите программу, каталог будет принимать не вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34,5 - не кратно, остаток 4
// 16,4 - кратно

Console.WriteLine("Введите целое число а");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
    Console.WriteLine ("Число кратное друг другу");
else
    Console.WriteLine ("Число не кратное друг другу");    
