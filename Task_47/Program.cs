// Task 47

/*    Задайте двумерный массив размером m×n, заполненный 
      случайными вещественными числами.

      m = 3, n = 4.

      0,5 7 -2 -0,2
      1 -3,3 8 -9,9
      8 7,8 -7,1 9         */


Console.Write("Number of Rows Two-Dimensional Array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Number of Columns Two-Dimensional Array: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] TwoDimensArray = new double[m, n];

void PrintArray(double[,] matr)
{ 
     for (int i = 0; i < m; i++)
     { 
        for (int j = 0; j < n; j++)
        { 
             Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
     }
}
         
void FillArray(double[,] matr)
{ 
     for (int i = 0; i < m; i++)
     { 
         for (int j = 0; j < n; j++)
         { 
             matr[i,j] = new Random().Next(-100, 100); // [-100, 99]
         }
     }
}

FillArray(TwoDimensArray);
Console.WriteLine();
PrintArray(TwoDimensArray);
