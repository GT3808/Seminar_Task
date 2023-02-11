// Task 67

/*    Напишите программу, которая 
     будет принимать на вход число и 
     возвращать сумму его цифр.

     453 -> 12
     45 -> 9                */

int f(int n)                          // делаем тоже через рекурсию
{
if (n < 10)                         // ex: f(123)-> f(12)+3-> f(1)+2 -> 1
return n;                          // 1 e mai mic ca 10, da,de asta ramine 1
return f(n / 10) + n % 10;        // si 1 + 2 + 3 = 6 ; rezultatu e 6
}


Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
