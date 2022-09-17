// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
/*
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
Console.Write(number);

// is, has, глагол в третьем лице goes does
bool isPalindrome = Palindrom(number);

 string txt = isPalindrome == true? " -> Да" : " -> Нет";
 Console.WriteLine(txt);

bool Palindrom(string number)

{
  //bool check = true;
  for (int i = 0; i < number.Length / 2; i++)
  {
    //check = check & number[i] == number[number.Length -i -1];
    if (number[i] != number[number.Length -i -1])
    return false;
  }
  return true;
}

