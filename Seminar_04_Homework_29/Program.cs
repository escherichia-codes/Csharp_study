int[] fill(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}

int[] randomMassive = new int[8]; // Число элементов массива фиксированное
fill(randomMassive);
Console.WriteLine($"[{string.Join(", ", randomMassive)}]");
