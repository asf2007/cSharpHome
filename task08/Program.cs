// Задача 8: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 2;
Console.Write($"{num} -> ");
int i = 2;
while (i <= num && i % 2 == 0)
{
    Console.Write($"{i} ");
    i += 2;
}

