// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.Write("Введие первое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введие второе число: ");
int num1 = int.Parse(Console.ReadLine());

bool res = num == num1*num1 || num1 == num*num;
Console.WriteLine(res ? "Да" : "Нет");

// if (num == num1 * num1 | num1 == num*num)
// Console.WriteLine("Да");
// else Console.WriteLine("Нет");