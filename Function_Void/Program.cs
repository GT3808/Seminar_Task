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

Console.Clear();
void f (ref int n)
{
     n = n + 5;
}

int n = 10;
f (ref n);
Console.WriteLine(n);

// ref - передача значение по ссылке //
