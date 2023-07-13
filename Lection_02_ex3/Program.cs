int Max(int[] Array)
{
    int result = Array[0];
    int index = 1;
    while (index < Array.Length)
    {
        if (Array[index] > result) result = Array[index];
        index = index + 1;
    }
    return result;
}

int[] array2 = {78, 66, 12, 78, 66, 12, 78, 6600, 12};

int maxfin = Max(array2);

Console.WriteLine(maxfin);
