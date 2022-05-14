//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int num = number / 100;
int numb = number % 10;
Console.WriteLine($"Первое число = {num}"); 
Console.WriteLine($"Второе число = {numb}");
Console.Write(num);
Console.Write(numb);
