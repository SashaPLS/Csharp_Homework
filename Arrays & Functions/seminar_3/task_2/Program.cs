// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadInt("Введите число: ");
int temp = 0;
int length = CountDigit(number);

int CountDigit(int a)
{
    int c = 3;
    while(a > 0)
    {
        a /= 10;
        c++;
    }
    return c;
}

for (int i = 0; i < length; i++)
{
    temp = temp + number % 10; 
    number = number / 10; 
}
Console.WriteLine(temp);    

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
