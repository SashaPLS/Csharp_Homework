// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.0
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
int minDigit = array[0];

FillArray(array);
SelectionSort(array);
PrintArray(array);
Console.WriteLine();


int max = array[0];
for (int i = 1; i < array.Length; ++i)
    if (array[i] > max) max = array[i];
        Console.WriteLine($"Разница между максимальным {max} и минимальным {array[0]} элементом  равна {max - array[0]}");

void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int dummy = array[i];
                array[i] = array[min];
                array[min] = dummy;
                min = i;
            }
        }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble(1.100, 1.) ;
    }
}
