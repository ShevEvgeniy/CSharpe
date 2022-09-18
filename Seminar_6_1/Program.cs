// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
PrintArray (numbers);

ReverseArray (numbers);
PrintArray (numbers);
// int a = 5;
// int b = 2;
// Swap (ref a, ref b);
// System.Console.WriteLine($"{a} {b}");

void Swap (ref int a, ref int b){
    int c = a;
    a = b; 
    b = c;
}

void PrintArray (int [] nambers) {
    Console.WriteLine(string.Join (", ", numbers));
}

void ReverseArray (int[] numbers){
for (int i =0; i < numbers.Length / 2; i++) {
    // мы хотим поменять местами 1-й с
    
    //int temp = numbers[i];
    //numbers[i] = numbers[j];
    //numbers[j] = temp; вместо них используем
    Swap (ref numbers [i], ref numbers[numbers.Length -1 - i]);
}

}