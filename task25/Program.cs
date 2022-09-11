// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень : ");
int degree = Convert.ToInt32(Console.ReadLine());

int NumInDegree(int num, int degree)
{
    int mult = num;
    for (int i = 2; i <= degree; i++)
    {
        mult = mult * num;
    }
    return mult;
}
Console.WriteLine($"{num}, {degree} -> {NumInDegree(num, degree)}");
