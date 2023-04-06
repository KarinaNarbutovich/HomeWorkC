// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,6);
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.Write("\n");
    }
}

void FindRowMinSum (int[,] matrix)
{
    int sum=0;  int minSumIndex=0;
    int[] sumArray=new int[matrix.GetLength(0)];
    for (int i=0; i<matrix.GetLength(0); i++)
    { 
        for (int j=0; j<matrix.GetLength(1); j++)
        {
          sum=sum+matrix[i,j];
          sumArray[i]=sum;
         
        }
       Console.Write($"{sumArray[i]} | ");
       sum=0;
    }
    int minSum=sumArray[0];
    for (int i=0; i<sumArray.Length-1; i++){
        if(minSum>sumArray[i+1])
        {
           minSum=sumArray[i+1]; minSumIndex=i+2;
        }  
    }
    Console.WriteLine($"\n{minSumIndex} строка, где сумма равна {minSum}");
}


Console.Clear();
Console.WriteLine("Введите количество строк и столбцов: ");
int[] size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int[,] array=new int[size[0],size[1]];
InputMatrix(array);
PrintMatrix(array);
Console.Write("\n");
FindRowMinSum(array);