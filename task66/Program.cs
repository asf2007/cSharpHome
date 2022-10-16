// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int min, max;
if (m > n)
{
    max = m;
    min = n;
}
else
{
    max = n;
    min = m;
}
int SumNum(int min, int max)
{
    int sum = max;
    if (max > min)
    {
        sum += SumNum(min, max - 1);
    }
    return sum;
}

Console.WriteLine($"M = {m}; N = {n} -> {SumNum(min, max)}");