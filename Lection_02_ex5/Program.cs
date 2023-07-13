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

int ElementIndex(int[] array3, int find)
{
    int k = 0;
    int element = -1;
    while (k<array3.Length)
    {
        if (array3[k] == find)
        {
            element = k;
            break;
        }
        k++;
    }
    return element;
}

int[] massive = new int[10];
FillArray(massive);
PrintArray(massive);
Console.WriteLine();
int pos = ElementIndex(massive, 4);
Console.WriteLine(pos);

