// поиск индекса элемента с заданным значением

int[] array = { 1, 100, 3, 67, 45, 67, 78 };

int index = 0;
int find = 67;


while (index < array.Length)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


