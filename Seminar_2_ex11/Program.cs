// 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру 
// 456 - 46
// 782 - 72
// 918 - 98

int numberA = new Random(). Next(100, 1000);
Console.WriteLine(numberA);
Console.WriteLine($"{numberA/100}{numberA%10}");

