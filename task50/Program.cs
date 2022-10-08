// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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


void FindElement(int row, int column, int[,] arr)
{
    if (row < arr.GetLength(0) && column < arr.GetLength(1)) Console.Write($"{row}, {column} -> {arr[row, column]}");
    else Console.Write($"{row}, {column} -> такого элемента нет");
}
Console.Write("Введите номер строки начиная с 0: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца начиная с 0: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateNewArrRnd(3, 4, 1, 10);
ArrWriter(arr);
FindElement(row, column, arr);