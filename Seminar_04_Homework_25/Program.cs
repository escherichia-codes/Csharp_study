double f(double x, int y) // Функция по возведению в степень, содержащая цикл
{
double result = x;
for (int i = 1; i<y; i++)
{
    result = result*x;
}
return result;
}


Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("В какую степень его возвести? ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(f(a, b), 2));
