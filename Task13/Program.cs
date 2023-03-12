Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (n/100!=0 && n>0)
{
    while (n>999)
    {
n=n/10;
    }
    Console.WriteLine($"Третья цифра числа: {n%10}");
    }
else if (n/100!=0 && n<0)
{
     while (n<-999)
    {
n=n/10;
    }
    Console.WriteLine($"Третья цифра числа: {n%10*(-1)}");
}
else 
{
Console.WriteLine("У данного числа нет третьей цифры");
}