Console.Write("Введите координату точки A по оси X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int by = Convert.ToInt32(Console.ReadLine());

double length = Math.Round(Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by)), 2);

Console.Write($"Расстояние между точками равно {length}");
