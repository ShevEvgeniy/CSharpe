// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string ConvTo2Rec(int num) // вернуть строку разложенного числа в двоичном виде
{
    if (num == 0)
    {
        return "";
    }
    return $"{ConvTo2Rec(num / 2)}{num % 2}";
}

Console.Write("Введите число. ");

bool numBool = false;
int num = 0;

while (!numBool)
{
    Console.WriteLine("Число должно быть целым");
    numBool = int.TryParse(Console.ReadLine()!, out num);

    Console.WriteLine(ConvTo2Rec(num));


    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
    Console.Clear();

}