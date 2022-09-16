// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 5;
int n = 4;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int maxval, temp = 0;
int maxi, maxj;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        maxval = array[i, j];
        maxi = i;
        maxj = j;
        for (int k = j; k < array.GetLength(1); k++)
        {
            if(array[i,k] > maxval)
            {
                maxval = array[i,k];
                maxi = i;
                maxj = k;
            }
        }
        temp = array[i,j];
        array[i,j] = array[maxi,maxj]; 
        array[maxi,maxj] = temp;
    }
}

PrintArray(array);
