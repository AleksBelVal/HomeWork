// Задача №4 nрограмма принимает вход 3 числа, 
// и выдаёт максимальное число.
Console.WriteLine("Введите первое число: ");
var number1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
var number2 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
var number3= Decimal.Parse(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("Первое число - максимальное");
    }
    else
    {
        Console.WriteLine("Третье число - максимальное");
    }
}    
else 
{
    if (number2 > number3)
    {
        Console.WriteLine("Второе число - максимальное");
    }
    else
    {
        Console.WriteLine("Третье число - максимальное");
    }
}
