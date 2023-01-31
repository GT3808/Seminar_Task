// Task 35

/*   Задайте одномерный массив из 123 случайных чисел.
     Найдите количество элементов массива, значения
     которых лежат в отрезке [10, 99]
  Пример для массива из 5, а не 123 элементов.
  В своём решении сделайте для 123

  [5,18,123,6,2] -> 1
  [1,2,3,6,2]    -> 0
  [10,11,12,13,14] -> 5                 */

void InputArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(-100, 101); // [-100, 100]
}


int ReleaseArray(int[] array)
{
      int count = 0;
      foreach (int element in array)
      {
              if (element >= 10 && element <= 99)
                  count++;
      }
      return count;                     // изменили функцию в int //
}
      
      
Console.Clear();
//Console.Write("Enter number of array elements: ");
//int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123];
InputArray(array);
Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));