// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int Length, int minValue, int maxValue)
{

   int[] array=new int[Length];
   Random random=new Random();
for (int i=0; i<Length; i++)
{
  array[i]=random.Next(minValue, maxValue +1);
  Console.Write($" {array[i]}");
}
return array;
}



int CountOfEvenNumbers(int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count ++;
        }

    }
    Console.Write($"Количество четных элементов равно {count}");
    return count;
}


CountOfEvenNumbers(GenerateArray(6,100,778));