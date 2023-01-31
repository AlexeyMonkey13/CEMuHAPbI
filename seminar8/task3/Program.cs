// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] array = FirstArray(5, 5, 0, 10);
int[,] inArray = SecondArray(5, 5, 0, 10);
int[,] resultMatrix = new int[5, 5];
PrintArray(array);
Console.WriteLine();
PrintArray(inArray);
MultiplyMatrix(array, inArray, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

int[,] FirstArray(int n, int m, int min, int max)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
int[,] SecondArray(int a, int b, int minValue, int maxValue)
{
    int[,] resultArray = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            resultArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultArray;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" \t {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" \t {array[i,j]}");
    }
    Console.WriteLine();
  }
}