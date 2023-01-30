// Task 27

// Напишите програму, которая принимает на вход число 
// выдаёт сумму цифр в числе.

// нахождение в сумме цифр в любом числе

Console.Clear();
Console.Write("Enter number:");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
      result = result + n % 10;     // result += n % 10;
      n = n / 10;                  // n /= 10;
}
Console.WriteLine(result);         // adunam cifrele intre ele +- //
