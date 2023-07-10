Console.Write("Введите целое число больше нуля: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <= n)
{
    Console.Write($"{count} ");
    count++;
}