// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("введите номер ряда ");
int Rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите номер строки ");
int Columns = Convert.ToInt32(Console.ReadLine());

int[,] Array = NewArray(Rows, Columns, 0, 100);
PrintArray(Array);
double[] summcolumns = SredneeArifmetic(Array);
Console.WriteLine($" \t{String.Join(";    ", summcolumns)}");

int[,] NewArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"\t {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] SredneeArifmetic(int[,] Array)
{
    double[] result = new double[Array.GetLength(1)];
    for (int Columns = 0; Columns < Array.GetLength(1); Columns++)
    {
        double summ = 0;
        for (int Rows = 0; Rows < Array.GetLength(0); Rows++)
        {
            summ += Array[Rows, Columns];
        }
        result[Columns] = Math.Round(summ / Array.GetLength(0), 2);
    }
    return result;
}
