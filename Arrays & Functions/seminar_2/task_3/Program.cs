// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=N)
{
    if(i == N)
    {
        Console.WriteLine(i*i*i);
    }
    else
    {
        Console.Write(i*i*i+ ", ");
    }
    i++;
}
