﻿/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если 2 не кратно числу, то программа выводит остаток от деления.*/


Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
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