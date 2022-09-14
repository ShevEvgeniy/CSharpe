// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int NumCheck() //метод проверки на ввод числа
{
    while (true)
    {
        Console.WriteLine("Введите число для продолжения, или *q* чтоб выйти");
        string num = Console.ReadLine()!;
        if (num == "q")
        {
            Console.WriteLine($"Вы не ввели число");
            System.Environment.Exit(0); //Завершение программы на любом этапе
            return -1;
        }
        else if(int.TryParse(num, out int isItNum))
        return isItNum;
    }
}
while (true) //Зацикливание программы
{
    Console.WriteLine("Какое число будем раскладывать?");
    string num = NumCheck().ToString();
    int sum = 0;
    
    Console.WriteLine($"Сумма цифр в {num} - >");


foreach (char a in num)
{
   sum += a - '0';   
}
  Console.WriteLine($"{string.Join (" + ", num.ToCharArray ())} = {sum}");
  
  //Зацикливание программы
  Console.WriteLine();
  Console.WriteLine( "Enter чтобы продолжить / q чтобы выйти");
  ConsoleKeyInfo quite = Console.ReadKey();
  Console.WriteLine();
  if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}