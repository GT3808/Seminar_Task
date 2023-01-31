// Task 33

/* Задайте массив.Напишите программу, которая определяет, 
   присутствует ли заданное число в массиве.

   4; массив. [6, 7, 19, 345, 3] -> нет
   3; массив. [6, 7, 19,  345, 3] -> да

   */

   void InputArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(-9, 10); // [-9, 9]
}

   string ReleaseArray(int[] array, int number)
   {
          foreach (int element in array)
          {
               if (element == number)
                  return "yes";
          }
          return "no";
   }

   Console.Clear();
   Console.Write("Enter number of array elements: ");
   int n = Convert.ToInt32(Console.ReadLine());
   int[] array = new int[n];
   InputArray(array);
   Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");
   Console.Write("Enter the number, you are looking for inside the array: ");
   int number = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine(ReleaseArray(array, number));