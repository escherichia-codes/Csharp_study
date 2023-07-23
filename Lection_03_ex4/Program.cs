// Сортировка массива от минимального к максимальному

void PrintArray(int[] x)
{
    int j = 0;
    while (j < x.Length)
    {
        Console.Write($"{x[j]} ");
        j++;
    }
    Console.WriteLine();
}

void SortMaxMin(int[] x)
{
    for (int k = 0; k < x.Length - 1; k++)
    {
        int max = x[k];
        int indexmax = k;
        for (int i = k + 1; i < x.Length; i++)
        {
            if (x[i] > max)
            {
                max = x[i];
                indexmax = i;
            }
        }
        int temp = x[k];
        x[k] = max;
        x[indexmax] = temp;
    }
}



int[] array = { 2, 3, 7, 5, 0, 9 };
PrintArray(array);
SortMaxMin(array);
PrintArray(array);