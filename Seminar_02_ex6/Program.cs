Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A%B == 0)
{
    Console.Write("Первое число кратно второму");
}
else
{
    Console.Write($"Первое число не кратно второму, остаток {A%B}");
}