Console.Write("Введите первое число (делимое): ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (первый делитель): ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число (второй делитель): ");
int C = Convert.ToInt32(Console.ReadLine());

if (A%B == 0 && A%C == 0)
{
    Console.Write("Первое число кратно второму и третьему одновременно");
}
else
{
    Console.Write("Первое число НЕ кратно второму и третьему одновременно");
}