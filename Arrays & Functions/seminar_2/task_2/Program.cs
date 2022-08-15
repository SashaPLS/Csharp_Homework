// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int z1 = ReadInt("Введите Z точки А: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

int lenghtX = x1 - x2;
int lenghtY = y1 - y2;
int lenghtZ = z1 - z2;

double distance = Math.Sqrt(lenghtX * lenghtX + lenghtY * lenghtY + lenghtZ * lenghtZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
