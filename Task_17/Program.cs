// Task 17

Console.Clear();
Console.Write("Enter coordinate X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinate Y: ");
double y = Convert.ToDouble(Console.ReadLine());
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");             

