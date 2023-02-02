//  Task 38

/*  Задайте массив вещественных чисел.
    Найдите разницу между максимальным и
    минимальным элементов массива.

    [3 7 22 2 78] -> 76           */


void FrArray(double[] array)
{
      for (int i = 0; i < array.Length; i++)
          array[i] = Math.Round(new Random().NextDouble()*(10 - 1) + 1, 2); // [1, 10]
          // *(end - begin) + begin
}


string DiffMaxMin(double[] array)
{
      double minArray = array[0], maxArray = array[0];
      foreach (double element in array)
      {
              if (element > maxArray) maxArray = element;
              if (element < minArray) minArray = element;
      }
      return $"{maxArray} - {minArray} = {maxArray - minArray}";  
}

Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
FrArray(array);
Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");
Console.WriteLine($"Result: {DiffMaxMin(array)}");