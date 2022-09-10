// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string Polindrom(int num)
{
    int revers = 0;
    int remains = 0;
    int x = num;
    while (x != 0)
    {
        remains = x % 10;
        revers = revers * 10 + remains;
        x = x / 10;
    }
    if (num == revers)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> {Polindrom(number)}");
