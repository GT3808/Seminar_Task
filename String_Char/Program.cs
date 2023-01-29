// String Char

/*

String? stroka = Console.ReadLine();
Console.WriteLine(stroka [0]);        // одна строка - один символ //
terminal: hello
          h
*/

/*
string? stroka = Console.ReadLine();
Char x = '5';
Console.WriteLine(x);    //  Char - символьный тип данных  //

*/

/*
string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0]));   // 55 - таблица кодировок - UTF 8 //
                                                //   какое-то безобразие! ☺☺☺      //

*/

/*

string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);

//  ToString - делает перевод из строки в число  //

*/

/*

Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(-10, 11);  // [-10, 10]

Console.WriteLine($"Result: [{string.Join("--, ", array)}]");

//  Join - это функция указыват через что разделять
           элементы массива                           //

//  string.Join - это функция которая соединяет все элементы
                     массива в одну строку                    //

*/


