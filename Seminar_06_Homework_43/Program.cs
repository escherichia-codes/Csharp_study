// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] Dot (double a1, double c1, double a2, double c2)
{
    double x = (c2 - c1)/(a1 - a2);
    double y = a1*x + c1;
    double[] arr = {x, y};
    return arr;
}

Console.WriteLine("Для формирования системы уравнений вида: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"[{String.Join(", ", Dot (k1, b1, k2, b2))}]");


