/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве 
A(3,6,8); B (2,1,-7) -> 15,84 */
Console.WriteLine("Введите координату A: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

int num = x1 - x2;
int num1 = y1 - y2;
int num2 = z1 - z2;

double result = Math.Sqrt(num * num + num1 * num1 + num2 * num2);
double n = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками: {n}");