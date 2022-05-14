int num1 = 20; //new Random().Next(10,100);
int num2 = 47; //new Random().Next(10,100);
Console.WriteLine($"Первое число = {num1}"); 
Console.WriteLine($"Второе число = {num2}");
int num = num1 % num2;
if (num1 > num2)
{
    if (num == 0) 
    {
        Console.WriteLine("Число кратно");
    }
    else
    {
        Console.WriteLine($"Не кратно, остаток = {num}");
    }
}
else 
{
    Console.WriteLine("Число не делится");
}
