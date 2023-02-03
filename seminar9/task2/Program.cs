// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите min значение");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max значение");
int n = Convert.ToInt32(Console.ReadLine());
int a = SumNum(m, n);
Console.WriteLine($"сумма значений от min до max = {a}");

int SumNum(int min, int max)
{
    int sum = 0;
    if (min == max)
    {
        return min;
    }
    sum = min + SumNum(min + 1, max);
    return sum;
}

