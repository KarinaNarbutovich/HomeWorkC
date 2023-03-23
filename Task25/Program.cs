// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
Console.Write("Введите первое число: ");
double  a=Convert.ToDouble(Console.ReadLine());
if (a==0)
{
   Console.Write($"Число {a} в любой степени равно 0"); 
}
else 
{
Console.Write("Введите второе (натуральное) число: ");
double  b=Convert.ToDouble(Console.ReadLine());
double c=1;

while (b%1!=0 || b<1)
{
    Console.Write("Вы ошиблись! Данное число не является натуральным. Введите другое число: ");
    b=Convert.ToDouble(Console.ReadLine());
}
for (double i=1; i<=b; i++)
{
c=c*a;
}
Console.Write($"Число {a} в степени {b} равно {Math.Round(c,2)}");
}

