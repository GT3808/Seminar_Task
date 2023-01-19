Console.Clear();
Console.WriteLine("Enter 1-st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2-st number: ");
int m = Convert.ToInt32(Console.ReadLine());

if(m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
