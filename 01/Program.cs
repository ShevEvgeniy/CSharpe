Console.WriteLine("Введите число ");
string input = Console.ReadLine(); // ввод

int number = int.Parse(input); // число

//if (int.Parse (input))

int square = number * number; //квадрат

Console.WriteLine($"Число в квадрате = {square}");