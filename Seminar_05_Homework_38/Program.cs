// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-10000, 10001)) / 100;  // Интервал задан для упрощения счета
    }
}

// void PrintArray(double[] array2)
// {
//     int j = 0;
//     while (j < array2.Length)
//     {
//         Console.Write($"{array2[j]} ");
//         j++;
//     }
//     Console.WriteLine();
// }

double FindMinMax(double[] array3)
{
    double minimum = array3[0];
    double maximum = array3[0];
    for (int k = 1; k < array3.Length; k++)
    {
        if (array3[k] > maximum) maximum = array3[k];
        else if (array3[k] < minimum) minimum = array3[k];
    }
    return maximum - minimum;
}



Console.Write($"Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[Length];

FillArray(arr);
// PrintArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");

Console.WriteLine($"Разница между максимальным и минимальным элементом равна {FindMinMax(arr)}");
