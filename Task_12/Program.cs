﻿Console.Clear();
Console.Write("Enter 1-st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2-st number: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine($"no, {n % m}");

    // кратное и не кратное
    
