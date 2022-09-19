// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

Console.Write("Введите число 1: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M= {M}; N= {N}");
int sum = 0;
for (int i = M; i <= N; i++)
    sum += i;
Console.WriteLine($"Cумма натуральных элементов от {M} до {N} = {sum}");