// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
bool IsWeekend(int num)
{
    bool weekend = false;
    if (num == 6 || num == 7)
    {
        weekend = true;
    }
    return weekend;
}
Console.Write("Введите день недели числом от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number <= 7)
{
    if (IsWeekend(number))
        Console.Write($"{number} -> да");
    else
    {
        Console.Write($"{number} -> нет");
    }
}
else
{
    Console.Write("Введено неверное число!!!!!!!!Ошибка!!!!!");
}

