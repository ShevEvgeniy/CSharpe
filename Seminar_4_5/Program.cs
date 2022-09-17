// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

Console.WriteLine("Введите N ");

bool numBool = false;
int num = 0;
while (!numBool)
{
    Console.WriteLine("Число должно быть целым");
    numBool = int.TryParse(Console.ReadLine()!, out num);
}

int[] array =new int[num];
FillArray(array);
Console.WriteLine("Наш массив случайных чисел, 0 и 1:");
for (int i = 0; i < num; i++)
{
    Console.Write($"{array[i]} ");
}
*/
int[] CreateArray (int size) 
{
    int[] numBool = new int[size];
    for (int i = 0; i < size; i++)
    {
        numBool[i] = new Random().Next(0, 2); 
    }
    return numBool;
}
void PrintArray (int[] array)
{
    //Console.WriteLine($"[");
    //Console.WriteLine(string.Join (", ", array));
    //Console.WriteLine("]"); Преобразуем эти три строчки
    Console.WriteLine($"[{string.Join (", ", array)}]");

}

//int[] array = CreateArray (8);
//PrintArray (array); // Преобразуем  в PrintArray (CreateArray (8));

PrintArray (CreateArray (8));
