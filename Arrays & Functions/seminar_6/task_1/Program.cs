// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

string numbersInput = ReadString("Введите числa через запятую: ");
string number = string.Empty;
int temp = 0;
int count = 0;
int length = numbersInput.Length;

for (int i = 0; i < length; i++)
    {
        if (numbersInput[i] != ',')
        {
            number += numbersInput[i];
        }
        else
        {
         temp = Convert.ToInt32(number);

        if (temp > 0)
        {
            count++;
        }
            number = string.Empty;
        }
    }
        
Console.WriteLine(count);

string ReadString(string message)
{
    Console.WriteLine(message);
    return Convert.ToString(Console.ReadLine() +',');
}

//TODO: мое неправильное решение этого примера,все равно решил Вам скинуть

// string numbers = ReadString("Введите количество цифр через запятую: ");
// numbers = numbers.Replace (" ","");
// int [] array = new int[numbers.Length];
// int minusNumbers = CountMinus(array);
// int zeroNumbers = CountZero(array);
// int commaNumbers = CountComma(array);

// Console.WriteLine(commaNumbers - minusNumbers - zeroNumbers);

// int CountMinus (int [] array)
// {
//     int counterMinus = 0;
//     for (int i = 0; i < numbers.Length; i++)   
//         if(numbers[i] == '-')
//         counterMinus++;
//         return counterMinus;
// }
// int CountZero (int [] array)
// {
//     int counterZero = 0;
//     for (int i = 0; i < numbers.Length; i++)   
//         if(numbers[i] == '0')
//         counterZero++;
//         return counterZero;
// }
// int CountComma (int [] array)
// {
//     int counterComma = 1;
//     for (int i = 0; i < numbers.Length; i++)   
//         if(numbers[i] == ',')
//         counterComma++;
//         return counterComma;
// }

// string ReadString(string message)
// {
//     Console.Write(message);
//     return Console.ReadLine();
// }
