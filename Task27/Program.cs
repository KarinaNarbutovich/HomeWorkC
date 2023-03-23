// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Clear();
int count=0;
Console.Write("Введите целое число: ");
int n=Convert.ToInt32(Console.ReadLine());
 while (Math.Abs(n)>0)
 {
    
    count=count+Math.Abs(n)%10;
    n=n/10;
 }
 Console.Write($"Сумма цифр в данном числе равна {count}");