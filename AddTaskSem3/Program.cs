// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль,
// находясь перед некоторым кустом заданной во входном файле грядки.
//Входные данные
//Первая строка входного файла INPUT.TXT содержит целое число
//N (3 ≤ N ≤ 1000) – количество кустов черники. Вторая строка содержит N целых
// положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте.
// Все ai не превосходят 1000.
Console.Clear();
int sum=0;
Console.WriteLine("Введите количесвто кустов черники: ");
int n=Convert.ToInt32(Console.ReadLine());
while (n<3 || n>1000)
{
    Console.Write("Вы ошиблись. Введите количество кустов черники: ");
    n=Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n];
Console.Write("Введите количество ягод на каждом из кустов черники:\n");
for (int i=0; i<array.Length; i++)
{

    do {
        array [i]=Convert.ToInt32(Console.ReadLine());
        if (array[i]>1000)
        {
           Console.Write("Количество ягод не должно превышать 1000. Введите другое количество ягод: "); 
        }
    }
    while (array[i]>1000);
      
}
for (int j=0; j<array.Length-2; j++)
{
if (array[j]+array[j+1]+array[j+2]>sum)
{
    sum=array[j]+array[j+1]+array[j+2];
}
}
if (array[0]+array[n-1]+array[n-2]>sum)
{
  sum= array[0]+array[n-1]+array[n-2] ;
}
Console.Write($"Максимальное число ягод, которое может собрать за один заход собирающий модуль {sum}");