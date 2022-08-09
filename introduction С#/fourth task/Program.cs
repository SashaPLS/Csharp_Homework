//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = 1;
while (secondNumber <= number)
{
    if (secondNumber % 2 == 0)

        Console.WriteLine(secondNumber + ",");
    secondNumber += 1;

}

