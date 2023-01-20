/*Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 2;
while (count <= n)
{
    Console.Write($"{count} ");
    count = count + 2;
}
*/

Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < n; i += 2)
    Console.WriteLine($"{i} ");
