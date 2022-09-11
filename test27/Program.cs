// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int i = 0;
    int sum = 0;
    for (i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write($"{num} -> {SumNum(num)}");