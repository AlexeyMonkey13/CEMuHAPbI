// Задача 38:
//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
int huhuhu (int[] array)
{
    int aba = array[0];
    int baba = array[0];
    foreach (var item in array)
        {
             if(aba > item) aba = item;
             if(baba < item) baba = item; 
        }
    return baba - aba;
}

int[] StartArray = CreateRandomArray(6, 0, 1000);

Console.WriteLine($"Разница = {huhuhu(StartArray)}");