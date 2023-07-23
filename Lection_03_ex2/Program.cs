void MultiplyTable(int size)
{
    for (int i = 1; i<=size; i++)
    {
        for (int j = 1; j<=size; j++)
        {
            Console.Write($"{i*j} ");
        }
        Console.WriteLine("");
    }
}

MultiplyTable(4);

