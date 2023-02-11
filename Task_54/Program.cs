// Task 54

/*  Задайте двумерный массив. 
   Напишите программу, которая упорядочит по 
   убыванию элементы каждой строки двумерного массива.  */


void InputMatrix(int[,] matrix)
	{
	    for (int i = 0; i < matrix.GetLength(0); i++)
	    {
	        for (int j = 0; j < matrix.GetLength(1); j++)
	            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
	    }
}


void PrintMatrix(int[,] matrix)                               
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}


Console.Clear();
Console.Write("Enter matrix size: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);                                      // Заполняет наш массив
Console.WriteLine("Initial two-dimensional array: ");
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);                               // изменяет наш первоначальный двумерный массив, но она проста делает 
Console.WriteLine("Final 2D array: ");              // изменения, но не делает вывод
PrintMatrix(matrix);                               // делает вывод
