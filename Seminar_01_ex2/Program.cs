// Проверка квадратов

Console.Write("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
    if (y*y == x)
    {
        Console.Write("Да, ");
        Console.Write(x);
        Console.Write(" является квадратом ");
        Console.WriteLine(y);
    }
    else
    {
        Console.WriteLine("Квадратов не найдено");
    }
}
else
{
    if (x*x == y)
    {
        Console.Write("Да, ");
        Console.Write(y);
        Console.Write(" является квадратом ");
        Console.WriteLine(x);
    }
    else
    {
        Console.WriteLine("Квадратов не найдено");
    }
}