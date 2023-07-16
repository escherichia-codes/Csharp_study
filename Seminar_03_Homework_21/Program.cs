Console.Write("Введите координату точки A по оси X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Z: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
int bz = Convert.ToInt32(Console.ReadLine());

double length = Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2)), 2);

Console.Write($"Расстояние между точками равно {length}");

