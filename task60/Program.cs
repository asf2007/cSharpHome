// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// // 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[, ,] CreateNewArrRnd(int rows, int columns, int depth)
{
    int[, ,] array = new int[rows, columns, depth];
    int num = 20;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k =0; k<array.GetLength(2); k++)
            array[i, j, k] = num++;
        }
    }
    return array;
}
void ArrWriter(int[, ,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
              for(int k = 0; k<arr.GetLength(2); k++){
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
              }
        }
       Console.WriteLine(""); 
    }
}
int[, ,] arr = CreateNewArrRnd(2, 2, 2);
ArrWriter(arr);
