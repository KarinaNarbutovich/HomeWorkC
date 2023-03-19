// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату Х1: ");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
double z1=Convert.ToDouble(Console.ReadLine());
while (x1==0)
{
 Console.WriteLine("Вы ошиблись!\nВведите координату X1:  "); 
 x1= Convert.ToDouble(Console.ReadLine()); 
}
while (y1==0)
{
 Console.WriteLine("Вы ошиблись!\nВведите координату Y1:  ");
 y1= Convert.ToDouble(Console.ReadLine());   
}
while (z1==0)
{
 Console.WriteLine("Вы ошиблись!\nВведите координату Z1:  ");
 z1= Convert.ToDouble(Console.ReadLine());   
}
Console.WriteLine("Введите координату Х2: ");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
double z2=Convert.ToDouble(Console.ReadLine());
while (x2==0)
{
 Console.WriteLine("Вы ошиблись!\nВведите координату X2:  ");
 x2= Convert.ToDouble(Console.ReadLine());   
}
while (y2==0)
{
 Console.WriteLine("Вы ошиблись!\nВведите координату Y2:  ");
 y2= Convert.ToDouble(Console.ReadLine());   
}

while (z2==0)
{
 Console.WriteLine("Вы ошиблись!\nВведите координату Z2:  ");  
 z2= Convert.ToDouble(Console.ReadLine()); 
}
Console.WriteLine($"Расстояние между данными точками равно: {Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)),2)} ");
