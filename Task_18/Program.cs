// Task 18

Console.Clear();
Console.Write("Enter quarter number: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 4)
{
    Console.WriteLine("You made a mistake!\nEnter a number: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("x(0, +∞) and y(0, +∞)");
else if (n == 2)
    Console.WriteLine("x -∞, 0 and y 0, +∞ ");
else if (n == 3)
    Console.WriteLine("x -∞, 0 and y -∞, 0 ");
else
    Console.WriteLine("x(0, +∞) and y(-∞, 0)");