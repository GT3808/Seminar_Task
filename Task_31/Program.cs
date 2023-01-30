﻿// Task 31

/*  Задайте массив из 12 элементов, заполненный
    случайными числами из промежутка [-9, 9].
    Найдите сумму отрицательных и положительных
    элементов массива.
    Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
    сумма положительных чисел равна 29, сумма
    отрицательных чисел равна -20.                     */

void InputArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
         array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
      int summaPositive = 0, summaNegative = 0;
      foreach (int element in array)
      {
              if (element > 0)
                  summaPositive += element;
              else
                  summaNegative += element;
      }
      Console.WriteLine($"Sum of positive numbers is: {summaPositive}");
      Console.WriteLine($"Sum of negative numbers is: {summaNegative}");
}
      
      
Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");
ReleaseArray(array);

