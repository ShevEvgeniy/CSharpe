// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

while (true) //Зацикливание программы
{
    //Основной код задачи
// -------------------------------------------------------------------
    Console.WriteLine("Введите трехзначное число");
    int Num = NumChecker();

    if (Num>= 100 && Num < 1000)
    {
        int digit = Num / 10% 10; // Заранее известно, что число 3х значное, можно достать нужную цифру математикой
        Console.WriteLine($"Вторая цифра в {Num} -> {digit}");
    } 
else
{
    Console.WriteLine($"Число {Num} не является трехзначным");
}
// ------------------------------------------------------------------
// Зацикливание программы
Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
ConsoleKeyInfo quite = Console.ReadKey();
Console.WriteLine();
if (quite.KeyChar == 'q') break;
}
    int NumChecker() //метод проверки на ввод числа
{
    while (true) {
        Console.WriteLine("  //число для продолжения, или q чтобы выйти");
        string num = Console.ReadLine();

        if (num == "q")
        {
            Console.WriteLine($"Вы не ввели число");
            System.Environment.Exit(0); //завершение программы на любом этапе
            return -1;
        }
        else if (int.TryParse(num, out int isItNum))
            return isItNum;
    }
}
