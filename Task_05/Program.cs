Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n * (-1);
while (m <= n)
{
    Console.Write($"{m} ");
    m++;
}
