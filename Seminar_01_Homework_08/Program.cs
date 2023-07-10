Console.Write("Введите целое число больше нуля: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (n <= 0)
{
    Console.Write("Некорректное число");
}
else
{
    while (i <= n)
    {Console.Write($"{i} ");
    i += 2;}
}