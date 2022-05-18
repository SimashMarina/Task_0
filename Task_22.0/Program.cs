Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int n = 0;
while (n <= num)
{
    Console.WriteLine($"Число{n, 5}|Квадрат{n*n, 5}");
    n++;
}