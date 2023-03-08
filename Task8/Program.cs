Console.Clear();
Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
if (n>=2)
{
for (int i=1; i<=n; i++)
{
    if (i%2==0)
    {
Console.Write($" {i}");
    }
}
}
else 
{
    Console.WriteLine("Введите число больше 1 ");
}