// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 

string number = ReadInt("Введите трехзначное число: ");

Console.WriteLine("Вторая цифра этого числа ->" +number[1]);

string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}