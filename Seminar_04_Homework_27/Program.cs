int f(int x)
{
    int sum = 0;
    while (x > 0)
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр равна {f(a)}");