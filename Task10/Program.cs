Console.WriteLine("Введите трехзначное число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (100<n && n<1000)
{
    Console.WriteLine($"Вторая цифра данного числа: {(n/10)%10}");
}
else
{
Console.WriteLine("Введите другое число");
}