// Task 26

// Напишите програму, которая принимает на вход число
// и выдаёт количество цифр в числе.

// 456 - 3; 78 - 2; 89126 - 5;

Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
      n = n / 10;
      count++;
}
Console.WriteLine(count);
