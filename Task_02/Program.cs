Console.Clear();
Console.Write("Enter 1-st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2-st number: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    Console.WriteLine(n);
else if (m > n)
    Console.WriteLine(m);
else
    Console.WriteLine("The numbers are equal");
