// Task 65

/*   Задайте значения M и N. 
     Напишите программу, которая выведет 
     все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"            */  


string f(int m, int n)
{
if (n == m)
return $"{m}";
return f(m, n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Enter 1-st number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2-st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
