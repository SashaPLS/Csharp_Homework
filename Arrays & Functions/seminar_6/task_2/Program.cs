// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями firstLine = k1 * x + b1, secondLine = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = ReadInt("Введите число: ");
double k1 = ReadInt("Введите число: ");
double b2 = ReadInt("Введите число: ");
double k2 = ReadInt("Введите число: ");
double x = b1 - b2 / k2 - k1;
double firstLine = k1 * x + b1;
double secondLine = k2 * x + k2;
double intersectionPoint = (k2 * b1 - k1 * b2) / (k2 - k1);
double angleBetweenLines = k2 - k1 / 1 + k1 * k2;

Console.WriteLine ($"Точка пересечения: {intersectionPoint}");

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
