// Task 53

/*    Задайте двумерный массив. 
     Напишите программу, которая поменяет 
     местами первую и последнюю строку массива.  */


void FillMatrix(int[,] matrix)                                 // заполняем наш массив
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}

void ScreenMatrix(int[,] matrix)                              // выводит наш массив
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


void ReleaseMatrix(int[,] matrix)                            // тут делаем переустановку
{
  int temp = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    temp = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];    // 0 - это номер последней строки // в терм.- cum e 
    matrix[matrix.GetLength(0) - 1, j] = temp;            // primul rind , asa si ultimul, adica primul trece in ultimul
  }                                                      // matrix[0, j] - 0 - нулевая строка
}                                                       // [matrix.GetLength(0) - 1 - это мы узнаём колич.строк, а так как 
                                                       // нумерации с 0 и по этомому высчитаем -1,чтобы получить номер последней строке

Console.Clear();
Console.Write("Enter array dimension: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);
