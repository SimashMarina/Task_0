Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int n = 1;
while (n <= num)
{
    Console.WriteLine($"Число{n, 5}|Куб{n*n*n, 5}");
    n++;
}
