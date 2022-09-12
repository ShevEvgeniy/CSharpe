//Наша задача — выбрать самый первый элемент и в оставшейся
//части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
//нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, это
//6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.

// Было: 6 8 3 2 1 4 5 7
// Результат: 1 2 3 4 5 6 7 8

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;
//{
//minPosition = j
//}
}
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

