// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = ReadInt("Введите индекс элемента,содержащийся в строке (не более 9): ");
int columns = ReadInt("Введите индекс элемента,содержащийся в столбце (не более 9): ");
int[,] array = new int [10,10];

FillArray2D(array);
PrintArray2D(array);


if (rows < array.GetLength(0) && columns < array.GetLength(1))
    {
        Console.WriteLine($"{array[rows,columns]}");
    }
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}  

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,30);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
