// Homework 21

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
Console.Write("Enter X3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
double m = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(x3 - y2, 2)), 2);  // число с остатком
Console.WriteLine(m);
*/

Console.Clear();
Console.Write("Enter X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double m = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));  // число с остатком
Console.WriteLine($"Result: {Math.Round(m, 2)}");