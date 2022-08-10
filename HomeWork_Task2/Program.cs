// Задача №2 nрограмма принимает вход 2 числа, 
// и выдаёт какое число больше, а какое меньше.
Console.WriteLine("Введите первое число: ");
var number1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
var number2 = Decimal.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Первое число, больше второго");
}
else 
{
    Console.WriteLine("Второе число, больше первого");
}