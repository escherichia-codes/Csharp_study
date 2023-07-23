// void Method() - ничего на получает и ничего не выводит. Метод вызывается Method();
// void Method2(int a) - ничего не возвращает, но принимает аргументы 

void Method2arg(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine($"Привет, {msg}!"); // Именные аргументы не обязательно писать по порядку
        i++;
    }

}

Method2arg(msg: "Петя", count: 7);

// int Method3() - возвращает данные, но не принимает

int MethodYear()
{
    return DateTime.Now.Year; // для возвращающей функции return обязателен
}

int year = MethodYear();
Console.WriteLine(year);

// int Method4(int a) - возвращает и принимает

// string MethodIntToString(int count, string text)
// {
//     int i = 0;
//     string result = ""; // = String.Empty
//     while (i<count)
//     {
//         result = result + text + " ";
//         i++;
//     }
//     return result;
// }

string MethodIntToString(int count, string text)
{
    string result = ""; // = String.Empty
    for (int i = 0; i < count; i++)
    {
        result = result + text + " ";
    }
    return result;
}

Console.WriteLine(MethodIntToString(4, "Петя"));

