//Напишите программу, которая выводит случайное число из отрезка [10:99] и показывает наибольшую цифру числа
int number = new Random().Next(10,100);
Console.WriteLine(number);
int num = number / 10;
int numb = number % 10;
Console.WriteLine($"Первое число = {num}");
Console.WriteLine($"Второе число = {numb}");
Console.WriteLine(num > numb ? $"Максимальное число = {num}" : $"Максимальное число = {numb}"); //if (num>numb) max = num; else max = numb;
