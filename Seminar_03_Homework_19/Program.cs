Console.Write("Введите пятизначное число: ");
int Str = Convert.ToInt32(Console.ReadLine());

int a = Str;
int Rev = 0;

while (a > 0)
{
    Rev = Rev * 10 + a % 10;
    a = a / 10;
}

Console.WriteLine($"Прямое число: {Str}");
Console.WriteLine($"Обратное число: {Rev}");
if (Str == Rev)
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное число НЕ палиндром");
}
