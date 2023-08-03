// Ряд Фибоначчи заданной длины

Console.Write("Введите длину ряда: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

array[0] = 0;
array[1] = 1;
int i = 2;

while (i < N)
{
    array[i] = array[i-1] + array[i-2];
    i++;
}

Console.WriteLine($"[{String.Join(", ",array)}]");

// Без массивов

Console.Write("Введите длину ряда: ");
int M = Convert.ToInt32(Console.ReadLine());

int n0 = 0;
int n1 = 1;
int n2 = 1;

for (int j = 0; j < M; j++)
{
    Console.Write($"{n0} ");
    n2 = n0 + n1;
    n0 = n1;
    n1 = n2;
}

