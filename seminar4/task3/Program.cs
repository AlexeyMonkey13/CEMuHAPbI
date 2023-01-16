// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int [] mass = new int [9];
for(int i = 1; i < mass.Length; i++)
{
    mass [i] = new Random().Next(0,  10);
    Console.Write(mass [i]);
}