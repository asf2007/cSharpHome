// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {num1}");
}
else
{
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {num2}");
}

