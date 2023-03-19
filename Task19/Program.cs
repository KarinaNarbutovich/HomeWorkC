// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string n=Console.ReadLine()!;
int count=0;
for ( int i=0; i<n.Length/2; i++) 
{
if (n[i]!=n[n.Length-1-i]) 
{
Console.WriteLine($"Число {n} не является палиндромом");
break;
}
else{
    count++;
}
}
if (count>1)
{
    Console.WriteLine($"Число {n} - палиндром");
}
