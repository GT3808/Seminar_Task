Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("No third digit");
else
{
    while (n >= 999)
    {
          n = n / 10;
    }
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}