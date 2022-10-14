// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MultMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(0); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return result;
}
int[,] arr1 = CreateNewArrRnd(2, 2, 1, 9);
int[,] arr2 = CreateNewArrRnd(2, 2, 1, 9);
ArrWriter(arr1);
Console.WriteLine("");
ArrWriter(arr2);
Console.WriteLine("");
Console.WriteLine("Результат умножения:");
ArrWriter(MultMatrix(arr1, arr2));
