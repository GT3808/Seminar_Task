// Доп. Задача

//   Площадь треугольника


/*   По целочисленным координатам 
     вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
     требуется вычислить его площадь.                
     
         2 1 2 4 6 1 -> 6
      	 0 0 0 3 3 0 -> 4.5                   */



Console.Clear();
Console.WriteLine("Enter number: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double A = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double B = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
double C = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));

double p = (A + B + C) / 2;
double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

Console.WriteLine($"Result: {S} ");
