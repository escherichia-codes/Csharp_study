Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());


if (A*A == B || B*B == A)
{
    if (A*A == B) 
    {Console.WriteLine($"Число {B} - квадрат числа {A}");}
    else 
    {Console.WriteLine($"Число {A} - квадрат числа {B}");}
}
else
{
    Console.Write("Ни одно число не является квадратом второго");
}