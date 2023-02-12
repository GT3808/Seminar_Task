// Task 61 Доп.


/*   Вывести первые N строк треугольник Паскаля. 
     Сделать вывод в виде равнобедренного треугольника.   */


int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}


void ReleaseTask(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++)  // этот цикл исключительно толка для вывода количества пробелов
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));  // это формула для нахождения значение триугольника паскаля
        }
        Console.WriteLine();
    }
}


Console.Write("Enter the number of rows of Pascal's triangle: ");
int n = Convert.ToInt32(Console.ReadLine());
ReleaseTask(n);
