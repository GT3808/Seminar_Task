// Пример Рекурсии

// Необходимо возвести число a в степень b

/* int f(int a, int b)
   {
   if (b == 0)                   // cind b ajunge la 0, noi il inmultim cu 1, apoi 1 cu 3
   return 1;                    // 3 cu 3 si etc.
   return f(a, b - 1) * a;     // <- in acest caz aceasta functie nu se va face,se face doar inmultirea
   }                          


   Console.Clear();
   Console.WriteLine(f(3, 5));   */

// f(3, 5)*3  -> f(3, 4)*3 -> f(3, 3)*3 -> f(3, 2)*3 -> f(3, 1)*3 -> f(3, 0)*1 = 243


int f(int a, int b)
{
if (b == 0)                   
return 1;                        // 3* 3* 3* 3* 3* 1
Console.WriteLine(a);                   
return f(a, b - 1) * a;     
}                          


Console.Clear();
Console.WriteLine(f(3, 5));
