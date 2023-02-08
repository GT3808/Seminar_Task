//  Task 59


/*      Задайте двумерный массив из целых чисел. 
      Напишите программу, которая удалит строку и 
      столбец, на пересечении которых расположен 
      наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7                                 */


void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}
void ScreenMatrix(int[,] matrix)
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
  int min = matrix[0, 0];                              // мы будем сравнивать локальный минимум, положили значение  
  int minIndexI = 0;                                  // равное которая находится под номером 0 
  int minIndexJ = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     if (matrix[i, j] < min)
     {
      min = matrix[i, j];
      minIndexI = i;
      minIndexJ = j;
     }
    }
  } 
  Console.WriteLine($"min = {min}; [{minIndexI}, {minIndexJ}]");

  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (i != minIndexI)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != minIndexJ)
                Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
  }
}

Console.Clear();
Console.Write("Enter array dimensions: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
