class Program {

    public static void Main () {
        const int Size = 12;  // КаждоеСловоСЗаглавнойБуквы    PascalCase
        int[] numbers = CreateRandomArray (Size);
        PrintArray (numbers);
        int positivesSum = CalcPositivesSum (numbers);
        int negativesSum = CalcNegativesSum (numbers);
        Console.WriteLine ($"Сумма положительных = {positivesSum}, сумма отрицательных = {negativesSum}");
    }

    static void PrintArray (int[] numbers) {
        foreach (int number in numbers)
            System.Console.Write ($"{number} ");
    }

    static int[] CreateRandomArray (int size) {
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++) {
            numbers[i] = new Random ().Next (-9, 10);  // правая граница не включается
        }
        return numbers;
    }

    static int CalcPositivesSum (int[] numbers) {
        int positivesSum = 0;
        // для каждого числа number из массива чисел numbers
        foreach (int number in numbers) {
            if (number > 0)
                positivesSum += number;
        }
        return positivesSum;
    }
    static int CalcNegativesSum (int[] numbers) {
        int negativesSum = 0;
        foreach (int number in numbers) {
            if (number < 0)
                negativesSum += number;
        }
        return negativesSum;
    }
}