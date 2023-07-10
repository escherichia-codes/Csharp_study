Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n%10;
Console.WriteLine($"Последняя цифра - {result}");
