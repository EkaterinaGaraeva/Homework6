/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] GetArray(int length)
{
    int[] ArrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        ArrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return ArrayOfNumbers;
}

int PositiveNumbers(int[] ArrayOfNumbers)
{
    int count = 0;
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество чисел M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = GetArray(M);
int n = PositiveNumbers(arr);
Console.Write($"Количество положительных чисел - {n}");




