Console.Write("Введите целое число больше нуля: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Это число меньше 100, в нем нет третьей цифры");
}
else
{
    while (a > 999)
    {
        a = a/10;
    }
        
    int a3 = a%10;
    Console.Write($"Третья цифра это: {a3}");
}


