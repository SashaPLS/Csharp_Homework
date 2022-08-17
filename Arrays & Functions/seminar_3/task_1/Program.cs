// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int numberA = ReadInt("Введите число А: ");
int numberB = ReadInt("Введите число В: ");

double powMethod = Math.Pow (numberA,numberB);

Console.WriteLine("Число "+numberA+" в степени "+numberB+" равно: "+powMethod+"");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
