Console.Clear();
Console.Write("Enter the day of the week: ");
int n = Convert.ToInt32(Console.ReadLine());
// && - и(логические умножение)
// || -  или (логиское сложение)
// True - 1
// False - 0
//       1    +   0   = 1(True)
while (n < 1 || n > 7)
{
    Console.Write("You are mistaken!\nEnter the day of the week: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Monday");
else if (n == 2)
    Console.WriteLine("Tuesday");
else if (n == 3)
    Console.WriteLine("Wednesday");
else if (n == 4)
    Console.WriteLine("Thursday");
else if (n == 5)
    Console.WriteLine("Friday");
else if (n == 6)
    Console.WriteLine("Saturday");
else
    Console.WriteLine("Sunday");

