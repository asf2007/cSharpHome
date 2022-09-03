// Задача 6: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 2;
if (div == 0)
{
    Console.Write($"{num} -> да");
}
else
{
    Console.Write($"{num} -> нет");
}
