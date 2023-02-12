// Task 60

/*   Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.   */


void InputMatrix(int[,,] ThreeMatrix)                                  // in 2D masiv punem doar o virgula [,], iar in 3D masiv punem [,,]
{                                                                     // и будем использовать 3 цикла
    int number = 10;
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)              // цикл по количество строк
    {                                                        
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)        // по кол. столбцов  
        {
            for (int k = 0; k < ThreeMatrix.GetLength(2); k++)  // и по новой координате
                ThreeMatrix[i, j, k] = number++;               // вот таким упращенным образом делаем прибавление увеличение  
        }                                                     // значение на один у переменной и сразу присвоение 
    }
}


void PrintMatrix(int[,,] ThreeMatrix)
{
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
                Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}


Console.Clear();
Console.Write("Enter the size of the 3D array: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("Values ​​enter are incorrect!\nEnter the size of the 3D array: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] ThreeMatrix = new int[size[0], size[1], size[2]];
InputMatrix(ThreeMatrix);
PrintMatrix(ThreeMatrix);
