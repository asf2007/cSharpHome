// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateNewArrRnd(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * 20 - 10, 1);
        }
    }
    return array;
}
void ArrWriter(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            if (j < arr.GetLength(1) - 1)
            {
                Console.Write($"{arr[i, j],5} ");
            }
            else
            {
                Console.Write($"{arr[i, j],5}");
            }
        }
        Console.WriteLine("]");
    }
}

ArrWriter(CreateNewArrRnd(3, 4));