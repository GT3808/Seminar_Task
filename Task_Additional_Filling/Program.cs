
// Task ЗАПОЛНЕНИЕ ДИАГОНАЛЯМИ

/*   Заполнение диагоналями
Даны числа n и m. Создайте массив A[n][m] 
и заполните его, как показано на примере.

Объяснение: 
Если Вы распишете каждое значение на какой 
позиции оно стоит, то числа, которые стоят на одной 
диагонали имеют одинаковую сумма (i + j)              */

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Enter matrix dimensions: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int number = 1;
for (int i = 1; i < matrix.GetLength(0) + matrix.GetLength(1) + 1; i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (j + k + 1 == i)
            {
                matrix[j, k] = number++;
            }
        }
    }
}
PrintMatrix(matrix);



