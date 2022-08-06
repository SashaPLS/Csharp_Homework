//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = 2;
if (number % secondNumber == 0)
    {
    Console.WriteLine("Число является чётным");
    }
else
    {
    Console.WriteLine("Введите другое число, это число нечётное");
    }



