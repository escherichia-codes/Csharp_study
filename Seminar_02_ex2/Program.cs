// Локальная переменная работат только внутри функции
// Переменной не может быть присвоено значение функции void, потому что функция void не возвращает значения

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void f(int x)
{
    x = x +10;
    Console.WriteLine(x);
}

int g(int x)
{
    x = x +10;
    Console.WriteLine(x);
    return x;
}

int h(ref int x)
{
    x = x +10;
    Console.WriteLine(x);
    return x;
}

Console.WriteLine(n);
g(n); // После этого значение n не изменится, потому что функция отрабатывает, но ее результат никуда не выводится
Console.WriteLine(n);

Console.WriteLine(n);
n = g(n); // После этого значение n изменится, потому что функция отрабатывает, и ее результат присваивается n
Console.WriteLine(n);

Console.WriteLine(n);
n = h(ref n); // После этого значение n изменится, потому что функция отрабатывает внутри ячейки, где хранится значение переменной n
Console.WriteLine(n);