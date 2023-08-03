// Преобразование десятеричного числа в двоичное

Console.Write("Введите число: ");
int Dec = Convert.ToInt32(Console.ReadLine());

int Work = Dec;
string Bin = String.Empty;

while (Work > 0)
{
    Bin = Convert.ToString(Work%2) + Bin;
    Work = Work/2;
}

Console.Write($"Десятеричное число {Dec} соответствует двоичному {Bin}.");