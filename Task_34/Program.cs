// Task 34

/*  Задайте массив заполненный случайными
    положительными трёхзначными числами.Напишите
    программу, которая покажет количество 
    чётных чисел в массиве.

    [345,897,568,234] -> 2               */

void InputArray(int[] array)
{
      for (int i = 0; i < array.Length; i++)
          array[i] = new Random().Next(1, 101); // [1, 100]
}


int CountEvenInArray(int[] array)
{
     int count = 0;
     foreach(int element in array)
     {
            if (element % 2 == 0)
               count++;
     }
     return count;
}

Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");
Console.WriteLine($"Result: {CountEvenInArray(array)}");