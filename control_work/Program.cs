// Написать программу, которая из имещюегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполенения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":)"]->["2", ":)"]
// ["1234", "1567", "-2", "computer scence"] ->["-2"]
// ["Russia", "Denmark", "Kazan"]->[]

Console.Clear();

string[] array1 = new string[5] {"hello", "2", "world", ":)", "1234"};
 // string[] array1 = new string[4] {"1234", "1567", "-2", "computer scence"};
//string[] array1 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];
void SecondArrayIn(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayIn(array1, array2);
 PrintArray(array2);