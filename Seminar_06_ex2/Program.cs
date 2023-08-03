// Переворот массива

Console.Write("Введите элементы массива через пробел: ");
int[] array1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.Write("Исходный массив: ");
Console.WriteLine($"[{String.Join(", ",array1)}]");

int N = array1.Length;
Console.WriteLine($"Размер массива: {N}");

int[] array2 = new int[N];
for (int i = 0; i < N; i++)
{
    array2[i] = array1[N - 1 - i];
}

Console.Write("Перевернутый массив: ");
Console.WriteLine($"[{String.Join(", ",array2)}]");

// Вариант с переворотом внутри массива

Console.Write("Введите элементы массива через пробел: ");
int[] array3 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.Write("Исходный массив: ");
Console.WriteLine($"[{String.Join(", ",array3)}]");

int N2 = array3.Length;
Console.WriteLine($"Размер массива: {N2}");

for (int i = 0; i < N2/2; i++)
{
    int temp = array3[N - 1 - i];
    array3[N - 1 - i] = array3[i];
    array3[i] = temp;
}

Console.Write("Перевернутый массив: ");
Console.WriteLine($"[{String.Join(", ",array3)}]");
