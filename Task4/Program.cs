
int max(int a, int b, int c)
{
int result= a;
if (b>a)
{
    result=b;
}
if (c>b)
{
    result=c;
}
return result;
}


Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c=Convert.ToInt32(Console.ReadLine());

int Max=max(a,b,c);
Console.WriteLine($"Максимальное из чисел ({a}, {b}, {c}) = {Max}");
