Console.WriteLine("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 2 четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 4 четверти");
}
