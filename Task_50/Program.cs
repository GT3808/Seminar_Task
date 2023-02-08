// Task 50



/*     Напишите программу, которая на вход 
     принимает позиции элемента в двумерном 
     массиве, и возвращает значение этого элемента 
     или же указание, что такого элемента нет.

     Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4
    1 7 -> такой позиции в массиве нет          */


/*  void ImputMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
               matrix[i, j] = Math.Round(new Random().NextDouble(1, 11); // [1, 10]
          }
     }
}   */


void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2); // как задовать случайные добрые числа например от 10 до 20,
            Console.Write($"{matrix[i, j]} \t");                              //  или для нахождения случайного дробного числа - мы делаем округление
        }                                                                    // - Math.Round(new Random().NextDouble() * (5 - 1) + 1, 1
        Console.WriteLine();                                                // а так как нам нужно найти от -20 до 20 ....(-20, 2) двойка последняя  
    }                                                                      // озночает - сколька цифр после запетой нам нужно или хотим видеть
}

                                                                                           // тут создаём функцию которая будет возврощать значение
double SearchElementToMatrix(double[,] matrix, int row, int column)                        // нащего двумерного массива и так как она имеет тип        
{                                                                                              // данных double, то мы так и указываем в функции double       
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > column && row >= 0 && column >= 0)  // SearchElementToMatrix - пойск какогото определённого елемента  
        return matrix[row, column];                                                           // в нутри нашего двум. массива
    return 0;
}


Console.Clear();                                                                 // основная программа 
Console.Write("Enter array dimension: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];                              // указываем чему равно кол.строк и чему равно кол.столбцов
InputMatrix(matrix);                                                          // мы передаём процедуру в наш массив
int[] coord = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Enter element position: ");
double result = SearchElementToMatrix(matrix, coord[0] - 1, coord[1] - 1);       // тут мы завидём переменную result
if (result != 0)                                                                // делаем сравнение
    Console.WriteLine(result);
else
    Console.WriteLine("There no such number");                              // чему будет равен наш результат - что такое число нет
