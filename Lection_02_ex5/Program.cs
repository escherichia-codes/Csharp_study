void FillArray(int[] array1)
{
    int i = 0;
    while (i<array1.Length)
    {
        array1[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] array2)
{
    int j = 0;
    while (j<array2.Length)
    {
        Console.Write($"{array2[j]} ");
        j++;
    }
}

int[] massive = new int[10];
FillArray(massive);
PrintArray(massive);

