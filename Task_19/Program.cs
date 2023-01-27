// Task 19

/*
Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли 
оно палиндромом.

14212 = no
23432 = yes
12821 = yes

*/

Console.Clear();
Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 10000;
int a2 = (a / 1000) % 10;
int a4 = (a % 100) / 10;
int a5 = a % 10;
if (a1 == a5 && a2 == a4)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");