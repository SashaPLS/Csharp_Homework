// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[10, 10];
double tempColumns = 0;
int counterRows = 0;
int counterColumns = 0;
double length = array.GetLength(1);

FillArray2D(array);
PrintArray2D(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        tempColumns += array[i, j];
        counterColumns++;
        counterRows++;    
        if(i == array.GetLength(1))
            {
                i++;
            }
        if (counterRows == array.GetLength(1) )
            {
                break;
            } 
    } 
    Console.Write($" {tempColumns / length} ; ");
    tempColumns = 0; 
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
