//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string secondNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра введенного числа - " +secondNumber[1]);