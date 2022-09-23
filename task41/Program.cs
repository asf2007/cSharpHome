// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Ведите числа через пробел: ");
string inputNum = Console.ReadLine();

void PositiveNumCount(string numsStr)
{
    string[] arr = numsStr.Split(" ");
    int num;
    int positiveCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        num = Convert.ToInt32(arr[i]);
        Console.Write($"{num} ");
        if (num > 0) positiveCount++;
    }
    Console.Write($"-> {positiveCount} ");
}
PositiveNumCount(inputNum);