// Task 15 

/* 
Напишите программу, которая принимает на вход 
цифру, обозначающую день недели, и проверяет, является
ли этот день выходным.
6 - да; 7 - да; 1 - нет.
*/

Console.Clear();
Console.Write("Enter day week: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 6 && n > 1)
{
     Console.Write("Wrong!\nday off: ");
     n = Convert.ToInt32(Console.ReadLine());
}
if   (n == 1)
      Console.WriteLine("Monday");
else if
      (n == 2)
      Console.WriteLine("Tuesday");
else if
      (n == 3)
      Console.WriteLine("Wednesday");
else if
      (n == 4)
      Console.WriteLine("Thursday");
else if
      (n == 5)
      Console.WriteLine("Friday");
else if
      (n == 6)
      Console.WriteLine("Saturday day off");
else 
      Console.WriteLine("Sunday day off");


