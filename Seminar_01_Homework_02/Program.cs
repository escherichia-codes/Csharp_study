﻿Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write($"Максимальное число: {a}");
}
else
{
    Console.Write($"Максимальное число: {b}");
}