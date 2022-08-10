// Задача №6 определить четность введённого числа (делится ли оно на 2 без остатка)
Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt16(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число - чётное");
}
else 
{
    Console.WriteLine("Число нечётное");
}