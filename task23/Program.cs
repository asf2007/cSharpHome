// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Cube(int number)
{
    int count = 1;
    while (number >= count)
    {
        Console.WriteLine($"{count} -> {count * count * count}");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"для числа {num}: ");
Cube(num);
