Console.Write("Введите номер дня недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());


if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
    Console.Write("Это будний день");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.Write("Ура, это выходной");
    }
    else
    {
        Console.Write("Кажется, вы ввели что-то не то");
    }
}