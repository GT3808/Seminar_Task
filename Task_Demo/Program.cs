Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine($"Random number: {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.Write(n1);
else
    Console.Write(n2);

