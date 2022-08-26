// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = ReadInt("Введите число: ");
double k1 = ReadInt("Введите число: ");
double b2 = ReadInt("Введите число: ");
double k2 = ReadInt("Введите число: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 *x + b1;
double y1 = k2 *x + b2;

if(k1 == k2)
{
    Console.WriteLine($"Две прямые параллельны друг другу и не пересекаются");
}
else
{
Console.WriteLine($"Точка пересечения: ({x} ; {y})");
Console.WriteLine($"Точка пересечения: ({x} ; {y1})");
}

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
