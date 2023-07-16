int[] randomMassive = new int[8]; // Число элементов массива фиксированное

for (int i = 0; i < randomMassive.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    randomMassive[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", randomMassive)}]");
