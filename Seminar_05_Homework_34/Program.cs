// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

// void PrintArray(int[] array2)
// {
//     int j = 0;
//     while (j < array2.Length)
//     {
//         Console.Write($"{array2[j]} ");
//         j++;
//     }
//     Console.WriteLine();
// }

int CountEven(int[] array3)
{
    int count = 0;
    for (int k = 0; k < array3.Length; k++)
    {
        if (array3[k] % 2 == 0) count++;
    }
    return count;
}



Console.Write($"Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[Length];

FillArray(arr);
//PrintArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");

Console.WriteLine($"Число четных элементов равно {CountEven(arr)}");