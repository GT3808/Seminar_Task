// Task 28 

// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// тоесть нам необходимо найти факториал числа //

// 4 - 24; 5 - 120;

Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++)
     count = count * i;

Console.WriteLine(count);