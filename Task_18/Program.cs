Console.WriteLine("Введите номер четверти: ");
var n = (Console.ReadLine());

if (n == "1")
{
    Console.WriteLine("x > 0; Y > 0"); 
}
else if (n == "2")
{
    Console.WriteLine("x < 0; Y > 0");
}
else if (n == "3")
{
    Console.WriteLine("x < 0; Y < 0"); 
}
else if (n == "4")
{
    Console.WriteLine("x > 0; Y < 0"); 
}
else Console.WriteLine("Вы ввели некорректное значение");