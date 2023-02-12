// Task 58


/*   Задайте две матрицы. Напишите программу, 
    которая будет находить произведение двух матриц.  

чтобы найти двух матриц, они должны быть ровны по размеру   */


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}


void PrintMatrix(int[,] matrix)                                      // он принимает двумерный массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)                    // это функция будет нам возврощать новый двумерный массив
{                                                                                // которым будет записонна произведение двух матриц
    int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
            result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    }
    return result;
}


Console.Clear();
Console.Write("Enter the size  the matrices: ");                         
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[size[0], size[1]];                                   // размеры матриц должны быть одинаковые
int[,] SecondMatrix = new int[size[0], size[1]];
InputMatrix(FirstMatrix);
InputMatrix(SecondMatrix);
Console.WriteLine("Initial array 1: ");
PrintMatrix(FirstMatrix);
Console.WriteLine("Initial array 2: ");
PrintMatrix(SecondMatrix);
Console.WriteLine("Result:");
PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));  // и так как один возвр. а один приним. мы можем делать комбинацию
                                                       // вызова функции процедуры
// in terminal rezultatul iese inmultirea acestor doua
// masive intre ele - primu rind si prima coloana din primu 
// masiv inmultim cu tot primu rind si pr.col.din al 
// doilea masiv si tot asa toate numerele