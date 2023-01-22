/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();

int[] NewArray()
{
    Console.WriteLine("Сколько цифр вы хотите ввести?");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Число № {i + 1} ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array;
}

void CountsPositiveNumbers (int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Сумма положительных чисел = {count}");
}

int [] MyArray = NewArray();
CountsPositiveNumbers(MyArray);
Console.WriteLine(String.Join(" ", MyArray));


