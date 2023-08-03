// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPlus(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}



Console.Write("Введите целые числа через пробел: ");
int[] array1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"[{String.Join(", ", array1)}]");

Console.Write($"Число чисел больше 0: {CountPlus(array1)}");
