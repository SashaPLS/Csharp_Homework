// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = SpiralArray(4);
PrintArray(array);

int[,] SpiralArray(int size)
{
    int[,] array = new int[size, size]; 

    int i = 0, j = 0; 
    int count = 1; 

    while (size != 0)
    {
        for(int k = 0; k < size - 1; k++) 
        {
            array[i, j++] = count++;
        }
        for (int k = 0; k < size - 1; k++) 
        {
            array[i++, j] = count++;
        }
        for (int k = 0; k < size - 1; k++) 
        {
            array[i, j--] = count++;
        }
        for (int k = 0; k < size - 1; k++) 
        {
            array[i--, j] = count++;
        }

        size = size < 2 ? 0 : size - 2; 
        i++; 
        j++; 
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}