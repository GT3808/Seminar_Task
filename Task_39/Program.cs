// Task 39

/*    Напишите программу, которая перевернёт 
      одномерный массив (последний элемент 
      будет на первом месте, а 
      первый - на последнем и т.д.)

      [1 2 3 4 5] -> [5 4 3 2 1]
      [6 7 3 6] -> [6 3 7 6]                   */



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReplaceElement(int[] array)
{
   for (int i = 0; i < array.Length / 2; i++)
   {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
   }
}

Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");
ReplaceElement(array);
Console.WriteLine($"End array: [{string.Join(", ", array)}]");
