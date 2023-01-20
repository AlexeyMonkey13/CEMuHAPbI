// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] CreateRandomArray (int n, int start, int end)
{
    int [] RandomArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
        Console.Write(" " + RandomArray[i] + " ");
    }
    return RandomArray;
}

void ShowArray (int [] Array)
{
    int count = 0;
    Console.Write("Номера в массиве");
    for (int i = 0; i < Array.Length;i++)
    {
        if (Array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"сумма чётных:{count}");
}



Console.WriteLine("введите длинну массива");
int numb = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;

int[] MyArray = CreateRandomArray (numb, min, max);
ShowArray(MyArray);


