// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
string maxNumber = "- максимальное число";
if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Первое число:  " + firstNumber + " " + maxNumber + "");
    }
    else
    {
        Console.WriteLine("Третье число: " + thirdNumber + " " + maxNumber + "");
    }
}
else if (thirdNumber < secondNumber)
{
    Console.WriteLine("Второе число: " + secondNumber + " " + maxNumber + "");
}
else
{
    Console.WriteLine("Третье число: " + thirdNumber + " " + maxNumber + "");
}
