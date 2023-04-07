// Задача 61(Дополнительная задача):Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

int Factorial(int n)
{
    int x=1;
    for (int i=1; i<=n; i++)
    {
        x=x*i;
    }
    return x;
}



Console.Clear();
Console.WriteLine("Введите количество N строк треугольника Паскаля: ");
int n=int.Parse(Console.ReadLine()!);
for (int i = 0; i < n; i++)
            {
                for (int c = 0; c <= (n - i); c++) 
                {
                    Console.Write(" "); 
                }
                for (int c = 0; c <= i; c++)
                {
                    Console.Write(" "); 
                    Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c))); 
                }
                Console.WriteLine();
            }
