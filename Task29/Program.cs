// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] array = new int[8];
Console.Write("Введите элементы массива:\n");
for (int i=0; i<array.Length; i++)
{
        array [i]=Convert.ToInt32(Console.ReadLine());    
}
Console.WriteLine($"[{string.Join(", ", array)}]");

//Создание массива с помощью Random

double[] arrayRandom = new double[8];
for (int i=0; i<arrayRandom.Length; i++)
{
        arrayRandom [i]=Math.Round(new Random().NextDouble()*(20-10)+10,2);   
}
Console.WriteLine($"[{string.Join(",   ", arrayRandom)}]");
