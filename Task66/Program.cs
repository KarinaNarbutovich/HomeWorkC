// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int f(int m,int n)
{
    if (m==n)
    {
        return n;
    } return m+f(m+1,n);
}

Console.Clear();
Console.Write("Задайте значение M: ");
int m=int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int n=int.Parse(Console.ReadLine()!);
while (n<m)
{
 Console.Write("Вы ошиблись! Значение N не может быть меньше значения M.\nВведите значение N:  "); 
 n= int.Parse(Console.ReadLine()!); 
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна: {f(m,n)}");