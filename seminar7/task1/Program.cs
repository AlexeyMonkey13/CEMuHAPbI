// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение случайных чисел");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальный элемент массива");
int max = Convert.ToInt32(Console.ReadLine());
double [,] RandomArray = NewArray(rows, columns, min, max);
PrintArray(RandomArray);

double [,] NewArray(int n, int m, int minValue, int maxValue)
{
    double [,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
     return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 1; i< inArray.GetLength(0); i++)
    {
        for (int j =1; j < inArray.GetLength(1); j++)
        {
            Console.Write($" \t {inArray [i,j]}");
        }
        Console.WriteLine();
    }
}

