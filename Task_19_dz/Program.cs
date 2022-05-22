/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

// Универсальная программа

Console.WriteLine("Введите число: ");
var n = (Console.ReadLine());

if (n.Reverse().SequenceEqual(n)) 
{
    Console.WriteLine("Палиндром");
}
else 
{
    Console.WriteLine("Не палиндром");
}