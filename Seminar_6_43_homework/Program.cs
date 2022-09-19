// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double x, double y) CrossPoint(Line function1, Line function2)
{
    double x = (function2.b - function1.b) / (function1.k - function2.k);
    double y = (function1.k * x) + function1.b;
    return (x, y);
}

Line GetFactors(string Number)
{
    Line factor;
    Console.Write("Введите значение k{0}:", Number);
    factor.k = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b{0}:", Number);
    factor.b = Convert.ToDouble(Console.ReadLine());
    return factor;
}

Line count1, count2;

count1 = GetFactors("1");
count2 = GetFactors("2");
if (count1.k == count2.k)
{
    Console.WriteLine("Прямые y={0}*x + {1} и y={2}*x + {3} параллельны.",
                    count1.k, count1.b, 
                    count2.k, count2.b);
    Console.WriteLine("Точки пересечения нет.");
}
else
{
    double pointX, pointY;
    (pointX, pointY) = CrossPoint(count1, count2);
    Console.WriteLine();

    Console.WriteLine("Координаты точки пересечения = ({0} , {1}).", Math.Round(pointX, 1), Math.Round(pointY, 1));
}

public record struct Line // y = k * x + b
{
    public double k;
    public double b;
}

