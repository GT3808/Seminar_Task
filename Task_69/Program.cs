// Task 69

/*  
                Числа Фибоначчи

    Последовательностью Фибоначчи называется 
    последовательность чисел a0, a1, ..., an, ..., где
    a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).

Требуется найти N-е число Фибоначчи.          */


int f(int n)
{
if (n == 0)
return 0;

if (n == 1)
return 1;
return f(n - 1) + f(n - 2);
}


Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
