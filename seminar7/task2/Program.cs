// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.WriteLine("введите номер ряда ");
int elementsRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер строки ");
int elementsColumns = Convert.ToInt32(Console.ReadLine());
double [,] Array = NewArray(10, 10, 0, 100);
PrintArray(Array);
PlayerNumb(Array);


void PlayerNumb (double[,] inArray)
{
if (elementsRows > inArray.GetLength(0) || elementsColumns > inArray.GetLength(1))
    {
        Console.WriteLine($"такого элемента нет");
    }
    else
    {
        Console.Write($"ваше число {inArray[elementsRows, elementsColumns]:f2}");
    }
}


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
            Console.Write($" {inArray [i,j]:f2} ");
        }
        Console.WriteLine();
    }
}

