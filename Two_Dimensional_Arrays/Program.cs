// Двумерные массивы  Task 46

// Ввод несколько чисел в одну строку 



void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10, 100); // [10, 99]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Enter dimension of array: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

/*  Split - это функция, которая розделяет строку по пробелам
             и создаёт массив из двух чисел. И так как 
             она не возврощает наш массив и по
             этому оброщаемся к ToArray.            */