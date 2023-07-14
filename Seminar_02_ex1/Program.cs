Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] nArray = new int[n];
for (int i = 0; i < nArray.Length; i++)
{
    nArray[i] = new Random().Next(-10, 11);
}
// for (int i = 0; i < nArray.Length; i++)
// {
//     Console.Write($"{nArray[i]} ");
// }
Console.Write($"[{string.Join(", ", nArray)}]");
