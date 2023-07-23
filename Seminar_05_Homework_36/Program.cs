// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 21);  // Интервал задан для упрощения счета
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

int SumOddPositions(int[] array3) // Нечетные позиции соответствуют четным индексам
{
    int sumodd = 0;
    for (int k = 0; k < array3.Length; k = k + 2)
    {
        sumodd = sumodd + array3[k];
    }
    return sumodd;
}



Console.Write($"Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[Length];

FillArray(arr);
// PrintArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");

Console.WriteLine($"Сумма элементов на нечетных позициях равна {SumOddPositions(arr)}");

