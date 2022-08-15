// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int number = ReadInt("Введите число: ");
string monday = "понедельник";
string tuesday = "вторник";
string wednesday = "среда";
string thursday = "четверг";
string friday = "пятница";

if(number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной день");
    }
else if (number ==1 )
    {
        Console.WriteLine("Это будний день," +monday);
    }
else if (number ==2)
    {
        Console.WriteLine("Это будний день," +tuesday);
    }
else if (number ==3)
    {
        Console.WriteLine("Это будний день," +wednesday);
    }
else if (number ==4)
    {
        Console.WriteLine("Это будний день," +thursday);
    }
else if (number ==5)
    {
        Console.WriteLine("Это будний день," +friday);
    }

int ReadInt (string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }