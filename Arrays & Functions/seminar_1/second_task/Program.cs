//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99 && number >1)
    {
        Console.WriteLine("Третьей цифры нет");
    }
else if (number > 100 && number < 1000)    
    {
        number = number % 100 / 10;
        Console.WriteLine("Вторая цифра этого числа - " +number);
    }
else if (number > 1000 && number < 10000)    
    {
        number = number % 1000 / 100;
        Console.WriteLine("Вторая цифра этого числа - " +number);
    }
else if (number > 10000 && number < 100000)    
    {
        number = number % 10000 / 1000;
        Console.WriteLine("Вторая цифра этого числа - " +number);
    }