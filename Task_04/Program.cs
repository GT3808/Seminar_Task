Console.Clear();
Console.Write("Enter 1-st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2-st number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 3-st number: ");
int c = Convert.ToInt32(Console.ReadLine()), max = a;
if (max < b)
    max = b;
if (max < c)
    max = c;
Console.WriteLine(max);

