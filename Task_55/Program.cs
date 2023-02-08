// Task 55 


/*    Задайте двумерный массив. Напишите 
     программу, которая заменяет строки на столбцы. 
     В случае, если это невозможно, программа должна 
     вывести сообщение для пользователя.       */


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
  int temp = 0;                                                     // новоя перемен. temp делается для сохронения промежуточной значения
  for (int i = 0; i < matrix.GetLength(0); i++)                    // чтобы коректно выполнила замену элемента
  {
    for (int j = 0; j < i; j++)
    {
      temp = matrix[i, j];
      matrix[i, j] = matrix[j, i];
      matrix[j, i] = temp;
  }
}
}

Console.Clear();                                                             // из строки преврощаем в столбец
Console.Write("Enter array dimension: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
while (size[0] != size[1])
{
    Console.Write("You made a mistake!\nEnter the size of the array: ");      // daca in term. scriu pozitia 7 8 , atunci imi apare 
    size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();    // mesaju ca am gresit, si iar scrim poz. 7 7 si tot bine
}                                                                             // adica primul rind oriz. se transforma in rind vert.
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);
