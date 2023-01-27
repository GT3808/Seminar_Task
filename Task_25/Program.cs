// Task 25

Console.Clear();
Console.Write("Enter 1-st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2-st number: ");
int m = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i<= m; i++)
     result = result * n; // result *= n;
Console.WriteLine(result);

