// Task 40


/*         Напишите программу, которая принимает 
      на вход три числа и проверяет, может 
      ли существовать треугольник с сторонами такой длины.

   //   Теорема о неравенстве треугольника: каждая 
      сторона треугольника меньше суммы двух других сторон. //  */


Console.Clear();
Console.Write("Enter the 1-st side of triangle: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2-st side of triangle: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 3-st side of triangle: ");
int h = Convert.ToInt32(Console.ReadLine());

if (l + p > h && p + h > l && l + h > p)
     Console.WriteLine("yes");
else
     Console.WriteLine("no");

