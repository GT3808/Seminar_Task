// Task 21

/*Console.Clear();
Console.Write("Enter X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Pow(5, 2) */

/* Console.Clear();
Console.Write("Enter X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)); */

/* 
Console.Clear();
Console.Write("Enter X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2))); */ // до целого числа

Console.Clear();
Console.Write("Enter X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);  // число с остатком
Console.WriteLine(l);