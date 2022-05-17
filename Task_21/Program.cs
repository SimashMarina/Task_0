Console.WriteLine("Введите координату A: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

int num = x1 - x2;
int num1 = y1 - y2;

double result = Math.Sqrt(num * num + num1 * num1);
Console.WriteLine($"Расстояние от первой точки до второй: {result}");