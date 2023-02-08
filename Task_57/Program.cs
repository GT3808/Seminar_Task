// Task 57


/*    Составить частотный словарь элементов 
    двумерного массива. Частотный словарь содержит 
    информацию о том, сколько раз встречается элемент входных данных.  

    1,2,3
    4,6,1
    2,1,6

1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза     */


bool checkElement(int[] array, int number)       // делает проверку отдельна элемента нашего массива
{
    foreach (int element in array)
    {
        if (number == element)
            return false;
    }
    return true;
}

int FillMatrix(int[,] matrix, int[] HelpArray)
{
  int k = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int number = new Random().Next(1, 11);
      matrix[i, j] = number;
      if (checkElement(HelpArray, number) == true)
      {
        HelpArray[k] = number;
        k++;
      }
    }
  }
  return k;
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

void ReleaseMatrix(int[,] matrix, int[] array, int count)          // созд. перем. которую отвечает за колич. чисел
{
    for (int k = 0; k < count; k++)
    {
        int countUnieq = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    countUnieq++;
            }
        }
        Console.WriteLine($"Number {array[k]} meets {countUnieq} once");
    }
}

Console.Clear();
Console.Write("Enter array dimension: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] HelpArray = new int[size[0] * size[1]];
int k = FillMatrix(matrix, HelpArray);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix, HelpArray, k);
                         
