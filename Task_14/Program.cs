Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
//if (n % 7 == 0 && n % 23 == 0)
if (n % 161 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
