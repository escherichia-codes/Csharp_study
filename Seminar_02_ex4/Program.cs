int a = new Random().Next(10,100);
Console.Write($"Случайное двузначное число: {a}, его наибольшая цифра это ");
int a1 = a/10;
int a2 = a%10;
if (a1>a2)
{
    Console.WriteLine(a1);
}
else
{
    Console.WriteLine(a2);
}