// Task 68

/*   Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

m = 2, n = 3 -> A(m,n) = 29         */


int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int m, int n)
{
     if (m == 0)
     {
     return n + 1;
     }
else if (n == 0 && m > 0)
     {
     return Akkerman(m - 1, 1);
     }
else
    {
    return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Clear();
int m = InputNumber("Enter m: ");
int n = InputNumber("Enter n: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
    
