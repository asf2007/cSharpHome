// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SeconDigit(int num)
{
    int digit = -1;
    if (num > 99 && num < 1000)
    {
        digit = num / 10 % 10;
    }
    return digit;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SeconDigit(number);
if (secondDigit == -1)
{
    Console.Write("Введено не трехзначное число");
}
else
{
    Console.Write($"{number} -> {secondDigit}");
}

