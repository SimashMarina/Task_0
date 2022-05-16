/* Напишите программу, которая принимает на вход цифру, обозначающую дни недели 
и проверяет, является ли этот день выходным
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (0 < num && num < 8)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Не соответствует дню недели");
}