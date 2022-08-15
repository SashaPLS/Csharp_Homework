//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string number = ReadInt("Введите пятизначное число для проверки: ");
string firstNumber = Convert.ToString(number);

if (firstNumber[0] == firstNumber[4] && firstNumber[1] == firstNumber[3])

    {
    Console.WriteLine("Число является палиндромом");
    }
else

    Console.WriteLine("Число не является палиндромом");
if (number.Length != 5)
    {
        Console.WriteLine("Вы ввели не пятизначное число");
    }
string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}