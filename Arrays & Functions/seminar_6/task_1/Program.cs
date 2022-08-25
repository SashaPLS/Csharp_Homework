// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

string numbers = ReadStr("Введите количество цифр через запятую: ");
numbers = numbers.Replace (" ","");
int [] array = new int[numbers.Length];
int count = 0;
int minus = CountMinus(array);
int zero = CountZero(array);
int comma = CountComma(array);

for (int i = 0; i < numbers.Length; i++)
{
    array[i] = Convert.ToInt32(numbers[i]);
    if(array[i] > 0)
    {
        count ++;
    }
}   
Console.WriteLine(count - minus - zero - comma - minus);
Console.WriteLine(comma + 1 - minus);

int CountMinus (int [] array)
{
    int counterMinus = 0;
    for (int i = 0; i < numbers.Length; i++)   
        if(numbers[i] == '-')
        counterMinus++;
        return counterMinus;
}
int CountZero (int [] array)
{
    int counterZero = 0;
    for (int i = 0; i < numbers.Length; i++)   
        if(numbers[i] == '0')
        counterZero++;
        return counterZero;
}
int CountComma (int [] array)
{
    int counterComma = 0;
    for (int i = 0; i < numbers.Length; i++)   
        if(numbers[i] == ',')
        counterComma++;
        return counterComma;
}

string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}