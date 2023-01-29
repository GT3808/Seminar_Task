// Function void

/*

void f (int n)
{
  n = n + 5;
}

int n = 10;
f (n);
Console.WriteLine (n);

//  передача данных не выполнено  //

*/

/*
Console.Clear();
void f (ref int n)
{
     n = n + 5;
}

int n = 10;
f (ref n);
Console.WriteLine(n);

// ref - передача значение по ссылке //

*/

/*

Console.Clear();
void f(int[] n)
{ //          1
     n[0] = n[0] + 5;
} //       0  1  2  3  4
int[] n = {1, 2, 3, 4, 5};
f (n);
Console.WriteLine(string.Join(" ", n));

*/

/*

Напишите программу, которая принимает 
2 числа и выводит наибольшее



int f(int a, int b)
{
    if (a > b)
       return a;  // Функция завершит свою работу //
     return b;
}

int a = 10, b = 7;
Console.WriteLine(f(a, b));

*/

/*

int f(int a, int b)
{
    if (a > b)
       return a;
     return b;
}

int a = 10, b = 7;
int result = f(a, b);
Console.WriteLine(result);

///  Кааой тип данных нам возврощаются в такую переменную
     мы должны принимать результат, либо 
      сразу выводить на экран                              ///
                                

*/

