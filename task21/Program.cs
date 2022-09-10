// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double square = (bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az);
    if (square < 0)
    {
        square *= -1;
    }
    return Math.Sqrt(square);
}
Console.Write("Введите координату x точки A : ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A : ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A : ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B : ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B : ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B : ");
int bz = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({ax}, {ay}, {az}); B({bx}, {by}, {bz}) -> {Distance(ax, ay, az, bx, by, bz)}");