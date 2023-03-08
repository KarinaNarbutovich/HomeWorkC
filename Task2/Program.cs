Console.Clear();
Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"Большее число: {a}\n Меньшее число: {b}");
}
else if (b>a)
{
     Console.WriteLine($"Большее число: {b}\nМеньшее число: {a}");
}
else
{
    Console.WriteLine($"Числа  равны");
}
