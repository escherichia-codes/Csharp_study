Console.Write("Введите номер четверти (число от 1 до 4): ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 4)
{
    Console.Write("Некорректное значение. Введите номер четверти (число от 1 до 4): ");
    a = Convert.ToInt32(Console.ReadLine());
}

if (a == 1) Console.WriteLine("x > 0, y > 0");
if (a == 2) Console.WriteLine("x < 0, y > 0");
if (a == 3) Console.WriteLine("x < 0, y < 0");
if (a == 4) Console.WriteLine("x > 0, y < 0");
