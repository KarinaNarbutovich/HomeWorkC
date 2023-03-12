Console.WriteLine("Введите трехзначное число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (99<n && n<1000)
{
    Console.WriteLine($"Вторая цифра данного числа: {(n/10)%10}");
}
else if (-999<n && n<-99)
{
Console.WriteLine($"Вторая цифра данного числа: {(n/10)%10*(-1)}");
}
else
{
Console.WriteLine("Введите другое число");
}
