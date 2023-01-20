// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
void NewArray (int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            summ = summ + array [i];
        }
        
    }
       Console.WriteLine($"Сумма нечетных индексов {summ}");
}


Console.WriteLine("введите длинну массива");
int numb = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[] MyArray = CreateRandomArray (numb, min, max);
NewArray(MyArray);