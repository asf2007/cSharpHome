// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int ThirdDigit(int num)
{
    int digit = -1;
    if (num > 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        digit = num % 10;
    }
    return digit;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigit(number);
if (thirdDigit == -1)
{
    Console.Write($"{number} -> третьей цыфры нет");
}
else
{
    Console.Write($"{number} -> {thirdDigit}");
}