//   Task 41

/*    Пользователь вводит с клавиатуры M чисел. 
      Посчитайте, сколько чисел больше 0 ввёл пользователь.

      0, 7, 8, -2, -2       -> 2
      -1, -7, 567, 89, 223  -> 3                 */


Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Enter number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++; // count = count + 1;
}
Console.WriteLine($"Result: {count}");
