// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,11);
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

void MultiplicationMatrix (int[,] firstMatrix,int[,] SecondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
 
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < SecondMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;
 
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * SecondMatrix[k, j];
                }
            }
        }
    PrintMatrix(resultMatrix);
}


Console.Clear();
Console.WriteLine("Введите количество строк и столбцов первой матрицы: ");
int[] size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int[,] firstArray=new int[size[0],size[1]];
InputMatrix(firstArray);
PrintMatrix(firstArray);
Console.Write("\n");
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int n=int.Parse(Console.ReadLine()!);
int[,] secondArray=new int[size[1],n];
InputMatrix(secondArray);
PrintMatrix(secondArray);
Console.Write("\n");
MultiplicationMatrix(firstArray,secondArray);

