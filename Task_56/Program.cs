// Task 56


/*   Задайте прямоугольный двумерный массив. 
  Напишите программу, которая будет находить 
  строку с наименьшей суммой элементов.      */


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
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


int ReleaseMatrix(int[,] matrix)
{
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        minRow += matrix[0, i];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (minRow > sumRow)                       // in terminal adunam fiecare rind cifrele intre ele
            minRow = sumRow;                       // si care rind rezultatul e mai mic, acela si este rezultatul final
    }
    return minRow;
}


Console.Clear();
Console.Write("Enter the size a rectangular 2D array: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.Write("You mistaken!\nEnter the size a rectangular 2D array: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Initial 2D array: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Result: {ReleaseMatrix(matrix)}");
