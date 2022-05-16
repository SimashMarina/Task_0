// Напишите программу, которая принимает на вход трехзначное число,
// а на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int num1 = number / 10;
int result = num1 % 10;

Console.WriteLine(result);
