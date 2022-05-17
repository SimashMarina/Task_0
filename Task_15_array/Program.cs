// Задача 15 решение через массив.

Console.Write("Введите число дня недели от 1 до 7: ");
var day = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = {"Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да"};
if(day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day - 1]);
}
else Console.WriteLine("Вы ввели некорректное значение!");