// Task Перестановки


/*            Перестановки

Данна строка, состоящая из N попарно различных символов. 
Требуется вывести все перестановки символов данной строки.    */


void rec(string s2, string c)                   // in acest ex. noi in terminal iese 
{                                              // de ex: 12 - se schimba in 21
    string s1;                                 // daca de ex: 247 - va fi 247, 274, 427, 472, 724, 742
    int i;                                     // adica in cite moduri poate fi schimbat, adica peremutatii facem
    if (s2.Length == 0)
        Console.WriteLine(c);
    else
    {
        for (i = 0; i < s2.Length; i++)
        {
            c += s2[i];
            s1 = s2;
            s1 = s1.Remove(i, 1);
            rec(s1, c);
            c = c.Remove(c.Length - 1, 1);
        }
    }
}


Console.Clear();
string? s = Console.ReadLine(), c, s2;
for(int i = 0; i < s.Length; i++)
{
    c = s[i].ToString();
    s2 = s;
    s2 = s2.Remove(i, 1);
    //Console.WriteLine(s2);
    rec(s2, c);
}
