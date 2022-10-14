// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] ArrSortRows(int[,] arr)
{
    int tmp;
    int minTmp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tmp = arr[i, j];
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > tmp)
                {
                    minTmp = tmp;
                    tmp = arr[i, k];
                    arr[i, k] = minTmp;
                }
            }
            arr[i, j] = tmp;

        }
    }
    return arr;
}

int[,] arr = CreateNewArrRnd(4, 5, 1, 9);
ArrWriter(arr);
Console.WriteLine("");
ArrWriter(ArrSortRows(arr));