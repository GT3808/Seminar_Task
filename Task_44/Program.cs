// Task 44


/*   Не используя рекурсию, выведите первые N чисел 
     Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

     Если N = 5 -> 0 1 1 2 3
     Если N = 3 -> 0 1 1
     Если N = 7 -> 0 1 1 2 3 5 8               */


Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0} ");
     x = a0 + a1;
     a0 = a1;           // in terminal iese ca 0+1=1, 1+1=2, 2+3=5, 5+8=13
     a1 = x;            // si asa mai departe     
}
 


/*  Console.Clear();
    Console.Write("Enter number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int a0 = 0, a1 = 1, x;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{a0} ");
        x = a0 + a1;
        a1 = x;              // aici doar am schimbat cu locul si in terminal
        a0 = a1;            // se face inmultirea 1*2=2, 2*2=4, 4*8=16 etc.   
    }   */