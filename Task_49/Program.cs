﻿// Task 49


/*      Задайте двумерный массив. 
     Найдите элементы, у которых оба индекса 
     нечётные, и замените эти элементы на их квадраты.
     Например:
    1. Изначально массив выглядел вот так:

    1 4 7 2     2. Новый массив будет выглядеть вот так:
    5 9 2 3
    8 4 2 4           1 4 7 2
                      5 81 2 9
                      8 4 2 4                 */


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                matrix[i, j] *= matrix[i, j];
        }
    }
}

Console.Clear();
Console.Write("Enter dimension of array: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Initial array:");
Console.WriteLine();
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine();
Console.WriteLine("End array:");
Console.WriteLine();
PrintMatrix(matrix);
    


