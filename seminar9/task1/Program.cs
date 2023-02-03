// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Введите значение");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0)
{
    Numbers(n, 1);
}
if(n < 0)
{
    NumbersMinus(1, n);
}

void Numbers(int start, int end)
{
    Console.Write($"{start}");
    if(start == end) return;
    Numbers(start - 1, end);
    
}

void NumbersMinus(int start, int end)
{
    Console.Write($"{start} ");
    if(start == end) return;
    Numbers(start- 1, end - 1);
    
}

