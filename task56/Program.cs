// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumRow(int[,]arr){
int sumMin=0;    
int sum=0;
int minRow=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum=0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           sum=sum+arr[i,j];
        }
           if(i==0) sumMin=sum;
           else{
            if(sumMin>sum)
            {
            sumMin=sum;
            minRow=i;
            }
           }
        
        
    }
    return minRow;
}

int [,] arr = CreateNewArrRnd(3,3,1,9);
ArrWriter(arr);
Console.WriteLine($"{MinSumRow(arr)} строка");
