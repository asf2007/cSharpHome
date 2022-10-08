// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateNewArrRnd(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void ArrWriter(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            if (j < arr.GetLength(1) - 1)
            {
                Console.Write($"{arr[i, j],3},");
            }
            else
            {
                Console.Write($"{arr[i, j],3}");
            }
        }
        Console.WriteLine("]");
    }
}
void AvrgColumns(int[,] arr)
{
    double sum;
    Console.Write("Среднее арифмитическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        Console.Write($"{sum / arr.GetLength(0)}; ");
    }
}
int[,] arr = CreateNewArrRnd(4, 5, 1, 9);
ArrWriter(arr);
AvrgColumns(arr);
