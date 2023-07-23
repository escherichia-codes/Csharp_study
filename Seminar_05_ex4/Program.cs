// Поиск присутствия

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);  // Интервал задан для упрощения счета
    }
}

string Finding(int[] array3, int find) 
{
    for (int k = 0; k < array3.Length; k += 1)
    {
        if (array3[k] == find) return "Искомое число присутствует";
    }
    return "Такого числа нет";
}

Console.Write($"Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите искомое число: ");
int Search = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[Length];

FillArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine(Finding(arr, Search));