// Ввод пользовательского массива одной строкой

Console.Write("Введите элементы массива через пробел: ");
int[] array1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"[{String.Join(", ",array1)}]");

array1 = array1.Select(x => x +10).ToArray();
Console.WriteLine($"[{String.Join(", ",array1)}]");

foreach (int i in array1) // специфический цикл по элементам массива
Console.WriteLine(i);
