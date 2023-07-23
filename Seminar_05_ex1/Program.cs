// Палиндром через строки, метод флажка

bool flag = true;

while (flag == true)
{
    Console.Write("Введите число: ");
    string n = Console.ReadLine();
    if (n == "0") flag = false;
    else if (n[0] == n[4] && n[1] == n[3]) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
