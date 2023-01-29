// Task 24

// Напишите программу, которая принимает на вход число (A)
// и выдает сумму чисел от 1 до A.

// 7 - 28; 4 - 10; 8 - 36; 

Console.Clear();
Console.Write("Enter number: ");
double n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine($"Result: {(1 + n) / 2 * n}");
