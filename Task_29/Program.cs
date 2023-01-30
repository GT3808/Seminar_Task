// Task 29

// Напишите програму, которая задаёт массив из 8 
// элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Enter number of array elements: ");
int c = Convert.ToInt32(Console.ReadLine());
int [] array = new int [c];

for (int i = 0; i < array.Length; i++)
     array [i] = new Random().Next(-3, 15); // [-3, 14]

Console.WriteLine($"Result: [{string.Join(" - ", array)}]");    

